using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeslaMall.Server.Migrations
{
    /// <inheritdoc />
    public partial class userReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("3c571b7f-7c64-4e94-9c7a-b6fb69fbd50a"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("3d2cc86f-f4ae-4190-8a77-106bbf280c49"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("6bce1307-0384-4af4-9aa9-95bf249a0ab3"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("7298e4f0-e779-4a9b-bc51-80326cc8db93"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("850b38f7-9d37-4b32-965b-099592f27120"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("989a87a4-92ae-4a72-8c3d-513099a9212b"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("a66dc547-9329-456b-95fc-ec36587d6ef0"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("ad67c375-529e-48de-a23f-cf109bff6c06"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("be51ec27-fbd1-4af7-b6d0-23e59fb908f0"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("de53c366-a3f1-4fdb-9e97-44e651ebbfd1"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("ea31569d-094f-4075-b0ad-d48dfb15eb85"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("fbd829e1-7528-4d8a-b493-b494143987bf"));

            migrationBuilder.CreateTable(
                name: "UserReservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReservationId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelatedReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservationCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserReservations_Reservations_RelatedReservationId",
                        column: x => x.RelatedReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CurrentCarStatus", "ModelName", "RelatedLocationId", "RelatedReservationId" },
                values: new object[,]
                {
                    { new Guid("0e87bd38-6246-44b3-a000-3ea77342d3a9"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null },
                    { new Guid("112d9211-86c9-4ec2-8100-c4df7cd7c82f"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("2c911726-3731-41fc-a85a-27995b1d95fa"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("50c71cac-0cc6-4336-b3cb-d184f20f35b4"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("5935ae08-d69c-44eb-a006-f34b26990899"), 1, "Model X", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("662ed6bf-bc92-4462-bcd2-c30dbe84e209"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("828c981e-af80-4524-8560-5f8034007d94"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("8949fd89-45e4-4c6d-ba38-830cd71a7652"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("973863ef-c97c-4c45-909d-47d14fa24026"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null },
                    { new Guid("a23d2c0a-33cb-4580-889a-3f401d8a74e1"), 1, "Model 3", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("a616ab3e-2a3b-466a-bc9f-180fe7b65e5d"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null },
                    { new Guid("bed8ea64-0bbe-4145-8ec8-4d20b199241b"), 1, "Model X", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserReservations_RelatedReservationId",
                table: "UserReservations",
                column: "RelatedReservationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserReservations");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("0e87bd38-6246-44b3-a000-3ea77342d3a9"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("112d9211-86c9-4ec2-8100-c4df7cd7c82f"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2c911726-3731-41fc-a85a-27995b1d95fa"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("50c71cac-0cc6-4336-b3cb-d184f20f35b4"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("5935ae08-d69c-44eb-a006-f34b26990899"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("662ed6bf-bc92-4462-bcd2-c30dbe84e209"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("828c981e-af80-4524-8560-5f8034007d94"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("8949fd89-45e4-4c6d-ba38-830cd71a7652"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("973863ef-c97c-4c45-909d-47d14fa24026"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("a23d2c0a-33cb-4580-889a-3f401d8a74e1"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("a616ab3e-2a3b-466a-bc9f-180fe7b65e5d"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("bed8ea64-0bbe-4145-8ec8-4d20b199241b"));

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CurrentCarStatus", "ModelName", "RelatedLocationId", "RelatedReservationId" },
                values: new object[,]
                {
                    { new Guid("3c571b7f-7c64-4e94-9c7a-b6fb69fbd50a"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("3d2cc86f-f4ae-4190-8a77-106bbf280c49"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("6bce1307-0384-4af4-9aa9-95bf249a0ab3"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("7298e4f0-e779-4a9b-bc51-80326cc8db93"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("850b38f7-9d37-4b32-965b-099592f27120"), 1, "Model X", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("989a87a4-92ae-4a72-8c3d-513099a9212b"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("a66dc547-9329-456b-95fc-ec36587d6ef0"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null },
                    { new Guid("ad67c375-529e-48de-a23f-cf109bff6c06"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null },
                    { new Guid("be51ec27-fbd1-4af7-b6d0-23e59fb908f0"), 1, "Model X", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("de53c366-a3f1-4fdb-9e97-44e651ebbfd1"), 1, "Model 3", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("ea31569d-094f-4075-b0ad-d48dfb15eb85"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("fbd829e1-7528-4d8a-b493-b494143987bf"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null }
                });
        }
    }
}
