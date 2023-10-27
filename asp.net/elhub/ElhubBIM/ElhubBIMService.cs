using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EoptNetCore_Console.ElhubBIM
{

    public class ElhubBIMTester
    {

        public void Start()
        {


            WSHttpBinding myBinding = new WSHttpBinding(SecurityMode.Message);


            myBinding.Security.Message.ClientCredentialType = MessageCredentialType.Certificate;

            // Create the endpoint address.
            EndpointAddress ea = new
                EndpointAddress("http://machineName/Calculator");

            // Create the client.
            ElhubBIMServiceClient cc = new ElhubBIMServiceClient(myBinding, ea);

            // Specify a certificate to use for authenticating the client.
            cc.ClientCredentials.ClientCertificate.SetCertificate(StoreLocation.CurrentUser, StoreName.My, X509FindType.FindBySubjectName, "Cohowinery.com");

            // Begin using the client.
            try
            {
                cc.Open();
                //cc.UpdateThirdPartyAccessAsync());

                cc.Close();

            }
            catch (Exception e)
            {
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public class ElhubBIMServiceClient : System.ServiceModel.ClientBase<ElhubBIMService>, ElhubBIMService
    {

        public ElhubBIMServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public Task<UpdateThirdPartyAccessResponse> UpdateThirdPartyAccessAsync(UpdateThirdPartyAccessRequest1 request)
        {
            return base.Channel.UpdateThirdPartyAccessAsync(request);
        }

        public Task<UpdateThirdPartyAccessResponse> UpdateThirdPartyAccessAsync(UpdateThirdPartyAccessRequest UpdateThirdPartyAccessRequest)
        {
            UpdateThirdPartyAccessRequest1 inValue = new UpdateThirdPartyAccessRequest1();
            inValue.UpdateThirdPartyAccessRequest = UpdateThirdPartyAccessRequest;
            return ((ElhubBIMService)(this)).UpdateThirdPartyAccessAsync(inValue);
        }

        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }

        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
    }


    public interface ElhubBIMService
    {
        [System.ServiceModel.OperationContractAttribute(Action = "UpdateThirdPartyAccess", ReplyAction = "*")]
        // [System.ServiceModel.FaultContractAttribute(typeof(ElhubSOAPFaultType), Action = "UpdateThirdPartyAccess", Name = "ElhubSOAPFault", Namespace = "urn:no:elhub:emif:wsdl:common:v2")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        Task<UpdateThirdPartyAccessResponse> UpdateThirdPartyAccessAsync(UpdateThirdPartyAccessRequest1 request);

    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class UpdateThirdPartyAccessResponse
    {

        public UpdateThirdPartyAccessResponse()
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class UpdateThirdPartyAccessRequest1
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:no:elhub:emif:wsdl:marketprocesses:v2", Order = 0)]
        public UpdateThirdPartyAccessRequest UpdateThirdPartyAccessRequest;

        public UpdateThirdPartyAccessRequest1()
        {
        }

        public UpdateThirdPartyAccessRequest1(UpdateThirdPartyAccessRequest UpdateThirdPartyAccessRequest)
        {
            this.UpdateThirdPartyAccessRequest = UpdateThirdPartyAccessRequest;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:no:elhub:emif:wsdl:marketprocesses:v2")]
    public partial class UpdateThirdPartyAccessRequest
    {
        private ElhubBIM_XML.UpdateThirdPartyAccess updateThirdPartyAccessField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:no:elhub:emif:thirdpartyaccess:UpdateThirdPartyAccess:v2", Order = 0)]
        public ElhubBIM_XML.UpdateThirdPartyAccess UpdateThirdPartyAccess
        {
            get
            {
                return this.updateThirdPartyAccessField;
            }
            set
            {
                this.updateThirdPartyAccessField = value;
            }
        }
    }

}
