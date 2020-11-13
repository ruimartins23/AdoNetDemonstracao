using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Recipe
    {
        public string Title { get; set; }
        public string Category { get; set; } // enum
        public TimeSpan Time { get; set; }
        public string Dificulty { get; set; } //enum
        public string Rating { get; set; }
        public string Description { get; set; }
        public bool IsValidated { get; set; }
        public string User { get; set; }
        public Comment Comment { get; set; }
        public string Ingredientes { get; set; }
        public List<Ingrediente> Ingredients { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
