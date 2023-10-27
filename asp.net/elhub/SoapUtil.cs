using EoptNetCore_Console;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace SoapUtil
{
    /*
    * Sample use: 
    *
    * var content = @"<ConsultarNfseRpsEnvio xmlns=""http://shad.elotech.com.br/schemas/iss/nfse_v1_2.xsd"">
    *                <IdentificacaoRps>
    *                   <Numero>404</Numero>
    *                   <Serie>E</Serie>
    *                   <Tipo>1</Tipo>
    *                </IdentificacaoRps>
    *                <IdentificacaoRequerente>
    *                   <CpfCnpj>
    *                      <Cnpj>80896194000194</Cnpj>
    *                   </CpfCnpj>
    *                   <InscricaoMunicipal>5610</InscricaoMunicipal>
    *                   <Senha>K4KT7GHC</Senha>
    *                   <Homologa>true</Homologa>
    *                </IdentificacaoRequerente>
    *             </ConsultarNfseRpsEnvio>";
    *
    * X509Certificate2 cert = new X509Certificate2("<FILE>", "PASSWORD", X509KeyStorageFlags.MachineKeySet); 
    * WS_4117909A ws1 = new WS_4117909A(cert, "http://extranet.palotina.pr.gov.br:8088/WebEloWSIssAise/nfse_v1_2.wsdl");
    * ws1.FileName = System.IO.Path.Combine("<PATH>", "<FILE>.xml");
    * var doc = XDocument.Parse(content);
    * var request = doc.ToString(SaveOptions.DisableFormatting);
    * var response = ws1.ConsultarNfsePorRps(request);
    *
    */


    public class Test
    {
        public void RunTheTest()
        {
            var content = @"<ConsultarNfseRpsEnvio xmlns=""http://shad.elotech.com.br/schemas/iss/nfse_v1_2.xsd"">
                    <IdentificacaoRps>
                       <Numero>404</Numero>
                       <Serie>E</Serie>
                       <Tipo>1</Tipo>
                    </IdentificacaoRps>
                    <IdentificacaoRequerente>
                       <CpfCnpj>
                          <Cnpj>80896194000194</Cnpj>
                       </CpfCnpj>
                       <InscricaoMunicipal>5610</InscricaoMunicipal>
                       <Senha>K4KT7GHC</Senha>
                       <Homologa>true</Homologa>
                    </IdentificacaoRequerente>
                 </ConsultarNfseRpsEnvio>";

            X509Certificate2 cert = new X509Certificate2("<FILE>", "PASSWORD", X509KeyStorageFlags.MachineKeySet);
            WS_4117909A ws1 = new WS_4117909A(cert);
            ws1.Url = "http://extranet.palotina.pr.gov.br:8088/WebEloWSIssAise/nfse_v1_2.wsdl";
            XDocument doc = XDocument.Parse(content);
            string request = doc.ToString(SaveOptions.DisableFormatting);
            string response = ws1.SendRequest_old(request,"e:\requestSendt.xml");
        }

    }


    // *** Sign XML with Malformed Id
    /*
     * https://weblog.west-wind.com/posts/2008/Feb/23/Digitally-Signing-an-XML-Document-and-Verifying-the-Signature
     * https://stackoverflow.com/questions/5099156/malformed-reference-element-when-adding-a-reference-based-on-an-id-attribute-w
     * https://stackoverflow.com/questions/30579938/generate-digital-signature-but-with-a-specific-namespace-prefix-ds
     */
    internal sealed class SignedXmlWithId : SignedXml
    {
        public SignedXmlWithId(XmlDocument xml) : base(xml) { }

        public SignedXmlWithId(XmlElement xmlElement) : base(xmlElement) { }

        public override XmlElement GetIdElement(XmlDocument doc, string id)
        {
            // check to see if it's a standard ID reference
            XmlElement idElem = base.GetIdElement(doc, id);

            if (idElem == null)
            {
                //XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
                //ns.AddNamespace("wsu", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd");

                XmlNamespaceManager ns = WS_4117909A.CreateXmlNamespaceManager(doc);

                idElem = doc.SelectSingleNode("//*[@wsu:Id=\"" + id + "\"]", ns) as XmlElement;
            }

            return idElem;
        }

    }

    #region 
    //Classes Auxiliares
    public class WS_4117909A //Based on exampe from internet
    {
        private HttpStatusCode cLastCode;
        public string Url;

        public const string STR_SOAPENV = "http://schemas.xmlsoap.org/soap/envelope/";
        public const string STR_WSSE = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd";
        public const string STR_WSU = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd";
        public const string STR_DS = "http://www.w3.org/2000/09/xmldsig#";
        public const string STR_EC = "http://www.w3.org/2001/10/xml-exc-c14n#";

        public const string STR_URN = "urn:no:elhub:emif:wsdl:marketprocesses:v2";
        public const string STR_URN1 = "urn:no:elhub:emif:market:RequestEndOfSupply:v2";
        public const string STR_URN2 = "urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2";

        public X509Certificate2 Certificado { get; set; }

        public HttpStatusCode lastCode { get { return cLastCode; } }

        public WS_4117909A(X509Certificate2 pCertificado)
        {
            Certificado = pCertificado;
        }

        public static HttpWebRequest CreateWebRequest(string url, string action)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("SOAPAction", action);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }


        public static XmlNamespaceManager CreateXmlNamespaceManager(XmlDocument doc)
        {
            XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
            ns.AddNamespace("soapenv", STR_SOAPENV);
            ns.AddNamespace("wsse", STR_WSSE);
            ns.AddNamespace("wsu", STR_WSU);
            ns.AddNamespace("ds", STR_DS); //was STR_WSD
            ns.AddNamespace("ec", STR_EC); //was STR_WSD

            ns.AddNamespace("urn", STR_URN);
            ns.AddNamespace("urn1", STR_URN1);
            ns.AddNamespace("urn2", STR_URN2);
            return ns;
        }

        public XmlDocument AssinaSOAP(string value) {
            return AssinaSOAP(value, false);
        }

        public XmlDocument AssinaSOAP(string value, bool addTimeStamp)
        {
              string sSoapEnvelope =
              @"<?xml version=""1.0"" encoding=""utf-8""?>
                <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:urn=""urn:no:elhub:emif:wsdl:marketprocesses:v2"" xmlns:urn1=""urn:no:elhub:emif:market:RequestEndOfSupply:v2"" xmlns:urn2=""urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2"">
                  <soapenv:Header>
                    <wsse:Security 
                       xmlns:wsse=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd"" 
                       xmlns:wsu=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd"">
                       <wsse:BinarySecurityToken EncodingType=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#Base64Binary"" 
                                                 ValueType=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-x509-token-profile-1.0#X509v3"" 
                                                 wsu:Id=""X509-EC95425802FB9F663F15021186132611""> 
                       </wsse:BinarySecurityToken>";


            if (addTimeStamp)
            {
                var dt = DateTime.Now;
                sSoapEnvelope += @$"<wsu:Timestamp wsu:Id=""TS-9999"">
                    <wsu:Created>{dt.ToUniversalTime().ToString("yyyy-MM-ddT-HH:mm:ss.fffZ")}</wsu:Created>
                    <wsu:Expires>{dt.AddHours(1).ToUniversalTime().ToString("yyyy-MM-ddT-HH:mm:ss.fffZ")}</wsu:Expires>
                </wsu:Timestamp>";
            }

            sSoapEnvelope +=@"
                    </wsse:Security> 
                  </soapenv:Header>
                  <soapenv:Body xmlns:wsu=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd"" wsu:Id=""id-1"">
                  </soapenv:Body>
                </soapenv:Envelope>";

            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.LoadXml(sSoapEnvelope);

            var ns = CreateXmlNamespaceManager(doc);

            // *** Grab the body element - this is what we create the signature from
            XmlElement body = doc.DocumentElement.SelectSingleNode(@"//soapenv:Body", ns) as XmlElement;
            if (body == null)
                throw new ApplicationException("No body tag found");

            // *** Fill the body
            body.InnerXml = value;

            return AssinaSOAP(doc);
        }

        public XmlDocument AssinaSOAP(XmlDocument doc)
        {

            var ns = CreateXmlNamespaceManager(doc);

            // *** Signed XML will create Xml Signature - Xml fragment
            SignedXmlWithId signedXml = new SignedXmlWithId(doc);

            // *** Create a KeyInfo structure
            KeyInfo keyInfo = new KeyInfo();
            keyInfo.Id = "KI-EC95425802FB9F663F15021186132692";

            KeyInfoNode keyInfoNode = new KeyInfoNode();
            XmlElement wsseSec = doc.CreateElement("wsse", "SecurityTokenReference", STR_WSSE);
            wsseSec.SetAttribute("xmlns:wsu", STR_WSU);
            wsseSec.SetAttribute("Id", STR_WSU, "STR-EC95425802FB9F663F15021186132713");
            XmlElement wsseRef = doc.CreateElement("wsse", "Reference", STR_WSSE);
            wsseRef.SetAttribute("URI", "#X509-EC95425802FB9F663F15021186132611");
            wsseRef.SetAttribute("ValueType", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-x509-token-profile-1.0#X509v3");
            wsseSec.AppendChild(wsseRef);
            keyInfoNode.Value = wsseSec;

            keyInfo.AddClause(keyInfoNode);

            // *** The actual key for signing - MAKE SURE THIS ISN'T NULL!
            signedXml.SigningKey = this.Certificado.PrivateKey;
            
            // *** provide the certficate info that gets embedded - note this is only
            // *** for specific formatting of the message to provide the cert info
            signedXml.KeyInfo = keyInfo;
         //   signedXml.SignatureMethod = "http://www.w3.org/2000/09/xmldsig#sha1";
            // *** Again unusual - meant to make the document match template
            signedXml.SignedInfo.CanonicalizationMethod = SignedXml.XmlDsigExcC14NTransformUrl;

            // Set the InclusiveNamespacesPrefixList property.        
            XmlDsigExcC14NTransform canMethod = (XmlDsigExcC14NTransform)signedXml.SignedInfo.CanonicalizationMethodObject;
            canMethod.InclusiveNamespacesPrefixList = "soapenv wsse urn urn1 urn2";

            if (doc.OuterXml.Contains("id-1"))
            {
                // *** Now create reference to sign: Point at the Body element
                Reference referenceBody = new Reference();
                referenceBody.Uri = "#id-1";  // reference wsu:Id=id-6 section in same doc

                // Add an enveloped transformation to the reference.
                XmlDsigExcC14NTransform envBody = new XmlDsigExcC14NTransform();  //this points to the body
                envBody.InclusiveNamespacesPrefixList = "urn urn1 urn2";
                referenceBody.AddTransform(envBody); // required to match doc

                signedXml.AddReference(referenceBody);
            }
            if (doc.OuterXml.Contains("TS-9999"))
            {
                // *** Now create reference to sign: Point at the Body element
                Reference referenceTimeStamp = new Reference();
                referenceTimeStamp.Uri = "#TS-9999";  // reference wsu:Id=id-6 section in same doc

                // Add an enveloped transformation to the reference.
                XmlDsigExcC14NTransform envTimeStamp = new XmlDsigExcC14NTransform();  //this points to the body
                envTimeStamp.InclusiveNamespacesPrefixList = "";
                referenceTimeStamp.AddTransform(envTimeStamp); // required to match doc

                signedXml.AddReference(referenceTimeStamp);
            }

            // *** Finally create the signature
            signedXml.ComputeSignature();

            // *** wsse:Security element
            XmlElement soapSignature = doc.DocumentElement.SelectSingleNode(@"//wsse:Security", ns) as XmlElement;
            if (soapSignature == null)
                throw new ApplicationException("No wsse:Security tag found");

            // *** Create wsse:BinarySecurityToken element
            XmlElement soapToken = doc.DocumentElement.SelectSingleNode(@"//wsse:BinarySecurityToken", ns) as XmlElement;
            if (soapToken == null)
                throw new ApplicationException("No wsse:BinarySecurityToken tag found");

            var export = this.Certificado.Export(X509ContentType.Cert);
            var base64 = Convert.ToBase64String(export);
            soapToken.InnerText = base64;

            // *** Result is an XML node with the signature detail below it
            // *** Now let's add the sucker into the SOAP-HEADER
            XmlElement signedElement = signedXml.GetXml();
            XmlAttribute sId = doc.CreateAttribute("Id");
            sId.Value = $"SIG-{U.DateTimeToUnix(DateTime.Now)}";
            signedElement.Attributes.Append(sId);

            // *** And add our signature as content
            soapSignature.AppendChild(signedElement);

            // *** Now add the signature header into the master header
            XmlElement soapHeader = doc.DocumentElement.SelectSingleNode("//soapenv:Header", ns) as XmlElement;
            if (soapHeader == null)
                throw new ApplicationException("No soapenv:Header tag found");

            // *** Validate
            // var pass = ValidateSoapBodySignature(doc, this.Certificado);

            return doc;
        }


        ///this is old, uses HttpWebRequest, better to use HttpClient
        public String SendRequest_old(String value, string fileName)
        {
            HttpWebRequest request = CreateWebRequest(this.Url, "");
            XmlDocument soapEnvelopeXml = AssinaSOAP(value);
            U.WriteLine($"SendNfseRequest Saving to Filename={fileName}");
            using (Stream stream = request.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
                soapEnvelopeXml.Save(fileName);
            }

            U.WriteLine($"SendNfseRequest Sending Soap to={request.Address}");

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                    {
                        string soapResult = rd.ReadToEnd();
                        return soapResult;
                    }
                }

            }
            catch (WebException wex)
            {
                Debug.WriteLine($"SendNfseRequset ERROR message={wex.Message}");
                cLastCode = (wex.Response as HttpWebResponse).StatusCode;
                return new StreamReader(wex.Response.GetResponseStream()).ReadToEnd();
            }

        }

        public bool ValidateSoapBodySignature(XmlDocument doc, X509Certificate2 cert)
        {

            XmlNamespaceManager ns = CreateXmlNamespaceManager(doc);

            bool passes = true;
            CspParameters cspParams = new CspParameters();
            cspParams.KeyContainerName = "XML_DSIG_RSA_KEY";
            RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider(cspParams);
            SignedXml signedXml = new SignedXmlWithId(doc);
            XmlNodeList nodeList = doc.GetElementsByTagName("Signature");
            if (nodeList.Count == 0)
                nodeList = doc.GetElementsByTagName("ds:Signature");
            XmlNodeList certificates = doc.GetElementsByTagName("wsse:BinarySecurityToken");

            X509Certificate2 dcert2 = new X509Certificate2(Convert.FromBase64String(certificates[0].InnerText));

            foreach (XmlElement element in nodeList)
            {
                signedXml.LoadXml(element);
                passes = passes && signedXml.CheckSignature(dcert2, true);
            }

            return passes;
        }

        public void ValidateXml(string fileName)
        {
            // Set the validation settings.
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);

            // Create the XmlReader object.
            XmlReader reader = XmlReader.Create(fileName, settings);

            // Parse the file. 
            while (reader.Read()) ;
        }

        // Display any warnings or errors.
        private static void ValidationCallBack(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
                U.WriteLine("\tWarning: Matching schema not found.  No validation occurred." + args.Message);
            else
                U.WriteLine("\tValidation error: " + args.Message);

        }

    }
    #endregion

}