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
    
    public partial class Category
    {
        public Category()
        {
            this.WatchCategories = new HashSet<WatchCategory>();
            this.Items = new HashSet<Item>();
        }
    
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public int parentCategory { get; set; }
        public string categoryDescription { get; set; }
    
        public virtual ICollection<WatchCategory> WatchCategories { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
