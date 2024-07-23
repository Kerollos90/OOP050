using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class UserView
    {

        public string name { get; set; }
        public string email { get; set; }










        public static explicit operator UserView(User user)
        {


            string[] names = user?.name?.Split("");
            return new UserView()
            {

                email = user.email,
                name = user.name





            };
        
        
        
        
        
        
        
        
        }





    }
}
