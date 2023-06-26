using Microsoft.EntityFrameworkCore.Migrations;

namespace den_office.Migrations
{
    public partial class updatedDatabaseWithCustomerNameSurnameEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Customer",
                table: "Reservation",
                newName: "CustomerSurname");

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Reservation");

            migrationBuilder.RenameColumn(
                name: "CustomerSurname",
                table: "Reservation",
                newName: "Customer");
        }
    }
}
