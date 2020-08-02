using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmRater.ApiModels
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public ICollection<UserModel> Movies { get; set; }
    }
}
