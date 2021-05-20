using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteLanches.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string DescricaoCurta { get; set; }
        [StringLength(255)]
        public string DescricaoLonga { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
        [StringLength(200)]
        public string ImagemUrl { get; set; }
        [StringLength(200)]
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool IsEmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}