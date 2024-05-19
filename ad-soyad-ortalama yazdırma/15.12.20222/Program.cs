// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
class ogrenci
{
    private int numara=10;
    private string ad="serkan";
    private string soyad="tan";
    private int vize=100;
    private int final=70;
    public int Numara { get { return numara; } set { numara = value; } }    
    public string Ad { get { return ad; } set { ad = value; } }
    public string Soyad { get { return soyad; } set { soyad = value; } }
    public int Vize { get { return vize; }
        set { if (value < 0 || value > 100) vize = 0; else vize = value; } }
    public int Final
    {
        get { return final; }
        set { if (value < 0 || value > 100) final = 0; else final = value; }
    }
    public double ortalama()
    {
        return vize * 0.4 + final * 0.6;
    }
}
class ana
{
    static void Main()
    {
        ogrenci ogrenci = new ogrenci();

        Console.Write("Adı : ");
        Console.WriteLine(ogrenci.Ad);
        Console.Write("Soyadı : ");
        Console.WriteLine(ogrenci.Soyad);
        Console.Write("numarası : ");
        Console.WriteLine(ogrenci.Numara);
        Console.Write("ortalama : ");
        Console.WriteLine(ogrenci.ortalama());
    }
}


