using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessBankPortal.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegistrationDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    DOB = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Zip_Code = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    Additional_Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrationDetails");
        }
    }
}
