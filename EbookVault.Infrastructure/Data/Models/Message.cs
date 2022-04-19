using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string Content { get; set; }

        public DateTime Date = DateTime.Now;

        // TODO

        [StringLength(36)]
        public Guid SenderId { get; set; }

        [StringLength(36)]
        public Guid RecipientId { get; set; }
    }
}
