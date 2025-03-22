public class Kapi
{
    public int Sayi { get; set; }

    public Kapi(int sayi)
    {
        Sayi = sayi;
    }
}

public class Pencere
{
    public int Sayi { get; set; }

    public Pencere(int sayi)
    {
        Sayi = sayi;
    }
}

public class Kasa
{
    public string Tip { get; set; }

    public Kasa(string tip)
    {
        Tip = tip;
    }
}

public class Marka
{
    public string Ad { get; set; }
    public string Model { get; set; }

    public Marka(string ad, string model)
    {
        Ad = ad;
        Model = model;
    }
}
public class Araba
{
    public Marka Marka { get; set; }
    public Kapi Kapi { get; set; }
    public Pencere Pencere { get; set; }
    public Kasa Kasa { get; set; }
    public decimal Fiyat { get; set; }

    public Araba(Marka marka, Kapi kapi, Pencere pencere, Kasa kasa, decimal fiyat)
    {
        Marka = marka;
        Kapi = kapi;
        Pencere = pencere;
        Kasa = kasa;
        Fiyat = fiyat;
    }

    public void BilgileriYazdir()
    {
        Console.WriteLine($"Arabanın markası {Marka.Ad}, modeli {Marka.Model}, kapı sayısı {Kapi.Sayi}, pencere sayısı {Pencere.Sayi}, kasası {Kasa.Tip}, fiyatı {Fiyat:N0} TL'dir.");
    }
}