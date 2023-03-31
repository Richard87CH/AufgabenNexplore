using System;
using System.Xml.Serialization;

namespace ConsoleApp
{
    class Program
    {
        // Methode zum Anzeigen einer Fehlermeldung bei ungültiger Eingabe
        static void InvalidInput()
        {
            Console.WriteLine("xxxxxx Ungültige Eingabe xxxxxx\n");
        }

        // Methode zum Anzeigen einer Trennlinie unter den Resultaten, für bessere Übersichtlichkeit
        static void DividingLine()
        {
            Console.WriteLine("----------------------------------------------------------------------------\n");
        }

        // Main-Methode mit dem Hauptmenü
        static void Main(string[] args)
        {
            int choice;
            do
            {
            MainMenu:
                Console.WriteLine("\nMenü:");
                Console.WriteLine("1. Zahlen (addieren, Minimum, Maximum, aufsteigend sortieren)");
                Console.WriteLine("2. Wörter alphabetisch sortieren");
                Console.WriteLine("3. Pyramide bauen");
                Console.WriteLine("0. App schliessen");
                Console.WriteLine("\nBitte die Zahl des gewünschten Menüpunkts eingeben und mit Enter bestätigen:");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
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
                            InvalidInput();
                            break;
                    }
                }
                else
                {
                    InvalidInput();
                    goto MainMenu;
                }
            }
            while (choice != 0);
        }

        // Methode für Untermenü "Zahlen"
        static void Numbers()
        {
            int choice;
            do
            {
            Numbers:
                Console.WriteLine("\n1. Addieren");
                Console.WriteLine("2. Minimum bestimmen");
                Console.WriteLine("3. Maximum bestimmen");
                Console.WriteLine("4. Aufsteigend sortieren");
                Console.WriteLine("0. Zurück");
                Console.WriteLine("\nBitte die Zahl des gewünschten Menüpunkts eingeben und mit Enter bestätigen:");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
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
                            InvalidInput();
                            break;
                    }
                }
                else
                {
                    InvalidInput();
                    goto Numbers;
                }
            }
            while (choice != 0);
        }

        // Methode zum Addieren von zwei Zahlen
        static void Add()
        {
            Console.WriteLine("\nBitte zwei Zahlen eingeben und beide Zahlen jeweils mit Enter bestätigen:");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine('+');
            var num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nSumme: {num1 + num2}");
            DividingLine();
        }

        // Methode zum Finden der kleinsten/grössten von drei Zahlen
        static void FindMinMax(bool FindMin)
        {
            Console.WriteLine("\nBitte drei Zahlen eingeben und jede Zahl mit Enter bestätigen:");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            string caption = "\nMinimum:";
            var extremal = num1;
            if (FindMin)
            {
                if (num2 < extremal)
                    extremal = num2;
                if (num3 < extremal)
                    extremal = num3;
            }
            else
            {
                if (num2 > extremal)
                    extremal = num2;
                if (num3 > extremal)
                    extremal = num3;
                caption = "\nMaximum:";
            }
            Console.WriteLine($"{caption} {extremal}");
            DividingLine();
        }

        // Methode zum aufsteigenden Sortieren von drei Zahlen
        static void Sort()
        {
            Console.WriteLine("\nBitte drei Zahlen eingeben und jede Zahl mit Enter bestätigen:");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            int temp;
            if (num1 > num2) // Vergleich num1 - num2
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            if (num2 > num3) // Vergleich: ursprüngliches num1 - num3
            {
                temp = num2;
                num2 = num3;
                num3 = temp;
            }
            if (num1 > num2) // noch fehlender Vergleich: ursprüngliches num2 - num3
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            Console.WriteLine($"\nAufsteigend sortiert: {num1}, {num2}, {num3}");
            DividingLine();
        }

        // Methode zum alphabetischen Sortieren von drei Wörtern
        static void Words()
        {
            Console.WriteLine("\nBitte drei Wörter eingeben und jedes Wort mit Enter bestätigen:");
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            string word3 = Console.ReadLine();
            List<string> words = new List<string>() { word1, word2, word3 };
            words.Sort();
            Console.Write($"\nNach Alphabet sortiert: {string.Join(", ", words)} ");
            Console.WriteLine();
            DividingLine();
        }

        // Methode zum Anzeigen einer Pyramide bestehend aus 'X' und Leerschlägen
        static void Pyramid()
        {
        Pyramid:
            Console.WriteLine("\nBitte die gewünschte Pyramidenhöhe in Zeilen angeben:");
            //var input = Console.ReadLine();
            if (int.TryParse(Console.ReadLine(), out var height))
            {
                for (int i = 1; i <= height; i++)
                {
                    var air = new string(' ', height - i);
                    var solid = new string('X', i * 2 - 1);
                    Console.WriteLine($"{air}{solid}");                   
                }
                Console.WriteLine();
            }
            else
            {
                InvalidInput();
                goto Pyramid;
            }
        }
    }
}


