//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.864.0
namespace v1_3.Models
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.864.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ProductDataContracts", Namespace="", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ProductDataContracts
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ContractBean> _contract;
        
        [System.Xml.Serialization.XmlElementAttribute("contract", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<ContractBean> Contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContractSpecified
        {
            get
            {
                return ((this.Contract != null) 
                            && (this.Contract.Count != 0));
            }
        }
    }
}
