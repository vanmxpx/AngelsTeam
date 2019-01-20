﻿// <auto-generated />
using System;
using AngelsTeam.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AngelsTeam.Migrations
{
    [DbContext(typeof(AngelsDbContext))]
    partial class AngelsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AngelsTeam.Model.Credential", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Credentials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin1212",
                            Password = "admin1212",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "ivanov1212",
                            Password = "ivanov1212",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Email = "user1212",
                            Password = "user1212",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Email = "mark1212",
                            Password = "mark1212",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("AngelsTeam.Model.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attachment");

                    b.Property<string>("Body")
                        .HasMaxLength(1024);

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2019, 1, 19, 16, 55, 2, 900, DateTimeKind.Local).AddTicks(4375));

                    b.Property<int>("Dislikes")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("Likes")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Title")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Attachment = "assets/images/test.jpeg",
                            Body = "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс. У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам:",
                            Date = new DateTime(2019, 1, 19, 16, 55, 2, 916, DateTimeKind.Local).AddTicks(2910),
                            Dislikes = 10,
                            Likes = 20,
                            Title = "Новость дня"
                        },
                        new
                        {
                            Id = 2,
                            Attachment = "assets/images/test.jpeg",
                            Body = "Дорогие друзья, сегодня ...",
                            Date = new DateTime(2019, 1, 19, 16, 55, 2, 916, DateTimeKind.Local).AddTicks(3585),
                            Dislikes = 3,
                            Likes = 15,
                            Title = "Новость дня 2"
                        });
                });

            modelBuilder.Entity("AngelsTeam.Model.Period", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Periods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Short"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Middle"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Long"
                        });
                });

            modelBuilder.Entity("AngelsTeam.Model.Signal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attachment");

                    b.Property<string>("Body")
                        .HasMaxLength(512);

                    b.Property<string>("Coin")
                        .HasMaxLength(3);

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2019, 1, 19, 16, 55, 2, 905, DateTimeKind.Local).AddTicks(1819));

                    b.Property<bool>("IsFree")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("SignalLevelId");

                    b.Property<int>("TargetId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("SignalLevelId");

                    b.HasIndex("TargetId");

                    b.ToTable("Signals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Attachment = "assets/images/test.jpeg",
                            Body = "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс ",
                            Coin = "BTC",
                            Date = new DateTime(2019, 1, 19, 16, 55, 2, 917, DateTimeKind.Local).AddTicks(1925),
                            IsFree = true,
                            SignalLevelId = 1,
                            TargetId = 1,
                            Title = "Бесплатный сигнал дня"
                        },
                        new
                        {
                            Id = 2,
                            Attachment = "assets/images/test.jpeg",
                            Body = "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс ",
                            Coin = "BTC",
                            Date = new DateTime(2019, 1, 19, 16, 55, 2, 917, DateTimeKind.Local).AddTicks(4468),
                            IsFree = false,
                            SignalLevelId = 3,
                            TargetId = 2,
                            Title = "Платный сигнал дня"
                        });
                });

            modelBuilder.Entity("AngelsTeam.Model.SignalLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("SignalLevels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hight"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Middle"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Low"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Info"
                        });
                });

            modelBuilder.Entity("AngelsTeam.Model.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SubscriptionTypeId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("AngelsTeam.Model.SubscriptionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(512);

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 64)))
                        .HasColumnType("varchar(32)");

                    b.Property<string>("Name")
                        .HasMaxLength(64);

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.ToTable("SubscriptionTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = @"Ознакомление с контентом
Бесплатные сигналы
Разбор некоторых монет",
                            Duration = "-1",
                            Name = "Бесплатная",
                            Price = 0
                        },
                        new
                        {
                            Id = 2,
                            Description = @"Приватные сигналы
Приватный чат участников
Продление подписки, если ежемесячный профит составил < 60%",
                            Duration = "1",
                            Name = "Ежемесячная",
                            Price = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = @"Безлимитные сигналы
Личные консультации
Разбор ваших монет",
                            Duration = "-1",
                            Name = "Безлимитная",
                            Price = 4
                        });
                });

            modelBuilder.Entity("AngelsTeam.Model.Target", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Buy");

                    b.Property<int>("PeriodId");

                    b.Property<string>("Profits");

                    b.Property<string>("Stop");

                    b.HasKey("Id");

                    b.HasIndex("PeriodId");

                    b.ToTable("Target");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Buy = "0.123",
                            PeriodId = 2,
                            Profits = "prof",
                            Stop = "0.132"
                        },
                        new
                        {
                            Id = 2,
                            Buy = "0.123",
                            PeriodId = 2,
                            Profits = "prof",
                            Stop = "0.132"
                        });
                });

            modelBuilder.Entity("AngelsTeam.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpirationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValue(new DateTime(2019, 1, 19, 16, 55, 2, 889, DateTimeKind.Local).AddTicks(1990));

                    b.Property<string>("Name")
                        .HasMaxLength(32);

                    b.Property<string>("Surname")
                        .HasMaxLength(32);

                    b.Property<string>("Telegram")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int>("UserTypeId");

                    b.HasKey("Id");

                    b.HasIndex("UserTypeId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExpirationDate = new DateTime(2019, 1, 19, 16, 55, 2, 919, DateTimeKind.Local).AddTicks(1135),
                            Name = "Admin",
                            Surname = "Admin",
                            Telegram = "yourAdmin",
                            UserTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            ExpirationDate = new DateTime(2019, 1, 19, 16, 55, 2, 919, DateTimeKind.Local).AddTicks(2071),
                            Name = "Ivan",
                            Surname = "Ivanov",
                            Telegram = "IvanovIvan",
                            UserTypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            ExpirationDate = new DateTime(2019, 1, 19, 16, 55, 2, 919, DateTimeKind.Local).AddTicks(2093),
                            Name = "Lexa",
                            Surname = "Lepexa",
                            Telegram = "Lepexa",
                            UserTypeId = 3
                        },
                        new
                        {
                            Id = 4,
                            ExpirationDate = new DateTime(2019, 1, 19, 16, 55, 2, 919, DateTimeKind.Local).AddTicks(2101),
                            Name = "Mark",
                            Surname = "zuckerberg",
                            Telegram = "MarkZuck",
                            UserTypeId = 4
                        });
                });

            modelBuilder.Entity("AngelsTeam.Model.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Free"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Unverified"
                        });
                });

            modelBuilder.Entity("AngelsTeam.Model.Credential", b =>
                {
                    b.HasOne("AngelsTeam.Model.User", "User")
                        .WithOne("Credential")
                        .HasForeignKey("AngelsTeam.Model.Credential", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AngelsTeam.Model.Signal", b =>
                {
                    b.HasOne("AngelsTeam.Model.SignalLevel", "SignalLevel")
                        .WithMany()
                        .HasForeignKey("SignalLevelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngelsTeam.Model.Target", "Target")
                        .WithMany()
                        .HasForeignKey("TargetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AngelsTeam.Model.Subscription", b =>
                {
                    b.HasOne("AngelsTeam.Model.SubscriptionType", "SubscribtionType")
                        .WithMany("Subscriptions")
                        .HasForeignKey("SubscriptionTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngelsTeam.Model.User", "User")
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AngelsTeam.Model.Target", b =>
                {
                    b.HasOne("AngelsTeam.Model.Period", "Period")
                        .WithMany()
                        .HasForeignKey("PeriodId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AngelsTeam.Model.User", b =>
                {
                    b.HasOne("AngelsTeam.Model.UserType", "UserType")
                        .WithMany()
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
