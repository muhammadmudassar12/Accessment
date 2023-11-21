using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessment.PrimeNumber
{
    class Prime
    {
        public void findPrimeNum()
        {
            int a = 0;
            int num = 4;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine(" is a Prime Number", num);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }

            //bool isPrime = true;
            //Console.WriteLine("Prime Numbers : ");
            //for (int i = 2; i <= 50; i++)
            //{
            //    for (int j = 2; j <= i; j++)
            //    {

            //        if (i != j && i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }

            //    }
            //    if (isPrime)
            //    {
            //        Console.Write(i + "\t");
            //    }
            //    isPrime = true;
            // }

        }
    }
}
