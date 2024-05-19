// See https://aka.ms/new-console-template for more information
 class Alanlar
{
    private string kod = "200";
    private string ad = "hamza";
    private int kredi = 100;
    private string eğitmen = "serkan tan";
    public string setkod { get { return kod; } set { value = kod; } }
    public string setad { get { return ad; } set { value = ad; } }
    public int setkredi { get { return kredi; } set { value = kredi; } }
    public string seteğitmen { get { return eğitmen; } set { value = eğitmen; } }
    public void dersbilgiver()
    {
        Console.WriteLine(kod);
        Console.WriteLine(ad);
        Console.WriteLine(kredi);
        Console.WriteLine(eğitmen);
    }
    public void eğitmendeğiş(string yenideğer = "ahmet")
    {
        eğitmen = yenideğer;
    }
    public void koddeğiş(string yenikod = "faruk")
    {
        kod = yenikod;
    }
}


