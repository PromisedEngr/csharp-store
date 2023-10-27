﻿//using System;/*  w  w  w.  d    e m  o  2  s  .   c o m  */
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Security.Cryptography.X509Certificates;
//using System.IdentityModel.Selectors;
//using System.IdentityModel.Tokens;
//using System.ServiceModel;
//using System.ServiceModel.Channels;
//using System.ServiceModel.Description;
//using System.ServiceModel.Dispatcher;
//using System.ServiceModel.Security;
//using System.ServiceModel.Security.Tokens;


//public class Test
//{
//    public static void test()
//    {
//        AsymmetricSecurityBindingElement sbe = new SymmetricSecurityBindingElement();
//        sbe.RecipientTokenParameters = new X509SecurityTokenParameters(X509KeyIdentifierClauseType.Thumbprint, SecurityTokenInclusionMode.Never);
//        sbe.InitiatorTokenParameters = new X509SecurityTokenParameters(X509KeyIdentifierClauseType.Thumbprint, SecurityTokenInclusionMode.AlwaysToRecipient);
//        X509SecurityTokenParameters p = new X509SecurityTokenParameters(X509KeyIdentifierClauseType.IssuerSerial, SecurityTokenInclusionMode.AlwaysToRecipient);
//        p.RequireDerivedKeys = false;
//        sbe.SetKeyDerivation(false);
//        sbe.MessageProtectionOrder = MessageProtectionOrder.SignBeforeEncrypt;
//        ServiceHost host = new ServiceHost(typeof(Foo));
//        HttpTransportBindingElement hbe = new HttpTransportBindingElement();
//        CustomBinding binding = new CustomBinding(sbe, hbe);
//        binding.ReceiveTimeout = TimeSpan.FromSeconds(5);
//        host.AddServiceEndpoint("IFoo", binding, new Uri("http://localhost:8080"));
//        ServiceCredentials cred = new ServiceCredentials();
//        cred.ServiceCertificate.Certificate = new X509Certificate2("test.pfx", "mono");
//        cred.ClientCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
//        host.Description.Behaviors.Add(cred);
//        host.Description.Behaviors.Find<ServiceDebugBehavior>()
//          .IncludeExceptionDetailInFaults = true;
//        foreach (ServiceEndpoint se in host.Description.Endpoints)
//            se.Behaviors.Add(new StdErrInspectionBehavior());
//        ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
//        smb.HttpGetEnabled = true;
//        smb.HttpGetUrl = new Uri("http://localhost:8080/wsdl");
//        host.Description.Behaviors.Add(smb);
//        host.Open();
//        Console.WriteLine("Hit [CR] key to close ...");
//        Console.ReadLine();
//        host.Close();
//    }
//}
//[ServiceContract]
//public interface IFoo
//{
//    [OperationContract]
//    string Echo(string msg);
//}
//[ServiceBehavior(IncludeExceptionDetailInFaults = true)]
//class Foo : IFoo
//{
//    public string Echo(string msg)
//    {
//        Console.WriteLine(msg);
//        return msg + msg;
//    }
//}
