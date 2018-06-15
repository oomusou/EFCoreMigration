using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreMigration.Migrations
{
    public partial class Migration03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Age", "Name" },
                values: new object[] { 1, 18, "Sam" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Age", "Name" },
                values: new object[] { 2, 19, "Kevin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2);
        }
    }
}
