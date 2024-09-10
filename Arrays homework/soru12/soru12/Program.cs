namespace soru12;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi = new int[20];
        Random rnd = new Random();
        int sayaç = 1;

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = rnd.Next(1, 11);

        }
        System.Console.WriteLine("Random dizimiz");
        System.Console.WriteLine("---------------------------------------------------");
        foreach (var item in dizi)
        {
            System.Console.WriteLine($"{sayaç}. ==> {item}");
            sayaç++;
        }

        int fazlaTekEleman = dizi[0];
        int tekrareleman = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            int x = dizi[i];
            int teksay = 0;

            foreach (var eleman in dizi)
            {
                if (eleman == x)
                {
                    teksay++;
                }
            }

            if (teksay > tekrareleman)
            {
                fazlaTekEleman = x;
                tekrareleman = teksay;
            }
        }

        System.Console.WriteLine($"En çok tekrar eden eleman {fazlaTekEleman} = {tekrareleman} kadar tekrarlanıyor.");
    }
}
