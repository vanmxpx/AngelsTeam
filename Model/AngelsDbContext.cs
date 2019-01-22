using System;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Profit> Profits { get; set; }
        public DbSet<Target> Targets { get; set; }

        public AngelsDbContext(DbContextOptions<AngelsDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
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
                entity.Property(p => p.Body).HasMaxLength(1024);
                entity.Property(p => p.Likes).HasDefaultValue(0);
                entity.Property(p => p.Dislikes).HasDefaultValue(0);
            });
            modelBuilder.Entity<Signal>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(p => p.Date).HasDefaultValue(DateTime.Now).HasColumnType("datetime");
                entity.Property(p => p.Body).HasMaxLength(512);
                entity.Property(p => p.Free).HasDefaultValue(false);
                entity.Property(p => p.Coin).HasMaxLength(3);

            });
            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<SubscriptionType>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(p => p.Name).HasMaxLength(64);
                entity.Property(p => p.Exchange).HasMaxLength(15);
                entity.Property(p => p.Price);
                entity.Property(p => p.Duration).HasColumnType("varchar(32)");
            });
            modelBuilder.Entity<Period>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<SignalLevel>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<UserType>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Target>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Description>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Profit>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Description>().HasData(new Description[]
            {
                new Description
                {
                    Id = 1,
                        Value = "Безлимитные сигналы",
                        SubscriptionTypeId = 3

                },
                new Description
                {
                    Id = 2,
                        Value = "Личные консультации",
                        SubscriptionTypeId = 3
                },

                new Description
                {
                    Id = 3,
                        Value = "Разбор ваших монет",
                        SubscriptionTypeId = 3
                }, new Description
                {
                    Id = 4,
                        Value = "Приватные сигналы",
                        SubscriptionTypeId = 2

                },
                new Description
                {
                    Id = 5,
                        Value = "Приватный чат участников",
                        SubscriptionTypeId = 2
                },

                new Description
                {
                    Id = 6,
                        Value = "Продление подписки, если ежемесячный профит составил < 60%",
                        SubscriptionTypeId = 2
                },
                new Description
                {
                    Id = 7,
                        Value = "Ознакомление с контентом",
                        SubscriptionTypeId = 1

                },
                new Description
                {
                    Id = 8,
                        Value = "Бесплатные сигналы",
                        SubscriptionTypeId = 1
                },

                new Description
                {
                    Id = 9,
                        Value = "Разбор некоторых монет",
                        SubscriptionTypeId = 1
                },
            });
            modelBuilder.Entity<Profit>().HasData(new Profit[]
            {
                new Profit
                {
                    Id = 1,
                        Value = "0.012",
                        TargetId = 1

                },
                new Profit
                {
                    Id = 2,
                        Value = "0.012",
                        TargetId = 1
                },

                new Profit
                {
                    Id = 3,
                        Value = "0.012",
                        TargetId = 1
                }, new Profit
                {
                    Id = 4,
                        Value = "0.012",
                        TargetId = 2

                },
                new Profit
                {
                    Id = 5,
                        Value = "0.012",
                        TargetId = 2
                },

                new Profit
                {
                    Id = 6,
                        Value = "0.012",
                        TargetId = 2
                }
            });
            modelBuilder.Entity<News>().HasData(new News[]
            {
                new News
                {
                    Id = 1,
                        Attachment = "assets/images/test.jpeg",
                        Title = "Новость дня",
                        Body = "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс. У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам:",
                        Likes = 20,
                        Dislikes = 10,
                        Date = DateTime.Now
                },
                new News
                {
                    Id = 2,
                        Attachment = "assets/images/test.jpeg",
                        Title = "Новость дня 2",
                        Body = "Дорогие друзья, сегодня ...",
                        Likes = 15,
                        Dislikes = 3,
                        Date = DateTime.Now
                },
                new News
                {
                    Id = 3,
                        Attachment = "assets/images/test.jpeg",
                        Title = "Новость дня",
                        Body = "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс. У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам:",
                        Likes = 20,
                        Dislikes = 10,
                        Date = DateTime.Now
                },
                new News
                {
                    Id = 4,
                        Attachment = "assets/images/test.jpeg",
                        Title = "Новость дня",
                        Body = "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс. У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам:",
                        Likes = 20,
                        Dislikes = 10,
                        Date = DateTime.Now
                }
            });
            modelBuilder.Entity<Signal>().HasData(new Signal[]
            {
                new Signal
                {
                    Id = 1,
                        Attachment = "assets/images/test.jpeg",
                        Body = "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс ",
                        Coin = "BTC",
                        Date = DateTime.Now,
                        Free = true,
                        SignalLevelId = 1,
                        TargetId = 1,
                        Title = "Бесплатный сигнал дня"
                },
                new Signal
                {
                    Id = 2,
                        Attachment = "assets/images/test.jpeg",
                        Body = "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс ",
                        Coin = "BTC",
                        Date = DateTime.Now,
                        Free = false,
                        SignalLevelId = 3,
                        TargetId = 2,
                        Title = "Платный сигнал дня"
                }
            });
            modelBuilder.Entity<Target>().HasData(new Target[]
            {
                new Target
                {
                    Id = 1,
                        Buy = "0.123",
                        PeriodId = 2,
                        Stop = "0.132"
                },
                new Target
                {
                    Id = 2,
                        Buy = "0.123",
                        PeriodId = 2,
                        Stop = "0.132"
                }
            });
            modelBuilder.Entity<SubscriptionType>().HasData(new SubscriptionType[]
            {
                new SubscriptionType
                {
                    Id = 1,
                        Duration = -1,
                        Name = "Бесплатная",
                        Exchange = "BTC",
                        Price = 0,
                },
                new SubscriptionType
                {
                    Id = 2,
                        Duration = 1,
                        Exchange = "BTC",
                        Name = "Ежемесячная",
                        Price = 2,
                },
                new SubscriptionType
                {
                    Id = 3,
                        Duration = -1,
                        Exchange = "BTC",
                        Name = "Безлимитная",
                        Price = 4,
                }
            });
            modelBuilder.Entity<UserType>().HasData(new UserType[]
            {
                new UserType
                {
                    Id = 1,
                        Name = "Admin"
                },
                new UserType
                {
                    Id = 2,
                        Name = "User"
                },
                new UserType
                {
                    Id = 3,
                        Name = "Free"
                },
                new UserType
                {
                    Id = 4,
                        Name = "Unverified"
                }
            });
            modelBuilder.Entity<Period>().HasData(new Period[]
            {
                new Period
                {
                    Id = 1,
                        Name = "Short"
                },
                new Period
                {
                    Id = 2,
                        Name = "Middle"
                },
                new Period
                {
                    Id = 3,
                        Name = "Long"
                }
            });
            modelBuilder.Entity<SignalLevel>().HasData(new SignalLevel[]
            {
                new SignalLevel
                {
                    Id = 1,
                        Name = "Hight"
                },
                new SignalLevel
                {
                    Id = 2,
                        Name = "Middle"
                },
                new SignalLevel
                {
                    Id = 3,
                        Name = "Low"
                },
                new SignalLevel
                {
                    Id = 4,
                        Name = "Info"
                }
            });
            modelBuilder.Entity<Credential>().HasData(new Credential[]
            {
                new Credential
                {
                    Id = 1,
                        Email = "admin1212",
                        Password = "admin1212",
                        UserId = 1,
                },
                new Credential
                {
                    Id = 2,
                        Email = "ivanov1212",
                        Password = "ivanov1212",
                        UserId = 2,
                },
                new Credential
                {
                    Id = 3,
                        Email = "user1212",
                        Password = "user1212",
                        UserId = 3
                },
                new Credential
                {
                    Id = 4,
                        Email = "mark1212",
                        Password = "mark1212",
                        UserId = 4
                }
            });
            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User
                {
                    Id = 1,
                        Name = "Admin",
                        Surname = "Admin",
                        Telegram = "yourAdmin",
                        Photo = "assets/images/candles.jpeg",
                        ExpirationDate = DateTime.Now.AddDays(12),
                        UserTypeId = 1
                },
                new User
                {
                    Id = 2,
                        Name = "Ivan",
                        Surname = "Ivanov",
                        Telegram = "IvanovIvan",
                        Photo = "assets/images/candles.jpeg",
                        ExpirationDate = DateTime.Now.AddDays(20),
                        UserTypeId = 2
                },
                new User
                {
                    Id = 3,
                        Name = "Lexa",
                        Surname = "Lepexa",
                        Telegram = "Lepexa",
                        Photo = "assets/images/candles.jpeg",
                        ExpirationDate = DateTime.Now.AddDays(-10),
                        UserTypeId = 3
                },
                new User
                {
                    Id = 4,
                        Name = "Mark",
                        Surname = "zuckerberg",
                        Telegram = "MarkZuck",
                        Photo = "assets/images/candles.jpeg",
                        ExpirationDate = DateTime.Now,
                        UserTypeId = 4
                }
            });
        }
    }
}