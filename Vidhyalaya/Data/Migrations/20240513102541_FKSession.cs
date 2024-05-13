using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidhyalaya.Data.Migrations
{
    /// <inheritdoc />
    public partial class FKSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GradeLabel",
                table: "Student");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradeLabel",
                table: "Student",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
