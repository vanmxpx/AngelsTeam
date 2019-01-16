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
        public DbSet<SignalLevel> SignalLevels { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Role> Roles { get; set; }


        public AngelsDbContext(DbContextOptions<AngelsDbContext> options) : base(options)
        {
            // Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(p => p.Telegram).IsRequired().HasMaxLength(32);
                entity.Property(p => p.Name).HasMaxLength(32);
                entity.Property(p => p.Surname).HasMaxLength(32);
                entity.Property(p => p.ExpirationDate).HasDefaultValue(DateTime.Now).HasColumnType("date");

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
                entity.Property(p => p.Date).HasDefaultValue(DateTime.Now).HasColumnType("datetime");
                entity.Property(p => p.Description).HasMaxLength(512);
                entity.Property(p => p.IsFree).HasDefaultValue(false);
                entity.Property(p => p.Coin).HasMaxLength(3);

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
                entity.Property(p => p.Cost).HasColumnType("float");
            });
            modelBuilder.Entity<Period>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<SignalLevel>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Role>(entiry =>
            {
                entiry.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Role>().HasData(new Role[] {
                    new Role {
                        Id = 1,
                        Name = "User"
                    },
                    new Role{
                        Id = 2,
                       Name = "Subscriber"
                    },
                    new Role{
                        Id = 3,
                        Name = "Admin"
                    }
                });
            modelBuilder.Entity<Period>().HasData(new Period[] {
                    new Period {
                        Id = 1,
                        Name = "Short"
                    },
                    new Period {
                        Id = 2,
                        Name = "Middle"
                    },
                    new Period {
                        Id = 3,
                        Name = "Long"
                    }
            });
            modelBuilder.Entity<SignalLevel>().HasData(new SignalLevel[] {
                    new SignalLevel {
                        Id = 1,
                        Name = "Hight"
                    },
                    new SignalLevel {
                        Id = 2,
                        Name = "Middle"
                    },
                    new SignalLevel {
                        Id = 3,
                        Name = "Low"
                    },
                    new SignalLevel {
                        Id = 4,
                        Name = "Info"
                    }
                });
            modelBuilder.Entity<Credential>().HasData(
                new Credential[] {
                    new Credential {
                        Id = 1,
                        Email = "admin1212",
                        Password = "admin1212",
                        UserId = 1,
                    },
                    new Credential {
                        Id = 2,
                        Email = "ivanov1212",
                        Password = "ivanov1212",
                        UserId = 2,
                    },
                    new Credential {
                        Id = 3,
                        Email = "user1212",
                        Password = "user1212",
                        UserId = 3,
                    }
                }
            );
            modelBuilder.Entity<User>().HasData(
                new User[] {
                    new User {
                        Id=1,
                        Name="Admin",
                        Surname = "Admin",
                        Telegram = "yourAdmin",
                        ExpirationDate = DateTime.Now,
                        RoleId = 3
                    },
                    new User {
                        Id=2,
                        Name="Ivan",
                        Surname = "Ivanov",
                        Telegram = "IvanovIvan",
                        ExpirationDate = DateTime.Now,
                        RoleId = 2
                    },
                    new User{
                        Id = 3,
                        Name = "Lexa",
                        Surname = "Lepexa",
                        Telegram = "Lepexa",
                        ExpirationDate = DateTime.Now,
                        RoleId = 1
                    }
                }
            );
        }
    }
}