namespace Veritabani_Baglanti
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ogrenci")]
    public partial class ogrenci
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int No { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string Ad { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string Soyad { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string Bolum { get; set; }
    }
}
