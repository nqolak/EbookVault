using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbookVault.Infrastructure.Data.Models
{
    public class Genre
    {
        [Key]
        [StringLength(36)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public bool IsDeleted { get; set; } = false;

        // Relations

        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}
