using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivro.Models
{
    public class EmprestimoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Digita o nome do recebedor!")]
        public string Recebedor { get; set; }
        [Required(ErrorMessage = "Digita o nome do fornecedor!")]
        public string Fornecedor { get; set; }
        public DateTime dataUltimaAtualizacao { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Digita o nome do livro!")]
        public string LivroEmprestado { get; set; }
    }
}
