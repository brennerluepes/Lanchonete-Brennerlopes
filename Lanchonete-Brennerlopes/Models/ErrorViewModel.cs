using LanchoneteMVC.Models;
using System.ComponentModel.DataAnnotations;

Model: Lanche.cs
using System.ComponentModel.DataAnnotations;
namespace LanchoneteMVC.Models
{
    public class Lanche
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Categoria { get; set; }
        [Required]
        [Range(0.01, 1000)]
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
    }
}