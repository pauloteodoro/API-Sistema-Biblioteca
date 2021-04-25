using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Category
    {
        public Category()
        {
            Id = Guid.NewGuid();
            Book = new List<Book>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Name { get; set; }

        public virtual List<Book> Book { get; set; }
    }
}