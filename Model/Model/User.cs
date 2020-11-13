using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class User
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Gender { get; set; } //enum

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Account Account { get; set; }

        public List<Recipe> ReceitasFavoritas { get; set; }

    }
}
