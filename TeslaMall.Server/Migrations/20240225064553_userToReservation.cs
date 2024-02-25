using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeslaMall.Server.Migrations
{
    /// <inheritdoc />
    public partial class userToReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserReservations_Reservations_RelatedReservationId",
                table: "UserReservations");

            migrationBuilder.DropIndex(
                name: "IX_UserReservations_RelatedReservationId",
                table: "UserReservations");

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

            migrationBuilder.DropColumn(
                name: "RelatedReservationId",
                table: "UserReservations");

            migrationBuilder.AddColumn<Guid>(
                name: "UserReservationId",
                table: "Reservations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CurrentCarStatus", "ModelName", "RelatedLocationId", "RelatedReservationId" },
                values: new object[,]
                {
                    { new Guid("0db72fc0-3d89-476b-8151-2f0d2cb1efb3"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("0ee37ae4-73d7-4dec-a2e2-82b4e16ec747"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null },
                    { new Guid("23832adc-7b50-44f0-a3f9-1470db2741f1"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("26f220bb-f6a6-405a-8e86-ce6d97114d50"), 1, "Model 3", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("2d9933c1-d237-4de4-b83a-05d04cda75dd"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("45fc06ee-aa68-4da7-95f3-5910d80eb581"), 1, "Model X", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("4fff416b-c209-43b1-ac4c-54bb5134fba4"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null },
                    { new Guid("513928a4-f98b-4c36-9bc9-e5cb4d227ca4"), 1, "Model X", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("58e596dd-591b-4010-9578-1228f44bec7f"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1a"), null },
                    { new Guid("8cc8a872-c941-4431-be3b-3ab45b7c1457"), 1, "Model Y", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1b"), null },
                    { new Guid("90009a08-8369-480a-8dbc-37c0b533ef34"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1c"), null },
                    { new Guid("bca9bde4-9930-43a7-bf14-f6e0cf5cad66"), 1, "Model S", new Guid("bddce424-3340-45bc-a4ef-02db33bc8c1d"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserReservationId",
                table: "Reservations",
                column: "UserReservationId",
                unique: true,
                filter: "[UserReservationId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_UserReservations_UserReservationId",
                table: "Reservations",
                column: "UserReservationId",
                principalTable: "UserReservations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_UserReservations_UserReservationId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_UserReservationId",
                table: "Reservations");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("0db72fc0-3d89-476b-8151-2f0d2cb1efb3"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("0ee37ae4-73d7-4dec-a2e2-82b4e16ec747"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("23832adc-7b50-44f0-a3f9-1470db2741f1"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("26f220bb-f6a6-405a-8e86-ce6d97114d50"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2d9933c1-d237-4de4-b83a-05d04cda75dd"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("45fc06ee-aa68-4da7-95f3-5910d80eb581"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("4fff416b-c209-43b1-ac4c-54bb5134fba4"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("513928a4-f98b-4c36-9bc9-e5cb4d227ca4"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("58e596dd-591b-4010-9578-1228f44bec7f"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("8cc8a872-c941-4431-be3b-3ab45b7c1457"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("90009a08-8369-480a-8dbc-37c0b533ef34"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("bca9bde4-9930-43a7-bf14-f6e0cf5cad66"));

            migrationBuilder.DropColumn(
                name: "UserReservationId",
                table: "Reservations");

            migrationBuilder.AddColumn<Guid>(
                name: "RelatedReservationId",
                table: "UserReservations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_UserReservations_RelatedReservationId",
                table: "UserReservations",
                column: "RelatedReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserReservations_Reservations_RelatedReservationId",
                table: "UserReservations",
                column: "RelatedReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
