// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

class sinema
{
    private int toplamKoltukSayisi;
    private int bosKoltukSayisi;
    private double bakiye;
    public string salonNo;
    const double TAM = 20.0;  //const türünde yazılan bir değer alt tarafta değiştirlemez.
    const double INDIRIMLI = 10.0;
    public sinema(int toplamKoltuk, string salon)
    {
        toplamKoltukSayisi = toplamKoltuk;
        salonNo = salon;
        bosKoltukSayisi = toplamKoltukSayisi;
        bakiye = 0;
    }
    public void biletSat(bool indirimliMi)
    {
        if (bosKoltukSayisi > 0)
        {
            bosKoltukSayisi--;
            if (indirimliMi) bakiye += INDIRIMLI;
            else bakiye += TAM;
            Console.WriteLine("bilet satıldı!!");
        }
        else
        {
            Console.WriteLine("Boş koltuk kalmadı");
        }
    }
    public void biletIptal(bool indirimliMi)
    {
        bosKoltukSayisi++;
        if (indirimliMi) bakiye -= INDIRIMLI;
        else bakiye -= TAM;
        Console.WriteLine("bilet iptal edildi!!");
    }
    public int bosKoltukOgren()
    {
        return bosKoltukSayisi;
    }
    public double bakiyeOgren()
    {
        return bakiye;
    }
    public static string kişiler(int mevcut=0)
    {
       while(true)
        {
            Console.Write("Sınıf mevcudunu Girin : ");
            mevcut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string[] ogrenci = new string[mevcut];

            for (int i = 0; i < mevcut; i++)
            {
                Console.Write("Öğrenci Adını Girin : ");
                ogrenci[i] = Console.ReadLine();
            }
            return kişiler();
        }
    }
    
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(sinema.kişiler());
        Console.Write("Salonun adını giriniz");
        string sAd = Console.ReadLine();
        Console.Write("Salonun koltuk sayısını giriniz");
        int sKoltuk = Convert.ToInt32(Console.ReadLine());
        sinema salon1 = new sinema(sKoltuk, sAd);
        Console.WriteLine("Bilet Satış Sistemi (satış=1 İptal=2 KalanbOşkoltuk=3 Kazanılan Para=4 çıkış=5)");
        while (true)
        {
            Console.Write("Yapılacak olan işlemi seçiniz ");
            string islem = Console.ReadLine();
            if (islem == "1")
            {
                Console.Write("indirimli bilet(1) normal bilet(2): ");
                string biletSecim = Console.ReadLine();
                if (biletSecim == "1") salon1.biletSat(true);
                if (biletSecim == "2") salon1.biletSat(false);

            }
            if (islem == "2")
            {
                Console.Write("indirimli bilet(1) normal bilet(2): ");
                string biletSecim = Console.ReadLine();
                if (biletSecim == "1") salon1.biletIptal(true);
                if (biletSecim == "2") salon1.biletIptal(false);

            }
            if (islem == "3")
            {
                Console.WriteLine($"{salon1.salonNo} da {salon1.bosKoltukOgren()} boş koltuk kaldı");
            }
            if (islem == "4")
            {
                Console.WriteLine($"{salon1.salonNo} da {salon1.bakiyeOgren()} para kazanıldı");
            }
            if (islem == "5") break;

        }

    }
}
