namespace soru9;

class Program
{
    static int[] dizi()
    {
        int[] sayılar = { 3, 5, 4, 23, 6, 7, 5, 34, 6, 8, 9 };
        Array.Sort(sayılar);
        System.Console.WriteLine(sayılar[0]);
        return sayılar;
    }
    static void Main(string[] args)
    {
        dizi();
    }
}
