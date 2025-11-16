using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update_TTHC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "phongBans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoatDong = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phongBans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhongBanId = table.Column<int>(type: "int", nullable: true),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoatDong = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_nhanViens_phongBans_PhongBanId",
                        column: x => x.PhongBanId,
                        principalTable: "phongBans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "congViecs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoUuTien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhanVienId = table.Column<int>(type: "int", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoatDong = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_congViecs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_congViecs_nhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "nhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_congViecs_NhanVienId",
                table: "congViecs",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_PhongBanId",
                table: "nhanViens",
                column: "PhongBanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "congViecs");

            migrationBuilder.DropTable(
                name: "nhanViens");

            migrationBuilder.DropTable(
                name: "phongBans");
        }
    }
}
