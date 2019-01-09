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
    [Migration("20190109143311_i5")]
    partial class i5
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
                });

            modelBuilder.Entity("AngelsTeam.Model.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2019, 1, 9, 16, 33, 10, 522, DateTimeKind.Local).AddTicks(6668));

                    b.Property<string>("Text")
                        .HasMaxLength(512);

                    b.Property<string>("Title")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("AngelsTeam.Model.Signal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Buy");

                    b.Property<string>("Coin")
                        .HasMaxLength(3);

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2019, 1, 9, 16, 33, 10, 527, DateTimeKind.Local).AddTicks(3783));

                    b.Property<string>("Duration");

                    b.Property<bool>("IsFree")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Risk")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("Low");

                    b.Property<string>("Sell");

                    b.Property<string>("TPs");

                    b.Property<string>("Text")
                        .HasMaxLength(512);

                    b.Property<string>("Title")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Signals");
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

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<int>("Description")
                        .HasMaxLength(512);

                    b.Property<string>("Title")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("SubscriptionTypes");
                });

            modelBuilder.Entity("AngelsTeam.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpirationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValue(new DateTime(2019, 1, 9, 16, 33, 10, 509, DateTimeKind.Local).AddTicks(1546));

                    b.Property<bool>("IsAdmin")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .HasMaxLength(32);

                    b.Property<string>("Surname")
                        .HasMaxLength(32);

                    b.Property<string>("Telegram")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AngelsTeam.Model.Credential", b =>
                {
                    b.HasOne("AngelsTeam.Model.User", "User")
                        .WithOne("Credential")
                        .HasForeignKey("AngelsTeam.Model.Credential", "UserId")
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
#pragma warning restore 612, 618
        }
    }
}