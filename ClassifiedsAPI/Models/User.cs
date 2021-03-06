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
    
    public partial class User
    {
        public User()
        {
            this.FlaggedItems = new HashSet<FlaggedItem>();
            this.ItemForSales = new HashSet<ItemForSale>();
            this.SecurityQuestions = new HashSet<SecurityQuestion>();
            this.Tags = new HashSet<Tag>();
            this.WatchCategories = new HashSet<WatchCategory>();
            this.WatchItems = new HashSet<WatchItem>();
            this.PointAwards = new HashSet<PointAward>();
        }
    
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string encryptedPassword { get; set; }
        public Nullable<int> phone { get; set; }
        public int userTypeId { get; set; }
        public bool isEmailVerified { get; set; }
    
        public virtual ICollection<FlaggedItem> FlaggedItems { get; set; }
        public virtual ICollection<ItemForSale> ItemForSales { get; set; }
        public virtual ICollection<SecurityQuestion> SecurityQuestions { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<WatchCategory> WatchCategories { get; set; }
        public virtual ICollection<WatchItem> WatchItems { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual ICollection<PointAward> PointAwards { get; set; }
    }
}
