using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.Web.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "846aa2b5-17a6-4924-a4f6-81ba1728329b", "949c3bb0-1dee-461e-bcca-b2ca8bb72b6f", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dee5271c-596e-48c7-afe5-39e06b91e500", "c9def9f9-f3ef-4db4-af8f-22c58cfb71fd", "HR", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "846aa2b5-17a6-4924-a4f6-81ba1728329b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dee5271c-596e-48c7-afe5-39e06b91e500");
        }
    }
}
