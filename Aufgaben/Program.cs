using System;

namespace ConsoleApp
{
    class Program
    {
        // Methode zum Anzeigen einer Trennlinie unter den Resultaten, zur Steigerung der Übersichtlichkeit
        static void Trennlinie()
        {
            Console.WriteLine("----------------------------------------------------------------------------");
        }

        // Main-Methode mit dem Hauptmenü
        static void Main(string[] args)
        {
            int Auswahl;
            do
            {
                Console.WriteLine("\nMenü:");
                Console.WriteLine("1. Zahlen (addieren, Minimum, Maximum, aufsteigend sortieren)");
                Console.WriteLine("2. Wörter alphabetisch sortieren");
                Console.WriteLine("3. Pyramide bauen");
                Console.WriteLine("0. App schliessen");

                Console.WriteLine("\nBitte die Zahl des gewünschten Menüpunkts eingeben und Enter drücken:");
                Auswahl = int.Parse(Console.ReadLine());

                switch (Auswahl)
                {
                    case 1:
                        Numbers();
                        break;
                    case 2:
                        Words();
                        break;
                    case 3:
                        Pyramid();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe!");
                        break;
                }
            } while (Auswahl != 0);
        }

        // Methode für Untermenü "Zahlen"
        static void Numbers()
        {
            int Auswahl;
            do
            {
                Console.WriteLine("\n1. Addieren");
                Console.WriteLine("2. Minimum bestimmen");
                Console.WriteLine("3. Maximum bestimmen");
                Console.WriteLine("4. Aufsteigend sortieren");
                Console.WriteLine("0. Zurück");

                Console.WriteLine("\nBitte die Zahl des gewünschten Menüpunkts eingeben und Enter drücken:");
                Auswahl = int.Parse(Console.ReadLine());

                switch (Auswahl)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        FindMinMax(true);
                        break;
                    case 3:
                        FindMinMax(false);
                        break;
                    case 4:
                        Sort();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe!");
                        break;
                }
            } while (Auswahl != 0);
        }

        // Methode zum Addieren von zwei Zahlen
        static void Add()
        {
            int num1, num2;
            Console.WriteLine("\nBitte zwei Zahlen eingeben und nach beiden Zahlen jeweils Enter drücken:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine('+');
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nSumme: { num1 + num2}");
            Trennlinie();
        }

     

        static void FindMinMax(bool FindMin) 
        {
            int num1, num2, num3;
            Console.WriteLine("\nBitte drei Zahlen eingeben und nach jeder Zahl Enter drücken:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            int extremal = num1;
            string caption = "\nMinimum:";
            if (FindMin)
            {
                if (num2 < extremal)
                    extremal = num2;
                if (num3 < extremal)
                    extremal = num3;
            }
            else
            {
                caption = "\nMaximum:";
                if (num2 > extremal)
                    extremal = num2;
                if (num3 > extremal)
                    extremal = num3;
            }
            Console.WriteLine($"{caption} {extremal}");
            Trennlinie();
        }

       

        // Methode zum aufsteigenden Sortieren von drei Zahlen
        static void Sort()
        {
            int num1, num2, num3;
            Console.WriteLine("\nBitte drei Zahlen eingeben und nach jeder Zahl Enter drücken:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            int temp;
            if (num1 > num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            if (num2 > num3)
            {
                temp = num2;
                num2 = num3;
                num3 = temp;
            }
            if (num1 > num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            Console.WriteLine("\nAufsteigend sortiert: {0}, {1}, {2}", num1, num2, num3);
            Trennlinie();
        }

        // Methode zum alphabetischen Sortieren von drei Wörtern
        static void Words()
        {
            string word1, word2, word3;
            Console.WriteLine("\nBitte drei Wörter eingeben und nach jedem Wort Enter drücken:");
            word1 = Console.ReadLine();
            word2 = Console.ReadLine();
            word3 = Console.ReadLine();
            List<string> words = new List<string>() { word1, word2, word3 };
            words.Sort();
            Console.Write($"\nNach Alphabet sortiert: {string.Join(", ",words)} ");
            
            
         
            
            Console.WriteLine();
            Trennlinie();
        }
        
        // Methode zum Anzeigen einer Pyramide bestehend aus 'X' und Leerschlägen
        static void Pyramid()
        {
            int height;
            Console.WriteLine("\nBitte die gewünschte Pyramidenhöhe in Zeilen angeben:");
            height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < (2 * i + 1); j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
    }
}

