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
    [System.Xml.Serialization.XmlTypeAttribute("ticketCommentData", Namespace="")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ticketCommentData", Namespace="")]
    public partial class TicketCommentData
    {
        
        public virtual bool ShouldSerializeCommentId()
        {
            return CommentId.HasValue;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("commentId", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Nullable<int> CommentId { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("date", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, DataType="dateTime")]
        public System.Nullable<System.DateTime> Date { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("comment", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string Comment { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("action", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public System.Nullable<TicketActionType> Action { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("commentRole", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public System.Nullable<Role> CommentRole { get; set; }
    }
}
