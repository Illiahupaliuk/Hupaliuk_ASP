using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rozklad.Core.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusRoutes",
                columns: table => new
                {
                    BusrouteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceOfDeparture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntermediateStops = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceOfArrival = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusRoutes", x => x.BusrouteId);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    cardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomerCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateEnd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVC_kod = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.cardId);
                });

            migrationBuilder.CreateTable(
                name: "Carriers",
                columns: table => new
                {
                    carrierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transport = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carriers", x => x.carrierId);
                });

            migrationBuilder.CreateTable(
                name: "Comentars",
                columns: table => new
                {
                    comentarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sheduleId = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    comentar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentars", x => x.comentarId);
                });

            migrationBuilder.CreateTable(
                name: "MapsRoutes",
                columns: table => new
                {
                    mapsRouteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoordinateOfDeparture = table.Column<float>(type: "real", nullable: false),
                    CoordinateOfArrival = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapsRoutes", x => x.mapsRouteId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    statusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.statusId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuyTickets",
                columns: table => new
                {
                    buyTicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numTicket = table.Column<int>(type: "int", nullable: false),
                    NomerTel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllPrice = table.Column<int>(type: "int", nullable: false),
                    cardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyTickets", x => x.buyTicketId);
                    table.ForeignKey(
                        name: "FK_BuyTickets_Cards_cardId",
                        column: x => x.cardId,
                        principalTable: "Cards",
                        principalColumn: "cardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusShedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusrouteId = table.Column<int>(type: "int", nullable: false),
                    Seats = table.Column<int>(type: "int", nullable: true),
                    carrierId = table.Column<int>(type: "int", nullable: false),
                    statusId = table.Column<int>(type: "int", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cost = table.Column<float>(type: "real", nullable: true),
                    buyTicketId = table.Column<int>(type: "int", nullable: false),
                    comentarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusShedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusShedules_BusRoutes_BusrouteId",
                        column: x => x.BusrouteId,
                        principalTable: "BusRoutes",
                        principalColumn: "BusrouteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusShedules_BuyTickets_buyTicketId",
                        column: x => x.buyTicketId,
                        principalTable: "BuyTickets",
                        principalColumn: "buyTicketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusShedules_Carriers_carrierId",
                        column: x => x.carrierId,
                        principalTable: "Carriers",
                        principalColumn: "carrierId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusShedules_Comentars_comentarId",
                        column: x => x.comentarId,
                        principalTable: "Comentars",
                        principalColumn: "comentarId");
                    table.ForeignKey(
                        name: "FK_BusShedules_Statuses_statusId",
                        column: x => x.statusId,
                        principalTable: "Statuses",
                        principalColumn: "statusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6719ba83-5710-411f-b7d6-e37bd1293bab", "b213c196-1c55-45f9-8fe1-fa16c52f81ea", "Admin", "ADMIN" },
                    { "f5d94e54-417b-45fe-9ba8-e6c2de4a1a8d", "dd65d6a1-e52c-4567-aef8-bda8c4f5ea91", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d9bf27b-46b0-45b6-9ce1-fb380d4b539c", 0, "591f327c-9d61-4ded-a8e0-f2623336d62f", "admin@rozklad.com", true, null, null, false, null, "ADMIN@ROZKLAD.COM", "ADMIN@ROZKLAD.COM", "AQAAAAEAACcQAAAAEPbwkxbLs9HjMmJOSMs0W/7OgTGh7qZ06PawKpqnZvmYP66YTrvMyY1+0p+IO9UOiw==", null, false, "e24c98e2-43f7-49ee-b8c8-26616c13f90f", false, "admin@rozklad.com" },
                    { "9005b1c4-365a-4f80-bb6f-484b761ed3ab", 0, "10c488a9-139f-43d9-946b-6d2b5d156e33", "user@rozklad.com", true, null, null, false, null, "USER@ROZKLAD.COM", "USER@ROZKLAD.COM", "AQAAAAEAACcQAAAAEHD7YaRdbQoyCt7STWztMdtxByHEUrSAOBal5SDFqcsgrpoNiazICzRpndHr5GjFPw==", null, false, "dc663cc5-c95f-4ce4-a68c-cc4fbecedf4f", false, "user@rozklad.com" }
                });

            migrationBuilder.InsertData(
                table: "BusRoutes",
                columns: new[] { "BusrouteId", "IntermediateStops", "PlaceOfArrival", "PlaceOfDeparture" },
                values: new object[] { 1, "gremzc", "Рівне", "Острог" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "cardId", "CVC_kod", "DateEnd", "NomerCard" },
                values: new object[] { 1, "234", "01/26", "3t46363477" });

            migrationBuilder.InsertData(
                table: "Carriers",
                columns: new[] { "carrierId", "Name", "Transport" },
                values: new object[] { 1, "Ilias", "autobus" });

            migrationBuilder.InsertData(
                table: "MapsRoutes",
                columns: new[] { "mapsRouteId", "CoordinateOfArrival", "CoordinateOfDeparture" },
                values: new object[] { 1, 434f, 123f });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "statusId", "StatusValue" },
                values: new object[] { 1, "В дорозі" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6719ba83-5710-411f-b7d6-e37bd1293bab", "6d9bf27b-46b0-45b6-9ce1-fb380d4b539c" },
                    { "f5d94e54-417b-45fe-9ba8-e6c2de4a1a8d", "6d9bf27b-46b0-45b6-9ce1-fb380d4b539c" },
                    { "f5d94e54-417b-45fe-9ba8-e6c2de4a1a8d", "9005b1c4-365a-4f80-bb6f-484b761ed3ab" }
                });

            migrationBuilder.InsertData(
                table: "BuyTickets",
                columns: new[] { "buyTicketId", "AllPrice", "BuyerName", "NomerTel", "cardId", "numTicket" },
                values: new object[] { 1, 125, "ilas", "78685895", 1, 3 });

            migrationBuilder.InsertData(
                table: "BusShedules",
                columns: new[] { "Id", "ArrivalTime", "BusrouteId", "Cost", "DepartureTime", "Seats", "buyTicketId", "carrierId", "comentarId", "statusId" },
                values: new object[] { 1, new DateTime(2022, 7, 20, 20, 30, 25, 0, DateTimeKind.Unspecified), 1, 75f, new DateTime(2022, 7, 20, 18, 30, 25, 0, DateTimeKind.Unspecified), 30, 1, 1, null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BusShedules_BusrouteId",
                table: "BusShedules",
                column: "BusrouteId");

            migrationBuilder.CreateIndex(
                name: "IX_BusShedules_buyTicketId",
                table: "BusShedules",
                column: "buyTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_BusShedules_carrierId",
                table: "BusShedules",
                column: "carrierId");

            migrationBuilder.CreateIndex(
                name: "IX_BusShedules_comentarId",
                table: "BusShedules",
                column: "comentarId");

            migrationBuilder.CreateIndex(
                name: "IX_BusShedules_statusId",
                table: "BusShedules",
                column: "statusId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyTickets_cardId",
                table: "BuyTickets",
                column: "cardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BusShedules");

            migrationBuilder.DropTable(
                name: "MapsRoutes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BusRoutes");

            migrationBuilder.DropTable(
                name: "BuyTickets");

            migrationBuilder.DropTable(
                name: "Carriers");

            migrationBuilder.DropTable(
                name: "Comentars");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
