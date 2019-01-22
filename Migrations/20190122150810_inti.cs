using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AngelsTeam.Migrations
{
    public partial class inti : Migration
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
                    Likes = table.Column<int>(nullable: false, defaultValue: 0),
                    Dislikes = table.Column<int>(nullable: false, defaultValue: 0),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2019, 1, 22, 17, 8, 9, 550, DateTimeKind.Local).AddTicks(7055)),
                    Body = table.Column<string>(maxLength: 1024, nullable: true),
                    Attachment = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(maxLength: 64, nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Exchange = table.Column<string>(maxLength: 15, nullable: true),
                    Duration = table.Column<string>(type: "varchar(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionTypes", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Targets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Buy = table.Column<string>(nullable: true),
                    Stop = table.Column<string>(nullable: true),
                    PeriodId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Targets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Targets_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Descriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true),
                    SubscriptionTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Descriptions_SubscriptionTypes_SubscriptionTypeId",
                        column: x => x.SubscriptionTypeId,
                        principalTable: "SubscriptionTypes",
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
                    Photo = table.Column<string>(nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "date", nullable: false, defaultValue: new DateTime(2019, 1, 22, 17, 8, 9, 538, DateTimeKind.Local).AddTicks(1000)),
                    UserTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserTypes_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true),
                    TargetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profits_Targets_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Targets",
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
                    Date = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2019, 1, 22, 17, 8, 9, 555, DateTimeKind.Local).AddTicks(4435)),
                    Body = table.Column<string>(maxLength: 512, nullable: true),
                    Free = table.Column<bool>(nullable: false, defaultValue: false),
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
                        name: "FK_Signals_Targets_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Targets",
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
                    SubscribtionTypeId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Profits_SubscribtionTypeId",
                        column: x => x.SubscribtionTypeId,
                        principalTable: "Profits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                table: "News",
                columns: new[] { "Id", "Attachment", "Body", "Date", "Dislikes", "Likes", "Title" },
                values: new object[,]
                {
                    { 1, "assets/images/test.jpeg", "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс. У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам:", new DateTime(2019, 1, 22, 17, 8, 9, 572, DateTimeKind.Local).AddTicks(9988), 10, 20, "Новость дня" },
                    { 2, "assets/images/test.jpeg", "Дорогие друзья, сегодня ...", new DateTime(2019, 1, 22, 17, 8, 9, 573, DateTimeKind.Local).AddTicks(723), 3, 15, "Новость дня 2" },
                    { 3, "assets/images/test.jpeg", "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс. У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам:", new DateTime(2019, 1, 22, 17, 8, 9, 573, DateTimeKind.Local).AddTicks(744), 10, 20, "Новость дня" },
                    { 4, "assets/images/test.jpeg", "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс. У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам: Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс . У нас хорошие новости. Освободилось ровно три места. По всем вопросам:", new DateTime(2019, 1, 22, 17, 8, 9, 573, DateTimeKind.Local).AddTicks(753), 10, 20, "Новость дня" }
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
                table: "SignalLevels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Info" },
                    { 3, "Low" },
                    { 2, "Middle" },
                    { 1, "Hight" }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionTypes",
                columns: new[] { "Id", "Duration", "Exchange", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "-1", "BTC", "Бесплатная", 0 },
                    { 2, "1", "BTC", "Ежемесячная", 2 },
                    { 3, "-1", "BTC", "Безлимитная", 4 }
                });

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

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "Id", "SubscriptionTypeId", "Value" },
                values: new object[,]
                {
                    { 7, 1, "Ознакомление с контентом" },
                    { 8, 1, "Бесплатные сигналы" },
                    { 9, 1, "Разбор некоторых монет" },
                    { 4, 2, "Приватные сигналы" },
                    { 5, 2, "Приватный чат участников" },
                    { 6, 2, "Продление подписки, если ежемесячный профит составил < 60%" },
                    { 1, 3, "Безлимитные сигналы" },
                    { 2, 3, "Личные консультации" },
                    { 3, 3, "Разбор ваших монет" }
                });

            migrationBuilder.InsertData(
                table: "Targets",
                columns: new[] { "Id", "Buy", "PeriodId", "Stop" },
                values: new object[,]
                {
                    { 1, "0.123", 2, "0.132" },
                    { 2, "0.123", 2, "0.132" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ExpirationDate", "Name", "Photo", "Surname", "Telegram", "UserTypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 2, 3, 17, 8, 9, 575, DateTimeKind.Local).AddTicks(8842), "Admin", "assets/images/candles.jpeg", "Admin", "yourAdmin", 1 },
                    { 2, new DateTime(2019, 2, 11, 17, 8, 9, 575, DateTimeKind.Local).AddTicks(9970), "Ivan", "assets/images/candles.jpeg", "Ivanov", "IvanovIvan", 2 },
                    { 3, new DateTime(2019, 1, 12, 17, 8, 9, 575, DateTimeKind.Local).AddTicks(9996), "Lexa", "assets/images/candles.jpeg", "Lepexa", "Lepexa", 3 },
                    { 4, new DateTime(2019, 1, 22, 17, 8, 9, 576, DateTimeKind.Local).AddTicks(5), "Mark", "assets/images/candles.jpeg", "zuckerberg", "MarkZuck", 4 }
                });

            migrationBuilder.InsertData(
                table: "Credentials",
                columns: new[] { "Id", "Email", "Password", "UserId" },
                values: new object[,]
                {
                    { 1, "admin1212", "admin1212", 1 },
                    { 2, "ivanov1212", "ivanov1212", 2 },
                    { 3, "user1212", "user1212", 3 },
                    { 4, "mark1212", "mark1212", 4 }
                });

            migrationBuilder.InsertData(
                table: "Profits",
                columns: new[] { "Id", "TargetId", "Value" },
                values: new object[,]
                {
                    { 1, 1, "0.012" },
                    { 2, 1, "0.012" },
                    { 3, 1, "0.012" },
                    { 4, 2, "0.012" },
                    { 5, 2, "0.012" },
                    { 6, 2, "0.012" }
                });

            migrationBuilder.InsertData(
                table: "Signals",
                columns: new[] { "Id", "Attachment", "Body", "Coin", "Date", "Free", "SignalLevelId", "TargetId", "Title" },
                values: new object[,]
                {
                    { 1, "assets/images/test.jpeg", "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс ", "BTC", new DateTime(2019, 1, 22, 17, 8, 9, 573, DateTimeKind.Local).AddTicks(4352), true, 1, 1, "Бесплатный сигнал дня" },
                    { 2, "assets/images/test.jpeg", "Дорогие друзья, завтра в 20:00(Мскв) начинается наш обучающий курс ", "BTC", new DateTime(2019, 1, 22, 17, 8, 9, 573, DateTimeKind.Local).AddTicks(7028), false, 3, 2, "Платный сигнал дня" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Credentials_UserId",
                table: "Credentials",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_SubscriptionTypeId",
                table: "Descriptions",
                column: "SubscriptionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Profits_TargetId",
                table: "Profits",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_Signals_SignalLevelId",
                table: "Signals",
                column: "SignalLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Signals_TargetId",
                table: "Signals",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_SubscribtionTypeId",
                table: "Subscriptions",
                column: "SubscribtionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_SubscriptionTypeId",
                table: "Subscriptions",
                column: "SubscriptionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Targets_PeriodId",
                table: "Targets",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeId",
                table: "Users",
                column: "UserTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Credentials");

            migrationBuilder.DropTable(
                name: "Descriptions");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Signals");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "SignalLevels");

            migrationBuilder.DropTable(
                name: "Profits");

            migrationBuilder.DropTable(
                name: "SubscriptionTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Targets");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "Periods");
        }
    }
}
