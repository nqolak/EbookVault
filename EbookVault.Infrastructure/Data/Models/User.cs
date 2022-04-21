using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbookVault.Infrastructure.Data.Models
{
    public class User : IdentityUser
    {
        public bool IsDeleted { get; set; } = false;

        // Relations

        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();

        public virtual ICollection<Book> UserUploads { get; set; } = new HashSet<Book>();

        public virtual ICollection<Message> SentMessages { get; set; } = new HashSet<Message>();

        public virtual ICollection<Message> ReceivedMessages { get; set; } = new HashSet<Message>();
    }
}
