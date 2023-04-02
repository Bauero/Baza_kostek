using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_kostek
{
    partial class Program
    {
        public static void removeData(List<Kostki> wszystkieKostki)
        {
            informacje:

            Console.WriteLine("Wybór sposobu usuwania: ");
            Console.WriteLine("1 - Nazwa kostki");
            Console.WriteLine("2 - numer koski na liscie");
            Console.WriteLine("3 - anuluj wpisywanie");
            Console.Write(">>> ");
            string ans = Console.ReadLine().Trim();

            switch (ans)
            {
                case "1":

                    break;

                case "2":
                    break;

                case "3":
                    goto informacje;
            }

        }
    }
}
