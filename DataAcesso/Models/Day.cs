using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcesso.Models
{
    public class Day
    {
        public DateTime Date { get; set; }
        public virtual List<Recipe> RecipeList { get; set; }
    }
}
