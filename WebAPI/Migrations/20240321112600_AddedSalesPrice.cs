using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedSalesPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsOnSale",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OriginalPrice",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SalePrice",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsOnSale", "OriginalPrice", "SalePrice" },
                values: new object[] { false, "$12.50", "$12.50" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsOnSale", "OriginalPrice", "SalePrice" },
                values: new object[] { false, "$15.99", "$15.99" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsOnSale", "OriginalPrice", "SalePrice" },
                values: new object[] { true, "$44.99", "$9.99" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsOnSale", "OriginalPrice", "SalePrice" },
                values: new object[] { false, "$15.99", "$15.99" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsOnSale", "OriginalPrice", "SalePrice" },
                values: new object[] { false, "$11.20", "$12.20" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsOnSale", "OriginalPrice", "SalePrice" },
                values: new object[] { false, "$10.50", "$10.50" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IsOnSale", "OriginalPrice", "SalePrice" },
                values: new object[] { false, "$18.99", "$18.99" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IsOnSale", "OriginalPrice", "SalePrice" },
                values: new object[] { true, "$44.99", "$12.99" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IsOnSale", "OriginalPrice", "SalePrice" },
                values: new object[] { false, "$14.50", "$14.50" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOnSale",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "SalePrice",
                table: "Courses");
        }
    }
}
