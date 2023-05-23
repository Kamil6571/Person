using System;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Postnr { get; set; }
    public string By { get; set; }

    public void WritePerson()
    {
        Console.WriteLine($"Navn: {FirstName}");
        Console.WriteLine($"Fornavn: {LastName}");
        Console.WriteLine($"Adresse: {Address}");
        Console.WriteLine($"Postnr: {Postnr}");
        Console.WriteLine($"By: {By}");
    }
}

public class Program
{
    public static void Main()
    {
        Person person = new Person();

        bool exit = false;

        do
        {
            Console.WriteLine("1. prette bruger");
            Console.WriteLine("2. Se profil");
            Console.WriteLine("3. Afslute");
            Console.WriteLine();

            Console.Write("Vælg en mulighed: ");
            string input = Console.ReadLine();

            Console.Clear(); // czyści ekran konsoli

            switch (input)
            {
                case "1":
                    Console.Write("Navn: ");
                    person.FirstName = Console.ReadLine();

                    Console.Write("Fornavn: ");
                    person.LastName = Console.ReadLine();

                    Console.Write("Adresse: ");
                    person.Address = Console.ReadLine();

                    Console.Write("Postnr: ");
                    person.Postnr = Console.ReadLine();

                    Console.Write("By: ");
                    person.By = Console.ReadLine();

                    Console.WriteLine("Personlige data er indtastet.");
                    Console.WriteLine();
                    break;

                case "2":
                    Console.WriteLine("Personprofil:");
                    person.WritePerson();
                    Console.WriteLine();
                    break;

                case "3":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Ugyldig mulighed. Vælg igen.");
                    Console.WriteLine();
                    break;
            }
        } while (!exit);
    }
}
