﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wypozyczalnia.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities5 : DbContext
    {
        public Entities5()
            : base("name=Entities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Powiadomienie> Powiadomienie { get; set; }
        public virtual DbSet<Problem> Problem { get; set; }
        public virtual DbSet<IndywidualnaOferta> IndywidualnaOferta { get; set; }
    }
}
