using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyNewBlog.Migrations
{
    /// <inheritdoc />
    public partial class Fix_Introducton_Field_To_Introduction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Introducton",
                table: "Posts",
                newName: "Introduction");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Introduction",
                table: "Posts",
                newName: "Introducton");
        }
    }
}
