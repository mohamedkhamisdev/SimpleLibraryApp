using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Category name must be between 2 and 100 characters")]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        // Navigation property - initialized to avoid null reference
        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}