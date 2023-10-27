
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

//Make some change, and another change

/* DOC
 * https://dok.elhub.no/ediel/elhub-messaging-interface-emif
  */

namespace EoptNetCore_Console
{

    class Program
    {
        //AppSettings

        public static string urlMarketProcessLocal = @"http://elhub:8080/WebService/services/MarketProcesses";  //I have elhub pointing to localhost in my hosts file
        public static string urlMarketProcessPublic = @"https://service-test2.elhub.no:8200/WebService/services/MarketProcesses";

        static void Main(string[] args)
        {
            bool bUsePoblicServer = false;

            var strBase = CreateEnvelopeRequest(true);
            // u.ValidateXml("e:\temp_envelope_1.xml");
            var strBaseWithSec = CreateEnvelopeWithSecurityAndBodyPart(strBase, bUsePoblicServer);

            SendEnvelopeSoap(strBaseWithSec, "RequestEndOfSupply", bUsePoblicServer);

            Console.WriteLine("press a key");
            Console.ReadKey();
        }

        private static string CreateEnvelopeRequest(bool returnOnlyBodyPart)
        {

            var envelope = ElHubMakeData.CreateEnvelopWithRequestEndOfSupplyRequestNoSec();
            var strEnvelope = ElHubMakeData.SerializeEnvelope(envelope);
            strEnvelope = strEnvelope.Replace("utf-16", "utf-8");  //Hack
            File.WriteAllText(@"e:\temp_envelope_1.xml", strEnvelope); //for debug


            ///Pick out RequestEndOfSupplyRequest
            //Remove start
            const string startTag = "<urn:RequestEndOfSupplyRequest>";
            const string endTag = "</urn:RequestEndOfSupplyRequest>";
            int startPos = strEnvelope.IndexOf(startTag);
            int endPos = strEnvelope.IndexOf(endTag) + endTag.Length;
            int length = (strEnvelope.Length - startPos) - (strEnvelope.Length - endPos);

            var strRequestEndOfSupply = strEnvelope.Substring(startPos, length);
            File.WriteAllText(@"e:\temp_envelope_1b.xml", strRequestEndOfSupply); //for debug

            if (returnOnlyBodyPart)
                return strRequestEndOfSupply;

            return strEnvelope;
        }

        private static string CreateEnvelopeWithSecurityAndBodyPart(string strBodyPart, bool bUsePublicServer)
        {
            System.Security.Cryptography.X509Certificates.X509Certificate2 cert = null;
            if (bUsePublicServer)
            {
                cert = new System.Security.Cryptography.X509Certificates.X509Certificate2("energioptimaliseringnorge.pfx", "eopt");
            }
            else
            {
                cert = new System.Security.Cryptography.X509Certificates.X509Certificate2("public_privatekey.pfx", "eopt");
            }

            SoapUtil.WS_4117909A util = new SoapUtil.WS_4117909A(cert);

            XmlDocument xmlSoapMessage = util.AssinaSOAP(strBodyPart);
            xmlSoapMessage.Save(@"e:\temp_requestSend_2.xml"); //for debug

            if (!util.ValidateSoapBodySignature(xmlSoapMessage, cert))
            {
                Debug.WriteLine($"ERROR - Signature is not valid");
            }

            //Convert to XDocument and send
            var nodeReader = new XmlNodeReader(xmlSoapMessage);
            nodeReader.MoveToContent();
            XDocument xDoc = XDocument.Load(nodeReader);
            string requestSoap = xDoc.ToString(SaveOptions.None);
            return requestSoap;
        }

        public static async void SendEnvelopeSoap(string strEnvelope, string soapAction, bool publicServer)
        {
            string url = "";
            if (publicServer)
                url = urlMarketProcessPublic;
            else
                url = urlMarketProcessLocal;

            HttpClientHandler httpClientHandler = new HttpClientHandler();

            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                return true;
            };
            httpClientHandler.AllowAutoRedirect = true;
            httpClientHandler.CheckCertificateRevocationList = false;
            httpClientHandler.SslProtocols = SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12 | SslProtocols.Tls13;
            httpClientHandler.UseCookies = false;
            // httpClientHandler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate; 

            using var client = new HttpClient(httpClientHandler);
            client.DefaultRequestHeaders.Add("SOAPAction", soapAction);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/xml"));

            var field = typeof(System.Net.Http.Headers.HttpRequestHeaders)
                            .GetField("invalidHeaders", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                                ?? typeof(System.Net.Http.Headers.HttpRequestHeaders)
                            .GetField("s_invalidHeaders", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            if (field != null)
            {
                var invalidFields = (System.Collections.Generic.HashSet<string>)field.GetValue(null);
                var b1 = invalidFields.Remove("Content-Type");
                var b2 = invalidFields.Remove("Accept-Encoding");
            }

            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "text/xml;charset=\"utf-8\"");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate");

            var dataContent = new StringContent(strEnvelope);
            var result = await client.PostAsync(url, dataContent);

            String strResult = result.Content.ReadAsStringAsync().Result;
            if (result.StatusCode == HttpStatusCode.OK)
                U.WriteLine($"SendEnvelopeSoap - Result={result}");
            else
                U.WriteLine($"SendEnvelopeSoap - ERROR - {result.StatusCode}  Result=\n{result} \nMessage=\n{result.RequestMessage}");
        }

    
    }
}
