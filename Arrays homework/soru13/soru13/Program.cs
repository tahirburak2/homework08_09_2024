namespace soru13;

class Program
{
    static void Main(string[] args)
    {
        int[] dizi=[1,2,3,4,5,6,7,8,9];
        
        int çiftToplam=0;
        int tekToplam=0;
        System.Console.WriteLine("Dizideki elemanlar:");
        foreach (var item in dizi)
        {
            System.Console.WriteLine(item);
        }
for (int i = 0; i < dizi.Length; i++)
{
    if(dizi[i]%2==0){
        çiftToplam+=dizi[i];
    }
    if (dizi[i]%2!=0)
    {
        tekToplam+=dizi[i];
    }
}
System.Console.WriteLine("----------------------------------");
System.Console.WriteLine($"Dizimizdeki tek sayıların toplamı={tekToplam}");
System.Console.WriteLine($"Dizimizdeli çift sayıların toplamı={çiftToplam}");

    }
}
