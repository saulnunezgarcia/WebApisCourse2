using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class ControlarNullables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 9, 5, 17, 44, 3, 837, DateTimeKind.Local).AddTicks(2309), new DateTime(2023, 9, 5, 17, 44, 3, 837, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 9, 5, 17, 44, 3, 837, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 9, 5, 17, 44, 3, 837, DateTimeKind.Local).AddTicks(2311) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 9, 1, 1, 7, 14, 714, DateTimeKind.Local).AddTicks(6816), new DateTime(2023, 9, 1, 1, 7, 14, 714, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 9, 1, 1, 7, 14, 714, DateTimeKind.Local).AddTicks(6819), new DateTime(2023, 9, 1, 1, 7, 14, 714, DateTimeKind.Local).AddTicks(6818) });
        }
    }
}
