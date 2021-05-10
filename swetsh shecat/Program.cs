using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swetsh_shecat
{
    class Program
    {
        static void Main(string[] args)
        {
            sheek aya = new sheek();

            string number = Console.ReadLine();
            int n = int.Parse(number);
            
            if(n<100)
            aya.les_100(n);
            else if(n<1000)
            aya.les_1000(n);
            else
            aya.les_1000000(n);
            
            Console.ReadKey();
        }
            
            
           
        }
    }

