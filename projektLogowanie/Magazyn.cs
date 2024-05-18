using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    internal class Magazyn
    {
    private List<Produkt> produkty = new List<Produkt>();

        // Dodawanie produktu do magazynu
        public void DodajProdukt(Produkt produkt)
        {
            produkty.Add(produkt);
        }

        // Wyświetlanie listy produktów w magazynie
        public void WyswietlListeProduktow()
        {
            Console.WriteLine("Lista produktów w magazynie:");
            foreach (var produkt in produkty)
            {
                Console.WriteLine($"- {produkt.Nazwa} ({produkt.KodKreskowy})");
            }
        }

        // Usuwanie produktu z magazynu
        public void UsunProdukt(string kodKreskowy)
        {
            var produkt = produkty.Find(p => p.KodKreskowy == kodKreskowy);
            if (produkt != null)
            {
                produkty.Remove(produkt);
                Console.WriteLine($"Produkt {produkt.Nazwa} został usunięty z magazynu.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono produktu o podanym kodzie kreskowym.");
            }
        }
    }
}

