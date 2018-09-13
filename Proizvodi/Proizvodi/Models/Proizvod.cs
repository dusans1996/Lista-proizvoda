using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proizvodi.Models
{
    [Table("Proizvod")]
    public partial class Proizvod
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Unesite naziv proizvoda")]
        [StringLength(50, ErrorMessage = "Mozete uneti najvise 50 karaktera")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Unesite opis proizvoda")]
        [StringLength(100, ErrorMessage = "Mozete uneti najvise 100 karaktera")]
        public string Opis { get; set; }

        [Required(ErrorMessage = "Unesite kategoriju proizvoda")]
        [StringLength(50, ErrorMessage = "Mozete uneti najvise 50 karaktera")]
        public string Kategorija { get; set; }

        [Required(ErrorMessage = "Unesite proizvodjaca proizvoda")]
        [StringLength(50, ErrorMessage = "Mozete uneti najvise 50 karaktera")]
        public string Proizvodjac { get; set; }

        [Required(ErrorMessage = "Unesite cenu proizvoda")]
        [Column(TypeName = "decimal(12, 3)")]
        public decimal Cena { get; set; }
    }
}
