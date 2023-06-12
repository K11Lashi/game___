using game_practice;
using System;
using System.Threading;

namespace TekstQuest
{
    class Program
    {


        static void Main(string[] args)

        {
            Player player = new Player("гг", 10, 100);
            Spider spider = new Spider("паук", 20, 500);
      

            Console.WriteLine("Игра началась!");

            Console.WriteLine("Выберите свой класс: напишите Воин или Маг в консоли");

            string CharClass = Console.ReadLine();

            char LocalselectorYN;

            int Gold = 0;

            string LocalStringSelector;

            string crossroad;

            while (CharClass != "Воин" && CharClass != "Маг")
            {
                Console.WriteLine("Вы не выбрали допустимый класс! Пробовать снова");

                Console.WriteLine("Выберите свой класс: напишите Воин или Маг в консоли");

                CharClass = Console.ReadLine();

            }

            if (CharClass == "Воин")
            {
                Console.WriteLine("Вы выбрали война");
            }
            else
            {
                Console.WriteLine("Вы выбрали мага");
            }

            Console.WriteLine("Ваше приключение начинается!");
            Console.WriteLine("На вас набросился гигантский паук");
            Console.ForegroundColor = ConsoleColor.White;

            int choise = Convert.ToInt32(Console.ReadLine());

            switch (choise)
            {

                case 1:
                    Battle_Spider();
                    break;

            }

            void Battle_Spider()
            { 

                if (player.Health > 0)

            {
                Console.WriteLine($"Вы начали битву с Пауком");
                while (player.Health > 0 && spider.Health > 0)
                {

                    Console.WriteLine($"ВЫ бьете оставляя Пауку {spider.Health -= player.Damage} здоровья");
                    Console.WriteLine($"Паук бьет оставляя вам {player.Health -= spider.Damage} здоровья");
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Вы победили");
                Console.ForegroundColor = ConsoleColor.White;
                spider.Health += 500;
            }
            else if (player.Health <= 0)
            {
                Console.WriteLine("вы погибли");
            }


        }

            Console.WriteLine("Вы видите пещеру в густом лесу. Вы хотите исследовать его?(Нажмите клавишу для выбора:Н/N)");

                LocalselectorYN = Console.ReadKey(true).KeyChar;

                if (LocalselectorYN == 'н' || LocalselectorYN == 'Н')
                {
                    Console.WriteLine("Ты будешь исследовать пещеру.");



                    Thread.Sleep(1500);

                    Console.WriteLine("Вы можете исследовать пещеру, где нашли 3 золотые монеты!");

                    Gold = Gold + 3;
                }
                else
                {
                    Console.WriteLine("Вы не видите в этом интереса.");
                }

                Console.WriteLine("\r\nВы видите перекресток, куда хотите пойти?");
                Console.WriteLine("Вы видите перекресток, гдt вы хотите перейти /влево, /вправо, / вперед для выбора");
                LocalStringSelector = Console.ReadLine();


                switch (LocalStringSelector)
                {
                    case "вправо":
                        {
                            Console.WriteLine("Вы идете направо и видите деревенские равнины, тут много тех, кому нужна помощь");
                            crossroad = "право";
                            break;
                        }
                    case "влево":
                        {
                            Console.WriteLine("Ты видишь глубокое море, в его бездне и просторе вы видете свое будущее");
                            crossroad = "лево";
                            break;
                        }
                    case "вперед":
                        {
                            Console.WriteLine("Вы видите большой город, вы понимаете что вас ждет много приключений");
                            crossroad = "вперед";
                            break;
                        }

                }
            Thread.Sleep(1500);
            Console.WriteLine("тут очень пафосно появляется логотип игры и да, но игры еще нет, goodluck!");
                Console.ReadKey();

            }
        }
    }
