using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "Lagos", "Ciudad de las flores", new DateTime(2024, 8, 6, 10, 33, 42, 562, DateTimeKind.Local).AddTicks(9406), new DateTime(2024, 8, 6, 10, 33, 42, 562, DateTimeKind.Local).AddTicks(9392), "", 0, "Xalapa", 1000, 200.0 },
                    { 2, "Lagos", "Ciudad del pan", new DateTime(2024, 8, 6, 10, 33, 42, 562, DateTimeKind.Local).AddTicks(9409), new DateTime(2024, 8, 6, 10, 33, 42, 562, DateTimeKind.Local).AddTicks(9408), "", 0, "Xico", 1000, 200.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
