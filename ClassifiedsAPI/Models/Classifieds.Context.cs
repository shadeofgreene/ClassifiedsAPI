﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ClassifiedsEntities : DbContext
    {
        public ClassifiedsEntities()
            : base("name=ClassifiedsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Category> Categories { get; set; }
        public DbSet<FlaggedItem> FlaggedItems { get; set; }
        public DbSet<FlagType> FlagTypes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemForSale> ItemForSales { get; set; }
        public DbSet<ItemImage> ItemImages { get; set; }
        public DbSet<KeyWord> KeyWords { get; set; }
        public DbSet<ListingType> ListingTypes { get; set; }
        public DbSet<PointAward> PointAwards { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<WatchCategory> WatchCategories { get; set; }
        public DbSet<WatchItem> WatchItems { get; set; }
    }
}
