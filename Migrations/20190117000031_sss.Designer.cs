﻿// <auto-generated />
using System;
using AngelsTeam.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AngelsTeam.Migrations
{
    [DbContext(typeof(AngelsDbContext))]
    [Migration("20190117000031_sss")]
    partial class sss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        });
                });

            modelBuilder.Entity("AngelsTeam.Model.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2019, 1, 17, 2, 0, 30, 870, DateTimeKind.Local).AddTicks(5826));

                    b.Property<string>("Text")
                        .HasMaxLength(512);

                    b.Property<string>("Title")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("News");
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

            modelBuilder.Entity("AngelsTeam.Model.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "User"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Subscriber"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("AngelsTeam.Model.Signal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attachment");

                    b.Property<string>("Coin")
                        .HasMaxLength(3);

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2019, 1, 17, 2, 0, 30, 874, DateTimeKind.Local).AddTicks(703));

                    b.Property<string>("Description")
                        .HasMaxLength(512);

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
                });

            modelBuilder.Entity("AngelsTeam.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpirationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValue(new DateTime(2019, 1, 17, 2, 0, 30, 859, DateTimeKind.Local).AddTicks(3124));

                    b.Property<string>("Name")
                        .HasMaxLength(32);

                    b.Property<int>("RoleId");

                    b.Property<string>("Surname")
                        .HasMaxLength(32);

                    b.Property<string>("Telegram")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExpirationDate = new DateTime(2019, 1, 17, 2, 0, 30, 887, DateTimeKind.Local).AddTicks(3286),
                            Name = "Admin",
                            RoleId = 3,
                            Surname = "Admin",
                            Telegram = "yourAdmin"
                        },
                        new
                        {
                            Id = 2,
                            ExpirationDate = new DateTime(2019, 1, 17, 2, 0, 30, 887, DateTimeKind.Local).AddTicks(4530),
                            Name = "Ivan",
                            RoleId = 2,
                            Surname = "Ivanov",
                            Telegram = "IvanovIvan"
                        },
                        new
                        {
                            Id = 3,
                            ExpirationDate = new DateTime(2019, 1, 17, 2, 0, 30, 887, DateTimeKind.Local).AddTicks(4547),
                            Name = "Lexa",
                            RoleId = 1,
                            Surname = "Lepexa",
                            Telegram = "Lepexa"
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
                    b.HasOne("AngelsTeam.Model.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}