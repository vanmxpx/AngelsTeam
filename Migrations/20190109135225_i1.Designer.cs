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
    [Migration("20190109135225_i1")]
    partial class i1
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

                    b.Property<string>("Email");

                    b.Property<string>("Password");

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

                    b.Property<DateTime>("Date");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("AngelsTeam.Model.Signal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Buy");

                    b.Property<string>("Coin");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Duration");

                    b.Property<bool>("IsFree");

                    b.Property<string>("Risk");

                    b.Property<string>("Sell");

                    b.Property<string>("TPs");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Signals");
                });

            modelBuilder.Entity("AngelsTeam.Model.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SubscriptionTypeId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionTypeId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("AngelsTeam.Model.SubscriptionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cost");

                    b.Property<int>("Description");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("SubscriptionTypes");
                });

            modelBuilder.Entity("AngelsTeam.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.Property<string>("Telegram");

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
                        .WithOne("Subscription")
                        .HasForeignKey("AngelsTeam.Model.Subscription", "SubscriptionTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AngelsTeam.Model.User")
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
