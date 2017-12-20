using System;
using System.Collections.Generic;

namespace ModuleTask.Classes
{
    public  class DeckMix
    {
       
        readonly Random rundom = new Random();
        public  void DeckMixing<TValue>(IList<TValue> dictionary, ref SortedList<int, TValue> SortedDeck)
        {
            foreach (var item in dictionary)
                SortedDeck.Add(rundom.Next(), item);
            
        }
    }
}
