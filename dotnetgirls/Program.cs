using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetGirlsTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1-task
            // Console.WriteLine("Hello world");
            // Console.ReadKey();


            //2-task
            /*string n;
              n=Convert.ToString(Console.ReadLine());
             Console.WriteLine("Salom " +n+"Siz bilan tanishganimdan hursandman");
              Console.ReadKey();*/




            //3-Task
            /* int  x;
               Console.WriteLine("Hello! Please enter your name.");
               x= Convert.ToInt32(Console.ReadLine());

               if ( x==9||  x==7)
               {
                   Console.WriteLine("Hello there, ");
               }

                else
               {
                   Console.WriteLine( "sorry don't know you haha");
               }
             Console.ReadKey();*/



            //Task-4
            /* int i, n, sum = 0;
             Console.WriteLine("Enter the value of n :");

             n = Convert.ToInt32(Console.ReadLine());



             for (i = 1; i <= n; i++)
             {
                 sum += i;

             }

             Console.WriteLine("Total sum: " + sum);
             Console.ReadKey();*/


            //Task-5

            /* int i, n, sum=0;
              Console.WriteLine("Enter the value of n:");
              n=Convert.ToInt32(Console.ReadLine());  
              for(i=1; i <= n; i++)
              {
                  if((n % 3==0) || (n % 5==0))
                         {
                      sum += i;
                  }
                  else {
                      Console.WriteLine("Bunday natija yo'q");

                  }
              }
              Console.ReadKey();  */



            //Task-6
            /* int i, n, sum = 0, sum2 = 1; ;
             n=Convert.ToInt32(Console.ReadLine());  
             for(i = 1; i <= n; i++)
             {
                 sum += i;
                 sum2 *= i;

             }
             Console.WriteLine("1 dan siz kiritgan singacha bo'lgan raqamlar yig'indisi:"+"    "+sum);
             Console.WriteLine("1 dan siz kiritgan singacha bo'lgan raqamlar ko'paytmasi:"+"    "+sum2);
             Console.ReadKey();*/



            //Task-7

            /*Console.WriteLine(" Multiplication Tables");
            for (int i = 2; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.WriteLine("{0}*{1}={2}", i, j, i * j);
                }
                Console.ReadLine();
                Console.ReadKey();*/




            //Task-8
            /* int n;
             Console.WriteLine("tub sonlari kiriting=");
             n=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("n gacha bo'lgan tub sonlar");
             for(int i=2; i<=n; i++)
             {
                 bool tub = true;
                 for (int j = 2; j <= Math.Sqrt(i); j++)
                 {
                     if (i % j == 0)
                     {
                         tub = false;
                         break;
                     }
                 }
                 if (tub == true)
                     Console.WriteLine(i);

             }
             Console.ReadKey();*/


            //Task-9

            /*  int n;
              int b;
              n = 78 - b;
              if (n == 0) Console.WriteLine("To'g'ri topdingiz");
              else
              {
                  if (-5 < n < 5) Console.WriteLine("Yaqinlashdingiz");
              }
                else
              {
                  if (-15 < n < 15) Console.WriteLine("yaqin");
                  else
                  {
                      Console.WriteLine("");
                  }
              }*/








            //Task-10

            /*int yil = 2022;
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine(yil);
                yil = yil + 4;
            }
            Console.ReadKey();*/



            //Task-11

        }
    }
}

