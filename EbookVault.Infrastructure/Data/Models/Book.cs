using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbookVault.Infrastructure.Data.Models
{
    public class Book
    {
        [Key]
        [StringLength(36)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        [StringLength(50)]
        public string? Publisher { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [StringLength(30)]
        public string Language { get; set; }

        [Required]
        public DateTime UploadDate = DateTime.Now;

        [Precision(3,2)]
        public Decimal Rating = 0m;

        [StringLength(500)]
        public string? Summary { get; set; }

        public bool IsVisible { get; set; }

        // Relations

        public User Uploder { get; set; }

        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();

        public virtual ICollection<Genre> Genres { get; set; } = new HashSet<Genre>();
    }
}
