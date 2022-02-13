using System;

namespace KasaSklepowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                PrintMenu();
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA WSZYSTKICH ZAKUPÓW");
            Console.WriteLine("2 => ZAKUPY");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3:");
            string w = System.Console.ReadLine();
            HandleChoice(w);
        }

        static void HandleChoice(string w)
        {
            if (w == "1")
            {
                Console.Clear();
                ShopService service = new ShopService();
                foreach (var p in service.Warehouse)

                Console.WriteLine($"{p.Name}  Cena netto: {p.NettoPrice}  zł    Cena brutto: {p.BruttoPrice} zł");
            }
            else if (w == "2")
            {
                //Console.Clear();
                Paragon();
            }
            else if (w == "3")
            {
                System.Environment.Exit(0);
            }
        }

        static void Paragon()
        {
            decimal price = 0;
            ShopService service = new ShopService();
            Console.WriteLine("KOD KRESKOWY LUB WYDRUK PARAGONU(P) :");
            while (true)
            {
                string kod = System.Console.ReadLine();

                if (kod == "p" || kod == "P")
                {
                    decimal netto = 0;
                    DateTime localTime = DateTime.Today;
                    Console.Clear();
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("PARAGON");
                    Console.WriteLine("");
                    Console.WriteLine($"DATA ZAKUPU: {localTime.ToString("dd-MM-yyyy")} ");
                    Console.WriteLine("---------------------------------");
                    foreach (var p in service.Paragon)
                    {
                        Console.WriteLine($"{p.Name} | {p.BruttoPrice} zł");
                        netto = netto + p.NettoPrice; 
                    }
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine($"DO ZAPŁATY: {price} zł");
                    Console.WriteLine($"W TYM VAT: {price-netto} zł");

                    System.Environment.Exit(0);
                }

                bool existingbarcode = false;
                foreach (var p in service.Warehouse)
                {
                    if (p.Barcode == kod)
                    {
                        existingbarcode = true;
                        price = price + p.BruttoPrice;
                        service.Paragon.Add(new Product(p.Barcode, p.Name, p.NettoPrice));
                        Console.Clear();
                        Console.WriteLine(p.Name);
                        Console.WriteLine("");
                        Console.WriteLine($"CENA ŁĄCZNA: {price} zł");
                        Console.WriteLine("");
                        Console.WriteLine("KOD KRESKOWY LUB WYDRUK PARAGONU(P) :");
                        break;
                    }
                }
                if (!existingbarcode)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NIE ZNALEZIONO PRODUKTU");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("KOD KRESKOWY LUB WYDRUK PARAGONU(P) :");
                }

            }
        }
    }
}

    
