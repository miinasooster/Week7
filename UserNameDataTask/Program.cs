using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada oma eesnimi
            //programm küsib kasutajal sisestada numbrid 1-3
            //kui kasutaja sisestab 1 - kuvab programm kasutaja eesnime tagurpidi
            //kui kasutaja sisestab 2 - kuvab programm kasutaja eesnime esimest tähte
            //kui kasutaja sisestab 3 - kuvab programm kasutaja eesnime pikkust

            //1,2,3 punktid teostada funktsioonide abil.

            Console.WriteLine("Palun, sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Palun, sisesta number 1-3:");
            char userChoice = Convert.ToChar(Console.ReadLine());

            switch (userChoice)
            {
                case '1': // eesnimi tagurpidi
                    ReverseName(userName);
                    break;

                case '2': //eesnime esimene täht
                    FirstLetter(userName);
                    break;

                case '3': //eesnime pikkus
                    Counter(userName);
                    break;

                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }

        }
        public static void FirstLetter(string userInput)
        {
            Console.WriteLine($"sinu eesnime esimene täht on {userInput[0]}.");
        }

        public static void ReverseName(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
        public static void Counter(string userInput)
        {
            Console.WriteLine($"sinu nimi on {userInput.Length} tähte pikk.");
        }

    }
    
}
