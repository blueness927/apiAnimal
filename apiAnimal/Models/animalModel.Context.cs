﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace apiAnimal.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class petstationEntities : DbContext
    {
        public petstationEntities()
            : base("name=petstationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<animalData> animalData { get; set; }
        public virtual DbSet<animalData_Condition> animalData_Condition { get; set; }
        public virtual DbSet<animalData_Pic> animalData_Pic { get; set; }
        public virtual DbSet<animalData_Type> animalData_Type { get; set; }
    }
}