﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BirdProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BirdEntities : DbContext
    {
        public BirdEntities()
            : base("name=BirdEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<B狀態> B狀態 { get; set; }
        public virtual DbSet<B鳥> B鳥 { get; set; }
        public virtual DbSet<B鳥奴> B鳥奴 { get; set; }
        public virtual DbSet<B腳環> B腳環 { get; set; }
        public virtual DbSet<B學名> B學名 { get; set; }
        public virtual DbSet<test> test { get; set; }
    }
}
