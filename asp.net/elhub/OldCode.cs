
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

namespace EoptNetCore_Console
{
    public  class OldCode
    {
        public interface IMyService
        {
            Task MyServiceMethod();
        }

        public class MyService : IMyService
        {
            private readonly string _baseUrl;
            private readonly string _token;
            private readonly ILogger<MyService> _logger;

            public MyService(ILoggerFactory loggerFactory, Microsoft.Extensions.Configuration.IConfigurationRoot config)
            {
                var baseUrl = config["SomeConfigItem:BaseUrl"];
                var token = config["SomeConfigItem:Token"];

                _baseUrl = baseUrl;
                _token = token;
                _logger = loggerFactory.CreateLogger<MyService>();
            }

            public async Task MyServiceMethod()
            {
                _logger.LogDebug(_baseUrl);
                _logger.LogDebug(_token);
            }
        }

        public class Startup
        {
            Microsoft.Extensions.Configuration.IConfigurationRoot Configuration { get; }

            public Startup()
            {
                //var builder = new Microsoft.Extensions.Configuration.ConfigurationBuilder()
                //.SetBasePath(Directory.GetCurrentDirectory())
                //.AddJsonFile("appsettings.json", optional: false);
                //var builder = new ConfigurationBuilder();
                //builder..AddJsonFile("appsettings.json");

                // Configuration = builder.Build();
            }

            public void ConfigureServices(IServiceCollection services)
            {
                //services.AddLogging();
                //services.AddSingleton<Microsoft.Extensions.Configuration.IConfigurationRoot>(Configuration);
                //services.AddSingleton<IMyService, MyService>();

                IServiceCollection services2 = new ServiceCollection();
                // Startup.cs finally :)
                Startup startup = new Startup();
                startup.ConfigureServices(services);

                IServiceProvider serviceProvider = services2.BuildServiceProvider();

                //configure console logging
                //serviceProvider.GetService<ILoggerFactory>().AddConsole(LogLevel.Debug);

                var logger = serviceProvider.GetService<ILoggerFactory>()
                    .CreateLogger<Program>();

                logger.LogDebug("Logger is working!");

                // Get Service and call method
                var service = serviceProvider.GetService<IMyService>();
                service.MyServiceMethod();
            }
        }

        private static void TestNFsUtilWebServiceWithXmlDoc(XmlDocument doc)
        {

            var cert = new System.Security.Cryptography.X509Certificates.X509Certificate2("public_privatekey.pfx", "eopt");
            //var cert = new System.Security.Cryptography.X509Certificates.X509Certificate2("energioptimaliseringnorge.pfx", "eopt");

            ///SEND IT AS SOAP
            SoapUtil.WS_4117909A util = new SoapUtil.WS_4117909A(cert);
            util.Url = Program.urlMarketProcessLocal;

            //for debug create a temp Soap and save it
            XmlDocument strSoapMessage = util.AssinaSOAP(doc);
            strSoapMessage.Save(@"e:\temp_requestWithSecurity.xml");

            //Convert to XDocument and send
            var nodeReader = new XmlNodeReader(doc);
            nodeReader.MoveToContent();
            XDocument xDoc = XDocument.Load(nodeReader);
            string requestSoap = xDoc.ToString(SaveOptions.None);

            U.WriteLine($"The RequestSoap to send length={requestSoap.Length}");

            string strResponse = util.SendRequest_old(requestSoap, Path.Combine(@"E:\", "temp_NFSeRequestSend.xml"));

            Debug.WriteLine($"The Response: {strResponse}");

        }


        private static string CreateSomeData()
        {
            //Create data
            var objRequestEndOfSupplyRequest = ElHubMakeData.CreateXmlRequestEndOfSupplyRequest();

            //serialize it and write to string
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(objRequestEndOfSupplyRequest.GetType());
            string strXmlRequestEndOfSupplyRequest = "";
            using (var stringWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter))
                {
                    xmlSerializer.Serialize(xmlWriter, objRequestEndOfSupplyRequest);
                    strXmlRequestEndOfSupplyRequest = stringWriter.ToString().Replace(@"<?xml version=""1.0"" encoding=""utf-16""?>", "");
                }
            }

            Debug.WriteLine($"strXmlRequestEndOfSupplyRequest: {strXmlRequestEndOfSupplyRequest}");
            File.WriteAllText(@"e:\soapSimpleMessage.xml", strXmlRequestEndOfSupplyRequest);
            return strXmlRequestEndOfSupplyRequest;
        }

        private static void TestNFsUtilWebServiceWithBodyPart(string strBodyPart)
        {
            var cert = new System.Security.Cryptography.X509Certificates.X509Certificate2("public_privatekey.pfx", "eopt");
            //var cert = new System.Security.Cryptography.X509Certificates.X509Certificate2("energioptimaliseringnorge.pfx", "eopt");

            SoapUtil.WS_4117909A util = new SoapUtil.WS_4117909A(cert);
            util.Url = Program.urlMarketProcessLocal;

            //Add Security
            XmlDocument xmlSoapMessage = util.AssinaSOAP(strBodyPart);
            xmlSoapMessage.Save(@"e:\temp_requestSend_2.xml");

            //Convert to XDocument
            var nodeReader = new XmlNodeReader(xmlSoapMessage);
            nodeReader.MoveToContent();
            XDocument xDoc = XDocument.Load(nodeReader);
            string requestSoap = xDoc.ToString(SaveOptions.None);

            //U.WriteLine($"The RequestSoap to send length={requestSoap.Length}");

            string strResponse = util.SendRequest_old(strBodyPart, Path.Combine(@"E:\", "temp_requestSend_2_nfsUtil.xml"));

            Debug.WriteLine($"The Response: {strResponse}");
        }

    }
}
