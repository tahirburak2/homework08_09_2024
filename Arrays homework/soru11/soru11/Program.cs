namespace soru11;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Bir kelime giriniz => ");
        string girKelime = Console.ReadLine();

        char[] kelDizi = girKelime.ToCharArray();
        Array.Reverse(kelDizi);
        string çevDiz = new string(kelDizi);

        foreach (var item in çevDiz)
        {
            System.Console.Write(item);
        }

    }
}
