using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip2.Models
{
    [Table("Tedarikçiler")]
    [Index(nameof(FirmaAdı), IsUnique = true)]
    [Index(nameof(Telefon), IsUnique = true)]
    [Index(nameof(EPosta), IsUnique = true)]
    public class Tedarikçi
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string FirmaAdı { get; set; }

        [Required]
        [MaxLength(45)]
        public string YetkiliAdı { get; set; }

        [Required]
        [MaxLength(20)]
        public string Telefon { get; set; }

        [MaxLength(45)]
        public string? EPosta { get; set; }

        [Required]
        [MaxLength(255)]
        public string Adres { get; set; }

        public virtual ICollection<Ürün> Ürünler { get; set; } = new HashSet<Ürün>();
    }
}
