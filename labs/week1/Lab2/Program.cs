using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        const int MAX_SCORE = 100;
        static void Main(string[] args)
        {
            int age = 24;
            Console.WriteLine("My age is {0}", age);
            int score = 50;
            float percent = (float)score / MAX_SCORE;
            Console.WriteLine("Percentage: {0:p}", percent);
            Console.Read();
        }
    }
}
