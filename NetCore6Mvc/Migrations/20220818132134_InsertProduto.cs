using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCore6Mvc.Migrations
{
    public partial class InsertProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produto(Nome,DescricaoCurta,DescricaoDetalhada,Valor,ImagemUrl,ImagemMini,Disponivel,QtdeEstoque,CategoriaId,CategoriasCategoriaId)" +
            "VALUES('Produto 2','Desc curta','desc det',159.90,'ImagemUrl','ImagemMini',1,'10',1,1)");

            migrationBuilder.Sql("INSERT INTO Produto(Nome,DescricaoCurta,DescricaoDetalhada,Valor,ImagemUrl,ImagemMini,Disponivel,QtdeEstoque,CategoriaId,CategoriasCategoriaId)" +
            "VALUES('Produto 2','Desc curta','desc det',179.90,'ImagemUrl','ImagemMini',1,'10',2,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produto");
        }
    }
}
