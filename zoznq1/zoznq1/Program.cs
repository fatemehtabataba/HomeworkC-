using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoznq1
{
    class test
    {
        private Double a;
        private Double b;
        private Double h;
        public Double A
        {
            get { return a; }
            set { a = value; }
        }
         public Double B
        {
            get { return b; }
            set { b = value; }
        }
         public Double H
        {
            get { return h; }
            set { h = value; }
        }
        public test()
        {}
        public test(Double A,Double B,Double H)
        {
            a = A;
            b = B;
            h = H;
        }
        public Double clc()
        {
            return (a + b) * 2 / 2;
        }
        class program
        {
            public static void Main()
            {
                test t = new test();

                 Double a= Convert.ToDouble(Console.ReadLine());
                 Double b= Convert.ToDouble(Console.ReadLine());
                 Double h= Convert.ToDouble(Console.ReadLine());
              Double res= t.clc();
                Console.WriteLine(t.clc());
                Console.ReadKey();

            }
        }
    }
}
