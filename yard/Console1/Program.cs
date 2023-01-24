using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class convert
    {
        private Double Diametr;
        public double diametr
        {
            get { return Diametr; }
            set { Diametr = value; }
        }
        public convert()
          {}
        public convert(Double d)
        {
            Diametr = d;
        }
        public Double conv()
        {
            return Diametr / 1.196;
        }
     internal  class test
        {
            public static void Main()
            {
                string a;
               a=Console.ReadLine();
               double x = Convert.ToDouble(a);
                convert c=new convert(x);
                Double con=c.conv();
                Console.WriteLine(con);
                Console.ReadKey();
            }
        }
    }
}
