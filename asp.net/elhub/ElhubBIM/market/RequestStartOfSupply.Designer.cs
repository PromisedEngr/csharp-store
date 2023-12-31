// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 6.0.0.0. www.xsd2code.com
//    {"TargetFramework":"NetCore","NameSpace":"EoptNetCore_Console.XsdToCode","Properties":{},"XmlAttribute":{"Enabled":true},"ClassParams":{},"Miscellaneous":{}}
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace EoptNetCore_Console.XsdToCode
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Runtime.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Xml;
    using System.Collections.Generic;


    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:market:RequestStartOfSupply:v2")]
    [XmlRootAttribute(Namespace = "urn:no:elhub:emif:market:RequestStartOfSupply:v2", IsNullable = false)]
    public partial class RequestStartOfSupply
    {
        #region Private fields
        private Elhub_HeaderType _header;
        private Elhub_EnergyContextType _processEnergyContext;
        private Elhub_RequestStartOfSupplyType _payloadMPEvent;
        #endregion

        public RequestStartOfSupply()
        {
            _payloadMPEvent = new Elhub_RequestStartOfSupplyType();
            _processEnergyContext = new Elhub_EnergyContextType();
            _header = new Elhub_HeaderType();
        }

        public Elhub_HeaderType Header
        {
            get
            {
                return _header;
            }
            set
            {
                _header = value;
            }
        }

        public Elhub_EnergyContextType ProcessEnergyContext
        {
            get
            {
                return _processEnergyContext;
            }
            set
            {
                _processEnergyContext = value;
            }
        }

        public Elhub_RequestStartOfSupplyType PayloadMPEvent
        {
            get
            {
                return _payloadMPEvent;
            }
            set
            {
                _payloadMPEvent = value;
            }
        }
    }

    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2")]
    public partial class Elhub_HeaderType
    {
        #region Private fields
        private string _identification;
        private Elhub_DocumentNameCodeType _documentType;
        private System.DateTime _creation;
        private bool _requestPositiveAcknowledgement;
        private Elhub_EnergyPartyType _physicalSenderEnergyParty;
        private Elhub_EnergyPartyType _juridicalSenderEnergyParty;
        private Elhub_EnergyPartyType _juridicalRecipientEnergyParty;
        #endregion

        public Elhub_HeaderType()
        {
            _juridicalRecipientEnergyParty = new Elhub_EnergyPartyType();
            _juridicalSenderEnergyParty = new Elhub_EnergyPartyType();
            _physicalSenderEnergyParty = new Elhub_EnergyPartyType();
            _documentType = new Elhub_DocumentNameCodeType();
        }

        public string Identification
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

        public bool RequestPositiveAcknowledgement
        {
            get
            {
                return _requestPositiveAcknowledgement;
            }
            set
            {
                _requestPositiveAcknowledgement = value;
            }
        }

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

    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public partial class Elhub_DocumentNameCodeType
    {
        #region Private fields
        private listAgencyIdentifierType _listAgencyIdentifier;
        private Elhub_DocumentType _value;
        #endregion

        [XmlAttribute]
        public listAgencyIdentifierType listAgencyIdentifier
        {
            get
            {
                return _listAgencyIdentifier;
            }
            set
            {
                _listAgencyIdentifier = value;
            }
        }

        [XmlTextAttribute]
        public Elhub_DocumentType Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }

    
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public enum listAgencyIdentifierType
    {
        [XmlEnumAttribute("260")]
        Item260,
        [XmlEnumAttribute("6")]
        Item6,
    }

    
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
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

    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public partial class Elhub_CountryCodeType
    {
        #region Private fields
        private listAgencyIdentifierType5 _listAgencyIdentifier;
        private CountryCode _value;
        #endregion

        [XmlAttribute]
        public listAgencyIdentifierType5 listAgencyIdentifier
        {
            get
            {
                return _listAgencyIdentifier;
            }
            set
            {
                _listAgencyIdentifier = value;
            }
        }

        [XmlTextAttribute]
        public CountryCode Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }

    
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public enum listAgencyIdentifierType5
    {
        [XmlEnumAttribute("5")]
        Item5,
    }

    
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
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

    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2")]
    public partial class Elhub_InvoiceeAddressType
    {
        #region Private fields
        private AddressTypeType _addressType;
        private string _streetName;
        private string _streetCode;
        private string _buildingNumber;
        private string _floorIdentification;
        private string _roomIdentification;
        private string _postcode;
        private string _cityName;
        private string _citySubDivisionName;
        private string _municipalityCode;
        private Elhub_CountryCodeType _countryCode;
        private string _addressFreeForm;
        private string _postOfficeBox;
        private string _careOf;
        private string _attentionOf;
        private string _onBehalf;
        #endregion

        public Elhub_InvoiceeAddressType()
        {
            _countryCode = new Elhub_CountryCodeType();
        }

        public AddressTypeType AddressType
        {
            get
            {
                return _addressType;
            }
            set
            {
                _addressType = value;
            }
        }

        public string StreetName
        {
            get
            {
                return _streetName;
            }
            set
            {
                _streetName = value;
            }
        }

        public string StreetCode
        {
            get
            {
                return _streetCode;
            }
            set
            {
                _streetCode = value;
            }
        }

        public string BuildingNumber
        {
            get
            {
                return _buildingNumber;
            }
            set
            {
                _buildingNumber = value;
            }
        }

        public string FloorIdentification
        {
            get
            {
                return _floorIdentification;
            }
            set
            {
                _floorIdentification = value;
            }
        }

        public string RoomIdentification
        {
            get
            {
                return _roomIdentification;
            }
            set
            {
                _roomIdentification = value;
            }
        }

        public string Postcode
        {
            get
            {
                return _postcode;
            }
            set
            {
                _postcode = value;
            }
        }

        public string CityName
        {
            get
            {
                return _cityName;
            }
            set
            {
                _cityName = value;
            }
        }

        public string CitySubDivisionName
        {
            get
            {
                return _citySubDivisionName;
            }
            set
            {
                _citySubDivisionName = value;
            }
        }

        public string MunicipalityCode
        {
            get
            {
                return _municipalityCode;
            }
            set
            {
                _municipalityCode = value;
            }
        }

        public Elhub_CountryCodeType CountryCode
        {
            get
            {
                return _countryCode;
            }
            set
            {
                _countryCode = value;
            }
        }

        public string AddressFreeForm
        {
            get
            {
                return _addressFreeForm;
            }
            set
            {
                _addressFreeForm = value;
            }
        }

        public string PostOfficeBox
        {
            get
            {
                return _postOfficeBox;
            }
            set
            {
                _postOfficeBox = value;
            }
        }

        public string CareOf
        {
            get
            {
                return _careOf;
            }
            set
            {
                _careOf = value;
            }
        }

        public string AttentionOf
        {
            get
            {
                return _attentionOf;
            }
            set
            {
                _attentionOf = value;
            }
        }

        public string OnBehalf
        {
            get
            {
                return _onBehalf;
            }
            set
            {
                _onBehalf = value;
            }
        }
    }

    
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public enum AddressTypeType
    {
        invoiceadr,
        postaladr,
    }

    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2")]
    public partial class Elhub_Communication
    {
        #region Private fields
        private CommunicationChannelType _communicationChannel;
        private string _completeNumber;
        private string _description;
        #endregion

        public CommunicationChannelType CommunicationChannel
        {
            get
            {
                return _communicationChannel;
            }
            set
            {
                _communicationChannel = value;
            }
        }

        public string CompleteNumber
        {
            get
            {
                return _completeNumber;
            }
            set
            {
                _completeNumber = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
    }

    
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public enum CommunicationChannelType
    {
        Email,
        Mobile,
        Phone,
        Telefax,
    }

    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public partial class Elhub_EndUserIdentifierType
    {
        #region Private fields
        private Elhub_schemeAgencyIdentifierType _schemeAgencyIdentifier;
        private string _value;
        #endregion

        [XmlAttribute]
        public Elhub_schemeAgencyIdentifierType schemeAgencyIdentifier
        {
            get
            {
                return _schemeAgencyIdentifier;
            }
            set
            {
                _schemeAgencyIdentifier = value;
            }
        }

        [XmlTextAttribute]
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }

    
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public enum Elhub_schemeAgencyIdentifierType
    {
        [XmlEnumAttribute("82")]
        Item82,
        Z01,
    }

    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2")]
    public partial class Elhub_CustomerPartyStartOfSupplyType
    {
        #region Private fields
        private Elhub_EndUserIdentifierType _identification;
        private string _name;
        private string _givenName;
        private string _familyName;
        private bool _extendedStorageMeteringValues;
        private string _nACE_DivisionCode;
        private List<Elhub_Communication> _communication;
        #endregion

        public Elhub_CustomerPartyStartOfSupplyType()
        {
            _communication = new List<Elhub_Communication>();
            _identification = new Elhub_EndUserIdentifierType();
        }

        public Elhub_EndUserIdentifierType Identification
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

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string GivenName
        {
            get
            {
                return _givenName;
            }
            set
            {
                _givenName = value;
            }
        }

        public string FamilyName
        {
            get
            {
                return _familyName;
            }
            set
            {
                _familyName = value;
            }
        }

        public bool ExtendedStorageMeteringValues
        {
            get
            {
                return _extendedStorageMeteringValues;
            }
            set
            {
                _extendedStorageMeteringValues = value;
            }
        }

        public string NACE_DivisionCode
        {
            get
            {
                return _nACE_DivisionCode;
            }
            set
            {
                _nACE_DivisionCode = value;
            }
        }

        [XmlElement("Communication")]
        public List<Elhub_Communication> Communication
        {
            get
            {
                return _communication;
            }
            set
            {
                _communication = value;
            }
        }
    }

    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public partial class Elhub_MeteringPointIdentifierType
    {
        #region Private fields
        private schemeAgencyIdentifierGS1Type _schemeAgencyIdentifier;
        private string _value;
        #endregion

        [XmlAttribute]
        public schemeAgencyIdentifierGS1Type schemeAgencyIdentifier
        {
            get
            {
                return _schemeAgencyIdentifier;
            }
            set
            {
                _schemeAgencyIdentifier = value;
            }
        }

        [XmlTextAttribute]
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }

    
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public enum schemeAgencyIdentifierGS1Type
    {
        [XmlEnumAttribute("9")]
        Item9,
    }

    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2")]
    public partial class Elhub_MeteringPointType
    {
        #region Private fields
        private Elhub_MeteringPointIdentifierType _identification;
        #endregion

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

    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2")]
    public partial class Elhub_RequestStartOfSupplyType
    {
        #region Private fields
        private System.DateTime _startOfOccurrence;
        private string _originalBusinessDocumentReference;
        private Elhub_MeteringPointType _meteringPointUsedDomainLocation;
        private Elhub_EnergyPartyType _balanceSupplierInvolvedEnergyParty;
        private Elhub_CustomerPartyStartOfSupplyType _consumerInvolvedCustomerParty;
        private List<Elhub_InvoiceeAddressType> _consumerInvolvedCustomerAddress;
        #endregion

        public Elhub_RequestStartOfSupplyType()
        {
            _consumerInvolvedCustomerAddress = new List<Elhub_InvoiceeAddressType>();
            _consumerInvolvedCustomerParty = new Elhub_CustomerPartyStartOfSupplyType();
            _balanceSupplierInvolvedEnergyParty = new Elhub_EnergyPartyType();
            _meteringPointUsedDomainLocation = new Elhub_MeteringPointType();
        }

        public System.DateTime StartOfOccurrence
        {
            get
            {
                return _startOfOccurrence;
            }
            set
            {
                _startOfOccurrence = value;
            }
        }

        public string OriginalBusinessDocumentReference
        {
            get
            {
                return _originalBusinessDocumentReference;
            }
            set
            {
                _originalBusinessDocumentReference = value;
            }
        }

        public Elhub_MeteringPointType MeteringPointUsedDomainLocation
        {
            get
            {
                return _meteringPointUsedDomainLocation;
            }
            set
            {
                _meteringPointUsedDomainLocation = value;
            }
        }

        public Elhub_EnergyPartyType BalanceSupplierInvolvedEnergyParty
        {
            get
            {
                return _balanceSupplierInvolvedEnergyParty;
            }
            set
            {
                _balanceSupplierInvolvedEnergyParty = value;
            }
        }

        public Elhub_CustomerPartyStartOfSupplyType ConsumerInvolvedCustomerParty
        {
            get
            {
                return _consumerInvolvedCustomerParty;
            }
            set
            {
                _consumerInvolvedCustomerParty = value;
            }
        }

        [XmlElement("ConsumerInvolvedCustomerAddress")]
        public List<Elhub_InvoiceeAddressType> ConsumerInvolvedCustomerAddress
        {
            get
            {
                return _consumerInvolvedCustomerAddress;
            }
            set
            {
                _consumerInvolvedCustomerAddress = value;
            }
        }
    }

    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2")]
    public partial class Elhub_EnergyPartyType
    {
        #region Private fields
        private Elhub_EnergyPartyIdentifierType _identification;
        #endregion

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

    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public partial class Elhub_EnergyPartyIdentifierType
    {
        #region Private fields
        private schemeAgencyIdentifierGS1Type _schemeAgencyIdentifier;
        private string _value;
        #endregion

        [XmlAttribute]
        public schemeAgencyIdentifierGS1Type schemeAgencyIdentifier
        {
            get
            {
                return _schemeAgencyIdentifier;
            }
            set
            {
                _schemeAgencyIdentifier = value;
            }
        }

        [XmlTextAttribute]
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }

    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public partial class Elhub_BusinessProcessRoleType
    {
        #region Private fields
        private listAgencyIdentifierType89_6 _listAgencyIdentifier;
        private Elhub_BusinessProcessRole _value;
        #endregion

        [XmlAttribute]
        public listAgencyIdentifierType89_6 listAgencyIdentifier
        {
            get
            {
                return _listAgencyIdentifier;
            }
            set
            {
                _listAgencyIdentifier = value;
            }
        }

        [XmlTextAttribute]
        public Elhub_BusinessProcessRole Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }

    
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public enum listAgencyIdentifierType89_6
    {
        [XmlEnumAttribute("6")]
        Item6,
        [XmlEnumAttribute("89")]
        Item89,
    }

    
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
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

    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public partial class Elhub_BusinessProcessType
    {
        #region Private fields
        private listAgencyIdentifierType89 _listAgencyIdentifier;
        private BRSIdentification _value;
        #endregion

        [XmlAttribute]
        public listAgencyIdentifierType89 listAgencyIdentifier
        {
            get
            {
                return _listAgencyIdentifier;
            }
            set
            {
                _listAgencyIdentifier = value;
            }
        }

        [XmlTextAttribute]
        public BRSIdentification Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }

    
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public enum listAgencyIdentifierType89
    {
        [XmlEnumAttribute("89")]
        Item89,
    }

    
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
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

    
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2")]
    public partial class Elhub_EnergyContextType
    {
        #region Private fields
        private Elhub_BusinessProcessType _energyBusinessProcess;
        private Elhub_BusinessProcessRoleType _energyBusinessProcessRole;
        private Elhub_EnergyIndustryClassificationType _energyIndustryClassification;
        #endregion

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

    
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public enum Elhub_EnergyIndustryClassificationType
    {
        [XmlEnumAttribute("23")]
        Item23,
    }
}
#pragma warning restore
