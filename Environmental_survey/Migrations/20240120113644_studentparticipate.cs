using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Environmental_survey.Migrations
{
    /// <inheritdoc />
    public partial class studentparticipate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "competition_",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Competition_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Competition_startdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Competition_enddate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Competition_location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Competiton_type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_competition_", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "competitions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Competition_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Competition_startdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Competition_enddate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Competition_location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Competiton_type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_competitions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "stdparticipate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Group_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Group_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Group_Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Group_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Num_Of_prpoles = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stdparticipate", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "competition_");

            migrationBuilder.DropTable(
                name: "competitions");

            migrationBuilder.DropTable(
                name: "stdparticipate");
        }
    }
}
