using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeslaMall.Server.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RentalLocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservationCosts = table.Column<float>(type: "real", nullable: false),
                    IsReservationConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    IsReservationPaid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentCarStatus = table.Column<int>(type: "int", nullable: false),
                    RelatedLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RelatedReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_RentalLocations_RelatedLocationId",
                        column: x => x.RelatedLocationId,
                        principalTable: "RentalLocations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cars_Reservations_RelatedReservationId",
                        column: x => x.RelatedReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReservationPeriods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelatedReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservationStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservationEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationPeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationPeriods_Reservations_RelatedReservationId",
                        column: x => x.RelatedReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RentalLocations",
                columns: new[] { "Id", "LocationName" },
                values: new object[,]
                {
                    { new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), "Palma City Center" },
                    { new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), "Alcudia" },
                    { new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), "Palma Airport" },
                    { new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), "Manacor" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CurrentCarStatus", "ModelName", "RelatedLocationId", "RelatedReservationId" },
                values: new object[,]
                {
                    { new Guid("100361e1-e764-471b-9d25-98d0dd8b90d4"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("30a6582e-ee83-4869-9b9a-2abbd3c20a60"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("3cc7589c-d881-4f9d-b576-e77436b557d4"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null },
                    { new Guid("4b8d652f-0aed-4000-9e8f-70b7c3aa2748"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("544bd22d-b9f4-4424-87f1-5126c672dccd"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("5fd75550-1f45-4bff-bc1b-b8ed801ee29f"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("782dd2b8-cd63-4c24-8af7-9f624dabf6d1"), 1, "Model X", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("8e9dc3a8-d243-4b04-9d05-a42db56e9bbd"), 1, "Model 3", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("bec0ee30-9633-47f1-8b4b-fb912bb7897c"), 1, "Model X", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("c0f4bdab-2a2b-492c-ade4-55a3dc09fa0f"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null },
                    { new Guid("db8bca1a-1c7e-40da-85f7-3dacda4f436a"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("f3136b5e-d3b9-4e42-9da6-3fe1cefb7fc2"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_RelatedLocationId",
                table: "Cars",
                column: "RelatedLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_RelatedReservationId",
                table: "Cars",
                column: "RelatedReservationId",
                unique: true,
                filter: "[RelatedReservationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationPeriods_RelatedReservationId",
                table: "ReservationPeriods",
                column: "RelatedReservationId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "ReservationPeriods");

            migrationBuilder.DropTable(
                name: "RentalLocations");

            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
