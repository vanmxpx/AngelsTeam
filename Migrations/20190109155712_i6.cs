using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngelsTeam.Migrations
{
    public partial class i6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 9, 17, 57, 10, 262, DateTimeKind.Local).AddTicks(4716),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2019, 1, 9, 16, 33, 10, 509, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Signals",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 9, 17, 57, 10, 275, DateTimeKind.Local).AddTicks(19),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 9, 16, 33, 10, 527, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "News",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 9, 17, 57, 10, 271, DateTimeKind.Local).AddTicks(9738),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 9, 16, 33, 10, 522, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ExpirationDate", "IsAdmin", "Name", "Surname", "Telegram" },
                values: new object[] { 1, new DateTime(2019, 1, 9, 17, 57, 10, 281, DateTimeKind.Local).AddTicks(3686), true, "Tom", "Koval", "Noderoid64" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ExpirationDate", "Name", "Surname", "Telegram" },
                values: new object[] { 2, new DateTime(2019, 1, 9, 17, 57, 10, 281, DateTimeKind.Local).AddTicks(4203), "Ivan", "Ivanov", "IvanovIvan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 9, 16, 33, 10, 509, DateTimeKind.Local).AddTicks(1546),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2019, 1, 9, 17, 57, 10, 262, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Signals",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 9, 16, 33, 10, 527, DateTimeKind.Local).AddTicks(3783),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 9, 17, 57, 10, 275, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "News",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 9, 16, 33, 10, 522, DateTimeKind.Local).AddTicks(6668),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 9, 17, 57, 10, 271, DateTimeKind.Local).AddTicks(9738));
        }
    }
}
