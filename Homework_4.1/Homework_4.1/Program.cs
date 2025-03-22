public class Program
{
    public static void Main(string[] args)
    {
        Marka bmwMarka = new Marka("BMW", "X5");
        Kapi dortKapi = new Kapi(4);
        Pencere dortPencere = new Pencere(4);
        Kasa sedanKasa = new Kasa("sedan");

        Araba bmwX5 = new Araba(bmwMarka, dortKapi, dortPencere, sedanKasa, 2000000);

        bmwX5.BilgileriYazdir();
    }
}