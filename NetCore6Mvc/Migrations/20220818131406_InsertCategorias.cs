using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCore6Mvc.Migrations
{
    public partial class InsertCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao)"+
                "VALUES('Normal','Produto Normal')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao)" +
                "VALUES('Importados','Produto Importado')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
