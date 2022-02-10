using Microsoft.EntityFrameworkCore.Migrations;

namespace den_office.Migrations
{
    public partial class updatedDatabaseWithCustomerRow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Customer",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Customer",
                table: "Reservation");
        }
    }
}
