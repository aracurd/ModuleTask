using System;
using System.Collections.Generic;

namespace ModuleTask.Classes
{
    /// <summary>
    /// The class that performs the function of mixing decks
    /// </summary>
    public class DeckMix
    {
        private readonly Random random = new Random();
        /// <summary>
        /// Function thet mixing a decks
        /// </summary>
        /// <param name="dictionary">Starting sorted deck</param>
        /// <param name="sortedDeck">Returned mixed deck</param>
        public void MixingDeck<TValue>(IList<TValue> dictionary, SortedList<int, TValue> sortedDeck)
        {
            foreach (var item in dictionary)
                sortedDeck.Add(random.Next(), item);            
        }
    }
}
