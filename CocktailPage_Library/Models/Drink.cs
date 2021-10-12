using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailPage_Library.Models
{
    public class Drink
    {
        public string strDrink { get; set; }
        public string strDrinkThumb { get; set; }
        public string idDrink { get; set; }
    }

    public class DrinkList
    {
        public IEnumerable<Drink> Drinks { get; set; }

        public DrinkList()
        {
            Drinks = new HashSet<Drink>();
        }
    }
}
