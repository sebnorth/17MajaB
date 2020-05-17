using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12345
{
    class Program
    {
        static void Main(string[] args)
        {

            #region testy dla kont

            

            List<Konto> bank = new List<Konto>();
            bank.Add(new Konto("Ania", 500));
            bank.Add(new Konto("Basia", 600));
            bank.Add(new Konto("Czesia", 700));
            bank.Add(new KontoFirmowe("Daria", 1500));
            bank.Add(new KontoFirmowe("Ewa", 2500));
            bank.Add(new KontoFirmowe("Fiona", 3500));

            foreach (Konto konto in bank)
            {
                konto.Wyplata(100);
            }

            foreach (Konto konto in bank)
            {
                Console.WriteLine(konto);
            }

            List<Konto> bankPosortowane = new List<Konto>();

            bankPosortowane = bank.OrderByDescending(konto => konto.Wlasciciel).ToList();

            foreach (Konto konto in bankPosortowane)
            {
                Console.WriteLine(konto);
            }

            bank.Reverse();

            foreach (Konto konto in bank)
            {
                Console.WriteLine(konto);
            }
            #endregion

            #region testy dla RORa

            Console.WriteLine("Podaj wpłątę: ");
            double.TryParse(Console.ReadLine(), out double wplata);
            ROR ror = new ROR();
            ror.Wplata(wplata);
            ror.Odsetki();
            Console.WriteLine($"Saldo wynosi: {ror.Saldo}");

            #endregion

            Console.ReadKey();
        }
    }
}
