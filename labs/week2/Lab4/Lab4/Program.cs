using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
	/// <summary>
	/// Demonstrates classes and objects
	/// </summary>
    class Program
    {
		/// <summary>
		/// Demonstrates use of Deck and Card objects
		/// </summary>
		/// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            Deck objDesck = new Deck();
            objDesck.Print();

            objDesck.Shuffle();
            objDesck.Print();

            Card TopCard = objDesck.TakeTopCard();

            Console.WriteLine("{0} of {1}", TopCard.Rank, TopCard.Suit);
            Console.Read();

        }
    }
}
