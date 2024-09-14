namespace soru1;

class Program
{
    static string Greet(int age){
string mesaj;
        if (age>=65)
        {
             mesaj="Emeklilik yaşındsınız";
             System.Console.WriteLine(mesaj);
        }
        else {
             mesaj="çalışma yaşındsınız";
             System.Console.WriteLine(mesaj);
        }

        return mesaj;
    }
    

    
    static void Main(string[] args)
    {System.Console.WriteLine("bir sayı girin:");
    int input=int.Parse(Console.ReadLine());

        Greet(input);
    }
}
