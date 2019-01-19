using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngelsTeam.Migrations
{
    public partial class i5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 19, 16, 41, 26, 756, DateTimeKind.Local).AddTicks(753),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2019, 1, 19, 16, 10, 9, 658, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Signals",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 19, 16, 41, 26, 781, DateTimeKind.Local).AddTicks(9046),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 19, 16, 10, 9, 676, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "News",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 19, 16, 41, 26, 773, DateTimeKind.Local).AddTicks(6668),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 19, 16, 10, 9, 671, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "News",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Attachment", "Body", "Date", "Dislikes", "Likes", "Title" },
                values: new object[,]
                {
                    { 1, "assets/images/test.jpeg", "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс. У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам:", new DateTime(2019, 1, 19, 16, 41, 26, 800, DateTimeKind.Local).AddTicks(8405), 10, 20, "Новость дня" },
                    { 2, "assets/images/test.jpeg", "Дорогие друзья, сегодня ...", new DateTime(2019, 1, 19, 16, 41, 26, 800, DateTimeKind.Local).AddTicks(9486), 3, 15, "Новость дня 2" }
                });

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

            migrationBuilder.InsertData(
                table: "Target",
                columns: new[] { "Id", "Buy", "PeriodId", "Profits", "Stop" },
                values: new object[,]
                {
                    { 1, "0.123", 2, "prof", "0.132" },
                    { 2, "0.123", 2, "prof", "0.132" }
                });

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

            migrationBuilder.InsertData(
                table: "Signals",
                columns: new[] { "Id", "Attachment", "Body", "Coin", "Date", "IsFree", "SignalLevelId", "TargetId", "Title" },
                values: new object[] { 1, "assets/images/test.jpeg", "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс ", "BTC", new DateTime(2019, 1, 19, 16, 41, 26, 802, DateTimeKind.Local).AddTicks(4169), true, 1, 1, "Бесплатный сигнал дня" });

            migrationBuilder.InsertData(
                table: "Signals",
                columns: new[] { "Id", "Attachment", "Body", "Coin", "Date", "IsFree", "SignalLevelId", "TargetId", "Title" },
                values: new object[] { 2, "assets/images/test.jpeg", "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс ", "BTC", new DateTime(2019, 1, 19, 16, 41, 26, 802, DateTimeKind.Local).AddTicks(8341), true, 3, 2, "Платный сигнал дня" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Signals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Signals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Target",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Target",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Users",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 19, 16, 10, 9, 658, DateTimeKind.Local).AddTicks(2992),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2019, 1, 19, 16, 41, 26, 756, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Signals",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 19, 16, 10, 9, 676, DateTimeKind.Local).AddTicks(9889),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 19, 16, 41, 26, 781, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "News",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2019, 1, 19, 16, 10, 9, 671, DateTimeKind.Local).AddTicks(2895),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2019, 1, 19, 16, 41, 26, 773, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "News",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1024,
                oldNullable: true);

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
                value: new DateTime(2019, 1, 19, 16, 10, 9, 691, DateTimeKind.Local).AddTicks(8737));

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
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 19, 16, 10, 9, 692, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpirationDate",
                value: new DateTime(2019, 1, 19, 16, 10, 9, 692, DateTimeKind.Local).AddTicks(225));
        }
    }
}
