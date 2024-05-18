namespace ShoppingApp
{
    internal class Program
    {
        static List<Klient> klienci = new List<Klient>();

        static void Main(string[] args)
        {
            // Przykładowi klienci
            klienci.Add(new Klient("jan123", "haslo123", "jan@example.com"));
            klienci.Add(new Klient("anna456", "haslo456", "anna@example.com"));

            Console.WriteLine("Witaj w naszym sklepie!");
            Console.WriteLine("1. Zaloguj się");
            Console.WriteLine("2. Zarejestruj się");
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    ZalogujKlienta();
                    break;
                case "2":
                    ZarejestrujKlienta();
                    break;
                   
                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        }

        static void ZalogujKlienta()
        {
            Console.WriteLine("Podaj login:");
            string login = Console.ReadLine();
            Console.WriteLine("Podaj hasło:");
            string haslo = Console.ReadLine();

            var klient = klienci.Find(k => k.Login == login && k.Haslo == haslo);
            if (klient != null)
            {
                Console.WriteLine($"Zalogowano jako {klient.Login}");
                // Tutaj możesz dodać logikę zdobywania punktów
                decimal wydanaKwota = 100.00m; // Przykładowa wydana kwota
                decimal punkty = wydanaKwota / 10; // Zdobyte punkty (1:10)
                klient.Punkty += punkty;
                Console.WriteLine($"Zdobyłeś {punkty} punktów.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy login lub hasło.");
            }
        }

        static void ZarejestrujKlienta()
        {
            Console.WriteLine("Podaj login:");
            string login = Console.ReadLine();
            Console.WriteLine("Podaj hasło:");
            string haslo = Console.ReadLine();
            Console.WriteLine("Podaj adres e-mail:");
            string email = Console.ReadLine();

            var nowyKlient = new Klient(login, haslo, email);
            klienci.Add(nowyKlient);

            Console.WriteLine("Rejestracja pomyślna!");
        }
    }
}
