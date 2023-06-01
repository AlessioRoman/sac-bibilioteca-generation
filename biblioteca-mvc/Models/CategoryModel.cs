using biblioteca_mvc.Models;

namespace biblioteca_mvc.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookModel> Books { get; set; }

        public CategoryModel() { }
    }
}
