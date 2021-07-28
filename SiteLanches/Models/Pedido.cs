using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SiteLanches.Models
{
    public class Pedido
    {
        [BindNever]
        public int PedidoId { get; set; }
        public List<PedidoDetalhe> PedidoItems { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Informe o sobrenome")]
        [Display(Name = "Sobrenome")]
        public string Sobrenome { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Informe o endereco")]
        [Display(Name = "Endereço")]
        public string Endereco1 { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Informe o complemento do endereço")]
        [Display(Name = "Complemento")]
        public string Endereco2 { get; set; }
        [StringLength(10)]
        [Required(ErrorMessage = "Informe o seu CEP")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }
        [StringLength(10)]
        public string Estado { get; set; }
        [StringLength(50)]
        public string Cidade { get; set; }
        [StringLength(25)]
        [Required(ErrorMessage = "Informe o seu telefone")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Informe o email.")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])", 
            ErrorMessage = "O email não possui um formato correto")]
        public string Email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public decimal PedidoTotal { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime PedidoEnviado { get; set; }
    }
}