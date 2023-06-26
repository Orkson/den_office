using Microsoft.EntityFrameworkCore.Migrations;

namespace den_office.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservation_ServiceId",
                table: "Reservation");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_ServiceId",
                table: "Reservation",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservation_ServiceId",
                table: "Reservation");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_ServiceId",
                table: "Reservation",
                column: "ServiceId",
                unique: true);
        }
    }
}
