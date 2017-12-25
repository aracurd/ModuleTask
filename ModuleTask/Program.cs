using ModuleTask.Classes;
using static System.Console;

namespace ModuleTask
{
    sealed class Program
    {
        static bool play = true;

        static void Main(string[] args)
        {
            while (play)
            {
                //Конструктор с созможностью ваыбора, использовать ли парсер
                //Чтобы выводилось без парсера измените "use" на false или удалите параметр
                var gLogic = new GameLogics(use:true);
                Title = "Blackjack";

                StartMessage();

                var val = ReadLine();

                if (val == "y") 
                {
                    Clear();
                    gLogic.StartGame();
                    RptGame();
                    Clear();
                }
                else
                {
                    play = false;
                    return;
                }
            }
        }

        public static void StartMessage()
        {
            WriteLine($"Hallo in {Title}");
            WriteLine($"Short rules of {Title}:");
            WriteLine($"There are 36 cards in the deck. \nHigh card points: Jack - 2, Queen - 3, King - 4, Ace - 11. \nThe other cards according to their values.\n");
            WriteLine("You wont to play? \"y\" - to play, \"n\" - to exit:");
        }

        public static void RptGame()
        {
            WriteLine("\nWant to play more? Enter: Play - y, Close -n");
            var rptVal = ReadLine();
            if (rptVal == "n")
                play = false;
        }
    }
}
