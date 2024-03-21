using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddNewCourseFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Duration", "Instructor", "Price", "SatisfactionRate", "Title" },
                values: new object[,]
                {
                    { 1, "220 hours", "Robert Fox", "$12.50", "94% (4.2K)", "Fullstack Web Developer Course from Scratch" },
                    { 2, "160 hours", "Jenny Wilson & Marvin McKinney", "$15.99", "92% (3.1K)", "HTML, CSS, JavaScript Web Developer" },
                    { 3, "100 hours", "Albert Flores", "$9.99", "98% (2.7K)", "The Complete Front-End Web Development Course" },
                    { 4, "160 hours", "Marvin McKinney", "$15.99", "92% (3.1K)", "iOS & Swift - The Complete iOS App Development Course" },
                    { 5, "160 hours", "Esther Howard", "$11.20", "92% (3.1K)", "Data Science & Machine Learning with Python" },
                    { 6, "220 hours", "Robert Fox", "$10.50", "94% (4.2K)", "Creative CSS Drawing Course: Make Art With CSS" },
                    { 7, "160 hours", "Ralph Edwards", "$18.99", "92% (3.1K)", "Blender Character Creator v2.0 for Video Games Design" },
                    { 8, "100 hours", "Albert Flores", "$12.99", "98% (2.7K)", "The Ultimate Guide to 2D Mobile Game Development with Unity" },
                    { 9, "160 hours", "Jenny Wilson", "$14.50", "92% (3.1K)", "Learn JMETER from Scratch on Live Apps-Performance Testing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
