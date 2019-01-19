﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngelsTeam.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 64, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2019, 1, 17, 0, 39, 24, 702, DateTimeKind.Local).AddTicks(7629)),
                    Text = table.Column<string>(maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SignalLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignalLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 64, nullable: true),
                    Description = table.Column<int>(maxLength: 512, nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Target",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Buy = table.Column<string>(nullable: true),
                    Profits = table.Column<string>(nullable: true),
                    Stop = table.Column<string>(nullable: true),
                    PeriodId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Target", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Target_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Telegram = table.Column<string>(maxLength: 32, nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: true),
                    Surname = table.Column<string>(maxLength: 32, nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "date", nullable: false, defaultValue: new DateTime(2019, 1, 17, 0, 39, 24, 692, DateTimeKind.Local).AddTicks(4708)),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Signals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2019, 1, 17, 0, 39, 24, 706, DateTimeKind.Local).AddTicks(1958)),
                    Description = table.Column<string>(maxLength: 512, nullable: true),
                    IsFree = table.Column<bool>(nullable: false, defaultValue: false),
                    Coin = table.Column<string>(maxLength: 3, nullable: true),
                    Attachment = table.Column<string>(nullable: true),
                    SignalLevelId = table.Column<int>(nullable: false),
                    TargetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Signals_SignalLevels_SignalLevelId",
                        column: x => x.SignalLevelId,
                        principalTable: "SignalLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Signals_Target_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Target",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Credentials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(maxLength: 32, nullable: false),
                    Password = table.Column<string>(maxLength: 32, nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credentials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Credentials_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubscriptionTypeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_SubscriptionTypes_SubscriptionTypeId",
                        column: x => x.SubscriptionTypeId,
                        principalTable: "SubscriptionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Periods",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Short" },
                    { 2, "Middle" },
                    { 3, "Long" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "User" },
                    { 2, "Subscriber" },
                    { 3, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "SignalLevels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Hight" },
                    { 2, "Middle" },
                    { 3, "Low" },
                    { 4, "Info" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ExpirationDate", "Name", "RoleId", "Surname", "Telegram" },
                values: new object[] { 3, new DateTime(2019, 1, 17, 0, 39, 24, 720, DateTimeKind.Local).AddTicks(1360), "Lexa", 1, "Lepexa", "Lepexa" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ExpirationDate", "Name", "RoleId", "Surname", "Telegram" },
                values: new object[] { 2, new DateTime(2019, 1, 17, 0, 39, 24, 720, DateTimeKind.Local).AddTicks(1338), "Ivan", 2, "Ivanov", "IvanovIvan" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ExpirationDate", "Name", "RoleId", "Surname", "Telegram" },
                values: new object[] { 1, new DateTime(2019, 1, 17, 0, 39, 24, 720, DateTimeKind.Local).AddTicks(368), "Admin", 3, "Admin", "yourAdmin" });

            migrationBuilder.InsertData(
                table: "Credentials",
                columns: new[] { "Id", "Email", "Password", "UserId" },
                values: new object[] { 3, "user1212", "user1212", 3 });

            migrationBuilder.InsertData(
                table: "Credentials",
                columns: new[] { "Id", "Email", "Password", "UserId" },
                values: new object[] { 2, "ivanov1212", "ivanov1212", 2 });

            migrationBuilder.InsertData(
                table: "Credentials",
                columns: new[] { "Id", "Email", "Password", "UserId" },
                values: new object[] { 1, "admin1212", "admin1212", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Credentials_UserId",
                table: "Credentials",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Signals_SignalLevelId",
                table: "Signals",
                column: "SignalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Signals_TargetId",
                table: "Signals",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_SubscriptionTypeId",
                table: "Subscriptions",
                column: "SubscriptionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Target_PeriodId",
                table: "Target",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Credentials");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Signals");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "SignalLevels");

            migrationBuilder.DropTable(
                name: "Target");

            migrationBuilder.DropTable(
                name: "SubscriptionTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Periods");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}