//Kajetan Komsta nr indeksu 18105
//Napisany program w dosyć prosty sposób oblicza pola i obwody takich figur jak: kwadrat, prostokat, trojkat, kolo.
//Program posiada menu, odporne na wpisanie niewlasciwej wartosci, a do do kazdego przypadku switcha przypisano oddzielne metody.
//Ostatni punkt switcha daje wyjscie z programu.
using System;
namespace Lab1_ZMPO
{
    class Program
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Oblicz:\n1. Pole trojkata\n2. Obwod trojkata\n3. Pole kwadratu\n4. Obwod kwadratu\n5. Pole prostokata\n6. Obwod prostokata\n7. Pole kola\n8. Obwod kola\n9. Wyjdz ");
        }
        public static void PolTroj()
        {
            Console.Write("Wprowadz dlugosc podstawy:");
            double pod = Convert.ToDouble(Console.ReadLine());
            Console.Write("Wprowadz wysokosc:");
            double wys = Convert.ToDouble(Console.ReadLine());

            double pole = (pod * wys) / 2;
            Console.Write("Pole trojkata wynosi = " + pole+"\n");
            Console.ReadKey();
        }
        public static void obwTroj()
        {
            Console.Write("Podaj dlugosc pierwszego boku : ");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj dlugosc drugiego boku : ");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj dlugosc trzeciego boku: ");
            double d3 = Convert.ToDouble(Console.ReadLine());
            double obw = d1+d2+d3;
            Console.Write("Obwod trojkatawynosi " + obw);
            Console.ReadLine();
        }
        public static void polkwa()
        {
                Console.WriteLine("Podaj bok kwadratu ");
                int bok = Convert.ToInt32(Console.ReadLine());
                int pole = bok * bok;
                Console.WriteLine($"Pole o boku {bok} wynosi {pole}");
                Console.ReadKey();   
        }
        public static void obwkwa()
        {
            Console.Write("Wprowadz dlugosc boku : ");
            decimal bok = Convert.ToDecimal(Console.ReadLine());
            decimal obwod = 4 * bok;
            Console.Write("Obwod kwadratu wynosi : " + obwod);
            Console.ReadLine();
        }
        public static void polpros()
        {
            Console.WriteLine("Podaj dlugosc prostokata: ");
            int dl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj szerokosc prostokata: ");
            int sz = Convert.ToInt32(Console.ReadLine());
            int pole = dl * sz;
            Console.WriteLine($"Pole o dlugosci {dl} i szerokosci {sz} wynosi {pole}");
            Console.ReadKey();
        }
        public static void obwpros()
        {
            Console.Write("Podaj dlugosc prostokata : ");
            decimal dl = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Podaj szerokosc prostokata : ");
            decimal sz = Convert.ToDecimal(Console.ReadLine());
            decimal obw = 2 * (dl + sz);
            Console.Write("Obwod prostokata wynosi: " + obw);
            Console.ReadLine();
        }
        public static void polekola()
        {
            Console.Write("Podaj promien: ");
            double promien = Convert.ToDouble(Console.ReadLine());
            double pole = Math.PI * promien * promien;
            Console.WriteLine("Pole kola wynosi: " + pole);
            Console.ReadKey();
        }
        public static void obwkola()
        {
            Console.Write("Podaj promien: ");
            double promien = Convert.ToDouble(Console.ReadLine());
            double obw = Math.PI * promien * 2;
            Console.WriteLine("Obwod kola wynosi: " + obw);
            Console.ReadKey();
        }
        public static void Main()
        {
            bool ok = false;
            do
            {
                PrintMenu();
                int wybor;
                while (!int.TryParse(Console.ReadLine(), out wybor) || wybor < 1 || wybor > 9)
                {
                    Console.WriteLine("Niepoprawna wartość, wprowadz wartosc numeryczna od 1 do 8");
                    PrintMenu();

                }
                switch (wybor)
                {
                    case 1:
                        PolTroj();
                        break;
                    case 2:
                        obwTroj();
                        break;
                    case 3:
                        polkwa();
                        break;
                    case 4:
                        obwkwa();
                        break;
                    case 5:
                        polpros();
                        break;
                    case 6:
                        obwpros();
                        break;
                    case 7:
                        polekola();
                        break;
                    case 8:
                        obwkola();
                        break;
                    case 9:
                        ok = true;
                        break;
                }
            } while (!ok);
        }
    }
}