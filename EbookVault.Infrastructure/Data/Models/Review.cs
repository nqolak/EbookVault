using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbookVault.Infrastructure.Data.Models
{
    public class Review
    {
        [Key]
        [StringLength(36)]
        public Guid Id { get; set; } = Guid.NewGuid();

        public Decimal Rating { get; set; }

        [StringLength(300)]
        public string? CommentText { get; set; } 

        // Relations

        public User Reviewer { get; set; }

        public Book BookReviewed { get; set; }
    }
}
