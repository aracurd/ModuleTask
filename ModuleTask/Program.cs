using System.Collections.Generic;
using ModuleTask.Classes;
using static System.Console;

namespace ModuleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var mix = new DeckMix();
            var i = 0;
            var deck = new Deck();
            SortedList<int, Card> sortedDeck = new SortedList<int, Card>();
            foreach (var item in deck.DeckDictionary)
            {
                i++;
               
                    WriteLine($"{item.CardSuits} {item.CardName} \t{item.CardValue}");
                if (i==13)
                {
                    WriteLine();
                    i = 0;
                }

            }

            mix.DeckMixing(deck.DeckDictionary, ref sortedDeck);
            ReadLine();

            foreach (var item in sortedDeck)
            {

                i++;

                WriteLine($"{item.Value.CardSuits} {item.Value.CardName} \t{item.Value.CardValue}");
                if (i == 13)
                {
                    WriteLine();
                    i = 0;
                }
            }

            ReadLine();
        }
    }
}
