//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemAnalizi_GorselProgramlama
{
    using System;
    using System.Collections.Generic;
    
    public partial class HarekatSB_Komutan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HarekatSB_Komutan()
        {
            this.PersonelKomutanı = new HashSet<PersonelKomutanı>();
        }
    
        public int KisiID { get; set; }
        public string KisiAdi { get; set; }
        public string KisiSoyadi { get; set; }
        public string KisiUnvani { get; set; }
        public string KisiRutbesi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonelKomutanı> PersonelKomutanı { get; set; }
    }
}
