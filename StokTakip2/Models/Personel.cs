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
    [Table("Personeller")]
    [Index(nameof(Telefon), IsUnique = true)]
    [Index(nameof(KullanıcıAdı), IsUnique = true)]
    public class Personel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string Ad { get; set; }

        [Required]
        [MaxLength(45)]
        public string Soyad { get; set; }

        [Required]
        [MaxLength(20)]
        public string Telefon { get; set; }

        [MaxLength(20)]
        public string? EPosta { get; set; }

        [MaxLength(255)]
        public string? Adres { get; set; }

        [Required]
        [MaxLength(45)]
        public string KullanıcıAdı { get; set; }

        [Required]
        [MaxLength(45)]
        public string Parola { get; set; }

        [ForeignKey(nameof(Yetki))]
        [Required]
        public int YetkiId { get; set; }
        public virtual Yetki Yetki { get; set; }

        public virtual ICollection<Satış> Satışlar { get; set; } = new HashSet<Satış>();
    }
}
