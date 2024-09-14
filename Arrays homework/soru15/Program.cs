namespace soru15;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = { 2, 5, 9, 10, 7, 8, 5, };

        int teksayıadet = 0;


        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 2 != 0)
            {
                teksayıadet++;
            }
        }

        int[] tekdizi = new int[teksayıadet];

        int index = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 2 != 0)
            {
                tekdizi[index] = dizi[i];
                index++;
            }
        }

        Array.Sort(tekdizi);

        int index2 = 0;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 2 != 0)
            {
                dizi[i] = tekdizi[index2];
                index2++;
            }
        }

        foreach (var item in dizi)
        {
            System.Console.WriteLine(item);
        }
    }
}
