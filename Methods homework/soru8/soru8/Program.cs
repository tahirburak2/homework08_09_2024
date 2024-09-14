namespace soru8;

class Program
{
    static int sıcaklık(int a)
    {
        int derece=a-32;
        System.Console.WriteLine($"girdiğiniz santigirat derece={derece} fahreniet derecedir.");
        return derece;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("santigrat derece girin:");
        int input=int.Parse(Console.ReadLine());
sıcaklık(input);
    }
}
