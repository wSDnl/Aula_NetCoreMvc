using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCore6Mvc.Migrations
{
    public partial class InsertUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(" INSERT INTO Users(NomeUsuario,Email,Senha,UsuarioAtivo)VALUES('User 1','email@email.com','1234',1) ");
            migrationBuilder.Sql(" INSERT INTO Users(NomeUsuario,Email,Senha,UsuarioAtivo)VALUES('User 2','email@email.com','1234',1) ");
            migrationBuilder.Sql(" INSERT INTO Users(NomeUsuario,Email,Senha,UsuarioAtivo)VALUES('User 3','email@email.com','1234',1) ");
            migrationBuilder.Sql(" INSERT INTO Users(NomeUsuario,Email,Senha,UsuarioAtivo)VALUES('User 4','email@email.com','1234',1) ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Users");
        }
    }
}
