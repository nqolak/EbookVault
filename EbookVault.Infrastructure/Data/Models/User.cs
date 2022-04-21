﻿using Microsoft.AspNetCore.Identity;
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

        public virtual ICollection<Book> UserBooks { get; set; } = new HashSet<Book>();
    }
}
