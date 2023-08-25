public abstract class sporcu
{
    public string adSoyad;
    public string gorev;
    public int lisansSuresi;
    public int ucret;

    public sporcu()
    {
        adSoyad = "Mauro Icardi";
        gorev = "Futbolcu";
        lisansSuresi = 2;
        ucret = 10000000;
    }
}
public class futbolcu : sporcu
{
    public futbolcu()
    {
        Console.WriteLine($"Futbolcu Özellikleri\nAdı Soyadı:{adSoyad}\nGörevi:{gorev}\nLisan Süresi:{lisansSuresi} yıl\nÜcret:{ucret}");

    }
}
class ftblcu
{
    static void Main(string[] args)
    {
        futbolcu f1= new futbolcu();
        Console.WriteLine();
    }
}
    