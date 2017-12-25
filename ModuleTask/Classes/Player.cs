using System.Collections.Generic;
using System.Linq;

namespace ModuleTask.Classes
{
    public sealed class Player
    {
        public Player(string user)
        {
            Name = user;
        }

        //Получил ли первый карту
        public bool Order { get; set; } = false;

        //Имя игрока, ввод не реализовал, задаются при создании экземпляра
        public string Name { get; set; } 

        //Карты на руках у игрока
        public IList<Card> Cards { get; set; } = new List<Card>();

        //записывается текущее количество очков в колоде игрока
        public int Score { get; set; } = default(int);

        //Набрано ли 21 очно, используется для проверок
        public bool PlayerDone { get; private set; }

        //сумма карт в колоде
        public int SumOfCards(IList<Card> cards ) => Score = cards.Sum(x => x.CardValue);   

        //подсчет суммы и проверка на 21    
        public void SumCheck()
        {
            SumOfCards(Cards);
            PlayerDone = Score >= 21;
        }
    }
}
