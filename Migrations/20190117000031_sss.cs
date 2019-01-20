using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngelsTeam.Migrations
{
    public partial class sss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "SubscriptionTypes");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "SubscriptionTypes",
                newName: "Name");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 17, 2, 0, 30, 859, DateTimeKind.Local).AddTicks(3124),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2019, 1, 17, 0, 39, 24, 692, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SubscriptionTypes",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 512);

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "SubscriptionTypes",
                type: "varchar(32)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "SubscriptionTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Signals",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 17, 2, 0, 30, 874, DateTimeKind.Local).AddTicks(703),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 17, 0, 39, 24, 706, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "News",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 17, 2, 0, 30, 870, DateTimeKind.Local).AddTicks(5826),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 17, 0, 39, 24, 702, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.InsertData(
                table: "SubscriptionTypes",
                columns: new[] { "Id", "Description", "Duration", "Name", "Price" },
                values: new object[,]
                {
                    { 1, @"Ознакомление с контентом
                Бесплатные сигналы
                Разбор некоторых монет", "-1", "Бесплатная", 0 },
                    { 2, @"Приватные сигналы
                Приватный чат участников
                Продление подписки, если ежемесячный профит составил < 60%", "1", "Ежемесячная", 2 },
                    { 3, @"Безлимитные сигналы
                Личные консультации
                Разбор ваших монет", "-1", "Безлимитная", 4 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 17, 2, 0, 30, 887, DateTimeKind.Local).AddTicks(3286));

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
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 17, 2, 0, 30, 887, DateTimeKind.Local).AddTicks(4547));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "SubscriptionTypes");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "SubscriptionTypes");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SubscriptionTypes",
                newName: "Title");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 17, 0, 39, 24, 692, DateTimeKind.Local).AddTicks(4708),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2019, 1, 17, 2, 0, 30, 859, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "SubscriptionTypes",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "SubscriptionTypes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Signals",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 17, 0, 39, 24, 706, DateTimeKind.Local).AddTicks(1958),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 17, 2, 0, 30, 874, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "News",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 17, 0, 39, 24, 702, DateTimeKind.Local).AddTicks(7629),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 17, 2, 0, 30, 870, DateTimeKind.Local).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 17, 0, 39, 24, 720, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 17, 0, 39, 24, 720, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 17, 0, 39, 24, 720, DateTimeKind.Local).AddTicks(1360));
        }
    }
}
