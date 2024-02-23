using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeslaMall.Server.Migrations
{
    /// <inheritdoc />
    public partial class descriptionInLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("100361e1-e764-471b-9d25-98d0dd8b90d4"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("30a6582e-ee83-4869-9b9a-2abbd3c20a60"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("3cc7589c-d881-4f9d-b576-e77436b557d4"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("4b8d652f-0aed-4000-9e8f-70b7c3aa2748"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("544bd22d-b9f4-4424-87f1-5126c672dccd"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("5fd75550-1f45-4bff-bc1b-b8ed801ee29f"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("782dd2b8-cd63-4c24-8af7-9f624dabf6d1"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("8e9dc3a8-d243-4b04-9d05-a42db56e9bbd"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("bec0ee30-9633-47f1-8b4b-fb912bb7897c"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("c0f4bdab-2a2b-492c-ade4-55a3dc09fa0f"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("db8bca1a-1c7e-40da-85f7-3dacda4f436a"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("f3136b5e-d3b9-4e42-9da6-3fe1cefb7fc2"));

            migrationBuilder.AddColumn<string>(
                name: "LocationDescription",
                table: "RentalLocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "RentalLocations",
                keyColumn: "Id",
                keyValue: new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"),
                column: "LocationDescription",
                value: "City center buzzing with life and music. Worth checking out!");

            migrationBuilder.UpdateData(
                table: "RentalLocations",
                keyColumn: "Id",
                keyValue: new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"),
                column: "LocationDescription",
                value: "Best coctails, parties and company. Don't wait and go!");

            migrationBuilder.UpdateData(
                table: "RentalLocations",
                keyColumn: "Id",
                keyValue: new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"),
                column: "LocationDescription",
                value: "Sunny airport welcoming any visitors to join great vacation!");

            migrationBuilder.UpdateData(
                table: "RentalLocations",
                keyColumn: "Id",
                keyValue: new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"),
                column: "LocationDescription",
                value: "Sandy beach, full sun and relax. Rent a car and go!");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "LocationDescription",
                table: "RentalLocations");

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
        }
    }
}
