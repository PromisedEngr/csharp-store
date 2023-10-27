// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 6.0.0.0. www.xsd2code.com
//    {"TargetFramework":"NetCore","NameSpace":"ElhubBIM","Properties":{},"XmlAttribute":{"Enabled":true},"ClassParams":{},"Miscellaneous":{}}
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace ElhubBIM_XML
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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:thirdpartyaccess:UpdateThirdPartyAccess:v2")]
    [XmlRootAttribute(Namespace = "urn:no:elhub:emif:thirdpartyaccess:UpdateThirdPartyAccess:v2", IsNullable = false)]
    public partial class UpdateThirdPartyAccess
    {
        #region Private fields
        private Elhub_HeaderType _header;
        private Elhub_EnergyContextType _processEnergyContext;
        private Elhub_UpdateThirdPartyAccessType _payloadMPEvent;
        #endregion

        public UpdateThirdPartyAccess()
        {
            _payloadMPEvent = new Elhub_UpdateThirdPartyAccessType();
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

        public Elhub_UpdateThirdPartyAccessType PayloadMPEvent
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public enum listAgencyIdentifierType
    {
        [XmlEnumAttribute("260")]
        Item260,
        [XmlEnumAttribute("6")]
        Item6,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2")]
    public partial class Elhub_EndUserType
    {
        #region Private fields
        private bool _extendedStorageMeteringValues;
        #endregion

        public Elhub_EndUserType()
        {
            _extendedStorageMeteringValues = true;
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public enum schemeAgencyIdentifierGS1Type
    {
        [XmlEnumAttribute("9")]
        Item9,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:AggregatedBusinessInformationEntities:v2")]
    public partial class Elhub_UpdateThirdPartyAccessType
    {
        #region Private fields
        private AddDeleteUpdate _updateIndicator;
        private Elhub_MeteringPointType _meteringPointUsedDomainLocation;
        private Elhub_EndUserType _consumerInvolvedCustomerParty;
        #endregion

        public Elhub_UpdateThirdPartyAccessType()
        {
            _consumerInvolvedCustomerParty = new Elhub_EndUserType();
            _meteringPointUsedDomainLocation = new Elhub_MeteringPointType();
        }

        public AddDeleteUpdate UpdateIndicator
        {
            get
            {
                return _updateIndicator;
            }
            set
            {
                _updateIndicator = value;
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

        public Elhub_EndUserType ConsumerInvolvedCustomerParty
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public enum AddDeleteUpdate
    {
        Add,
        Delete,
        Update,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public enum listAgencyIdentifierType89_6
    {
        [XmlEnumAttribute("6")]
        Item6,
        [XmlEnumAttribute("89")]
        Item89,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public enum listAgencyIdentifierType89
    {
        [XmlEnumAttribute("89")]
        Item89,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "urn:no:elhub:emif:common:BusinessDataType:v2")]
    public enum Elhub_EnergyIndustryClassificationType
    {
        [XmlEnumAttribute("23")]
        Item23,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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
}
#pragma warning restore