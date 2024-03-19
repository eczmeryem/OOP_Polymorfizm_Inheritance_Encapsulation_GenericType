Hesaplama cember = new Cember();
Console.WriteLine("Cember Alanı:" + cember.Alan());

Hesaplama kare = new Kare();
Console.WriteLine("Kare Alanı:" + kare.Alan());

Hesaplama dikdortgen = new Dikdortgen();
Console.WriteLine("Dikdörtgen Alanı :" + dikdortgen.Alan());

Console.ReadKey();

public class Hesaplama
{
    public virtual double Alan()
    {
        return 0;
    }
}

public class Cember : Hesaplama
{
    public double YariCap { get; set; }
    public Cember()
    {
        YariCap = 5;
    }
    public override double Alan()
    {
        return (3.14) * Math.Pow(YariCap, 2);
    }
}

public class Kare : Hesaplama
{
    public double Uzunluk { get; set; }
    public Kare()
    {
        Uzunluk = 6;
    }
    public override double Alan()
    {
        return Math.Pow(Uzunluk, 2);
    }
}

public class Dikdortgen : Hesaplama
{
    public double Yukseklik { get; set; }
    public double Genislik { get; set; }
    public Dikdortgen()
    {
        Yukseklik = 5.3;
        Genislik = 3.4;
    }
    public override double Alan()
    {
        return Yukseklik * Genislik;
    }
}