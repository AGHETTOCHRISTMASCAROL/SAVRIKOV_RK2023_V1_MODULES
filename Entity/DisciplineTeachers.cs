//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _20101_SAVRIKOV_1.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class DisciplineTeachers
    {
        public int IdDiscipline { get; set; }
        public int IdTeacher { get; set; }
        public int IdDisciplineTeachers { get; set; }
    
        public virtual Discipline Discipline { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
}