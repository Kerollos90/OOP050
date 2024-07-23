using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal abstract class Shape
    {

        public decimal dim01 { get; set; }
        public decimal dim02 { get; set; }


        public abstract decimal calarea();

        public abstract decimal Perimeter { get; }


    }



    class rectangle : Shape
    {
        public override decimal calarea()
        {
           return dim01*dim02;
        }

        public override decimal Perimeter
        {
            get { return (dim01 + dim02) * 2; }
           
        }
    }

    class square : Shape
    {
        public override decimal calarea()
        {
             dim01 = dim02 = dim;
        }

        public override decimal Perimeter
        {
            get { return (dim01 + dim02) * 2; }

        }
    }







}
