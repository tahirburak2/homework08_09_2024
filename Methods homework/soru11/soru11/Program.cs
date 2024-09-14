namespace soru11;

class Program
{
    static int kelime(string kel)
    {
        string sesli="aeıioöuü";
        int ahmet=0;
        foreach (var item in kel)
        {
                if (sesli.Contains(item))
                {
                   ahmet++; 
                }
                
        }
        System.Console.WriteLine(ahmet);
        return ahmet;
    }
    static void Main(string[] args)
    {
       System.Console.WriteLine("Bir kelime girin:");
       string input=Console.ReadLine();
       kelime(input);
       
    }
}
