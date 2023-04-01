using System.Reflection.Metadata.Ecma335;

namespace Baza_kostek
{
    internal class Program
    {
        static void Powitanie()
        {
            Console.WriteLine("Ten program umożliwia zarządzanie bazą kostek");
            Console.WriteLine("Wybież odpowiedną opcję:");
            Console.WriteLine("1 - Dodanie nowej kostki do bazy ");
            Console.WriteLine("2 - Usunięcie kostki z bazy ");
            Console.WriteLine("3 - Załadowanie kostki do bazy danych ");
            Console.WriteLine("4 - Pobranie kostek z bazy danych ");
            Console.WriteLine("5 - Wyświetlenie listy wszystkich kostek w bazie danych ");
            Console.WriteLine("6 - Dodawanie nowych wyników czasowych do kostek");
            Console.WriteLine("7 - zakończenie działania programu ");
        }

        static float CzyFloat(string f)
        {
            try
            {
                return (float)Convert.ToDouble(f);
            }
            catch { return 0.0f; }
        }
        static int? CzyInt(string i)
        {
            try
            {
                return Convert.ToInt32(i);
            }
            catch { return null; }
        }

        static void Main(string[] args)
        {
            Powitanie();

            List<Kostki> wszystkieKostki = new List<Kostki>();

            while (true)
            {
                Console.Write(">>> ");
                string? odp = Console.ReadLine().Trim();
                switch (odp)
                {
                    case "1":   // wczytywanie danych nowej kostki
                        {
                            string? nazwa = null;
                            float? nowyCzas = null;
                            string? data = null;
                           
                            Console.Clear();

                            while ((nazwa == null) || (nowyCzas == null) || (data == null))
                            {
                                //  Spróbuj wczytać nazwę do momentu aż użytkownik nie podadobrej
                                while (nazwa == null)
                                {
                                    string? wejscie = "";
                                    Console.Write("Wpisz nazwę kostki: ");
                                    wejscie = Console.ReadLine().Trim();
                                    if (wejscie.Length > 2)
                                    {
                                        nazwa = wejscie;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Wpisana nazwa jest za krótki - nazwa musi mieć przynjamniej 3 znaki");
                                        Console.WriteLine("\nNaciśnij dowolny klawisz by kontynuować");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }

                                Console.Clear();


                                // Poproś użytkownika o wprowadzenie czasu lub 0 jeśli nie chce podawać
                                while (nowyCzas == null)
                                {
                                    string? wejscie = "";
                                    Console.Write("Wpisz jeden czas ułożenia, lub 0 by nie dodawać żadnego (nie wpisuj 'f' na końcu, tylko np. 11.23): ");
                                    wejscie = Console.ReadLine().Trim();

                                    if (wejscie == "0") { nowyCzas = 0; }

                                    else if (wejscie.Length < 3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Wpisany czas jest za krótki -> wpisz go tak by miał minimum 3 cyfry");
                                        Console.WriteLine("\nNaciśnij dowolny klawisz by kontynuować");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        float poKonwersji = CzyFloat(wejscie);
                                        if (poKonwersji != 0.0f) { nowyCzas = poKonwersji; }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wpisany czas jest niepoprawny - by nie wpisywać żadnego czasu wpisz '0'");
                                            Console.WriteLine("\n Naciśnij dowolny klawisz by kontynuować");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                    }
                                }

                                Console.Clear();

                                while (data == null)
                                {
                                    string?[] wejscie = new string[3];
                                    Console.Write("Wpisz datę w postaci 'rok miesiac dzien' - możesz pominąc dzien lub dzien i miesiac: ");
                                    wejscie = Console.ReadLine().Split(" ");

                                    if (wejscie[0].Length < 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Wpisana data jest za krótka -> wpisz go tak by miał minimum 3 cyfry");
                                        Console.WriteLine("\nNaciśnij dowolny klawisz by kontynuować");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else if (wejscie[0].Length == 2)
                                    {
                                        if (CzyInt(wejscie[0]) != null) { }
                                    }
                                    else
                                    {
                                        /*float poKonwersji = CzyFloat(wejscie);
                                        if (poKonwersji != 0.0f) { nowyCzas = poKonwersji; }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wpisany czas jest niepoprawny - by nie wpisywać żadnego czasu wpisz '0'");
                                            Console.WriteLine("\n Naciśnij dowolny klawisz by kontynuować");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }*/
                                        
                                    }
                                }


                                Console.WriteLine("Wczytanie danych poprawne\n");

                                Console.WriteLine("Oto wprowadzone przez ciebie dane:");
                                Console.WriteLine($"Nazwa: {nazwa}");
                                string? nowy = nowyCzas != 0.0f ? nowyCzas.ToString() : "Nie Wprowadzono";
                                Console.WriteLine($"Czas: {nowy}");
                                Console.WriteLine($"Data otrzymania / kupna: {data}");

                            }

                            


                            break;
                        }
                }
            }
        }
    }
}