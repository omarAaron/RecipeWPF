using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredients> Ingredients { get; set; }
        public List<Steps> Steps { get; set; }
    }
}
