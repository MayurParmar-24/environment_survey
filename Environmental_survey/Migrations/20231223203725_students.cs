using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Environmental_survey.Migrations
{
    /// <inheritdoc />
    public partial class students : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Std_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Std_Roll_NO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Std_Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Std_Specification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Std_Section = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Std_Admission_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
