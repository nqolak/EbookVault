using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbookVault.Infrastructure.Data
{
    public class Review
    {
        [Key]
        [StringLength(36)]
        public Guid Id { get; set; } = Guid.NewGuid();

        public Decimal Rating { get; set; }

        [StringLength(300)]
        public string? CommentText { get; set; } 

        // TODO

        [Required]
        [StringLength(36)]
        public Guid PosterId { get; set; }

        [Required]
        [StringLength(36)]
        public Guid BookId { get; set; }
    }
}
