namespace soru10;

class Program
{
    static int[] dizi()
    {
        int[] sayılar = { 4, 3, 2, 5, 6, 7, 9, 7, 5, 4 };
        int toplam = 0;
        for (int i = 0; i < sayılar.Length; i++)
        {
            toplam += sayılar[i];
            System.Console.WriteLine(toplam);
        }


        int[] sonuç = new int[toplam];
        return sonuç;
    }
    static void Main(string[] args)
    {
        dizi();
    }
}
