using System;

// Generic bir sınıf tanımı
public class GenericClass<T>
{
    private T _genericMemberVariable;

    // Constructor
    public GenericClass(T value)
    {
        _genericMemberVariable = value;
    }

    // Generic bir metot tanımı
    public void DisplayGenericValue()
    {
        Console.WriteLine("Generic değer: " + _genericMemberVariable);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Int tipinde bir GenericClass örneği oluşturma
        GenericClass<int> intGenericObj = new GenericClass<int>(10);
        intGenericObj.DisplayGenericValue(); // "Generic değer: 10" çıktısını verir

        // String tipinde bir GenericClass örneği oluşturma
        GenericClass<string> stringGenericObj = new GenericClass<string>("Hello, World!");
        stringGenericObj.DisplayGenericValue(); // "Generic değer: Hello, World!" çıktısını verir
    }
    /* Bu örnekte, `GenericClass` adında bir generic sınıf tanımlıyoruz. `T` tip parametresi, sınıfın içinde kullanılabilecek bir tipe işaret eder. 
Ardından, `GenericClass`'ın bir örneğini oluştururken, belirli bir türü (`int` veya `string` gibi) belirtiriz. 
Bu örnekte, sınıfın içindeki `_genericMemberVariable` değişkeni ve `DisplayGenericValue` metodu, belirtilen tipe göre çalışır. Bu sayede aynı sınıfı farklı türlerle kullanabiliriz.
*/
}
