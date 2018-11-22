using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalERP.Migrations.Vendor
{
    public partial class VendorInit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "ID", "Email", "Name", "PhoneNumber", "WebsiteURL" },
                values: new object[] { 1, "IsellSwag@gmail.com", "Dakota Fisher", "306-420-6969", "Swag.swag" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
