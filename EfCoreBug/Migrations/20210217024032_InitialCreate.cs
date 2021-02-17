using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreBug.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    Post1Id = table.Column<Guid>(type: "TEXT", nullable: true),
                    Post2Id = table.Column<Guid>(type: "TEXT", nullable: true),
                    Post3Id = table.Column<Guid>(type: "TEXT", nullable: true),
                    Post4Id = table.Column<Guid>(type: "TEXT", nullable: true),
                    Post5Id = table.Column<Guid>(type: "TEXT", nullable: true),
                    Post6Id = table.Column<Guid>(type: "TEXT", nullable: true),
                    Post7Id = table.Column<Guid>(type: "TEXT", nullable: true),
                    Post8Id = table.Column<Guid>(type: "TEXT", nullable: true),
                    Post9Id = table.Column<Guid>(type: "TEXT", nullable: true),
                    Post10Id = table.Column<Guid>(type: "TEXT", nullable: true),
                    Post11Id = table.Column<Guid>(type: "TEXT", nullable: true),
                    Post12Id = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Posts_Post10Id",
                        column: x => x.Post10Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blogs_Posts_Post11Id",
                        column: x => x.Post11Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blogs_Posts_Post12Id",
                        column: x => x.Post12Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blogs_Posts_Post1Id",
                        column: x => x.Post1Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blogs_Posts_Post2Id",
                        column: x => x.Post2Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blogs_Posts_Post3Id",
                        column: x => x.Post3Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blogs_Posts_Post4Id",
                        column: x => x.Post4Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blogs_Posts_Post5Id",
                        column: x => x.Post5Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blogs_Posts_Post6Id",
                        column: x => x.Post6Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blogs_Posts_Post7Id",
                        column: x => x.Post7Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blogs_Posts_Post8Id",
                        column: x => x.Post8Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blogs_Posts_Post9Id",
                        column: x => x.Post9Id,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Post10Id",
                table: "Blogs",
                column: "Post10Id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Post11Id",
                table: "Blogs",
                column: "Post11Id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Post12Id",
                table: "Blogs",
                column: "Post12Id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Post1Id",
                table: "Blogs",
                column: "Post1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Post2Id",
                table: "Blogs",
                column: "Post2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Post3Id",
                table: "Blogs",
                column: "Post3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Post4Id",
                table: "Blogs",
                column: "Post4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Post5Id",
                table: "Blogs",
                column: "Post5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Post6Id",
                table: "Blogs",
                column: "Post6Id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Post7Id",
                table: "Blogs",
                column: "Post7Id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Post8Id",
                table: "Blogs",
                column: "Post8Id");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_Post9Id",
                table: "Blogs",
                column: "Post9Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
