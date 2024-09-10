namespace soru9;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = { -6, 5, 6, -9, -8, 2, 6, 7, 1, -50 };

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] > 0)
            {
                dizi[i] = -dizi[i];
            }
        }

        Array.Sort(dizi);
        Array.Reverse(dizi);
        foreach (var item in dizi)
        {
            System.Console.WriteLine(item);
        }
    }
}
