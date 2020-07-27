using System;
           
namespace Liczba_Parzysta_nieparzysta
    {
        class Program
        {
            static void Main(string[] args)
            {

                try
                {
                    Console.WriteLine("Podaj dowolną liczbę całkowitą ");
                    var number = int.Parse(Console.ReadLine());

                    if (number % 2 == 0)
                        Console.WriteLine("Liczba parzysta");
                    else
                        Console.WriteLine("Liczba nieparzysta");


                }
                catch (Exception)
                {

                    Console.WriteLine("Błąd .Podane dane nie są liczbą całkowitą");
                }

            }

        }
    }


    