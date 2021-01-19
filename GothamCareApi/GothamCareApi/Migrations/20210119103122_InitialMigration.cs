using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GothamCareApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    EmailId = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: true),
                    AdminName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.EmailId);
                });

            migrationBuilder.CreateTable(
                name: "Outlets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OutletName = table.Column<string>(type: "text", nullable: true),
                    StreetName = table.Column<string>(type: "text", nullable: true),
                    Landmark = table.Column<string>(type: "text", nullable: true),
                    TotalAvailableFoodPackets = table.Column<int>(type: "integer", nullable: false),
                    FoodType = table.Column<string>(type: "text", nullable: true),
                    RequiredNoOfVolunteers = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outlets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VolunteerName = table.Column<string>(type: "text", nullable: true),
                    VolunteerAddress = table.Column<string>(type: "text", nullable: true),
                    VolunteerPhoneNumber = table.Column<string>(type: "text", nullable: true),
                    VolunteerDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    OutletID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Outlets");

            migrationBuilder.DropTable(
                name: "Volunteers");
        }
    }
}
