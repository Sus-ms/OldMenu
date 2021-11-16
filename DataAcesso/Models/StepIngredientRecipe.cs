using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcesso.Models
{
    public class StepIngredientRecipe
    {
        public int StepIngredientRecipeId { get; set; }
        public int IngredientRecipeId { get; set; }
        public int StepId { get; set; }
        public int Order { get; set; }
        public string Length { get; set; }
        public string StepIngredientRecipeComment { get; set; }
    }
}
