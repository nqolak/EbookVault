using EbookVault.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EbookVault.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Book>()
                .HasOne(e => e.Uploder)
                .WithMany(e => e.UserUploads)
                .OnDelete(DeleteBehavior.NoAction);

            model.Entity<User>()
                .HasMany(e => e.SentMessages)
                .WithOne(e => e.Sender)
                .OnDelete(DeleteBehavior.NoAction);

            model.Entity<User>()
                .HasMany(e => e.ReceivedMessages)
                .WithOne(e => e.Recipient)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(model);
        }
    }
}