using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeslaMall.Server.Migrations
{
    /// <inheritdoc />
    public partial class CarDbConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2f5c7e0b-001f-42d7-8cf4-f08fa6869965"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("362a1ab0-7ead-4d2d-95ba-60997aea2802"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("3fb0c06e-8fd1-434b-af17-6a957d6f2503"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("77ff4072-e0e0-4160-9306-31b00740875f"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("7f7045b8-4e26-45b5-b8eb-9f9fe8c8745b"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("834b1b1b-a658-49e2-a0b1-2b7e379c13eb"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("853d74a0-b363-46b1-a680-f98104a18615"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("8ef68d73-c424-4179-b5ff-5d17a1788cf8"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("92607192-cd3b-4ea8-b059-156e533a8d29"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("b62a6764-4ea0-4c1d-9d13-0b7a63517bde"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("d6a93350-022b-47ca-9390-548e83c607f8"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("fc5fe612-127b-482d-9942-a925eb41392a"));

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CurrentCarStatus", "ModelName", "RelatedLocationId", "RelatedReservationId" },
                values: new object[,]
                {
                    { new Guid("03339d77-ac85-4fd1-b16f-8b9462476c0d"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("4e2c5039-1855-4209-8322-b089b0054b44"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("554f0f4f-b987-494b-b04a-8cfc980032fa"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("5926dc10-3ca7-4b39-97b2-b75508726d87"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("5cd8ab11-3ade-4ae0-b5ff-e181f2a99962"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null },
                    { new Guid("82a4cc83-e2c9-45be-be32-2db6ca3b1271"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("9484e99c-a1f0-4532-9302-e2ee111b7485"), 1, "Model X", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("96fa3765-01d3-4314-9fd4-488ee830bc4e"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null },
                    { new Guid("a903cf31-b367-4cf9-9ea1-9e7dd13cec02"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null },
                    { new Guid("ace6624f-804f-4ecf-a17f-0afc514f22b0"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("c7285935-db01-477d-b19a-2ff89238c154"), 1, "Model X", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("da7b19b5-c5f1-416b-b638-2ebb98462069"), 1, "Model 3", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("03339d77-ac85-4fd1-b16f-8b9462476c0d"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("4e2c5039-1855-4209-8322-b089b0054b44"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("554f0f4f-b987-494b-b04a-8cfc980032fa"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("5926dc10-3ca7-4b39-97b2-b75508726d87"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("5cd8ab11-3ade-4ae0-b5ff-e181f2a99962"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("82a4cc83-e2c9-45be-be32-2db6ca3b1271"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("9484e99c-a1f0-4532-9302-e2ee111b7485"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("96fa3765-01d3-4314-9fd4-488ee830bc4e"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("a903cf31-b367-4cf9-9ea1-9e7dd13cec02"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("ace6624f-804f-4ecf-a17f-0afc514f22b0"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("c7285935-db01-477d-b19a-2ff89238c154"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("da7b19b5-c5f1-416b-b638-2ebb98462069"));

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CurrentCarStatus", "ModelName", "RelatedLocationId", "RelatedReservationId" },
                values: new object[,]
                {
                    { new Guid("2f5c7e0b-001f-42d7-8cf4-f08fa6869965"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("362a1ab0-7ead-4d2d-95ba-60997aea2802"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null },
                    { new Guid("3fb0c06e-8fd1-434b-af17-6a957d6f2503"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null },
                    { new Guid("77ff4072-e0e0-4160-9306-31b00740875f"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("7f7045b8-4e26-45b5-b8eb-9f9fe8c8745b"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("834b1b1b-a658-49e2-a0b1-2b7e379c13eb"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null },
                    { new Guid("853d74a0-b363-46b1-a680-f98104a18615"), 1, "Model X", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("8ef68d73-c424-4179-b5ff-5d17a1788cf8"), 1, "Model 3", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("92607192-cd3b-4ea8-b059-156e533a8d29"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("b62a6764-4ea0-4c1d-9d13-0b7a63517bde"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("d6a93350-022b-47ca-9390-548e83c607f8"), 1, "Model X", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("fc5fe612-127b-482d-9942-a925eb41392a"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null }
                });
        }
    }
}
