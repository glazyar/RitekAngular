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
    
    public partial class PERSON_OBJECT_ACCESS
    {
        public System.Guid Id { get; set; }
        public string Login { get; set; }
        public int kodTPP { get; set; }
        public int kodCEH { get; set; }
        public int AccessLevel { get; set; }
        public bool DELETED { get; set; }
    }
}