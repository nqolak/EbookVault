using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbookVault.Infrastructure.Data.Models
{
    public class Feedback
    {
        [Key]
        [StringLength(36)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(500)]
        public string FeedbackText { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        // Relations

        public User Poster { get; set; }
    }
}
