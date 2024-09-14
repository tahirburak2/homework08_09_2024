namespace soru16;

class Program
{
    static void Main(string[] args)
    {
                 int input ;
                 int sayaç=0;
                 int[] dizi = new int[10];
                 int top =0;

             do
             {

             System.Console.WriteLine("Bir sayı giriniz => ");
                 input = int.Parse(Console.ReadLine());


                 if( input !=0)
                 {
                     dizi[sayaç] = input;
                     top +=input;

                     sayaç++;
                 }



         } while (input != 0 && sayaç < dizi.Length);
             Array.Resize(ref dizi, dizi.Length);
             foreach (var item in dizi)
             {
                 System.Console.WriteLine(item);
             }

           if(sayaç >0)
           {
                 double ort =(double)top/sayaç;
                 System.Console.WriteLine($"Sayılarımızın ortalaması = {ort}");
           
    }
}
}