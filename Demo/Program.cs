﻿namespace Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {



            #region Operator Overloading
            //Complex C01 = new Complex() { Real = 3, Imag = 5 };
            //Console.WriteLine(C01);


            //Complex C02 = new Complex() { Real = 6, Imag = 8 };
            //Console.WriteLine(C02);

            //Complex C03 = default;
            //C03 = C02 + C01;

            //Console.WriteLine(C03);
            //C03 = C02 - C01;
            //Console.WriteLine(C03);

            //C03 = C03++;
            //Console.WriteLine(C03);




            //if (C03 == C02)
            //    Console.WriteLine(true);
            //else Console.WriteLine(false);


            #endregion

           // Complex C01 = new Complex() { Real = 4, Imag = 8 };
           // int x = (int)C01;
           // Console.WriteLine(C01);
           //Console.WriteLine(x);
           // string s = C01;
           // Console.WriteLine(s);






           // User user = new User()
           // {
           //     id = 1,
           //     name = "Test",
           //     email   = "Test",
           //     password = "Test",
           //     security = Guid.NewGuid()
            
            
            
            
            
            
            
            
            
           // };


           // UserView userView = (userView)user;






            rectangle rectangle = new rectangle();
            rectangle.dim01= 10;
            rectangle.dim02= 20;
            decimal area =rectangle.calarea();
            Console.WriteLine(area);









        }














    }



   
}