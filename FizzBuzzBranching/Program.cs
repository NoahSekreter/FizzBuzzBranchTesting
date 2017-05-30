using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    result += "Fizz";
                }
                if(i % 5 == 0)
                {
                    result += "Buzz";
                }
                Console.WriteLine(i + " : " + result);
                result = "";
            }
        }
    }
}
