namespace biblioteca_mvc.Models
{
    public class BookCategoryForm
    {
        public BookModel Books { get; set; }
        public List<CategoryModel> Categories { get; set; }

        public BookCategoryForm() { }
    }
}
