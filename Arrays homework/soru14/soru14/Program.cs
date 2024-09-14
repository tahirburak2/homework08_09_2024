namespace soru14;

class Program
{
    static void Main(string[] args)
    {
        int[] sayılar = { 3, 4, 5, 6, 7, 8, 9, 12, 1, 51, 15 };
        int sayaç = 0;
        int[] üçBöl = new int[sayılar.Length];
        for (int i = 0; i < sayılar.Length; i++)
        {
            if (sayılar[i] % 3 == 0)
            {
                üçBöl[sayaç] = sayılar[i];
                sayaç++;
            }
        }



    }
}
