namespace soru10;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] dizi = new int[5];
        
        int sayaç = 0;
        for (int i = 0; i < 5; i++)
        {
            dizi[i] = rnd.Next(1, 79);


        }

        foreach (var item in dizi)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("--------------------------");
        Array.Reverse(dizi);
        foreach (var item in dizi)
        {
            System.Console.WriteLine(item);
        }
    }
}
