using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP003B.Assignment7.Migrations
{
    /// <inheritdoc />
    public partial class AddYearToActor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieActors_Actors_ActorId1",
                table: "MovieActors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActors_Movies_MovieId1",
                table: "MovieActors");

            migrationBuilder.DropIndex(
                name: "IX_MovieActors_ActorId1",
                table: "MovieActors");

            migrationBuilder.DropIndex(
                name: "IX_MovieActors_MovieId1",
                table: "MovieActors");

            migrationBuilder.DropColumn(
                name: "ActorId1",
                table: "MovieActors");

            migrationBuilder.DropColumn(
                name: "MovieId1",
                table: "MovieActors");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MovieActors",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ActorId",
                table: "MovieActors",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "YearReleased",
                table: "Actors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_ActorId",
                table: "MovieActors",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_MovieId",
                table: "MovieActors",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActors_Actors_ActorId",
                table: "MovieActors",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActors_Movies_MovieId",
                table: "MovieActors",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieActors_Actors_ActorId",
                table: "MovieActors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActors_Movies_MovieId",
                table: "MovieActors");

            migrationBuilder.DropIndex(
                name: "IX_MovieActors_ActorId",
                table: "MovieActors");

            migrationBuilder.DropIndex(
                name: "IX_MovieActors_MovieId",
                table: "MovieActors");

            migrationBuilder.DropColumn(
                name: "YearReleased",
                table: "Actors");

            migrationBuilder.AlterColumn<string>(
                name: "MovieId",
                table: "MovieActors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ActorId",
                table: "MovieActors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ActorId1",
                table: "MovieActors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieId1",
                table: "MovieActors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_ActorId1",
                table: "MovieActors",
                column: "ActorId1");

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_MovieId1",
                table: "MovieActors",
                column: "MovieId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActors_Actors_ActorId1",
                table: "MovieActors",
                column: "ActorId1",
                principalTable: "Actors",
                principalColumn: "ActorId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActors_Movies_MovieId1",
                table: "MovieActors",
                column: "MovieId1",
                principalTable: "Movies",
                principalColumn: "MovieId");
        }
    }
}
