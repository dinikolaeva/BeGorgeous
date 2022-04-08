namespace BeGorgeous.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddStylistsTreatmentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_Stylists_StylistId",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Treatments_StylistId",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "StylistId",
                table: "Treatments");

            migrationBuilder.CreateTable(
                name: "StylistsTreatments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StylistId = table.Column<int>(type: "int", nullable: false),
                    TreatmentId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StylistsTreatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StylistsTreatments_Stylists_StylistId",
                        column: x => x.StylistId,
                        principalTable: "Stylists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StylistsTreatments_Treatments_TreatmentId",
                        column: x => x.TreatmentId,
                        principalTable: "Treatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StylistsTreatments_IsDeleted",
                table: "StylistsTreatments",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_StylistsTreatments_StylistId",
                table: "StylistsTreatments",
                column: "StylistId");

            migrationBuilder.CreateIndex(
                name: "IX_StylistsTreatments_TreatmentId",
                table: "StylistsTreatments",
                column: "TreatmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StylistsTreatments");

            migrationBuilder.AddColumn<int>(
                name: "StylistId",
                table: "Treatments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_StylistId",
                table: "Treatments",
                column: "StylistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_Stylists_StylistId",
                table: "Treatments",
                column: "StylistId",
                principalTable: "Stylists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
