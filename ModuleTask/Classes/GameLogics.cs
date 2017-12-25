using System;
using System.Collections.Generic;
using System.Linq;
using ModuleTask.Classes.Parsers;
using static System.Console;

namespace ModuleTask.Classes
{
    public sealed class GameLogics
    {
        private readonly Player player;
        private readonly Player computer;
        private readonly Deck cardDeck = new Deck();
        private readonly DeckMix deckMix = new DeckMix();
        private readonly SortedList<int, Card> sortedDeck = new SortedList<int, Card>();
        //остановка игры
        private bool done;
        private bool useParser;
        
        public GameLogics()
        {
            player = new Player("player");
            computer = new Player("Computer");
            //Тасуется колода
            deckMix.MixingDeck(cardDeck.DeckDictionary, sortedDeck);
        }

        //Перегруженык конструктор, с возможностью задать использовать ли парсер
        public GameLogics(bool use)
        {
            player = new Player("player");
            computer = new Player("Computer");
            useParser = use;
            //Тасуется колода
            deckMix.MixingDeck(cardDeck.DeckDictionary, sortedDeck);
        }

        //Основно метод данного класса, запуск игры
        public void StartGame()
        {
            WhoReciveCardFirst();

            if (player.Order)
            {
                GetCardWithCheck(player, computer, amount: 2);
                GetCardWithCheck(computer, player, amount: 2);
            }
            else
            {
                //if computer first dail card
                GetCardWithCheck(computer, player, amount: 2);
                GetCardWithCheck(player, computer, amount: 2);
            }
          
            Game();
        }

        //запрос, кто получает первым карту
        private void WhoReciveCardFirst()
        {
            WriteLine("Who receives first cards? Select. If Computer write - pc, if User - ur:");
            var select = ReadLine();
            if (!String.IsNullOrWhiteSpace(select))
            {
                if (select.Length != 2 && (select != "pc" || select != "ur"))
                {
                    WriteLine("Invalid input");
                    computer.Order = true; //default if error 
                    return;
                }

                if (select == "pc")
                {
                    computer.Order = true;
                    Clear();
                    WriteLine($"{computer.Name} receives first cards dail.");
                    return;
                }
                player.Order = true;
                Clear();
                WriteLine($"{player.Name} receives first cards dail.");
                return;
            }

            WriteLine("Invalid input");
        }

        //повторы выдачи карт с проверками
        private void Game()
        {
            while (!done)
            {
                NewTurn();
                if (!done)
                    continue;
                Game();
            }
        }

        //Выдача карт с колоды
        private void DailCard(Player player, int amount = 1)
        {
            for (var i = 1; i <= amount; i++)
            {
                player.Cards.Add(sortedDeck.First().Value);
                sortedDeck.RemoveAt(0);
            }
        }

        //новый ход игры
        private void NewTurn()
        {
            if (player.Order)
            {
                GetCardWithCheck(player, computer);
                GetCardWithCheck(computer, player);
                return;
            }

            //if computer first dail card
            GetCardWithCheck(computer, player);

            if (done)
               return;

            GetCardWithCheck(player, computer);
        }

        //Проверки на 21 и т.п
        private void CheckCard(Player player1, Player player2)
        {
            player1.SumCheck();
            if (player1.PlayerDone && !player1.Order)
            {
                CardView(player1, useParser);
                EndGame(player1);
                done = true;
                return;
            }

            if (player1.PlayerDone && player1.Order)
            {
                CardView(player1, useParser);
                ReadLine();
                DailCard(player2);
                player2.SumCheck();
                CardView(player2, useParser);
                done = true;

                if (player1.Score > player2.Score)
                {
                    EndGame(player1);
                    return;
                }

                if (player1.Score < player2.Score)
                {
                    EndGame(player2);
                    return;
                }
                EndGame();
                return;
            }

            if (player1 == player)
                CardView(player1, useParser);
            else
            {
                return;
            }

            ReadKey();
        }

        //Вывод результатов с парсером, по умолчанию с парсером
        private void CardView(Player player, bool useParser = true)
        {
            if (useParser)
            {
                CardViewWithParser(player);
                return;
            }
                CardViewWithoutParser(player);
            
        }

        //Вывод результатов с парсером, акуратно в таблице
        private void CardViewWithParser(Player player)
        {
            WriteLine("\n" + "Name " + player.Name + "\n" +
                      player.Cards.ToStringTable(new[] { "Card", "Value" }, card => card.CardName,
                          card => card.CardValue) + "Score:\t   " + player.Score + "      \nGo first:  " + player.Order);
        }

        //Вывод результата без парсера
        private void CardViewWithoutParser(Player player)
        {
            WriteLine($"\nPlayer: {player.Name}");
            foreach (var card in player.Cards)
            {
                WriteLine($"Suit: {card.CardName}, Value:{card.CardValue}");
            }
            WriteLine($"Went first: {player.Order}\nNumber of points: {player.Score}");
        }

        //Метод вывода сообщения об выиграше
        private void EndGame(Player player) => WriteLine($"The game was won by {player.Name}, who first get score {player.Score} points");

        //перегруженый, выводио сообщение о ничье
        private void EndGame() => WriteLine("Players have an equal number of points. This is a draw!");

        //Повторяемая  сдача карты и проверка 
        private void GetCardWithCheck(Player player1, Player player2, int amount = 1)
        {
            DailCard(player1, amount);
            CheckCard(player1, player2);
        }
    }
}
