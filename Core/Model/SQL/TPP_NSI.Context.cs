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
    
    public partial class RITEK_NSIEntities : DbContext
    {
        public RITEK_NSIEntities()
            : base("name=RITEK_NSIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BUSH_NSI> BUSH_NSI { get; set; }
        public virtual DbSet<CEH_NSI> CEH_NSI { get; set; }
        public virtual DbSet<CLS_CAPITAL_REMONT> CLS_CAPITAL_REMONT { get; set; }
        public virtual DbSet<CLS_EXPL_SPOSOB> CLS_EXPL_SPOSOB { get; set; }
        public virtual DbSet<CLS_REMONT_REASON> CLS_REMONT_REASON { get; set; }
        public virtual DbSet<CLS_SKV_CATEGORY> CLS_SKV_CATEGORY { get; set; }
        public virtual DbSet<CLS_SKV_NAZN> CLS_SKV_NAZN { get; set; }
        public virtual DbSet<CLS_SKV_ZH_CICL> CLS_SKV_ZH_CICL { get; set; }
        public virtual DbSet<CLS_STOP_REASON> CLS_STOP_REASON { get; set; }
        public virtual DbSet<CLS_TEK_REMONT> CLS_TEK_REMONT { get; set; }
        public virtual DbSet<GROUP_NSI> GROUP_NSI { get; set; }
        public virtual DbSet<HEADERS_NSI> HEADERS_NSI { get; set; }
        public virtual DbSet<MST_NSI> MST_NSI { get; set; }
        public virtual DbSet<OBJECT_ACCESS> OBJECT_ACCESS { get; set; }
        public virtual DbSet<OBJECT_LIST> OBJECT_LIST { get; set; }
        public virtual DbSet<OTHER_OBJECT_LIST> OTHER_OBJECT_LIST { get; set; }
        public virtual DbSet<PARAMETER_NSI> PARAMETER_NSI { get; set; }
        public virtual DbSet<PARAMETER_SECOND> PARAMETER_SECOND { get; set; }
        public virtual DbSet<PLOT_NSI> PLOT_NSI { get; set; }
        public virtual DbSet<ROLES_NSI> ROLES_NSI { get; set; }
        public virtual DbSet<SKV_NSI> SKV_NSI { get; set; }
        public virtual DbSet<STANDARD_PARAMETERS> STANDARD_PARAMETERS { get; set; }
        public virtual DbSet<SURVEY_TYPES> SURVEY_TYPES { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TECH_OBJ_NSI> TECH_OBJ_NSI { get; set; }
        public virtual DbSet<TECH_OBJ_TYPE> TECH_OBJ_TYPE { get; set; }
        public virtual DbSet<TPP_NSI> TPP_NSI { get; set; }
        public virtual DbSet<CLS_GRP_STATES> CLS_GRP_STATES { get; set; }
        public virtual DbSet<SUPERHEADERS> SUPERHEADERS { get; set; }
        public virtual DbSet<SURVEY_STATES> SURVEY_STATES { get; set; }
    }
}
