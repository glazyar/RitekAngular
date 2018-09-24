//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class RABOTY_REPAIR_COMMON
    {
        public System.Guid Id { get; set; }
        public System.Guid SkvId { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> FinishDate { get; set; }
        public string Contractor { get; set; }
        public string Elevator { get; set; }
        public Nullable<System.DateTime> ComissionDate { get; set; }
        public Nullable<System.DateTime> RepairStartDate { get; set; }
        public Nullable<System.DateTime> RepairFinishDate { get; set; }
        public Nullable<double> WorkingDaysCount { get; set; }
        public string RejectedReason { get; set; }
        public Nullable<double> FluidDebit { get; set; }
        public Nullable<double> OilDebit { get; set; }
        public Nullable<double> NDin { get; set; }
        public Nullable<double> Pz { get; set; }
        public Nullable<double> TargetDepth { get; set; }
        public Nullable<double> CurrentDepth { get; set; }
        public string ProjectLevel { get; set; }
        public string PerfInterval { get; set; }
        public Nullable<double> Diameter { get; set; }
        public string GNO_before { get; set; }
        public string GNO_after { get; set; }
        public Nullable<double> Suspension_before { get; set; }
        public Nullable<double> Suspension_after { get; set; }
        public string PlanProcedures { get; set; }
        public Nullable<double> NormoTime { get; set; }
        public System.DateTime Created { get; set; }
        public string Author { get; set; }
        public System.DateTime LastSaved { get; set; }
        public string LastEditor { get; set; }
        public Nullable<int> RepairReasonId { get; set; }
    }
}
