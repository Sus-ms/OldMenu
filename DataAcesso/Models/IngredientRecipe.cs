using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcesso.Models
{
    public class IngredientRecipe
    {
        public int IngredientRecipeId { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public double Quantity { get; set; }
        public string MeasureUnit { get; set; }
        public double SingleQuantity { get; set; }
        public string IngredientRecipeComment { get; set; }
    }
}
