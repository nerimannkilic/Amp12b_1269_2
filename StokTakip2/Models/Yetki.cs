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
    [Table("Yetkiler")]
    [Index(nameof(YetkiAdı), IsUnique = true)]
    public class Yetki
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string YetkiAdı { get; set; }

        public virtual ICollection<Personel> Personeller { get; set; } = new HashSet<Personel>();
    }
}
