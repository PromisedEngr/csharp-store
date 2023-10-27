using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using EoptNetCore_Console.XsdToCode.RequestEndOfSupply;

namespace EoptNetCore_Console
{

    public class ElHubMakeData
    {

        private static string URN = "urn:no:elhub:emif:wsdl:marketprocesses:v2";
        private static string URN1 = "urn:no:elhub:emif:market:RequestEndOfSupply:v2";
        private static string URN2 = "urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2";

        public static string SerializeEnvelope(Envelope envelope)
        {
            //serialize it and write to string

            string str;
            using (var stringWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter))
                {
                    var ns = new XmlSerializerNamespaces();
                    ns.Add("soapenv", "http://schemas.xmlsoap.org/soap/envelope/");
                    ns.Add("urn", URN);
                    ns.Add("urn1", URN1);
                    ns.Add("urn2", URN2);

                    XmlSerializer xmlSerializer = new XmlSerializer(envelope.GetType());
                    xmlSerializer.Serialize(xmlWriter, envelope, ns);
                    str = stringWriter.ToString();
                    //str = stringWriter.ToString().Replace(@"<?xml version=""1.0"" encoding=""utf-16""?>", "");
                }
            }
            return str;
        }

        public static Envelope CreateEnvelopWithRequestEndOfSupplyRequestNoSec()
        {
            var envelope = new Envelope();
            envelope.Header = new Header();
            envelope.Body = new Body();
            envelope.Body.RequestEndOfSupplyRequest = CreateXmlRequestEndOfSupplyRequest();
            return envelope;
        }

        public static Envelope CreateEnvelopWithRequestEndOfSupplyRequestSec()
        {
            var envelope = new Envelope();
            envelope.Header = new Header();
            envelope.Header.Security = new Security();

            envelope.Body = new Body();
            envelope.Body.RequestEndOfSupplyRequest = CreateXmlRequestEndOfSupplyRequest();
            return envelope;
        }


        [XmlRootAttribute(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
        public class Security { }


        [XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public class Envelope
        {
            public Header Header { get; set; }
            public Body Body { get; set; }
        }

        //[XmlTypeAttribute(Namespace = "")]
        public class Header
        {
              public Security Security { get; set; }
        }

        //[XmlTypeAttribute(Namespace = "")]
        [XmlRootAttribute(Namespace = "urn:no:elhub:emif:wsdl:marketprocesses:v2")]
        public class Body
        {
            public RequestEndOfSupplyRequest RequestEndOfSupplyRequest { get; set; }
        }


        [XmlRootAttribute(Namespace = "urn:no:elhub:emif:market:RequestEndOfSupply:v2")]
        public class RequestEndOfSupplyRequest
        {
            public RequestEndOfSupply RequestEndOfSupply { get; set; }
        }

        public static RequestEndOfSupplyRequest CreateXmlRequestEndOfSupplyRequest()
        {
            var req = new RequestEndOfSupplyRequest();
            req.RequestEndOfSupply = new RequestEndOfSupply();
            req.RequestEndOfSupply.Header = new Elhub_Header();

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
                    Value = "707057500022939815"
                }
            };

            header.JuridicalSenderEnergyParty = new Elhub_EnergyPartyType()
            {
                Identification = new Elhub_EnergyPartyIdentifierType()
                {
                    schemeAgencyIdentifier = schemeAgencyIdentifierGS1Type.Item9,
                    Value = "707057500022939815"
                }
            };

            header.JuridicalRecipientEnergyParty = new Elhub_EnergyPartyType()
            {
                Identification = new Elhub_EnergyPartyIdentifierType()
                {
                    schemeAgencyIdentifier = schemeAgencyIdentifierGS1Type.Item9,
                    Value = "707057500022939815"
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
            return req;
        }
    }


}
