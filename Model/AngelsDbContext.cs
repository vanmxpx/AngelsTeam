using Microsoft.EntityFrameworkCore;
using System;


namespace AngelsTeam.Model
{
    public class AngelsDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Signal> Signals { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<SubscriptionType> SubscriptionTypes { get; set; }

        public AngelsDbContext(DbContextOptions<AngelsDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(p => p.Telegram).IsRequired().HasMaxLength(32);
                entity.Property(p => p.Name).HasMaxLength(32);
                entity.Property(p => p.Surname).HasMaxLength(32);
                entity.Property(p => p.ExpirationDate).HasDefaultValue(DateTime.Now).HasColumnType("date");
                entity.Property(p => p.IsAdmin).HasDefaultValue(false);

            });
            modelBuilder.Entity<Credential>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(p => p.Email).IsRequired().HasMaxLength(32);
                entity.Property(p => p.Password).IsRequired().HasMaxLength(32);
            });
            modelBuilder.Entity<News>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(p => p.Title).HasMaxLength(64);
                entity.Property(p => p.Date).HasDefaultValue(DateTime.Now).HasColumnType("datetime");
                entity.Property(p => p.Text).HasMaxLength(512);
            });
            modelBuilder.Entity<Signal>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(p => p.Title).HasMaxLength(64);
                entity.Property(p => p.Date).HasDefaultValue(DateTime.Now).HasColumnType("datetime");
                entity.Property(p => p.Text).HasMaxLength(512);
                entity.Property(p=>p.IsFree).HasDefaultValue(false);
                entity.Property(p=>p.Risk).HasDefaultValue("Low");
                entity.Property(p=>p.Coin).HasMaxLength(3);

            });
            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<SubscriptionType>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(p => p.Title).HasMaxLength(64);
                entity.Property(p => p.Description).HasMaxLength(512);
                entity.Property(p=>p.Cost).HasColumnType("float");
            });
            //Users
            // modelBuilder.Entity<User>(entity =>
            // {
            //     entity.HasKey(u => u.Id);

            //     entity.HasIndex(u => u.Telegram).IsUnique();

            //     entity.Property(u => u.IsAdmin).HasDefaultValue(false);
            //     entity.Property(u => u.Telegram).HasColumnType("varchar(32)").IsRequired();
            //     entity.Property(u=> u.Name).HasColumnType("varchar(32)");
            //     entity.Property(u=> u.Surname).HasColumnType("varchar(32)");
            //     entity.Property(u=> u.ExpirationDate).HasColumnType("datetime2");

            //     entity.HasOne(u=>u.Credential)
            //     .WithOne(r=>r.User)
            //     .HasForeignKey<Credential>(r => r.UserId).OnDelete(DeleteBehavior.Cascade);                

            //     entity.HasMany(u=>u.Subscriptions)
            //     .WithOne(p=>p.User)
            //     .HasForeignKey(p=>p.UserId);


            // });



            /*
            .Entity<User>()
            .HasOne(u => u.Profile)
            .WithOne(p => p.User)
            .HasForeignKey<UserProfile>(p => p.UserKey);
             */

        }
    }
}