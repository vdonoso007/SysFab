﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysFabEAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_SYSFABEntities : DbContext
    {
        public DB_SYSFABEntities()
            : base("name=DB_SYSFABEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DescWarehouse> DescWarehouse { get; set; }
        public virtual DbSet<Master> Master { get; set; }
        public virtual DbSet<Movements> Movements { get; set; }
        public virtual DbSet<Pharmacology> Pharmacology { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Catalog> Catalog { get; set; }
        public virtual DbSet<Table> Table { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<StockTakeInventory> StockTakeInventory { get; set; }
        public virtual DbSet<StockTakeInventoryDetail> StockTakeInventoryDetail { get; set; }
        public virtual DbSet<Transfer> Transfer { get; set; }
        public virtual DbSet<TransferDetail> TransferDetail { get; set; }
        public virtual DbSet<TransferReturn> TransferReturn { get; set; }
    }
}
