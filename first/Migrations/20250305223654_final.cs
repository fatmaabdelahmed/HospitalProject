using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace first.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Billings",
                table: "Billings");

            migrationBuilder.DropIndex(
                name: "IX_Billings_AppointmentId",
                table: "Billings");

            migrationBuilder.DropColumn(
                name: "BillingId",
                table: "Billings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Billings",
                table: "Billings",
                column: "AppointmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Billings",
                table: "Billings");

            migrationBuilder.AddColumn<int>(
                name: "BillingId",
                table: "Billings",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Billings",
                table: "Billings",
                column: "BillingId");

            migrationBuilder.CreateIndex(
                name: "IX_Billings_AppointmentId",
                table: "Billings",
                column: "AppointmentId",
                unique: true);
        }
    }
}
