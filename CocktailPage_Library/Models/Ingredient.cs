using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailPage_Library.Models
{
    public class Ingredient
    {
        public string idIngredient { get; set; }
        public string strIngredient { get; set; }
        public string strDescription { get; set; }
        public string strType { get; set; }
        public string strAlcohol { get; set; }
        public string strABV { get; set; }
    }

    public class IngredientList
    {
        public IEnumerable<Ingredient> Ingredients { get; set; }

        public IngredientList()
        {
            Ingredients = new HashSet<Ingredient>();
        }
    }
}
