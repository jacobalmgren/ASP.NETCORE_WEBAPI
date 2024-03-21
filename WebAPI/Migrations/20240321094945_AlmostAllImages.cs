using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlmostAllImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "durationImage",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "satisfactionImage",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "durationImage", "satisfactionImage" },
                values: new object[] { "https://localhost:7279/images/bx-time-five.svg", "https://localhost:7279/images/bx-like.svg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "durationImage", "satisfactionImage" },
                values: new object[] { "https://localhost:7279/images/bx-time-five.svg", "https://localhost:7279/images/bx-like.svg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "durationImage", "satisfactionImage" },
                values: new object[] { "https://localhost:7279/images/bx-time-five.svg", "https://localhost:7279/images/bx-like.svg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "durationImage", "satisfactionImage" },
                values: new object[] { "https://localhost:7279/images/bx-time-five.svg", "https://localhost:7279/images/bx-like.svg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "durationImage", "satisfactionImage" },
                values: new object[] { "https://localhost:7279/images/bx-time-five.svg", "https://localhost:7279/images/bx-like.svg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "durationImage", "satisfactionImage" },
                values: new object[] { "https://localhost:7279/images/bx-time-five.svg", "https://localhost:7279/images/bx-like.svg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "durationImage", "satisfactionImage" },
                values: new object[] { "https://localhost:7279/images/bx-time-five.svg", "https://localhost:7279/images/bx-like.svg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "durationImage", "satisfactionImage" },
                values: new object[] { "https://localhost:7279/images/bx-time-five.svg", "https://localhost:7279/images/bx-like.svg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "durationImage", "satisfactionImage" },
                values: new object[] { "https://localhost:7279/images/bx-time-five.svg", "https://localhost:7279/images/bx-like.svg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "durationImage",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "satisfactionImage",
                table: "Courses");
        }
    }
}
