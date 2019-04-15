using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace coreOnlineApparelStoreAdminPortal.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    ManagerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ManagerFirstName = table.Column<string>(nullable: true),
                    ManagerLastName = table.Column<string>(nullable: true),
                    ManagerPassword = table.Column<string>(nullable: true),
                    ManagerEmail = table.Column<string>(nullable: true),
                    ManagerAddress = table.Column<string>(nullable: true),
                    ManagerCountry = table.Column<string>(nullable: true),
                    ManagerState = table.Column<string>(nullable: true),
                    ManagerZipCode = table.Column<int>(nullable: false),
                    ManagerPhoneNumber = table.Column<long>(nullable: false),
                    ManagerGender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.ManagerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Managers");
        }
    }
}
