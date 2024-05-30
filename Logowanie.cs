using System;


namespace logowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            byte maxAttempts = 4;
            byte ile = 0;
            string login = "admin";
            string passwd = "123456";
            string log;
            int wynik;


            Console.WriteLine("Witaj w Terminalu");

            while (ile < maxAttempts)
            {
                wynik = maxAttempts - ile;
                Console.Write("Wprowadź Login: ");
                log = Console.ReadLine();
                if (log != login)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nie poprawny Login");
                    Console.WriteLine("ILOŚĆ PRÓB: " + wynik);
                    Console.ResetColor();
                    ile++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("POPRAWNY LOGIN");
                    Console.ResetColor();
                    break;

                }

            }

            //HASŁO
            ile = 0;

            while (ile <= maxAttempts)
            {
                wynik = maxAttempts - ile;
                Console.Write("Wprowadź Hasło: ");
                string pswd = Console.ReadLine();
                if (pswd != passwd)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nie poprawne hasło");
                    Console.WriteLine("ILOŚĆ PRÓB: " + wynik);
                    Console.ResetColor();
                    ile++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("POPRAWNE HASŁO");
                    Console.ResetColor();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DANE");
                    Console.WriteLine("UŻYTKOWNIK: " + login);
                    Console.WriteLine("HASŁO: " + passwd);
                    Console.ResetColor();
                    break;

                }

            }

            Console.WriteLine("Aby wyjśc naciśnij dowolny klawisz");
            Console.ReadKey();



        }
    }
}