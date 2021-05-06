using System.Collections.Generic;

namespace SiteLanches.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; }
    }
}