using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_5
{
    internal class userviewmodel
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? email { get; set; }

        public static explicit operator userviewmodel(user User)
        {
            string[]? names = User?.fullname.Split("");
            return new userviewmodel()
                (
                email = User?.email,
                firstname =names ?.Length> 0 ?  names[0] : String.Empty,
                lastname = names?.Length > 1 ? names[1] : String.Empty
                );



        }

    }   
}