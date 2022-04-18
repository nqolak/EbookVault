using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbookVault.Infrastructure.Data
{
    public class Book
    {
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

        [Required]
        public Decimal Rating = 0m;

        [StringLength(500)]
        public string? Summary { get; set; }

        // TODO

        [Required]
        [StringLength(36)]
        public Guid UploaderId { get; set; }

        [Required]
        public HashSet<Genre> Genres { get; set; }
    }
}
