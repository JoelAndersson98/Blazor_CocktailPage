using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailPage_Library.Models
{
    public class Glass
    {
        public string strGlass { get; set; }
    }

    public class GlassList
    {
        public IEnumerable<Glass> Glasses { get; set; }

        public GlassList()
        {
            Glasses = new HashSet<Glass>();
        }
    }
}
