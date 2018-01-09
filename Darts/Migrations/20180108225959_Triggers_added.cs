using Microsoft.EntityFrameworkCore.Migrations;

namespace Darts.Migrations
{
    public partial class Triggers_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("CREATE OR ALTER TRIGGER PLAYER_INS ON PLAYER" +
                " AFTER INSERT AS" +
                    " Declare @now DateTime" +
                    " SET @now = SYSDATETIME()" +
                    " UPDATE PLAYER" +
                    " SET INSERTDATETIME = @now, CHANGEDATETIME = @now" +
                    " FROM Inserted i" +
                    " WHERE i.ID = PLAYER.ID");

            migrationBuilder.Sql("CREATE OR ALTER TRIGGER PLAYER_UPD ON PLAYER" +
                " AFTER UPDATE AS" +
                    " UPDATE PLAYER" +
                    " SET CHANGEDATETIME = SYSDATETIME()" +
                    " FROM Inserted i" +
                    " WHERE i.ID = PLAYER.ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP TRIGGER PLAYER_INS");
            migrationBuilder.Sql("DROP TRIGGER PLAYER_UPD");
        }
    }
}
