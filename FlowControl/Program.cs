using System;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            int age; // Ålder för en individ
            int grupp; // Antal personer i gruppen
            //int pris = 0; // Pris för hela gruppen
            bool avsluta = false;
            while (!avsluta)
            {
                Console.Clear();
                Console.WriteLine("H U V U D M E N Y\n");
                Console.WriteLine("1.  Ungdom eller pensionär");
                Console.WriteLine("1a. Grupp, flera biljetter");
                Console.WriteLine("2.  Upprepa 10 gånger");
                Console.WriteLine("3.  Tredje ordet");
                Console.WriteLine("\n0.  Avsluta");

                string menyval = Console.ReadLine();
                switch (menyval)
                {
                    case "0":
                        Console.WriteLine("Avslutar");
                        Console.ReadLine();
                        avsluta = true;
                        break;
                    case "1":
                        // Pris beroende av ålder
                        Console.Clear();
                        Console.Write("Ålder? ");
                        string tmpOlder = Console.ReadLine();
                        bool siffra = Int32.TryParse(tmpOlder, out age);
                        // Console.WriteLine($"Siffra {age}");
                        if (age < 20) Console.WriteLine("Ungdomspris: 80kr");
                        else if (age > 64) Console.WriteLine("Pensionärspris: 90kr");
                        else Console.WriteLine("Standardpris: 120kr");
                        Console.ReadLine();
                        break;
                    case "1a":
                        // Pris för en grupp
                        Console.Clear();
                        Console.Write("Hur många personer (max 10)? ");
                        string tmpAntal = Console.ReadLine();
                        bool tmpGrupp = Int32.TryParse(tmpAntal, out grupp);
                        if (grupp > 1 && grupp <= 10)
                        {
                            int price1 = 0; // Ungdom
                            int price2 = 0; // Pensionär
                            int price3 = 0; // standard
                            int oldr;
                            for (int i = 0; i < grupp; i++)
                            {
                                Console.Write($"Ålder på person {i + 1}: ");
                                string tmpOld = Console.ReadLine();
                                bool tmpPrice = Int32.TryParse(tmpOld, out oldr);
                                if (oldr < 20) price1++;
                                if (oldr > 64) price2++;
                                if (oldr >= 20 && oldr <=64) price3++;
                            }
                            Console.WriteLine($"\nAntal personer: {grupp}");
                            Console.WriteLine($"Totalkostnad {price1*80 + price2*90 + price3*120}");

                            Console.WriteLine($"\n(Ungdom: {price1}, Standard: {price3}, Pensionär: {price2})");
                        }
                        //  else if (age > 64) Console.WriteLine("Pensionärspris: 90kr");
                        else Console.WriteLine("Standardpris: 120kr");
                        Console.ReadLine();
                        break;
                    case "2":
                        // Upprepa texten 10 gånger
                        Console.Clear();
                        Console.WriteLine("Skriv en text: ");
                        string inputText = Console.ReadLine();
                        Console.Clear();
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write($"{i+1}. {inputText}, ");
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Skriv en mening med minst tre ord: ");
                        string tmpTre = Console.ReadLine();
                        string[] tredje = tmpTre.Split(" ");
                        if (tredje.Length > 2) // För få ord
                        {
                            Console.WriteLine($"Tredje ordet i meningen \"{tmpTre}\" är:\n{tredje[2]}");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Jaha, du har svårt med antalet tre.");
                            Console.ReadLine();
                            break;
                        }
                    default:
                        Console.WriteLine("Felaktigt val, försök igen.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}

