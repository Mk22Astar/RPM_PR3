//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Registration.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Avtorizaciya
    {
        public int ID { get; set; }
        public int IDPolzovatel { get; set; }
        public string Parol { get; set; }
        public string Login { get; set; }
    
        public virtual Polzovateli Polzovateli { get; set; }
    }
}