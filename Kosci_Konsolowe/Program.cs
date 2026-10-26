using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        int i = 1;      
        while (i < 3 || i > 10)
            {
                Console.WriteLine("Ile Kostek chcesz rzucić?(3-10)");
                i = Convert.ToInt32(Console.ReadLine());
            }
        losowanie(i);




    }
    static void losowanie(int i)
    {
        int[] tab = new int[i];
        Random random = new Random();
        int liczba;
        for (int j = 0; j < i; j++)
        {
            liczba = random.Next(1, 6);
            Console.WriteLine("Kostka " + (j + 1) + ": " + liczba);
            
           
            tab[j] = liczba;
        }

       Punkty(tab);


    }
    static void Punkty(int[] tab)
    {
        int suma = 0;
        int[] cyfry = {0, 0, 0, 0, 0, 0};
        for(int i = 0; i < tab.Length; i++)
        {
            cyfry[tab[i] - 1]++;
        }
        for(int i = 0; i < cyfry.Length; i++)
        {
            if (cyfry[i] > 1)
            {
                suma += (i + 1) * cyfry[i];
            }
        }
        Console.WriteLine("Suma punktów: " + suma);
        Console.WriteLine("Jeszcze raz? (t/n)");
        string odp = Console.ReadLine();
        if(odp != null)
        {
            if(odp.ToLower() == "t")
            {
                int i = cyfry.Length;
                
                losowanie(i);
            }
            else
            {
                Console.WriteLine("Dziękuję za grę!");
            }
        }


    }
}