//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class vols
    {
        [Key]
        public int Id_vols { get; set; }
        public Nullable<int> id_avion { get; set; }
        public Nullable<int> id_user { get; set; }
        public Nullable<int> id_aero_dep { get; set; }
        public Nullable<int> id_aero_arri { get; set; }
        public string description { get; set; }
    
        public virtual aeroport aeroport { get; set; }
        public virtual aeroport aeroport1 { get; set; }
        public virtual avion avion { get; set; }
        public virtual User User { get; set; }
    }
}