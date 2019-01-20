using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngelsTeam.Migrations
{
    public partial class i4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Users",
                newName: "UserTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                newName: "IX_Users_UserTypeId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Signals",
                newName: "Body");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "News",
                newName: "Body");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 19, 16, 10, 9, 658, DateTimeKind.Local).AddTicks(2992),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2019, 1, 17, 2, 0, 30, 859, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Signals",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 19, 16, 10, 9, 676, DateTimeKind.Local).AddTicks(9889),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 17, 2, 0, 30, 874, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "News",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 19, 16, 10, 9, 671, DateTimeKind.Local).AddTicks(2895),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 17, 2, 0, 30, 870, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.AddColumn<string>(
                name: "Attachment",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Dislikes",
                table: "News",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "News",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Duration" },
                values: new object[] { @"Ознакомление с контентом
Бесплатные сигналы
Разбор некоторых монет", "-1" });

            migrationBuilder.UpdateData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Duration" },
                values: new object[] { @"Приватные сигналы
Приватный чат участников
Продление подписки, если ежемесячный профит составил < 60%", "1" });

            migrationBuilder.UpdateData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Duration" },
                values: new object[] { @"Безлимитные сигналы
Личные консультации
Разбор ваших монет", "-1" });

            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" },
                    { 3, "Free" },
                    { 4, "Unverified" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "UserTypeId" },
                values: new object[] { new DateTime(2019, 1, 19, 16, 10, 9, 691, DateTimeKind.Local).AddTicks(8737), 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 19, 16, 10, 9, 692, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpirationDate", "UserTypeId" },
                values: new object[] { new DateTime(2019, 1, 19, 16, 10, 9, 692, DateTimeKind.Local).AddTicks(216), 3 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ExpirationDate", "Name", "Surname", "Telegram", "UserTypeId" },
                values: new object[] { 4, new DateTime(2019, 1, 19, 16, 10, 9, 692, DateTimeKind.Local).AddTicks(225), "Mark", "zuckerberg", "MarkZuck", 4 });

            migrationBuilder.InsertData(
                table: "Credentials",
                columns: new[] { "Id", "Email", "Password", "UserId" },
                values: new object[] { 4, "mark1212", "mark1212", 4 });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserTypes_UserTypeId",
                table: "Users",
                column: "UserTypeId",
                principalTable: "UserTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTypes_UserTypeId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DeleteData(
                table: "Credentials",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Attachment",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Dislikes",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "News");

            migrationBuilder.RenameColumn(
                name: "UserTypeId",
                table: "Users",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserTypeId",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.RenameColumn(
                name: "Body",
                table: "Signals",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Body",
                table: "News",
                newName: "Text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 17, 2, 0, 30, 859, DateTimeKind.Local).AddTicks(3124),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2019, 1, 19, 16, 10, 9, 658, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Signals",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 17, 2, 0, 30, 874, DateTimeKind.Local).AddTicks(703),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 19, 16, 10, 9, 676, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "News",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 17, 2, 0, 30, 870, DateTimeKind.Local).AddTicks(5826),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 19, 16, 10, 9, 671, DateTimeKind.Local).AddTicks(2895));

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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "User" },
                    { 2, "Subscriber" },
                    { 3, "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Duration" },
                values: new object[] { @"Ознакомление с контентом
Бесплатные сигналы
Разбор некоторых монет", null });

            migrationBuilder.UpdateData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Duration" },
                values: new object[] { @"Приватные сигналы
Приватный чат участников
Продление подписки, если ежемесячный профит составил < 60%", null });

            migrationBuilder.UpdateData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Duration" },
                values: new object[] { @"Безлимитные сигналы
Личные консультации
Разбор ваших монет", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "RoleId" },
                values: new object[] { new DateTime(2019, 1, 17, 2, 0, 30, 887, DateTimeKind.Local).AddTicks(3286), 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 17, 2, 0, 30, 887, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpirationDate", "RoleId" },
                values: new object[] { new DateTime(2019, 1, 17, 2, 0, 30, 887, DateTimeKind.Local).AddTicks(4547), 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
