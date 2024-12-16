using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        while (true)
        {
            int wynik = random.Next(1, 7);
            Console.Clear();
            Console.WriteLine("Wynik rzutu kostką: " + wynik);
            Kostka(wynik);
            Console.WriteLine("Wciśnij przycisk aby rzucić ponownie :)");
            Console.ReadKey();
            
        }
    }

    static void Kostka(int number)
    {
        switch (number)
        {
            case 1:
                Console.WriteLine("+-------+");
                Console.WriteLine("|       |");
                Console.WriteLine("|   *   |");
                Console.WriteLine("|       |");
                Console.WriteLine("+-------+");
                break;
            case 2:
                Console.WriteLine("+-------+");
                Console.WriteLine("| *     |");
                Console.WriteLine("|       |");
                Console.WriteLine("|     * |");
                Console.WriteLine("+-------+");
                break;
            case 3:
                Console.WriteLine("+-------+");
                Console.WriteLine("| *     |");
                Console.WriteLine("|   *   |");
                Console.WriteLine("|     * |");
                Console.WriteLine("+-------+");
                break;
            case 4:
                Console.WriteLine("+-------+");
                Console.WriteLine("| *   * |");
                Console.WriteLine("|       |");
                Console.WriteLine("| *   * |");
                Console.WriteLine("+-------+");
                break;
            case 5:
                Console.WriteLine("+-------+");
                Console.WriteLine("| *   * |");
                Console.WriteLine("|   *   |");
                Console.WriteLine("| *   * |");
                Console.WriteLine("+-------+");
                break;
            case 6:
                Console.WriteLine("+-------+");
                Console.WriteLine("| *   * |");
                Console.WriteLine("| *   * |");
                Console.WriteLine("| *   * |");
                Console.WriteLine("+-------+");
                break;
            default:
                Console.WriteLine("Błąd: Niepoprawna liczba.");
                break;
        }
    }
}

