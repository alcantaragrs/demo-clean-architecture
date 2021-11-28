using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"insert into 
                    Product(Name, Description, Price, Stock, Image, CategoryId)
                    values
                        ('Caderno', 'Caderno espiral 96 folhas', 7.45, 50, 'caderno.jpg', 1)
                "
            );

            migrationBuilder.Sql(
                @"insert into 
                    Product(Name, Description, Price, Stock, Image, CategoryId)
                    values
                        ('Estojo', 'Estojo escolar cinza', 5.65, 70, 'estojo.jpg', 1)
                "
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Products");
        }
    }
}
