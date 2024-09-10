namespace soru8;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir sayı giriniz: ");
        int input=int.Parse(Console.ReadLine());
        Random rnd=new Random();
        int[] dizi=new int[10];
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i]=rnd.Next(1,11);
            foreach (var item in dizi)
            {
                System.Console.WriteLine(item);
            }
            if (dizi[i]==input)
            {
                System.Console.WriteLine("Girdiğiniz sayı dizide mecvut.");
            }
        }

       
    }
}
