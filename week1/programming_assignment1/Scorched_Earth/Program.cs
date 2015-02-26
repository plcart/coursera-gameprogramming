using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorched_Earth
{
    class Program
    {
        const float G = 9.8F;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome new player!");
            Console.WriteLine("This application will calculate the maximum height"+
                "of the shell and the distance it will travel along the ground!");
            Console.Write("Please provide the initial angle in degrees:");
            // convet the value to float and turn into radiuns
            float theta = float.Parse(Console.ReadLine()) * 0.0174532925F;
            Console.Write("Please provide the initial speed:");
            float speed = float.Parse(Console.ReadLine());
            float vox = speed * (float)Math.Cos(theta);
            float voy = speed * (float)Math.Sin(theta);
            float t = voy / G; 	// time until shell reaches apex
            float h = voy * voy / (2 * G);	// height of shell at apex
            float dx = vox * 2 * t;	// distance shell travels horizontally (assuming launch and target elevations are equal)
            Console.WriteLine(string.Format("The height of shell at apex is {0:f3}", h));
            Console.WriteLine(string.Format("The distance travalled by your shell is {0:f3}", dx));
            Console.Read();
        }
    }
}
