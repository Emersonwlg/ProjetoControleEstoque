using System.ComponentModel.DataAnnotations;

namespace ProjetoEstoque.Models
{
    public class Produto
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public int Quantidade {get;set;}
        public decimal ValorUnitario {get;set;}
    }
}