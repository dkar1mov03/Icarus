using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Icarus.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentResponse_Assets_DepartmentId",
                table: "DepartmentResponse");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentResponse_Request_RequestId",
                table: "DepartmentResponse");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_Assets_DepartmentId",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_Users_UserId",
                table: "Request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Request",
                table: "Request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentResponse",
                table: "DepartmentResponse");

            migrationBuilder.RenameTable(
                name: "Request",
                newName: "Requests");

            migrationBuilder.RenameTable(
                name: "DepartmentResponse",
                newName: "DepartmentResponses");

            migrationBuilder.RenameIndex(
                name: "IX_Request_UserId",
                table: "Requests",
                newName: "IX_Requests_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Request_DepartmentId",
                table: "Requests",
                newName: "IX_Requests_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentResponse_RequestId",
                table: "DepartmentResponses",
                newName: "IX_DepartmentResponses_RequestId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentResponse_DepartmentId",
                table: "DepartmentResponses",
                newName: "IX_DepartmentResponses_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requests",
                table: "Requests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentResponses",
                table: "DepartmentResponses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentResponses_Assets_DepartmentId",
                table: "DepartmentResponses",
                column: "DepartmentId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentResponses_Requests_RequestId",
                table: "DepartmentResponses",
                column: "RequestId",
                principalTable: "Requests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Assets_DepartmentId",
                table: "Requests",
                column: "DepartmentId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentResponses_Assets_DepartmentId",
                table: "DepartmentResponses");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentResponses_Requests_RequestId",
                table: "DepartmentResponses");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Assets_DepartmentId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Requests",
                table: "Requests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentResponses",
                table: "DepartmentResponses");

            migrationBuilder.RenameTable(
                name: "Requests",
                newName: "Request");

            migrationBuilder.RenameTable(
                name: "DepartmentResponses",
                newName: "DepartmentResponse");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_UserId",
                table: "Request",
                newName: "IX_Request_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_DepartmentId",
                table: "Request",
                newName: "IX_Request_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentResponses_RequestId",
                table: "DepartmentResponse",
                newName: "IX_DepartmentResponse_RequestId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentResponses_DepartmentId",
                table: "DepartmentResponse",
                newName: "IX_DepartmentResponse_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Request",
                table: "Request",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentResponse",
                table: "DepartmentResponse",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentResponse_Assets_DepartmentId",
                table: "DepartmentResponse",
                column: "DepartmentId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentResponse_Request_RequestId",
                table: "DepartmentResponse",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Assets_DepartmentId",
                table: "Request",
                column: "DepartmentId",
                principalTable: "Assets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Users_UserId",
                table: "Request",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
