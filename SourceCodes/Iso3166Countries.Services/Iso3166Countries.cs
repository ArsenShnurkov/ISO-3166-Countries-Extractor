﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 
namespace Iso3166Countries.Services {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://aliencube.org/schemas/2013/08/iso-3166-countries")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://aliencube.org/schemas/2013/08/iso-3166-countries", IsNullable=false)]
    public partial class Countries {
        
        private Country[] countryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Country")]
        public Country[] Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://aliencube.org/schemas/2013/08/iso-3166-countries")]
    public partial class Country {
        
        private string nameField;
        
        private string codeField;
        
        private System.Nullable<int> sortOrderField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> SortOrder {
            get {
                return this.sortOrderField;
            }
            set {
                this.sortOrderField = value;
            }
        }
    }
}
