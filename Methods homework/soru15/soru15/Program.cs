namespace soru15;

class Program
{
    static int metot()
    {
int[] dizi=new int[10];
Random rnd=new Random();
for (int i = 0; i < dizi.Length; i++)
{
    dizi[i]=rnd.Next(1,11);
}
int toplam=0;
for (int i = 0; i < dizi.Length; i++)
{
    toplam+=dizi[i];
}
foreach (var item in dizi)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("----------------------------------------");

return toplam;
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine(metot());
    }
}
