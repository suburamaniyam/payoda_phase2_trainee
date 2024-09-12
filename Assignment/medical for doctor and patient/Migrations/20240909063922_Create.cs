using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicineOfDoctorPatients.Migrations
{
    /// <inheritdoc />
    public partial class Create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Docid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocSpecialist = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Docid);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Patid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doctorid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Patid);
                    table.ForeignKey(
                        name: "FK_Patient_Doctor_Doctorid",
                        column: x => x.Doctorid,
                        principalTable: "Doctor",
                        principalColumn: "Docid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patient_Doctorid",
                table: "Patient",
                column: "Doctorid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Doctor");
        }
    }
}
