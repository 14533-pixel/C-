// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
{
    try
    {
        Console.WriteLine("sayı giriniz");
        int sayı=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2.sayıyı giriniz");
        int sayı2 = Convert.ToInt32(Console.ReadLine());
        if (sayı < 0) throw new Exception("0 veya daha düşük değer girilemez.");
        else if(sayı2 < 0 ) throw new Exception("0 veya daha düşük değer girilemez.");
        int toplam = sayı + sayı2;
        Console.WriteLine($"Toplamı : {toplam}");
    }
    catch(Exception nesne)
    {
    Console.WriteLine( "Şu hata oluştu  :"+nesne.Message ); 
    }
}
    //bir koşul verip o koşul sağlanmazsa ekrana hata yazdırma

