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
    
    public partial class SpisokZakupok
    {
        public int ID { get; set; }
        public int IDProdykta { get; set; }
        public int Kolichestvo { get; set; }
        public System.DateTime DataZayavku { get; set; }
    
        public virtual Prodykti Prodykti { get; set; }
    }
}