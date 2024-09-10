namespace soru3;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] pozitif = new int[10];
        int[] negatif = new int[10];
        int[] sayılar = new int[10];
        int sayaç = 0;
int sayaç1=1;
        System.Console.WriteLine("10 tane sayı giriniz: ");
        for (int i = 0; i < 10; i++)
        {

            
            sayılar[i] = random.Next(-10, 10);

        }
        System.Console.WriteLine("Elimizde bulunan rastgele sayılar.");

        foreach (var item in sayılar)
        {
            System.Console.WriteLine($"{sayaç1}. elemanı= {item}");
            
            sayaç1++;
        }
        for (int i = 0; i < sayılar.Length; i++)
        {
            if (sayılar[i] > 0)
            {
                pozitif[sayaç] = sayılar[i];
                sayaç++;
            }
            if (sayılar[i] < 0)
            {
                negatif[sayaç] = sayılar[i];
                sayaç++;
            }
        }
        System.Console.WriteLine($"Pozitif sayılarımız: ");
        foreach (var item in pozitif)
        {
            System.Console.WriteLine(item);
            
        }
        System.Console.WriteLine("Negatif sayılarımız: ");
        foreach (var item2 in negatif)
        {
            System.Console.WriteLine(item2);
        }
    }
}
