namespace soru1;

class Program
{
    static void Main(string[] args)
    {
        int[] sayılar = { 3, 5, 2, 8, 4, 15, 20, 11, 12, 9 };
        for (int i = 1; i < sayılar.Length - 1; i++)
        {
            if (sayılar[i] > sayılar[i - 1] && sayılar[i] > sayılar[i + 1])
            {
                System.Console.WriteLine($"{sayılar[i]} değeri sağındaki ve solundakinden büyüktür");
            }
        }
        //as
    }
}
