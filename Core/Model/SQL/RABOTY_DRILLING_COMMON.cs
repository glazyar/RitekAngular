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
    
    public partial class RABOTY_DRILLING_COMMON
    {
        public System.Guid Id { get; set; }
        public System.Guid SkvId { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> FinishDate { get; set; }
        public string DrillingEngine { get; set; }
        public string Contractor { get; set; }
        public string Master { get; set; }
        public string Supervisor { get; set; }
        public Nullable<double> ProjectDepth { get; set; }
        public string ProjectLevel { get; set; }
        public Nullable<System.DateTime> DrillStartDatePlan { get; set; }
        public Nullable<System.DateTime> DrillStartDateFact { get; set; }
        public Nullable<System.DateTime> DrillFinishDatePlan { get; set; }
        public Nullable<System.DateTime> DrillFinishDateFact { get; set; }
        public Nullable<System.DateTime> ImplementDatePlan { get; set; }
        public Nullable<System.DateTime> ImplementDateFact { get; set; }
        public Nullable<double> SpeedPlan { get; set; }
        public Nullable<double> SpeedFact { get; set; }
        public string ContsructionPlan { get; set; }
        public string ContsructionFact { get; set; }
        public string ParamsPlan { get; set; }
        public string ParamsFact { get; set; }
        public string RegimePlan { get; set; }
        public string RegimeFact { get; set; }
        public string KNBKPlan { get; set; }
        public string KNBKFact { get; set; }
        public System.DateTime Created { get; set; }
        public string Author { get; set; }
        public System.DateTime LastSaved { get; set; }
        public string LastEditor { get; set; }
    }
}
