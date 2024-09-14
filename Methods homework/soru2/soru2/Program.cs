namespace soru2;

class Program
{
    static string karşı(int sayı1, int sayi2)
    {
        string mesaj;
        if (sayı1 > sayi2)
        {
            mesaj = $"girilen 1. sayı {sayı1} 2. sayı {sayi2}'den daha büyüktür.";
            System.Console.WriteLine(mesaj);
        }
        else
        {
            mesaj = $"girilen 1. sayı {sayi2} 2. sayı {sayı1}'den daha büyüktür.";
            System.Console.WriteLine(mesaj);
        }
        return mesaj;
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine("2 sayı giriniz: ");
        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());
        karşı(input1, input2);

    }
}
