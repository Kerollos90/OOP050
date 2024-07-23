using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Complex
    {

        public int Real { get; set; }
        public int Imag { get; set; }
        public override string ToString()
        {
            return $"{Real}+{Imag}i";
        }

        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0)


            };



        }
        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0)


            };



        }




        public static Complex operator --(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) - 1,
                Imag = c?.Imag ?? 0


            };



        }


        public static Complex operator ++(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) + 1,
                Imag = c?.Imag ?? 0


            };



        }




        public static bool operator >(Complex Left, Complex Right)
        {
            if (Left == Right) return Left.Imag > Right.Real;
            else return Right.Real > Left.Imag;






        }

        public static bool operator <(Complex Left, Complex Right)
        {
            if (Left == Right) return Left.Imag < Right.Real;
            else return Right.Real < Left.Imag;






        }


        public static  explicit operator int (Complex c)
        {

            return c?.Real ?? 0;
            
        }


        public static implicit operator string?(Complex c)
        {

            return c?.ToString();

        }






















    }
}
