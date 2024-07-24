using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_5
{
    internal class user
    {
        public int id { get; set; }
        public string? fullname { get; set; }
        public string? email { get; set; }  
        public string? password { get; set; }
        public Guid securitystamp { get; set; }
    }
}
