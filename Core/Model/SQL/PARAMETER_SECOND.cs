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
    
    public partial class PARAMETER_SECOND
    {
        public System.Guid Id { get; set; }
        public int ParamId { get; set; }
        public string Subsystem { get; set; }
        public string SurveyType { get; set; }
        public string GroupName { get; set; }
        public string ParamName { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
        public string Unit { get; set; }
        public int Width { get; set; }
        public Nullable<int> Dec { get; set; }
        public bool IsEditable { get; set; }
        public bool IsCalculated { get; set; }
        public bool IsVisual { get; set; }
        public string Formula1 { get; set; }
        public string Formula2 { get; set; }
        public string TableName { get; set; }
        public bool InList { get; set; }
        public System.DateTime Created { get; set; }
    }
}
