using System.ComponentModel.DataAnnotations;

namespace testeEf.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        // Validações do Title e do Description
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres!")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres!")]

        public string Title { get; set; }

        // Validação do Description
        [MaxLength(1024, ErrorMessage = "Este campo deve conter no máximo 1024 caracteres!")]

        public string Description { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero!")]

        public decimal Price { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria inválida!")]

        public int CategoryId { get; set; } // Essa linha referencia a categoria no banco por meio de seu ID
        public Category Category { get; set; }
    }
}