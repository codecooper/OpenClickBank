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
    [System.Xml.Serialization.XmlTypeAttribute("productData", Namespace="")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Product", Namespace="")]
    public partial class ProductData
    {
        
        public virtual bool ShouldSerializeId()
        {
            return Id.HasValue;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("id", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Nullable<int> Id { get; set; }
        
        public virtual bool ShouldSerializeStatus()
        {
            return Status.HasValue;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("status", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Nullable<ActiveStatus> Status { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("digital", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Digital { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("physical", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Physical { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("digitalRecurring", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool DigitalRecurring { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("physicalRecurring", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool PhysicalRecurring { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("site", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Site { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("created", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Created { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("updated", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Updated { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("approval_status", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProductApprovalStatus Approval_Status { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("language", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Language { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("title", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Title { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("description", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Description { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("post_purchase_description", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Post_Purchase_Description { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("image", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImageBean Image { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("thank_you_pages")]
        public ThankYouPages Thank_You_Pages { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("pitch_pages")]
        public PitchPages Pitch_Pages { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("commission")]
        public ProductCommission Commission { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Pricing> _pricings;
        
        [System.Xml.Serialization.XmlArrayAttribute("pricings", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("pricing")]
        public System.Collections.ObjectModel.Collection<Pricing> Pricings
        {
            get
            {
                return _pricings;
            }
            set
            {
                _pricings = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PricingsSpecified
        {
            get
            {
                return ((this.Pricings != null) 
                            && (this.Pricings.Count != 0));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ContractBean> _contracts;
        
        [System.Xml.Serialization.XmlArrayAttribute("contracts", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("contract", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<ContractBean> Contracts
        {
            get
            {
                return _contracts;
            }
            set
            {
                _contracts = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContractsSpecified
        {
            get
            {
                return ((this.Contracts != null) 
                            && (this.Contracts.Count != 0));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ProductCategory> _categories;
        
        [System.Xml.Serialization.XmlArrayAttribute("categories", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("category", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<ProductCategory> Categories
        {
            get
            {
                return _categories;
            }
            set
            {
                _categories = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CategoriesSpecified
        {
            get
            {
                return ((this.Categories != null) 
                            && (this.Categories.Count != 0));
            }
        }
        
        public virtual bool ShouldSerializeDisable_Geo_Currency()
        {
            return Disable_Geo_Currency.HasValue;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("disable_geo_currency", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Nullable<bool> Disable_Geo_Currency { get; set; }
        
        public virtual bool ShouldSerializeAllow_Currency_Change()
        {
            return Allow_Currency_Change.HasValue;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("allow_currency_change", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Nullable<bool> Allow_Currency_Change { get; set; }
        
        public virtual bool ShouldSerializeUs_Tax_Exempt()
        {
            return Us_Tax_Exempt.HasValue;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("us_tax_exempt", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Nullable<bool> Us_Tax_Exempt { get; set; }
        
        public virtual bool ShouldSerializeRevenue_Recognition()
        {
            return Revenue_Recognition.HasValue;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("revenue_recognition", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Nullable<RevRec> Revenue_Recognition { get; set; }
        
        public virtual bool ShouldSerializeReduced_Upsell_Markup()
        {
            return Reduced_Upsell_Markup.HasValue;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("reduced_upsell_markup", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Nullable<bool> Reduced_Upsell_Markup { get; set; }
        
        public virtual bool ShouldSerializeSkip_Confirmation_Page()
        {
            return Skip_Confirmation_Page.HasValue;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("skip_confirmation_page", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Nullable<bool> Skip_Confirmation_Page { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("admin_download_url", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Admin_Download_Url { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("admin_mobile_download_url", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Admin_Mobile_Download_Url { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("no_commission", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool No_Commission { get; set; }
        
        public virtual bool ShouldSerializeSale_Refund_Days_Limit()
        {
            return Sale_Refund_Days_Limit.HasValue;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("sale_refund_days_limit", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Nullable<int> Sale_Refund_Days_Limit { get; set; }
        
        public virtual bool ShouldSerializeRebill_Refund_Days_Limit()
        {
            return Rebill_Refund_Days_Limit.HasValue;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("rebill_refund_days_limit", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Nullable<int> Rebill_Refund_Days_Limit { get; set; }
        
        public virtual bool ShouldSerializeAdmin_Restrict_Flexible_Refund()
        {
            return Admin_Restrict_Flexible_Refund.HasValue;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("admin_restrict_flexible_refund", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Nullable<bool> Admin_Restrict_Flexible_Refund { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("commission_tier_override", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Commission_Tier_Override { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("deliveryMethod", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DeliveryMethod { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("deliverySpeed", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DeliverySpeed { get; set; }
        
        public virtual bool ShouldSerializeMaxQuantity()
        {
            return MaxQuantity.HasValue;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("maxQuantity", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Nullable<int> MaxQuantity { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("isPartOfOrderBump", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IsPartOfOrderBump { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("isInitialOfOrderBump", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IsInitialOfOrderBump { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("isProductOfOrderBump", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IsProductOfOrderBump { get; set; }
        
        [System.Diagnostics.CodeAnalysis.AllowNullAttribute()]
        [System.Diagnostics.CodeAnalysis.MaybeNullAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("sku")]
        public string Sku { get; set; }
    }
}
