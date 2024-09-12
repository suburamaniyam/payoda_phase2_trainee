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
                name: "Patientcs",
                columns: table => new
                {
                    Patid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patientcs", x => x.Patid);
                    table.ForeignKey(
                        name: "FK_Patientcs_Doctor_Docid",
                        column: x => x.Docid,
                        principalTable: "Doctor",
                        principalColumn: "Docid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patientcs_Docid",
                table: "Patientcs",
                column: "Docid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patientcs");

            migrationBuilder.DropTable(
                name: "Doctor");
        }
    }
}
