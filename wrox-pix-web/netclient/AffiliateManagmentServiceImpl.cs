﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=1.1.4322.2032.
// 
using System.Diagnostics;
using System.Xml.Serialization;
using System;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Web.Services;


/// <remarks/>
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="AffiliateManagmentServiceImplHttpBinding", Namespace="http://service.pix.beginspring.wrox.com")]
public class AffiliateManagmentServiceImpl : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    /// <remarks/>
    public AffiliateManagmentServiceImpl() {
        this.Url = "http://localhost:8080/pixweb-0.0.1/services/AffilateManagment";
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://service.pix.beginspring.wrox.com", ResponseNamespace="http://service.pix.beginspring.wrox.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("out", IsNullable=true)]
    public Affiliate changePassword([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in0, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in1, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in2) {
        object[] results = this.Invoke("changePassword", new object[] {
                    in0,
                    in1,
                    in2});
        return ((Affiliate)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginchangePassword(string in0, string in1, string in2, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("changePassword", new object[] {
                    in0,
                    in1,
                    in2}, callback, asyncState);
    }
    
    /// <remarks/>
    public Affiliate EndchangePassword(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Affiliate)(results[0]));
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://service.pix.beginspring.wrox.com", ResponseNamespace="http://service.pix.beginspring.wrox.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void removeAffiliate([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in0) {
        this.Invoke("removeAffiliate", new object[] {
                    in0});
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginremoveAffiliate(string in0, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("removeAffiliate", new object[] {
                    in0}, callback, asyncState);
    }
    
    /// <remarks/>
    public void EndremoveAffiliate(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://service.pix.beginspring.wrox.com", ResponseNamespace="http://service.pix.beginspring.wrox.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void enrollUserViaAffiliateWebSite([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] PixUser in0, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Affiliate in1) {
        this.Invoke("enrollUserViaAffiliateWebSite", new object[] {
                    in0,
                    in1});
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginenrollUserViaAffiliateWebSite(PixUser in0, Affiliate in1, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("enrollUserViaAffiliateWebSite", new object[] {
                    in0,
                    in1}, callback, asyncState);
    }
    
    /// <remarks/>
    public void EndenrollUserViaAffiliateWebSite(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://service.pix.beginspring.wrox.com", ResponseNamespace="http://service.pix.beginspring.wrox.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void enrollAffiliate([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Affiliate in0) {
        this.Invoke("enrollAffiliate", new object[] {
                    in0});
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginenrollAffiliate(Affiliate in0, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("enrollAffiliate", new object[] {
                    in0}, callback, asyncState);
    }
    
    /// <remarks/>
    public void EndenrollAffiliate(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://service.pix.beginspring.wrox.com", ResponseNamespace="http://service.pix.beginspring.wrox.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("out", IsNullable=true)]
    public Affiliate getAffiliate([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in0) {
        object[] results = this.Invoke("getAffiliate", new object[] {
                    in0});
        return ((Affiliate)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BegingetAffiliate(string in0, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("getAffiliate", new object[] {
                    in0}, callback, asyncState);
    }
    
    /// <remarks/>
    public Affiliate EndgetAffiliate(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((Affiliate)(results[0]));
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://service.pix.beginspring.wrox.com", ResponseNamespace="http://service.pix.beginspring.wrox.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void removeAffiliateWithUser([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in0, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in1) {
        this.Invoke("removeAffiliateWithUser", new object[] {
                    in0,
                    in1});
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginremoveAffiliateWithUser(string in0, string in1, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("removeAffiliateWithUser", new object[] {
                    in0,
                    in1}, callback, asyncState);
    }
    
    /// <remarks/>
    public void EndremoveAffiliateWithUser(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://model.pix.beginspring.wrox.com")]
public class Affiliate {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string companyName;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string email;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string faxNumber;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string firstName;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string lastName;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string password;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string userName;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string websiteURL;
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://model.pix.beginspring.wrox.com")]
public class PixUser {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string email;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string firstName;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string lastName;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string password;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string userName;
}
