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
    
    public partial class Polzovateli
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Polzovateli()
        {
            this.Avtorizaciya = new HashSet<Avtorizaciya>();
        }
    
        public int IDPolzovatelya { get; set; }
        public string Familiya { get; set; }
        public string Imya { get; set; }
        public string Otchestvo { get; set; }
        public int IDRoli { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avtorizaciya> Avtorizaciya { get; set; }
        public virtual Roli Roli { get; set; }
    }
}
