//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.719.0
namespace Ocelli.OpenClickBank.Shared.Models
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.719.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("analyticsResult", Namespace="")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("analyticsResult", Namespace="")]
    public partial class AnalyticsResult
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AnalyticsResultRow> _rows;
        
        [System.Xml.Serialization.XmlArrayAttribute("rows", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("row", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<AnalyticsResultRow> Rows
        {
            get
            {
                return _rows;
            }
            set
            {
                _rows = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RowsSpecified
        {
            get
            {
                return ((this.Rows != null) 
                            && (this.Rows.Count != 0));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AnalyticsValue> _totals;
        
        [System.Xml.Serialization.XmlArrayAttribute("totals", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("total", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<AnalyticsValue> Totals
        {
            get
            {
                return _totals;
            }
            set
            {
                _totals = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalsSpecified
        {
            get
            {
                return ((this.Totals != null) 
                            && (this.Totals.Count != 0));
            }
        }
    }
}