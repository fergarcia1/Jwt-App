using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jwt_App.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() {Username = "pepe", Emailadress = "pepe.admin@gmail.com", Password = "password", GivenName = "Pepe", Surname = "Muji", Role = "Administrator"},
            new UserModel() {Username = "carlos", Emailadress = "calitos@gmail.com", Password = "password", GivenName = "Carlos", Surname = "Maji", Role = "Seller"}
        };
    }
}
