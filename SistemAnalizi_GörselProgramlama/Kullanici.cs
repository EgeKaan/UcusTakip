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
    
    public partial class Kullanici
    {
        public int KullanıcıID { get; set; }
        public int PersonelID { get; set; }
        public int RolID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    
        public virtual Personel Personel { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
