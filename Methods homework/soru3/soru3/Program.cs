using System.Globalization;
using System.Runtime.CompilerServices;

namespace soru3;

class Program
{
    static string kelime(string kel1){
     char[] kelime=kel1.ToCharArray();
     Array.Reverse(kelime);
     string ters=new string(kelime);
     return ters;
    }
    static void Main(string[] args)
    {
System.Console.WriteLine("bir kelime girin");
string input=Console.ReadLine();
string ters=kelime(input);
System.Console.WriteLine(ters);
    }
}
