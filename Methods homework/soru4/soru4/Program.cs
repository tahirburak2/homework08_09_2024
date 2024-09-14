namespace soru4;

class Program
{
    static int sonuç(int vize, int final)
    {
        int ortalama;
int vize1=vize*40/100;
int final1=final*60/100;
 ortalama=vize1+final1;

return ortalama;
    }
    static void Main(string[] args)
    {
System.Console.WriteLine("vize ve final sonucunuzu giriniz:");
int input=int.Parse(Console.ReadLine());
int input2=int.Parse(Console.ReadLine());


System.Console.WriteLine(sonuç(input,input2));
    }
}
