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
    
    public partial class SystemUser
    {
        public int IdSystemUsers { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
    
        public virtual Teachers Teachers { get; set; }
    }
}
