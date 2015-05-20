﻿namespace NFeSharp.Esquemas.v1_00
{
    using NFeSharp.Esquemas.TiposBasicos;
    //------------------------------------------------------------------------------
    // <auto-generated>
    //     O código foi gerado por uma ferramenta.
    //     Versão de Tempo de Execução:4.0.30319.34209
    //
    //     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
    //     o código for gerado novamente.
    // </auto-generated>
    //------------------------------------------------------------------------------

    using System.Xml.Serialization;

    // 
    // This source code was auto-generated by xsd, Version=4.0.30319.33440.
    // 
    


    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum resNFeCSitNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TVerResNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.00")]
        Item100,
    }

    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class retDistDFeInt
    {

        /// <remarks/>
        public TAmb tpAmb;

        /// <remarks/>
        public string verAplic;

        /// <remarks/>
        public string cStat;

        /// <remarks/>
        public string xMotivo;

        /// <remarks/>
        public System.DateTime dhResp;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string ultNSU;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string maxNSU;

        /// <remarks/>
        public retDistDFeIntLoteDistDFeInt loteDistDFeInt;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TVerDistDFe versao;
    }
    
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class retDistDFeIntLoteDistDFeInt
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("docZip")]
        public retDistDFeIntLoteDistDFeIntDocZip[] docZip;
    }

    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class retDistDFeIntLoteDistDFeIntDocZip
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string NSU;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schema;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value;
    }





    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeSignatureMethod
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm;

        public SignedInfoTypeSignatureMethod()
        {
            this.Algorithm = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        }
    }
    
}