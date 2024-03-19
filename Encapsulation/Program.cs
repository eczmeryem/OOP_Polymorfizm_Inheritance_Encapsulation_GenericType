/* Encapsulation, nesne yönelimli programlamada kullanılan bir kavramdır ve bir sınıfın içinde verilerin ve onların işlemlerinin bir araya getirilmesidir. 
 Encapsulation sayesinde bir sınıfın iç verilerine doğrudan erişim engellenir ve bu verilere sadece sınıfın metotları aracılığıyla erişilebilir.
 Bu, verilerin korunmasını sağlar ve sınıfın iç yapısının dış dünyaya karşı gizlenmesini sağlar.*/

using System;

public class Ogrenci
{
    // Ogrenci sınıfının özellikleri (fields)
    private string ad;
    private int yas;

    // Ad özelliğine erişim için property
    public string Ad
    {
        get { return ad; }
        set { ad = value; }
    }

    // Yas özelliğine erişim için property
    public int Yas
    {
        get { return yas; }
        set { yas = value; }
    }

    // Constructor
    public Ogrenci(string ad, int yas)
    {
        this.ad = ad;
        this.yas = yas;
    }

    // Metotlar
    public void BilgileriGoster()
    {
        Console.WriteLine("Öğrencinin adı: " + ad);
        Console.WriteLine("Öğrencinin yaş: " + yas);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Ogrenci sınıfından bir örnek oluşturma
        Ogrenci ogrenci = new Ogrenci("Ahmet", 20);

        // Öğrencinin bilgilerini görüntüleme
        ogrenci.BilgileriGoster();

        // Ad ve yaşa doğrudan erişim denemesi
        // ogrenci.ad = "Mehmet"; // Bu satır hata verecektir, çünkü 'ad' private olarak tanımlanmıştır.
        // Console.WriteLine("Öğrencinin adı: " + ogrenci.ad); // Bu satır hata verecektir, çünkü 'ad' private olarak tanımlanmıştır.

        // Ad ve yaşa property aracılığıyla erişim
        ogrenci.Ad = "Mehmet";
        ogrenci.Yas = 21;
        ogrenci.BilgileriGoster(); // Yeni bilgileri görüntüleme
    }
}
/*Bu örnekte, Ogrenci adında bir sınıf tanımlıyoruz. Sınıfın içinde ad ve yas adında private alanlar (fields) bulunur. 
  Bu alanlara erişim için Ad ve Yas adında public property'ler tanımlanmıştır. Bu property'ler aracılığıyla verilere erişim sağlanır ve değer atanır. 
  BilgileriGoster metodu sınıfın içindeki verileri konsola yazdırır. Dışarıdan, sınıfın örneklerine direkt olarak erişim engellenir,
  ancak bu verilere property'ler aracılığıyla erişilebilir. Bu sayede verilerin güvenliği ve kontrolü sağlanır.*/




