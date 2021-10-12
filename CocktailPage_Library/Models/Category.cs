using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailPage_Library.Models
{
    public class Category
    {
        public string strCategory { get; set; }
    }

    public class CategoryList
    {
        public IEnumerable<Category> Categories { get; set; }

        public CategoryList()
        {
            Categories = new HashSet<Category>();
        }
    }
}
