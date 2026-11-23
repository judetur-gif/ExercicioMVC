using System.ComponentModel.DataAnnotations;

namespace ExerciciosMVC.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "O nome é obrigatório")]
        [StringLength (80, MinimumLength = 5, ErrorMessage = "Nome deve conter 5 a 80 caracteres")]
        public string? Nome { get; set; }

        [Required (ErrorMessage = "A descrição é obrigatória")]
        [StringLength (int.MaxValue, MinimumLength = 10, ErrorMessage = "A descrição tem que ter no minimo 10 caracteres")]
        public string? Descricao { get; set; }

        [Required (ErrorMessage = "O local é obrigatório")]
        [StringLength (100, MinimumLength = 3, ErrorMessage = "O Local tem que conter 3 a 100 caracteres")]
        public string? Local  { get; set; }

        [Required (ErrorMessage = "Data do Evento é obrigatório")]
        public DateTime DataEvento { get; set; }

        [Range (1, 1000, ErrorMessage = "A quantidade de vagas tem que estar entre 1 a 1000")]
        public int QuantidadeVagas { get; set; }

        [Range (0, double.MaxValue, ErrorMessage = "O valor do ingresso tem que ser maior ou igual a zero")]
        public decimal ValorIngresso { get; set; }
    }
}