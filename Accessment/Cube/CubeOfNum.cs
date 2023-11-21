using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessment.Cube
{
    class CubeOfNum
    {
        public void cubeNumber() {
            int num;
            int result;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());         
            result = num * num * num;
            Console.WriteLine($"Cube of {num} is :{result}");

        }
        

        }
        
    }

