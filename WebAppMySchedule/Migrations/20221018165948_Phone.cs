using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMySchedule.Migrations
{
    public partial class Phone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Person_PersonIdPerson",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_PersonIdPerson",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "PersonIdPerson",
                table: "Address");

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Landline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdPerson = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phone_Person_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "Person",
                        principalColumn: "IdPerson",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_IdPerson",
                table: "Address",
                column: "IdPerson");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_IdPerson",
                table: "Phone",
                column: "IdPerson");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Person_IdPerson",
                table: "Address",
                column: "IdPerson",
                principalTable: "Person",
                principalColumn: "IdPerson",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Person_IdPerson",
                table: "Address");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropIndex(
                name: "IX_Address_IdPerson",
                table: "Address");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonIdPerson",
                table: "Address",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_PersonIdPerson",
                table: "Address",
                column: "PersonIdPerson");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Person_PersonIdPerson",
                table: "Address",
                column: "PersonIdPerson",
                principalTable: "Person",
                principalColumn: "IdPerson",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
