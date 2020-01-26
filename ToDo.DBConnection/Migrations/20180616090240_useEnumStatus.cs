using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDo.DBConnection.Migrations
{
    public partial class useEnumStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM TASKS");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Tasks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Tasks",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
