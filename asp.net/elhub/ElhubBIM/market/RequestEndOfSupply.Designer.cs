using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;

namespace EoptNetCore_Console.XsdToCode.RequestEndOfSupply
{
    [DebuggerStepThrough]
    public partial class RequestEndOfSupply
    {
        public RequestEndOfSupply()
        {
            PayloadMPEvent = new Elhub_RequestEndOfSupplyType();
            ProcessEnergyContext = new Elhub_EnergyContextType();
            Header = new Elhub_Header();
        }
        
        public Elhub_Header Header { get; set; }
        public Elhub_EnergyContextType ProcessEnergyContext { get; set; }
        public Elhub_RequestEndOfSupplyType PayloadMPEvent { get; set; }
        
    }

    [DebuggerStepThrough]
    [XmlRootAttribute(Namespace = "urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2")]
    public partial class Elhub_Header
    {
        
        private Elhub_DocumentNameCodeType _documentType;
        private System.DateTime _creation;
        private Elhub_EnergyPartyType _physicalSenderEnergyParty;
        private Elhub_EnergyPartyType _juridicalSenderEnergyParty;
        private Elhub_EnergyPartyType _juridicalRecipientEnergyParty;
        

        public Elhub_Header()
        {
            _juridicalRecipientEnergyParty = new Elhub_EnergyPartyType();
            _juridicalSenderEnergyParty = new Elhub_EnergyPartyType();
            _physicalSenderEnergyParty = new Elhub_EnergyPartyType();
            _documentType = new Elhub_DocumentNameCodeType();
        }

        public string Identification { get; set; }
        

        public Elhub_DocumentNameCodeType DocumentType
        {
            get
            {
                return _documentType;
            }
            set
            {
                _documentType = value;
            }
        }

        public System.DateTime Creation
        {
            get
            {
                return _creation;
            }
            set
            {
                _creation = value;
            }
        }

        [DefaultValueAttribute(false)]
        public bool RequestPositiveAcknowledgement { get; set; }
        

        public Elhub_EnergyPartyType PhysicalSenderEnergyParty
        {
            get
            {
                return _physicalSenderEnergyParty;
            }
            set
            {
                _physicalSenderEnergyParty = value;
            }
        }

        public Elhub_EnergyPartyType JuridicalSenderEnergyParty
        {
            get
            {
                return _juridicalSenderEnergyParty;
            }
            set
            {
                _juridicalSenderEnergyParty = value;
            }
        }

        public Elhub_EnergyPartyType JuridicalRecipientEnergyParty
        {
            get
            {
                return _juridicalRecipientEnergyParty;
            }
            set
            {
                _juridicalRecipientEnergyParty = value;
            }
        }
    }

    [DebuggerStepThrough]
    public partial class Elhub_DocumentNameCodeType
    {

        [XmlAttribute]
        public listAgencyIdentifierType listAgencyIdentifier { get; set; }

        [XmlTextAttribute]
        public Elhub_DocumentType Value { get; set; }
        
    }

    public enum listAgencyIdentifierType
    {
        [XmlEnumAttribute("260")]
        Item260,
        [XmlEnumAttribute("6")]
        Item6,
    }

    public enum Elhub_DocumentType
    {
        [XmlEnumAttribute("21")]
        Item21,
        [XmlEnumAttribute("392")]
        Item392,
        [XmlEnumAttribute("406")]
        Item406,
        [XmlEnumAttribute("414")]
        Item414,
        [XmlEnumAttribute("432")]
        Item432,
        E02,
        E07,
        E10,
        E13,
        E30,
        E31,
        E39,
        E58,
        E65,
        E66,
        E67,
        ERR,
        [XmlEnumAttribute("294")]
        Item294,
    }

    [DebuggerStepThrough]
    public partial class Elhub_CountryCodeType
    {

        [XmlAttribute]
        public listAgencyIdentifierType5 listAgencyIdentifier { get; set; }
        
        [XmlTextAttribute]
        public CountryCode Value { get; set; }
        
    }

    public enum listAgencyIdentifierType5
    {
        [XmlEnumAttribute("5")]
        Item5,
    }

    public enum CountryCode
    {
        AD,
        AE,
        AF,
        AG,
        AI,
        AL,
        AM,
        AO,
        AQ,
        AR,
        AS,
        AT,
        AU,
        AW,
        AX,
        AZ,
        BA,
        BB,
        BD,
        BE,
        BF,
        BG,
        BH,
        BI,
        BJ,
        BL,
        BM,
        BN,
        BO,
        BQ,
        BR,
        BS,
        BT,
        BV,
        BW,
        BY,
        BZ,
        CA,
        CC,
        CD,
        CF,
        CG,
        CH,
        CI,
        CK,
        CL,
        CM,
        CN,
        CO,
        CR,
        CU,
        CV,
        CW,
        CX,
        CY,
        CZ,
        DE,
        DJ,
        DK,
        DM,
        DO,
        DZ,
        EC,
        EE,
        EG,
        EH,
        ER,
        ES,
        ET,
        FI,
        FJ,
        FK,
        FM,
        FO,
        FR,
        GA,
        GB,
        GD,
        GE,
        GF,
        GG,
        GH,
        GI,
        GL,
        GM,
        GN,
        GP,
        GQ,
        GR,
        GS,
        GT,
        GU,
        GW,
        GY,
        HK,
        HM,
        HN,
        HR,
        HT,
        HU,
        ID,
        IE,
        IL,
        IM,
        IN,
        IO,
        IQ,
        IR,
        IS,
        IT,
        JE,
        JM,
        JO,
        JP,
        KE,
        KG,
        KH,
        KI,
        KM,
        KN,
        KP,
        KR,
        KW,
        KY,
        KZ,
        LA,
        LB,
        LC,
        LI,
        LK,
        LR,
        LS,
        LT,
        LU,
        LV,
        LY,
        MA,
        MC,
        MD,
        ME,
        MF,
        MG,
        MH,
        MK,
        ML,
        MM,
        MN,
        MO,
        MP,
        MQ,
        MR,
        MS,
        MT,
        MU,
        MV,
        MW,
        MX,
        MY,
        MZ,
        NA,
        NC,
        NE,
        NF,
        NG,
        NI,
        NL,
        NO,
        NP,
        NR,
        NU,
        NZ,
        OM,
        PA,
        PE,
        PF,
        PG,
        PH,
        PK,
        PL,
        PM,
        PN,
        PR,
        PS,
        PT,
        PW,
        PY,
        QA,
        RE,
        RO,
        RS,
        RU,
        RW,
        SA,
        SB,
        SC,
        SD,
        SE,
        SG,
        SH,
        SI,
        SJ,
        SK,
        SL,
        SM,
        SN,
        SO,
        SR,
        SS,
        ST,
        SV,
        SX,
        SY,
        SZ,
        TC,
        TD,
        TF,
        TG,
        TH,
        TJ,
        TK,
        TL,
        TM,
        TN,
        TO,
        TR,
        TT,
        TV,
        TW,
        TZ,
        UA,
        UG,
        UM,
        US,
        UY,
        UZ,
        VA,
        VC,
        VE,
        VG,
        VI,
        VN,
        VU,
        WF,
        WS,
        YE,
        YT,
        ZA,
        ZM,
        ZW,
    }

    [DebuggerStepThrough]
    
    public partial class Elhub_InvoiceeAddressType
    {
        public Elhub_InvoiceeAddressType()
        {
            CountryCode = new Elhub_CountryCodeType();
        }

        public AddressTypeType AddressType { get; set; }
        public string StreetName { get; set; }
        public string StreetCode { get; set; }
        public string BuildingNumber { get; set; }
        public string FloorIdentification { get; set; }
        public string RoomIdentification { get; set; }
        public string Postcode { get; set; }
        public string CityName { get; set; }
        public string CitySubDivisionName { get; set; }
        public string MunicipalityCode { get; set; }

        public Elhub_CountryCodeType CountryCode { get; set; }
        public string AddressFreeForm { get; set; }
        public string PostOfficeBox { get; set; }
        public string CareOf { get; set; }
        public string AttentionOf { get; set; }
        public string OnBehalf { get; set; }
    }

    public enum AddressTypeType
    {
        invoiceadr,
        postaladr,
    }

    [DebuggerStepThrough]
    public partial class Elhub_Communication
    {
        
        public CommunicationChannelType CommunicationChannel { get; set; }
        public string CompleteNumber { get; set; }
        public string Description { get; set; }
    }

    public enum CommunicationChannelType
    {
        Email,
        Mobile,
        Phone,
        Telefax,
    }

    [DebuggerStepThrough]
    public partial class Elhub_EndUserIdentifierType
    {
        [XmlAttribute]
        public Elhub_schemeAgencyIdentifierType schemeAgencyIdentifier { get; set; }

        [XmlTextAttribute]
        public string Value { get; set; }
        
    }

    public enum Elhub_schemeAgencyIdentifierType
    {
        [XmlEnumAttribute("82")]
        Item82,
        Z01,
    }

    [DebuggerStepThrough]
    public partial class Elhub_CustomerPartyEndOfSupplyType
    {

        public Elhub_CustomerPartyEndOfSupplyType()
        {
            Identification = new Elhub_EndUserIdentifierType();
        }

        public Elhub_EndUserIdentifierType Identification { get; set; }

        public string Name { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Communication")]
        public Elhub_Communication[] Communication { get; set; }
    }

    [DebuggerStepThrough]
    public partial class Elhub_MeteringPointIdentifierType
    {
        [XmlAttribute]
        public schemeAgencyIdentifierGS1Type schemeAgencyIdentifier { get; set; }
        

        [XmlTextAttribute]
        public string Value { get; set; }
    }

    public enum schemeAgencyIdentifierGS1Type
    {
        [XmlEnumAttribute("9")]
        Item9,
    }

    [DebuggerStepThrough]
    public partial class Elhub_MeteringPointType
    {
        
        private Elhub_MeteringPointIdentifierType _identification;
        

        public Elhub_MeteringPointType()
        {
            _identification = new Elhub_MeteringPointIdentifierType();
        }

        public Elhub_MeteringPointIdentifierType Identification
        {
            get
            {
                return _identification;
            }
            set
            {
                _identification = value;
            }
        }
    }

    [DebuggerStepThrough]
    [XmlRootAttribute(Namespace = "urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2")]
    public partial class Elhub_RequestEndOfSupplyType
    {

        public Elhub_RequestEndOfSupplyType()
        {
            ConsumerInvolvedCustomerParty = new Elhub_CustomerPartyEndOfSupplyType();
            BalanceSupplierInvolvedEnergyParty = new Elhub_EnergyPartyType();
            MeteringPointUsedDomainLocation = new Elhub_MeteringPointType();
        }

        public System.DateTime EndOfOccurrence { get; set; }
        public string OriginalBusinessDocumentReference { get; set; }
        public EndReasonType ReasonForTransaction { get; set; }
        public Elhub_MeteringPointType MeteringPointUsedDomainLocation { get; set; }
        public Elhub_EnergyPartyType BalanceSupplierInvolvedEnergyParty { get; set; }
        public Elhub_CustomerPartyEndOfSupplyType ConsumerInvolvedCustomerParty { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ConsumerInvolvedCustomerAddress")]
        public Elhub_InvoiceeAddressType[] ConsumerInvolvedCustomerAddress { get; set; }
        
    }

    public enum EndReasonType
    {
        Z41,
        Z42,
        Z44,
        Z45,
    }

    [DebuggerStepThrough]
    public partial class Elhub_EnergyPartyType
    {
        
        private Elhub_EnergyPartyIdentifierType _identification;
        

        public Elhub_EnergyPartyType()
        {
            _identification = new Elhub_EnergyPartyIdentifierType();
        }

        public Elhub_EnergyPartyIdentifierType Identification
        {
            get
            {
                return _identification;
            }
            set
            {
                _identification = value;
            }
        }
    }

    [DebuggerStepThrough]
    public partial class Elhub_EnergyPartyIdentifierType
    {

        [XmlAttribute]
        public schemeAgencyIdentifierGS1Type schemeAgencyIdentifier { get; set; }
        

        [XmlTextAttribute]
        public string Value { get; set; }
        
    }

    [DebuggerStepThrough]
    public partial class Elhub_BusinessProcessRoleType
    {

        [XmlAttribute]
        public listAgencyIdentifierType89_6 listAgencyIdentifier { get; set; }
        

        [XmlTextAttribute]
        public Elhub_BusinessProcessRole Value { get; set; }
        
    }

    public enum listAgencyIdentifierType89_6
    {
        [XmlEnumAttribute("6")]
        Item6,
        [XmlEnumAttribute("89")]
        Item89,
    }

    public enum Elhub_BusinessProcessRole
    {
        AG,
        BSL,
        DDE,
        DDK,
        DDM,
        DDQ,
        DDZ,
        DDX,
        MDR,
        PQ,
        QRY,
        SLR,
    }

    [DebuggerStepThrough]
    public partial class Elhub_BusinessProcessType
    {
        [XmlAttribute]
        public listAgencyIdentifierType89 listAgencyIdentifier { get; set; }

        [XmlTextAttribute]
        public BRSIdentification Value { get; set; }
        
    }

    public enum listAgencyIdentifierType89
    {
        [XmlEnumAttribute("89")]
        Item89,
    }

    public enum BRSIdentification
    {
        [XmlEnumAttribute("BRS-NO-101")]
        BRSNO101,
        [XmlEnumAttribute("BRS-NO-102")]
        BRSNO102,
        [XmlEnumAttribute("BRS-NO-103")]
        BRSNO103,
        [XmlEnumAttribute("BRS-NO-104")]
        BRSNO104,
        [XmlEnumAttribute("BRS-NO-111")]
        BRSNO111,
        [XmlEnumAttribute("BRS-NO-121")]
        BRSNO121,
        [XmlEnumAttribute("BRS-NO-122")]
        BRSNO122,
        [XmlEnumAttribute("BRS-NO-123")]
        BRSNO123,
        [XmlEnumAttribute("BRS-NO-131")]
        BRSNO131,
        [XmlEnumAttribute("BRS-NO-132")]
        BRSNO132,
        [XmlEnumAttribute("BRS-NO-133")]
        BRSNO133,
        [XmlEnumAttribute("BRS-NO-201")]
        BRSNO201,
        [XmlEnumAttribute("BRS-NO-202")]
        BRSNO202,
        [XmlEnumAttribute("BRS-NO-211")]
        BRSNO211,
        [XmlEnumAttribute("BRS-NO-212")]
        BRSNO212,
        [XmlEnumAttribute("BRS-NO-213")]
        BRSNO213,
        [XmlEnumAttribute("BRS-NO-214")]
        BRSNO214,
        [XmlEnumAttribute("BRS-NO-221")]
        BRSNO221,
        [XmlEnumAttribute("BRS-NO-222")]
        BRSNO222,
        [XmlEnumAttribute("BRS-NO-223")]
        BRSNO223,
        [XmlEnumAttribute("BRS-NO-224")]
        BRSNO224,
        [XmlEnumAttribute("BRS-NO-301")]
        BRSNO301,
        [XmlEnumAttribute("BRS-NO-302")]
        BRSNO302,
        [XmlEnumAttribute("BRS-NO-303")]
        BRSNO303,
        [XmlEnumAttribute("BRS-NO-305")]
        BRSNO305,
        [XmlEnumAttribute("BRS-NO-306")]
        BRSNO306,
        [XmlEnumAttribute("BRS-NO-311")]
        BRSNO311,
        [XmlEnumAttribute("BRS-NO-312")]
        BRSNO312,
        [XmlEnumAttribute("BRS-NO-313")]
        BRSNO313,
        [XmlEnumAttribute("BRS-NO-314")]
        BRSNO314,
        [XmlEnumAttribute("BRS-NO-315")]
        BRSNO315,
        [XmlEnumAttribute("BRS-NO-317")]
        BRSNO317,
        [XmlEnumAttribute("BRS-NO-318")]
        BRSNO318,
        [XmlEnumAttribute("BRS-NO-321")]
        BRSNO321,
        [XmlEnumAttribute("BRS-NO-322")]
        BRSNO322,
        [XmlEnumAttribute("BRS-NO-324")]
        BRSNO324,
        [XmlEnumAttribute("BRS-NO-332")]
        BRSNO332,
        [XmlEnumAttribute("BRS-NO-391")]
        BRSNO391,
        [XmlEnumAttribute("BRS-NO-402")]
        BRSNO402,
        [XmlEnumAttribute("BRS-NO-501")]
        BRSNO501,
        [XmlEnumAttribute("BRS-NO-502")]
        BRSNO502,
        [XmlEnumAttribute("BRS-NO-503")]
        BRSNO503,
        [XmlEnumAttribute("BRS-NO-511")]
        BRSNO511,
        [XmlEnumAttribute("BRS-NO-512")]
        BRSNO512,
        [XmlEnumAttribute("BRS-NO-601")]
        BRSNO601,
        [XmlEnumAttribute("BRS-NO-602")]
        BRSNO602,
        [XmlEnumAttribute("BRS-NO-611")]
        BRSNO611,
        [XmlEnumAttribute("BRS-NO-622")]
        BRSNO622,
        [XmlEnumAttribute("BRS-NO-623")]
        BRSNO623,
        POLL,
    }

    [DebuggerStepThrough]
    [XmlRootAttribute(Namespace = "urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2")]
    public partial class Elhub_EnergyContextType
    {
        
        private Elhub_BusinessProcessType _energyBusinessProcess;
        private Elhub_BusinessProcessRoleType _energyBusinessProcessRole;
        private Elhub_EnergyIndustryClassificationType _energyIndustryClassification;
        

        public Elhub_EnergyContextType()
        {
            _energyBusinessProcessRole = new Elhub_BusinessProcessRoleType();
            _energyBusinessProcess = new Elhub_BusinessProcessType();
        }

        public Elhub_BusinessProcessType EnergyBusinessProcess
        {
            get
            {
                return _energyBusinessProcess;
            }
            set
            {
                _energyBusinessProcess = value;
            }
        }

        public Elhub_BusinessProcessRoleType EnergyBusinessProcessRole
        {
            get
            {
                return _energyBusinessProcessRole;
            }
            set
            {
                _energyBusinessProcessRole = value;
            }
        }

        public Elhub_EnergyIndustryClassificationType EnergyIndustryClassification
        {
            get
            {
                return _energyIndustryClassification;
            }
            set
            {
                _energyIndustryClassification = value;
            }
        }
    }

    public enum Elhub_EnergyIndustryClassificationType
    {
        [XmlEnumAttribute("23")]
        Item23,
    }
}
#pragma warning restore
