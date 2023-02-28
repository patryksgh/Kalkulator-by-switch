namespace Kalkulatorek
{
    using System;

    class Program
    {
        static void Main()
        {
           
            Console.WriteLine("Kalkulator");
            odNowa:
            Console.Clear();
            Console.WriteLine("Podaj pierwszą liczbę:");
            double liczba1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            double liczba2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Wybierz:");
            wybieranie:
            Console.WriteLine("1. żeby dodać");
            Console.WriteLine("2. żeby odjąć");
            Console.WriteLine("3. żeby pomnożyć");
            Console.WriteLine("4. żeby podzielić");
            int operacja = int.Parse(Console.ReadLine());
          
            switch (operacja)
            {
                case 1:
                    Console.WriteLine("{0} + {1} = {2}", liczba1, liczba2, liczba1 + liczba2);
                    break;
                case 2:
                    Console.WriteLine("{0} - {1} = {2}", liczba1, liczba2, liczba1 - liczba2);
                    break;
                case 3:
                    Console.WriteLine("{0} * {1} = {2}", liczba1, liczba2, liczba1 * liczba2);
                    break;
                case 4:
                    if (liczba2 != 0)
                    {
                        Console.WriteLine("{0} / {1} = {2}", liczba1, liczba2, liczba1 / liczba2);
                    }
                    else
                    {
                        Console.WriteLine("Nie można dzielić przez zero!");
                    }
                    break;
                default:
                    Console.WriteLine("Nieznana operacja!");
                    goto wybieranie;
            }
            
            Console.WriteLine("Naciścnij 1 żeby wykonać kolejną operacje lub 2 żeby wyjść");
            int odNowa = int.Parse(Console.ReadLine());
            if (odNowa != 2)
                {
                    goto odNowa;
                }
            else
            Console.Clear();
            {  
                Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć");
            }   
        }
    }
}