using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using ElhubSoapSec;


namespace EoptNetCore_Console
{
    //A comment

    public class ElhubTester
    {

        /*
		 * For Elhub certificates
		 https://elhub.no/dokumentasjon-og-miljoer/miljoer/sikkerhet-og-sertifikater/
		 */

        /* Read this, PDF:
		 https://archive.sap.com/kmuuid2/e0ecb76a-2f70-2a10-8bb6-bf5d4f1fb750/1.pdf
		 */

        /*
		 * https://stackoverflow.com/questions/12832213/how-to-make-wcf-client-conform-to-specific-ws-security-sign-usernametoken-and
		 */
        /*
		private System.ServiceModel.Channels.Binding GetCustomBinding()
		{


			System.ServiceModel.Channels.  asbe = new AsymmetricSecurityBindingElement();
			asbe.MessageSecurityVersion = MessageSecurityVersion.WSSecurity11WSTrust13WSSecureConversation13WSSecurityPolicy12;

			asbe.InitiatorTokenParameters = new System.ServiceModel.Security.Tokens.X509SecurityTokenParameters { InclusionMode = SecurityTokenInclusionMode.Never };
			asbe.RecipientTokenParameters = new System.ServiceModel.Security.Tokens.X509SecurityTokenParameters { InclusionMode = SecurityTokenInclusionMode.Never };
			asbe.MessageProtectionOrder = System.ServiceModel.Security.MessageProtectionOrder.SignBeforeEncrypt;

			asbe.SecurityHeaderLayout = SecurityHeaderLayout.Strict;
			asbe.EnableUnsecuredResponse = true;
			asbe.IncludeTimestamp = false;
			asbe.SetKeyDerivation(false);
			asbe.DefaultAlgorithmSuite = System.ServiceModel.Security.SecurityAlgorithmSuite.Basic128Rsa15;
			asbe.EndpointSupportingTokenParameters.Signed.Add(new UserNameSecurityTokenParameters());
			asbe.EndpointSupportingTokenParameters.Signed.Add(new X509SecurityTokenParameters());

			CustomBinding myBinding = new CustomBinding();
			myBinding.Elements.Add(asbe);
			myBinding.Elements.Add(new TextMessageEncodingBindingElement(MessageVersion.Soap11, Encoding.UTF8));

			HttpsTransportBindingElement httpsBindingElement = new HttpsTransportBindingElement();
			httpsBindingElement.RequireClientCertificate = true;
			myBinding.Elements.Add(httpsBindingElement);

			return myBinding;
		}
        */

        private string urlMarketProcess = @"http://elhub:8080/WebService/services/MarketProcesses"; //elhub points to localhost in Windows/system32/drivers/etc/hosts file
        //private string urlMarketProcess = @"https://service-test2.elhub.no:8200/WebService/services/MarketProcesses";

        public MarketProcessesClient CreateClientBasicHTTP(string address)
        {
            System.ServiceModel.BasicHttpBinding httpBinding = new System.ServiceModel.BasicHttpBinding();
           
            //httpBinding.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.TransportWithMessageCredential;
            //httpBinding.Security.Transport.ClientCredentialType = System.ServiceModel.HttpClientCredentialType.None;
            
            httpBinding.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Message;

            httpBinding.Security.Message.ClientCredentialType = System.ServiceModel.BasicHttpMessageCredentialType.Certificate;

            httpBinding.MaxBufferSize = int.MaxValue;
            httpBinding.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
            httpBinding.MaxReceivedMessageSize = int.MaxValue;

            //httpBinding.AllowCookies = true;

            System.ServiceModel.EndpointAddress endpointAddress = new System.ServiceModel.EndpointAddress(address);
            var client = new MarketProcessesClient(httpBinding, endpointAddress);
            client.ClientCredentials.ClientCertificate.Certificate = new X509Certificate2("energioptimaliseringnorge.pfx", "eopt");
            //client.ClientCredentials.ServiceCertificate.DefaultCertificate = new X509Certificate2("ElhubPubicTest.p7b");
            client.ClientCredentials.ServiceCertificate.DefaultCertificate = new X509Certificate2("public_privatekey.pfx", "eopt");

            return client;
        }

        public MarketProcessesClient CreateClientSecure(string address)
        {
            try
            {
                //System.ServiceModel.WSHttpBinding httpBinding = new(System.ServiceModel.SecurityMode.Message);
                //httpBinding.Security.Message.ClientCredentialType = System.ServiceModel.MessageCredentialType.Certificate;
                //httpBinding.Security.Message.EstablishSecurityContext = false;
                //httpBinding.Security.Message.NegotiateServiceCredential = false;

                System.ServiceModel.WSHttpBinding httpBinding = new System.ServiceModel.WSHttpBinding(System.ServiceModel.SecurityMode.Message);
                //httpBinding.Security.Transport.ClientCredentialType = System.ServiceModel.HttpClientCredentialType.None;
                httpBinding.Security.Message.ClientCredentialType = System.ServiceModel.MessageCredentialType.Certificate;
                httpBinding.Security.Message.EstablishSecurityContext = false;
                httpBinding.Security.Message.NegotiateServiceCredential = false;

                /*
				System.ServiceModel.WSHttpBinding httpBinding = new(System.ServiceModel.SecurityMode.Message);
				httpBinding.Security.Transport.ClientCredentialType = System.ServiceModel.HttpClientCredentialType.;
				httpBinding.Security.Message.ClientCredentialType = System.ServiceModel.MessageCredentialType.Certificate;
				httpBinding.Security.Message.EstablishSecurityContext = false;
				httpBinding.Security.Message.NegotiateServiceCredential = false;
				*/

                httpBinding.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                httpBinding.MaxReceivedMessageSize = int.MaxValue;

                //var httpBindingElemennt = httpBinding.CreateBindingElements;
                //System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new();
                //httpsBindingElement.RequireClientCertificate = true;

                System.ServiceModel.EndpointAddress endpointAddress = new System.ServiceModel.EndpointAddress(address);
                MarketProcessesClient client = new MarketProcessesClient(httpBinding, endpointAddress);

                //	client.ChannelFactory.Credentials.ClientCertificate.
                //string pathServerCert = @"C:\Work\EoptNetCore\EoptNetCore_Console\ElhubPubicTest.p7b";
                //client.ClientCredentials.ServiceCertificate.DefaultCertificate = new X509Certificate2(pathServerCert);

                //client.ClientCredentials.ServiceCertificate.Authentication.TrustedStoreLocation 
                //client.Endpoint.Contract.ProtectionLevel = System.Net.Security.ProtectionLevel.Sign;
                //client.Endpoint.EndpointBehaviors.Add(new CertificateRequest());

                //string clientPass = System.IO.File.ReadAllText(@"eoptSignCertificate.password");
                //string pathClientCert = @"eoptSignCertificate1.p7b";
                //client.ClientCredentials.ClientCertificate.Certificate = new X509Certificate2("energioptimaliseringnorge.pfx", "eopt");

                client.ClientCredentials.ClientCertificate.Certificate = new X509Certificate2("public_privatekey.pfx", "eopt");

                //client.ClientCredentials.ClientCertificate.SetCertificate(StoreLocation.CurrentUser, StoreName.My, X509FindType.FindBySerialNumber, "1589ed6e3f37fc09733fe3"); // "ENERGIOPTIMALISERING NORGE AS"

                return client;

            }
            catch (Exception e)
            {
                Debug.WriteLine($"ERROR Could not create Client Message={e.Message}");
                throw;
            }
        }

        private MarketProcessesClient CreateClient(string address)
        {
            return CreateClientBasicHTTP(address);
            //return CreateClientSecure(address);
        }

        public async void StartTestReqEndOfSupplyBIM()
        {
            try
            {
                var client = CreateClient(urlMarketProcess);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public async void StartTest_RequestEndOfSupply()
        {
            try
            {
                var client = CreateClient(urlMarketProcess);

                await client.OpenAsync();
                try
                {
                    var req = new RequestEndOfSupplyRequest();
                    req.RequestEndOfSupply = new RequestEndOfSupply();
                    req.RequestEndOfSupply.Header = new Elhub_HeaderType();

                    //Create HEADER 
                    var header = req.RequestEndOfSupply.Header;
                    header.Identification = Guid.NewGuid().ToString();
                    header.Creation = DateTime.Now;

                    header.DocumentType = new Elhub_DocumentNameCodeType();
                    header.DocumentType.Value = Elhub_DocumentType.Item432;
                    header.DocumentType.listAgencyIdentifier = listAgencyIdentifierType.Item6;

                    header.PhysicalSenderEnergyParty = new Elhub_EnergyPartyType()
                    {
                        Identification = new Elhub_EnergyPartyIdentifierType()
                        {
                            schemeAgencyIdentifier = schemeAgencyIdentifierGS1Type.Item9,
                            Value = "1234567890123"
                        }
                    };

                    header.JuridicalSenderEnergyParty = new Elhub_EnergyPartyType()
                    {
                        Identification = new Elhub_EnergyPartyIdentifierType()
                        {
                            schemeAgencyIdentifier = schemeAgencyIdentifierGS1Type.Item9,
                            Value = "1234567890123"
                        }
                    };

                    header.JuridicalRecipientEnergyParty = new Elhub_EnergyPartyType()
                    {
                        Identification = new Elhub_EnergyPartyIdentifierType()
                        {
                            schemeAgencyIdentifier = schemeAgencyIdentifierGS1Type.Item9,
                            Value = "1234567890123"
                        }
                    };

                    //ProcessEnergyContext
                    req.RequestEndOfSupply.ProcessEnergyContext = new Elhub_EnergyContextType();
                    var processEnergyContext = req.RequestEndOfSupply.ProcessEnergyContext;
                    processEnergyContext.EnergyBusinessProcess = new Elhub_BusinessProcessType()
                    {
                        listAgencyIdentifier = listAgencyIdentifierType89.Item89,
                        Value = BRSIdentification.BRSNO201
                    };
                    processEnergyContext.EnergyBusinessProcessRole = new Elhub_BusinessProcessRoleType()
                    {
                        listAgencyIdentifier = listAgencyIdentifierType89_6.Item6,
                        Value = Elhub_BusinessProcessRole.DDQ
                    };

                    processEnergyContext.EnergyIndustryClassification = Elhub_EnergyIndustryClassificationType.Item23;

                    //PAYLOAD
                    req.RequestEndOfSupply.PayloadMPEvent = new Elhub_RequestEndOfSupplyType();
                    var payload = req.RequestEndOfSupply.PayloadMPEvent;
                    payload.EndOfOccurrence = DateTime.Now;
                    payload.MeteringPointUsedDomainLocation = new Elhub_MeteringPointType()
                    {
                        Identification = new Elhub_MeteringPointIdentifierType()
                        {
                            schemeAgencyIdentifier = schemeAgencyIdentifierGS1Type.Item9,
                            Value = "707057500022939815"
                        }
                    };
                    payload.BalanceSupplierInvolvedEnergyParty = new Elhub_EnergyPartyType()
                    {
                        Identification = new Elhub_EnergyPartyIdentifierType()
                        {
                            schemeAgencyIdentifier = schemeAgencyIdentifierGS1Type.Item9,
                            Value = "2222222222229"
                        }
                    };
                    payload.ConsumerInvolvedCustomerParty = new Elhub_CustomerPartyEndOfSupplyType()
                    {
                        Identification = new Elhub_EndUserIdentifierType()
                        {
                            schemeAgencyIdentifier = Elhub_schemeAgencyIdentifierType.Z01,
                            Value = "01018035871"
                        },
                        GivenName = "Ola",
                        FamilyName = "Nordmann",
                        Communication = new Elhub_Communication[]
                        {
                    new Elhub_Communication()
                    {
                        CommunicationChannel = CommunicationChannelType.Mobile,
                        CompleteNumber = "944 56 123"
                    }
                        }
                    };

                    payload.ConsumerInvolvedCustomerAddress = new Elhub_InvoiceeAddressType[]
                    {
                        new Elhub_InvoiceeAddressType()
                        {
                            AddressType = AddressTypeType.invoiceadr,
                            StreetName = "Kirkegt",
                            BuildingNumber = "45",
                            Postcode = "7010",
                            CityName = "Trondheim",
                            CountryCode = new Elhub_CountryCodeType()
                            {
                                listAgencyIdentifier = listAgencyIdentifierType5.Item5,
                                Value = CountryCode.NO
                            }
                        }
                    };


                    var result = await client.RequestEndOfSupplyAsync(req);


                    Debug.WriteLine($"RequestEndOfSupplyRequest OK");
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"RequestEndOfSupplyRequest ERROR - MSG={e.Message} INNER={e.InnerException}");

                }

                client.Close();

            }
            catch (Exception e)
            {
                Debug.WriteLine($" Connection ERROR - Message= {e.Message}");
            }
        }


       

        public async void StartTest_UpdateThirdPartyAcsess()
        {
            try
            {
                var client = CreateClient(urlMarketProcess);

                await client.OpenAsync();
                try
                {
                    var req = new UpdateThirdPartyAccessRequest();

                    req.UpdateThirdPartyAccess = new UpdateThirdPartyAccess();
                    req.UpdateThirdPartyAccess.Header = new Elhub_HeaderType();
                    var header = req.UpdateThirdPartyAccess.Header;
                    header.Identification = Guid.NewGuid().ToString();
                    header.DocumentType = new Elhub_DocumentNameCodeType()
                    {
                        listAgencyIdentifier = listAgencyIdentifierType.Item260,
                        Value = Elhub_DocumentType.E10
                    };
                    header.Creation = DateTime.Now;
                    header.RequestPositiveAcknowledgement = false;
                    header.PhysicalSenderEnergyParty = new Elhub_EnergyPartyType()
                    {
                        Identification = new Elhub_EnergyPartyIdentifierType()
                        {
                            schemeAgencyIdentifier = schemeAgencyIdentifierGS1Type.Item9,
                            Value = "7080010010735"
                        }
                    };
                    header.JuridicalSenderEnergyParty = new Elhub_EnergyPartyType()
                    {
                        Identification = new Elhub_EnergyPartyIdentifierType()
                        {
                            schemeAgencyIdentifier = schemeAgencyIdentifierGS1Type.Item9,
                            Value = "7080010010735"
                        }
                    };
                    header.JuridicalRecipientEnergyParty = new Elhub_EnergyPartyType()
                    {
                        Identification = new Elhub_EnergyPartyIdentifierType()
                        {
                            schemeAgencyIdentifier = schemeAgencyIdentifierGS1Type.Item9,
                            Value = "7080010010735"
                        }
                    };

                    req.UpdateThirdPartyAccess.ProcessEnergyContext = new Elhub_EnergyContextType();
                    var processEnergyContext = req.UpdateThirdPartyAccess.ProcessEnergyContext;
                    processEnergyContext.EnergyBusinessProcess = new Elhub_BusinessProcessType()
                    {
                        listAgencyIdentifier = listAgencyIdentifierType89.Item89,
                        Value = BRSIdentification.BRSNO622
                    };
                    processEnergyContext.EnergyBusinessProcessRole = new Elhub_BusinessProcessRoleType()
                    {
                        listAgencyIdentifier = listAgencyIdentifierType89_6.Item6,
                        Value = Elhub_BusinessProcessRole.AG
                    };
                    processEnergyContext.EnergyIndustryClassification = Elhub_EnergyIndustryClassificationType.Item23;

                    req.UpdateThirdPartyAccess.PayloadMPEvent = new Elhub_UpdateThirdPartyAccessType();
                    var payLoad = req.UpdateThirdPartyAccess.PayloadMPEvent;
                    payLoad.UpdateIndicator = AddDeleteUpdate.Add;
                    payLoad.MeteringPointUsedDomainLocation = new Elhub_MeteringPointType()
                    {
                        Identification = new Elhub_MeteringPointIdentifierType()
                        {
                            schemeAgencyIdentifier = schemeAgencyIdentifierGS1Type.Item9,
                            Value = "707562000000051524"
                        }
                    };

                    payLoad.ConsumerInvolvedCustomerParty = new Elhub_EndUserType()
                    {
                        ExtendedStorageMeteringValues = true
                    };

                    var respons = await client.UpdateThirdPartyAccessAsync(req);
                    Debug.WriteLine($"UpdateThirdPartyAcsess OK");
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"UpdateThirdPartyAcsess ERROR Message={e.Message}");
                }
                await client.CloseAsync();
            }
            catch (Exception e)
            {
                Debug.WriteLine($" Connection ERROR Message: {e.Message}");
            }
        }

    }
}
