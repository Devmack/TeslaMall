using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeslaMall.Server.Migrations
{
    /// <inheritdoc />
    public partial class CarIdNavigationInReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "RentedCarId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "RentedCarId",
                table: "Reservations");

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
        }
    }
}
