//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassifiedsAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemImage
    {
        public int itemImageId { get; set; }
        public string itemImageShortDescription { get; set; }
        public string itemImageFilename { get; set; }
        public bool isPrimary { get; set; }
        public int itemId { get; set; }
    
        public virtual Item Item { get; set; }
    }
}
