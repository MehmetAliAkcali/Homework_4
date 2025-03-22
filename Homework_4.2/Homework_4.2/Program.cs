public class Program
{
    public static void Main(string[] args)
    {
        Matematik matematik = new Matematik();

        // Tamsayı toplama
        Console.WriteLine("2 + 3 = " + matematik.Topla(2, 3));
        Console.WriteLine("2 + 3 + 4 = " + matematik.Topla(2, 3, 4));

        // Ondalıklı toplama
        Console.WriteLine("2.5 + 3.5 = " + matematik.Topla(2.5, 3.5));
        Console.WriteLine("2.5 + 3.5 + 4.5 = " + matematik.Topla(2.5, 3.5, 4.5));

        // Tamsayı çarpma
        Console.WriteLine("2 * 3 = " + matematik.Carp(2, 3));
        Console.WriteLine("2 * 3 * 4 = " + matematik.Carp(2, 3, 4));

        // Ondalıklı çarpma
        Console.WriteLine("2.5 * 3.5 = " + matematik.Carp(2.5, 3.5));
        Console.WriteLine("2.5 * 3.5 * 4.5 = " + matematik.Carp(2.5, 3.5, 4.5));
    }
}
