using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcesso.Models
{
    public class Recipe
    {
        #region Properties
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public int GuestNumber { get; set; }
        public string Difficulty { get; set; }
        public double TimePreparation { get; set; }
        public DateTime LastPreparation { get; set; }
        public string Season { get; set; }
        public bool IsSpecial { get; set; }
        public string FamilyGroup { get; set; }

        public int StepIngredientRecipeId { get; set; }
        public int IngredientRecipeId { get; set; }

        public virtual List<StepIngredientRe2cipe> StepIngredientRecipeList { get; set; }
        public virtual List<IngredientRecipe2> IngredientRecipeList { get; set; }
        #endregion
    }
}
