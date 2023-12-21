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
    [Table("Kategoriler")]
    [Index(nameof(KategoriAdı), IsUnique = true)]
    public class Kategori
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string KategoriAdı { get; set; }

        public virtual ICollection<Ürün> Ürünler { get; set; } = new HashSet<Ürün>();
    }
}
