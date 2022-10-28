using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IDKyet.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Champions");

            migrationBuilder.AddColumn<int>(
                name: "RoleID",
                table: "Champions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Champions",
                table: "Champions",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Summs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Server = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChampionsListSumms",
                columns: table => new
                {
                    ChampionsId = table.Column<int>(type: "int", nullable: false),
                    SummonersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionsListSumms", x => new { x.ChampionsId, x.SummonersId });
                    table.ForeignKey(
                        name: "FK_ChampionsListSumms_Champions_ChampionsId",
                        column: x => x.ChampionsId,
                        principalTable: "Champions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChampionsListSumms_Summs_SummonersId",
                        column: x => x.SummonersId,
                        principalTable: "Summs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[] { 1, "Top" });

            migrationBuilder.InsertData(
                table: "Summs",
                columns: new[] { "Id", "Name", "Password", "Server" },
                values: new object[] { 1, "KarelFrederick", "Karlík1234", 0 });

            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoleID",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Champions_RoleID",
                table: "Champions",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_ChampionsListSumms_SummonersId",
                table: "ChampionsListSumms",
                column: "SummonersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Champions_Roles_RoleID",
                table: "Champions",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Champions_Roles_RoleID",
                table: "Champions");

            migrationBuilder.DropTable(
                name: "ChampionsListSumms");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Summs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Champions",
                table: "Champions");

            migrationBuilder.DropIndex(
                name: "IX_Champions_RoleID",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "Champions");

            migrationBuilder.RenameTable(
                name: "Champions",
                newName: "Items");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "Role",
                value: "Top");
        }
    }
}
