namespace soru16;

class Program
{
    static bool Palindrom(string kelime)
    {
        string tersKelime = new (kelime.Reverse().ToArray());

        return kelime == tersKelime;
    }
    static void Main(string[] args)
    {
        Console.Write("Bir kelime giriniz: ");
        string input = Console.ReadLine();

        if (Palindrom(input))
        {
            Console.WriteLine($"'{input}' kelimesi bir palindromdur.");
        }
        else
        {
            Console.WriteLine($"'{input}' kelimesi bir palindrom değildir.");
        }
    }
}
