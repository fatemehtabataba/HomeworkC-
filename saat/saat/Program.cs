using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saat
{
    class time
    {
        private int Hour;
        private int Min;
        public int hour
        {
            get{return Hour;}
            set{Hour=value;}
        }
        public int min
        {
            get{return Min;}
            set{Min=value;}
        }
        public time()
        {}
    public time(int h,int m)
        {
            Hour = h;
            Min = m;
    }
    public void clc()
    {
        if (Hour <= 24 && Min <= 59)
        {
            if (Hour <= 12)
            {
                Console.WriteLine(Hour+":"+ min+"am");
              //  Console.WriteLine(Hour);
                //Console.WriteLine(Min);
            }

            else if (Hour > 12)
            {
                Hour = Hour - 12;
                Console.WriteLine(Hour+":"+ min+"pm");
            }
        }
        else
        {
            Console.WriteLine("eror time not ");
        }
    }
           internal class test
           {
               public static void Main()
               {
                   int hour=Convert.ToInt32(Console.ReadLine());
                   int min=Convert.ToInt32(Console.ReadLine());
                   time t=new time(hour,min);
                   t.clc();
                   Console.ReadKey();
               }
        }
    }
}
