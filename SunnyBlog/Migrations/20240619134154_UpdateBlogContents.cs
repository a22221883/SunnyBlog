using Microsoft.EntityFrameworkCore.Migrations;

namespace SunnyBlog.Migrations
{
    public partial class UpdateBlogContents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "BlogContent");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "BlogContent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogContent_CategoryId",
                table: "BlogContent",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogContent_Category_CategoryId",
                table: "BlogContent",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogContent_Category_CategoryId",
                table: "BlogContent");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_BlogContent_CategoryId",
                table: "BlogContent");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "BlogContent");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "BlogContent",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
