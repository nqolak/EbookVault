using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbookVault.Infrastructure.Data.Models
{
    public class Message
    {
        [Key]
        [StringLength(36)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(500)]
        public string MessageText { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        // Relations

        public virtual User Sender { get; set; }

        public virtual User Recipient { get; set; }
    }
}
