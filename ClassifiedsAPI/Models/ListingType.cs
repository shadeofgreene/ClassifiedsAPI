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
    
    public partial class ListingType
    {
        public ListingType()
        {
            this.Items = new HashSet<Item>();
        }
    
        public int listingTypeId { get; set; }
        public string listingType1 { get; set; }
    
        public virtual ICollection<Item> Items { get; set; }
    }
}
