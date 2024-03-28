using System.ComponentModel.DataAnnotations;

namespace Frontend.Models.Request
{
    public class CargaRequest
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(100, MinimumLength = 10,
     ErrorMessage = "Nome deve ter no minímo 10 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A informação é obrigatória!!")]
        public bool Peso { get; set;}

        [Required(ErrorMessage = "A informação é obrigatória!!")]
        public bool Largura { get; set; }

        [Required(ErrorMessage = "A informação é obrigatória!!")]
        public bool Altura { get; set; }


        [Required(ErrorMessage = "A informação é obrigatória!!")]
        public bool Distancia { get; set;}


    
    }
}
