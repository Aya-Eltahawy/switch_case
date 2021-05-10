using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swetsh_shecat
{
    class sheek
    {



        public string number;

        
        public static void dol1 (int n)
        {
switch (n)
            {
                case 1: Console.Write("one "); break;
                case 2: Console.Write("two "); break;
                case 3: Console.Write("three "); break;
                case 4: Console.Write("four "); break;
                case 5: Console.Write("five "); break;
                case 6: Console.Write("six "); break;
                case 7: Console.Write("seven "); break;
                case 8: Console.Write("eight "); break;
                case 9: Console.Write("nine "); break;
               
            }
        }
  
             public static void dol2 (int n)
        {

            switch (n)
            {
                case 10: Console.Write("ten "); break;
                case 11: Console.Write("eleven "); break;
                case 12: Console.Write("twelve "); break;
                case 13: Console.Write("thirteen "); break;
                case 14: Console.Write("fourteen "); break;
                case 15: Console.Write("fiveteen "); break;
                case 16: Console.Write("sixteen "); break;
                case 17: Console.Write("seventeen "); break;
                case 18: Console.Write("eighteen "); break;
                case 19: Console.Write("nineteen "); break;
               

            }
             }
         public static void dol3 (int n)
        {
            switch (n)
            {
                case 2: Console.Write("twety "); break;
                case 3: Console.Write("thirty "); break;
                case 4: Console.Write("fourty "); break;
                case 5: Console.Write("fivety "); break;
                case 6: Console.Write("sixty "); break;
                case 7: Console.Write("seventy "); break;
                case 8: Console.Write("eighty "); break;
                case 9: Console.Write("ninety "); break;
               

            }
         }
       public void les_100(int n)
         {
            
             if (n < 10)
             {
                 dol1(n);

             }
             else if (n < 20)
                 dol2(n);
             else
             {
                 dol3(n / 10);
                 dol1(n % 10);
             }
             
         }
       public void les_1000(int n)
       {

           if (n < 100)
           {
               les_100(n);

           }
           else
           {
               les_100(n / 100);
               Console.Write("hundred ");
               les_100(n % 100);
           }
       }
            public void les_1000000(int n)
       {

           if (n < 1000)
           {
               les_1000(n);

           }
          else
           {
               les_1000(n / 1000);
               Console.Write("thausand ");
               les_1000 (n % 1000);
           }

       }
    }
}
