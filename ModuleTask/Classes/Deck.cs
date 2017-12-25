using System.Collections.Generic;
using ModuleTask.Enums;

namespace ModuleTask.Classes
{
    /// <summary>
    /// Sorted card deck
    /// <param name="CardSuits"> Suit of card </param>
    /// <param name="CardName"> Name of card </param>>
    /// <param name="CardValue"> Card value </param>>
    /// <param name="CardSuits">Card in deck or deal</param>>
    /// </summary>
    public class Deck
    {
        public List<Card> DeckDictionary = new List<Card>()
        {
            //Spade
            new Card { CardSuits = Suits.Spade.ToString(), CardName = Cards.Six.ToString(),   CardValue = 6},
            new Card { CardSuits = Suits.Spade.ToString(), CardName = Cards.Seven.ToString(), CardValue = 7},
            new Card { CardSuits = Suits.Spade.ToString(), CardName = Cards.Eight.ToString(), CardValue = 8},
            new Card { CardSuits = Suits.Spade.ToString(), CardName = Cards.Nine.ToString(),  CardValue = 9},
            new Card { CardSuits = Suits.Spade.ToString(), CardName = Cards.Ten.ToString() ,  CardValue = 10},
            new Card { CardSuits = Suits.Spade.ToString(), CardName = Cards.Jack.ToString(),  CardValue = 2},
            new Card { CardSuits = Suits.Spade.ToString(), CardName = Cards.Queen.ToString(), CardValue = 3},
            new Card { CardSuits = Suits.Spade.ToString(), CardName = Cards.King.ToString(),  CardValue = 4},
            new Card { CardSuits = Suits.Spade.ToString(), CardName = Cards.Ace.ToString(),   CardValue = 11},
            //Club
            new Card { CardSuits = Suits.Club.ToString(), CardName = Cards.Six.ToString(),   CardValue = 6},
            new Card { CardSuits = Suits.Club.ToString(), CardName = Cards.Seven.ToString(), CardValue = 7},
            new Card { CardSuits = Suits.Club.ToString(), CardName = Cards.Eight.ToString(), CardValue = 8},
            new Card { CardSuits = Suits.Club.ToString(), CardName = Cards.Nine.ToString(),  CardValue = 9},
            new Card { CardSuits = Suits.Club.ToString(), CardName = Cards.Ten.ToString() ,  CardValue = 10},
            new Card { CardSuits = Suits.Club.ToString(), CardName = Cards.Jack.ToString(),  CardValue = 2},
            new Card { CardSuits = Suits.Club.ToString(), CardName = Cards.Queen.ToString(), CardValue = 3},
            new Card { CardSuits = Suits.Club.ToString(), CardName = Cards.King.ToString(),  CardValue = 4},
            new Card { CardSuits = Suits.Club.ToString(), CardName = Cards.Ace.ToString(),   CardValue = 11},
            //Diamond
            new Card { CardSuits = Suits.Diamond.ToString(), CardName = Cards.Six.ToString(),   CardValue = 6},
            new Card { CardSuits = Suits.Diamond.ToString(), CardName = Cards.Seven.ToString(), CardValue = 7},
            new Card { CardSuits = Suits.Diamond.ToString(), CardName = Cards.Eight.ToString(), CardValue = 8},
            new Card { CardSuits = Suits.Diamond.ToString(), CardName = Cards.Nine.ToString(),  CardValue = 9},
            new Card { CardSuits = Suits.Diamond.ToString(), CardName = Cards.Ten.ToString() ,  CardValue = 10},
            new Card { CardSuits = Suits.Diamond.ToString(), CardName = Cards.Jack.ToString(),  CardValue = 2},
            new Card { CardSuits = Suits.Diamond.ToString(), CardName = Cards.Queen.ToString(), CardValue = 3},
            new Card { CardSuits = Suits.Diamond.ToString(), CardName = Cards.King.ToString(),  CardValue = 4},
            new Card { CardSuits = Suits.Diamond.ToString(), CardName = Cards.Ace.ToString(),   CardValue = 11},
            //Heart
            new Card { CardSuits = Suits.Heart.ToString(), CardName = Cards.Six.ToString(),   CardValue = 6},
            new Card { CardSuits = Suits.Heart.ToString(), CardName = Cards.Seven.ToString(), CardValue = 7},
            new Card { CardSuits = Suits.Heart.ToString(), CardName = Cards.Eight.ToString(), CardValue = 8},
            new Card { CardSuits = Suits.Heart.ToString(), CardName = Cards.Nine.ToString(),  CardValue = 9},
            new Card { CardSuits = Suits.Heart.ToString(), CardName = Cards.Ten.ToString() ,  CardValue = 10},
            new Card { CardSuits = Suits.Heart.ToString(), CardName = Cards.Jack.ToString(),  CardValue = 2},
            new Card { CardSuits = Suits.Heart.ToString(), CardName = Cards.Queen.ToString(), CardValue = 3},
            new Card { CardSuits = Suits.Heart.ToString(), CardName = Cards.King.ToString(),  CardValue = 4},
            new Card { CardSuits = Suits.Heart.ToString(), CardName = Cards.Ace.ToString(),   CardValue = 11},

        };
        
    }
}
