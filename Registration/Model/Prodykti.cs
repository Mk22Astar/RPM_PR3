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
    
    public partial class Prodykti
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prodykti()
        {
            this.Sostav = new HashSet<Sostav>();
            this.SpisokZakupok = new HashSet<SpisokZakupok>();
        }
    
        public int IDProdykta { get; set; }
        public string Nazvanie { get; set; }
        public int Ostatok { get; set; }
        public int IDEdiniciIzmereniya { get; set; }
    
        public virtual EdiniciIzmereniya EdiniciIzmereniya { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sostav> Sostav { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpisokZakupok> SpisokZakupok { get; set; }
    }
}