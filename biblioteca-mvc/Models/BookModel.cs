using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace biblioteca_mvc.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        [MaxLength(40)]
        [StringLength(100, ErrorMessage = "Il campo titolo può essere lungo al massimo 100 caratteri")]
        public string Name { get; set; }


        public string Isbn { get; set; }
        public string Author { get; set; }

        [Column(TypeName = "text")]
        [Required(ErrorMessage = "Il campo descrizione è obbligatorio!")]
        public string Summary { get; set; }

        [MaxLength(300)]
        [Required(ErrorMessage = "Il campo URL dell'immagine è obbligatorio")]
        [Url(ErrorMessage = "L'URL inserito non è un url valido!")]
        [StringLength(300, ErrorMessage = "Il campo URL immagine può contenere al massimo 300 caratteri")]
        public string ImageUrl { get; set; }

        public string Ebook { get; set; }
        public string Available { get; set; }

        public int? CategoryId { get; set; }
        public CategoryModel Category { get; set; }

        public BookModel()
        {

        }
    }

}
