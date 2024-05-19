// See https://aka.ms/new-console-template for more information
class Alanlar
{
    private int numara;
    private string ogrenciad;
    private string ogrencisoyad;
    private int vize;
    private int final;
    public int setNumara { get { return numara; } set { numara = value; } }
    public string setögrenciad { get { return ogrenciad; } set { ogrenciad = value; } }
    public string setögrencisoyad { get { return ogrencisoyad; } set { ogrencisoyad = value; } }
    public int setvize
    {
        get { return vize; }
        set { if (value < 0 || value > 100) vize = 0; else vize = value; } //vize notunu 0-100 arasında olup olmadığını kontrol ettim 
    }
    public int setfinal {
        get { return final; }
        set { if (value < 0 || value > 100) vize = 0; else final = value; } //final notunun 0-100 arasında olup olmadığını kontrol ettim
    }
    public void ogrencıBılgıVer() //yukardaki bilgileri yazdırma işlemini burda yaptım.
    {
        Console.WriteLine($" Öğrenci Numarası : {numara} \n Öğrenci Adı : {ogrenciad} \n Öğrenci Soyadı : {ogrencisoyad} \n Vize ve Final Notu : {vize} ve {final}");
        
    }
    public double ortalama() //ortalama hesaplama işlemini burda yaptım.
    {
        return (vize * 0.4) + (final * 0.6);
    }
    public void yaz() //ortalamayı aşağıda yazdırmak yerine burda void türünde bi değişken vererek burda yazdırdım.
    {
        Console.WriteLine($" Vize-Final Ortalaması : {ortalama()}");
    }
}

class Methotlar
{
    static void Main()
    {
        Alanlar nesne = new Alanlar();
        nesne.setNumara = 224212040;
        nesne.setögrenciad = "Hamza";
        nesne.setögrencisoyad = "Çoban";
        nesne.setvize =90;
        nesne.setfinal=70;
        nesne.ogrencıBılgıVer();
        nesne.yaz();
    }
}