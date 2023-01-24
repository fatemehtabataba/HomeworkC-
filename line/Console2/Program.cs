using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class converter
    {
        private Double X1;
        private Double X2;
        private Double Y1;
        private Double Y2;

        public Double x1 
        {
        get{return X1;}
        set{X1=value;}
        }
        public Double x2
        {
            get{return X2;}
            set{x2=value;}
        }
        public Double y1
        {
            get { return Y1 ; }
            set { Y1 = value; }
        }
        public Double y2
        {
            get { return Y2; }
            set { Y2 = value; }
        }

        public  converter()
          {}
        public   converter(int a, int b, int c, int d)
        {
            X1=a;
            Y1=b;
            X2=c;
            Y2=d;

        }
        public Double calc()
        {
            Double x=Math.Pow(X2-X1,2);
            Double y=Math.Pow(Y2-Y1,2);
            Double javab=Math.Sqrt(x+y);
           
            return javab;
        }
        internal class program
        {
            public static void Main()
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int num3 = Convert.ToInt32(Console.ReadLine());
                int num4 = Convert.ToInt32(Console.ReadLine());
                converter convertt = new converter(num1,num2,num3,num4);
                Double res = convertt.calc();
                Console.WriteLine(res);
                Console.ReadKey();
            }

        }
    }
}
