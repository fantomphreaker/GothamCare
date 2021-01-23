using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataService.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Outlets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OutletName = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    StreetName = table.Column<string>(type: "text", nullable: false),
                    Landmark = table.Column<string>(type: "text", nullable: false),
                    TotalAvailableFoodPackets = table.Column<int>(type: "integer", nullable: false),
                    FoodType = table.Column<int>(type: "integer", nullable: false),
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
                    VolunteerName = table.Column<string>(type: "text", nullable: false),
                    VolunteerAddress = table.Column<string>(type: "text", nullable: false),
                    VolunteerPhoneNumber = table.Column<string>(type: "text", nullable: false),
                    VolunteerDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    OutletID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Volunteers_Outlets_OutletID",
                        column: x => x.OutletID,
                        principalTable: "Outlets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Volunteers_OutletID",
                table: "Volunteers",
                column: "OutletID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Volunteers");

            migrationBuilder.DropTable(
                name: "Outlets");
        }
    }
}
