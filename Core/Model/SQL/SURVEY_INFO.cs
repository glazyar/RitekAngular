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
    
    public partial class SURVEY_INFO
    {
        public int Id { get; set; }
        public string SurveyType { get; set; }
        public string groupName { get; set; }
        public int kodTPP { get; set; }
        public int Status { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime Created { get; set; }
        public string Author { get; set; }
        public System.DateTime LastSaved { get; set; }
        public string LastEditor { get; set; }
        public Nullable<System.DateTime> ExpireTime { get; set; }
        public Nullable<System.DateTime> FinishedTime { get; set; }
        public string Finisher { get; set; }
        public Nullable<System.DateTime> ClosedTime { get; set; }
        public bool FullFlag { get; set; }
        public Nullable<System.DateTime> SendTime { get; set; }
        public Nullable<System.Guid> SkvId { get; set; }
    }
}