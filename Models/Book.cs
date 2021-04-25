using System;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Book
    {
        public Book()
        {
            Id = Guid.NewGuid();

        }
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int Stock { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

}