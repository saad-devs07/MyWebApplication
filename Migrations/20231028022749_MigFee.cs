using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class MigFee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fee",
                columns: table => new
                {
                    FId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FMonth = table.Column<int>(type: "int", nullable: false),
                    FAmount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SId = table.Column<int>(type: "int", nullable: false),
                    StudentSId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fee", x => x.FId);
                    table.ForeignKey(
                        name: "FK_Fee_Std_StudentSId",
                        column: x => x.StudentSId,
                        principalTable: "Std",
                        principalColumn: "SId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fee_StudentSId",
                table: "Fee",
                column: "StudentSId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fee");
        }
    }
}
