using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngelsTeam.Migrations
{
    public partial class i123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 19, 16, 55, 2, 889, DateTimeKind.Local).AddTicks(1990),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2019, 1, 19, 16, 41, 26, 756, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Signals",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 19, 16, 55, 2, 905, DateTimeKind.Local).AddTicks(1819),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 19, 16, 41, 26, 781, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "News",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 19, 16, 55, 2, 900, DateTimeKind.Local).AddTicks(4375),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 19, 16, 41, 26, 773, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 1, 19, 16, 55, 2, 916, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 1, 19, 16, 55, 2, 916, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Signals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 1, 19, 16, 55, 2, 917, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Signals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "IsFree" },
                values: new object[] { new DateTime(2019, 1, 19, 16, 55, 2, 917, DateTimeKind.Local).AddTicks(4468), false });

            migrationBuilder.UpdateData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Duration",
                value: "-1");

            migrationBuilder.UpdateData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Duration",
                value: "1");

            migrationBuilder.UpdateData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Duration",
                value: "-1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 19, 16, 55, 2, 919, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 19, 16, 55, 2, 919, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 19, 16, 55, 2, 919, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 19, 16, 55, 2, 919, DateTimeKind.Local).AddTicks(2101));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 19, 16, 41, 26, 756, DateTimeKind.Local).AddTicks(753),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2019, 1, 19, 16, 55, 2, 889, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Signals",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 19, 16, 41, 26, 781, DateTimeKind.Local).AddTicks(9046),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 19, 16, 55, 2, 905, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "News",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 19, 16, 41, 26, 773, DateTimeKind.Local).AddTicks(6668),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 19, 16, 55, 2, 900, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 1, 19, 16, 41, 26, 800, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 1, 19, 16, 41, 26, 800, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Signals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 1, 19, 16, 41, 26, 802, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Signals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "IsFree" },
                values: new object[] { new DateTime(2019, 1, 19, 16, 41, 26, 802, DateTimeKind.Local).AddTicks(8341), true });

            migrationBuilder.UpdateData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Duration",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Duration",
                value: null);

            migrationBuilder.UpdateData(
                table: "SubscriptionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Duration",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 19, 16, 41, 26, 806, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 19, 16, 41, 26, 806, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 19, 16, 41, 26, 806, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 19, 16, 41, 26, 806, DateTimeKind.Local).AddTicks(7702));
        }
    }
}
