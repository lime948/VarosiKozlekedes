using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarosiKozlekedes.Models;
using VarosiKozlekedes.Services;

namespace VarosiKozlekedes
{
    internal class Program
    {
        static List<Jegyrendszer> utazasok = DatabaseService.GetJegyek();
        static void Main(string[] args)
        {
            int teljesBevetel = 0;
            foreach (var utazas in utazasok)
            {
                teljesBevetel += utazas.ArSzamitas();
            }
            Console.WriteLine($"A nap teljes bevétele: {teljesBevetel} Ft");

            foreach (var utazas in utazasok)
            {
                Console.WriteLine($"Utazás típusa: {utazas.GetType().Name}, Ár: {utazas.ArSzamitas()} Ft");
            }
        }
    }
}
