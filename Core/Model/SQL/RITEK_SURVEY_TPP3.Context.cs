﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Model.SQL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RITEK_SURVEY_TPP3Entities : DbContext
    {
        public RITEK_SURVEY_TPP3Entities()
            : base("name=RITEK_SURVEY_TPP3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<RABOTY_DEVELOPMENT_COMMON> RABOTY_DEVELOPMENT_COMMON { get; set; }
        public virtual DbSet<RABOTY_DEVELOPMENT_DAILY> RABOTY_DEVELOPMENT_DAILY { get; set; }
        public virtual DbSet<RABOTY_DEVELOPMENT_WORKS> RABOTY_DEVELOPMENT_WORKS { get; set; }
        public virtual DbSet<RABOTY_DRILLING_COMMON> RABOTY_DRILLING_COMMON { get; set; }
        public virtual DbSet<RABOTY_DRILLING_DRIFTING> RABOTY_DRILLING_DRIFTING { get; set; }
        public virtual DbSet<RABOTY_DRILLING_PERSONAL> RABOTY_DRILLING_PERSONAL { get; set; }
        public virtual DbSet<RABOTY_DRILLING_WORKS> RABOTY_DRILLING_WORKS { get; set; }
        public virtual DbSet<RABOTY_REPAIR_COMMON> RABOTY_REPAIR_COMMON { get; set; }
        public virtual DbSet<RABOTY_REPAIR_DAILY> RABOTY_REPAIR_DAILY { get; set; }
        public virtual DbSet<RABOTY_REPAIR_WORKS> RABOTY_REPAIR_WORKS { get; set; }
        public virtual DbSet<SKV_NSI> SKV_NSI { get; set; }
        public virtual DbSet<Survey> Survey { get; set; }
        public virtual DbSet<SURVEY_INFO> SURVEY_INFO { get; set; }
        public virtual DbSet<Config> Config { get; set; }
        public virtual DbSet<PERSON_OBJECT_ACCESS> PERSON_OBJECT_ACCESS { get; set; }
        public virtual DbSet<PERSON_ROLES> PERSON_ROLES { get; set; }
        public virtual DbSet<PERSONAL> PERSONAL { get; set; }
    }
}