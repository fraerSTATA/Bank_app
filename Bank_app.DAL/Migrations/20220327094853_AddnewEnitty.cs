using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bank_app.DAL.Migrations
{
    public partial class AddnewEnitty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckedCreditRequests_CreditRequest_CreditRequestid",
                table: "CheckedCreditRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditRequest_CreditViews_CreditViewid",
                table: "CreditRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditRequest_Users_Userid",
                table: "CreditRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreditRequest",
                table: "CreditRequest");

            migrationBuilder.RenameTable(
                name: "CreditRequest",
                newName: "CreditRequests");

            migrationBuilder.RenameIndex(
                name: "IX_CreditRequest_Userid",
                table: "CreditRequests",
                newName: "IX_CreditRequests_Userid");

            migrationBuilder.RenameIndex(
                name: "IX_CreditRequest_CreditViewid",
                table: "CreditRequests",
                newName: "IX_CreditRequests_CreditViewid");

            migrationBuilder.AddColumn<string>(
                name: "descript",
                table: "CreditViews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Userid",
                table: "CreditRequests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreditRequests",
                table: "CreditRequests",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckedCreditRequests_CreditRequests_CreditRequestid",
                table: "CheckedCreditRequests",
                column: "CreditRequestid",
                principalTable: "CreditRequests",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditRequests_CreditViews_CreditViewid",
                table: "CreditRequests",
                column: "CreditViewid",
                principalTable: "CreditViews",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditRequests_Users_Userid",
                table: "CreditRequests",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckedCreditRequests_CreditRequests_CreditRequestid",
                table: "CheckedCreditRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditRequests_CreditViews_CreditViewid",
                table: "CreditRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditRequests_Users_Userid",
                table: "CreditRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreditRequests",
                table: "CreditRequests");

            migrationBuilder.DropColumn(
                name: "descript",
                table: "CreditViews");

            migrationBuilder.RenameTable(
                name: "CreditRequests",
                newName: "CreditRequest");

            migrationBuilder.RenameIndex(
                name: "IX_CreditRequests_Userid",
                table: "CreditRequest",
                newName: "IX_CreditRequest_Userid");

            migrationBuilder.RenameIndex(
                name: "IX_CreditRequests_CreditViewid",
                table: "CreditRequest",
                newName: "IX_CreditRequest_CreditViewid");

            migrationBuilder.AlterColumn<string>(
                name: "Userid",
                table: "CreditRequest",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreditRequest",
                table: "CreditRequest",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckedCreditRequests_CreditRequest_CreditRequestid",
                table: "CheckedCreditRequests",
                column: "CreditRequestid",
                principalTable: "CreditRequest",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditRequest_CreditViews_CreditViewid",
                table: "CreditRequest",
                column: "CreditViewid",
                principalTable: "CreditViews",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditRequest_Users_Userid",
                table: "CreditRequest",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
