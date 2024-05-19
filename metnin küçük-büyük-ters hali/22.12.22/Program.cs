// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using System.Globalization;

class Metinisle
{
    public static string buyukharf(string metin)
    {
        metin = metin.ToLower();
        return metin;
    }
    public static string kucukharf(string metin)
    {
        metin = metin.ToUpper();
        return metin;
    }
    public static string ilkbuyuk(string metin)
    {
        string[] dizi=metin.Split(' ');    
        string kelime;
    for (int i = 0; i < dizi.Length; i++)
        {
            kelime = dizi[i];
            dizi[i] = kelime[0].ToString().ToUpper()+kelime.Substring(1,kelime.Length-1).ToLower();
        }
    return string.Join(" ", dizi);  
    }
    public static string ters(string metin)
    {
        for (int i = metin.Length - 1; i >= 0; i--)
        {
            Console.Write(metin[i]);
        }
        return metin;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Metin giriniz :");
        string metin2 = Console.ReadLine();
        Console.WriteLine("Küçük hali: ");
        Console.WriteLine(Metinisle.buyukharf(metin2));
        Console.WriteLine("Büyük hali: ");
        Console.WriteLine(Metinisle.kucukharf(metin2));
        Console.WriteLine("Baş harfleri büyük hali : ");
        Console.WriteLine(Metinisle.ilkbuyuk(metin2));
        Console.WriteLine("Ters yazılış hali : ");
        Metinisle.ters(metin2);
        

    }
}