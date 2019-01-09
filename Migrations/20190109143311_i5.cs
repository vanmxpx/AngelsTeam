using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngelsTeam.Migrations
{
    public partial class i5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Users_UserId",
                table: "Subscriptions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 9, 16, 33, 10, 509, DateTimeKind.Local).AddTicks(1546),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2019, 1, 9, 16, 18, 31, 390, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "SubscriptionTypes",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Cost",
                table: "SubscriptionTypes",
                type: "float",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Subscriptions",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Signals",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Signals",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Risk",
                table: "Signals",
                nullable: true,
                defaultValue: "Low",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsFree",
                table: "Signals",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Signals",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Signals",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 9, 16, 33, 10, 527, DateTimeKind.Local).AddTicks(3783),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Coin",
                table: "Signals",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "News",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 9, 16, 33, 10, 522, DateTimeKind.Local).AddTicks(6668),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 9, 16, 18, 31, 401, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Users_UserId",
                table: "Subscriptions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Users_UserId",
                table: "Subscriptions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 9, 16, 18, 31, 390, DateTimeKind.Local).AddTicks(6591),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2019, 1, 9, 16, 33, 10, 509, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "SubscriptionTypes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Cost",
                table: "SubscriptionTypes",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Subscriptions",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Signals",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Signals",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Risk",
                table: "Signals",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldDefaultValue: "Low");

            migrationBuilder.AlterColumn<bool>(
                name: "IsFree",
                table: "Signals",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "Signals",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Signals",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 9, 16, 33, 10, 527, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.AlterColumn<string>(
                name: "Coin",
                table: "Signals",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "News",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 9, 16, 18, 31, 401, DateTimeKind.Local).AddTicks(3162),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 9, 16, 33, 10, 522, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Users_UserId",
                table: "Subscriptions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
