using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessment.Arrays
{
    class ConvertArray
    {
        public void stringConversation()
        {



            object[] array = new object[] { 10, "hello", 5, "world", 12.3 };
            string[] stringarray = new string[5];

            for (int i = 0; i <= array.Length - 1; i++)
            {
                stringarray[i] += Convert.ToString(array[i]);

                Console.Write($"\"{stringarray[i]}\"  ");
            }          
        }
    }
}

    
       

