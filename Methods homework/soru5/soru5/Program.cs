namespace soru5;

class Program{

static string[] TersÇev(string[] dizi)
{
    foreach (var item in dizi)
    {
        System.Console.WriteLine(item.ToUpper());
    }
    
    return dizi;

}


static void Main(string[] args)
    {
        string[] mehmet = { "ahmet", "murat", "elif", "burak", "aleyna" };

        TersÇev(mehmet);
    }

}