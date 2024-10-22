# Patika+ Week5 Array Uygulaması
Merhaba,
Bu proje C# ile Patika+ 5.hafta Arrays için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- Diziler ve kullanımını öğrenmek
- Döngüler'i kullanmak


## İstenilen Görev
Bu pratikte aşağıdaki 4 aşamayı kodlamanız isteniyor.
1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.


## Kod Region1 
```csharp
static void Main(string[] args)
{
    #region Çözüm1
    // 10 elemanlı bir tam sayı dizisi tanımlıyoruz.
    int[] numbers = new int[10];

    Console.WriteLine("10 adet sayı giriniz");

    // For döngüsü ile diziyi dolduruyoruz.
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{i + 1}. sayıyı gir: ");
        numbers[i] = int.Parse(Console.ReadLine());
    }


    // Kullanıcıdan 11. elemanı alıyoruz.
    Console.Write("diziye 11. elemanı giriniz: ");
    int newnumber = int.Parse(Console.ReadLine());


    // Eski diziyi 11 elemanlı yeni bir diziye kopyalıyoruz.
    int[] newArray = new int[11];

    for (int i = 0; i < numbers.Length; i++)
    {
        newArray[i] = numbers[i];
    }

    // Yeni elemanı ekliyoruz.
    newArray[10] = newnumber;

    // Küçükten Büyüğe sıralıyoruz.
    Array.Sort(newArray);

    // Yeni diziyi ekrana yazdırıyoruz.
    Console.WriteLine("\nKüçükten Büyüğe Sıralanmış Hali");
    foreach (int number in newArray)
    {
        Console.WriteLine(number);
    }

    #endregion
}
```
10 elemanlı bir dizi oluşturdum daha sonra içerisine 10 adet eleman girişi yaptırttım. Döngüden çıkınca 11. elemanı da girmesini istedim.
Daha sonra eski diziyi yeni oluşturduğum 11 elemanlı dizi içerisine attım ve 11. elemanı da ekledim. Sort() methodu ile küçükten büyüğe sıraladım.
Bu biraz karışık bir yol

## Kod Region2 Lists
```csharp
#region Çözüm2 List
// Dinamik olarak eleman ekleyebileceğimiz bir List tanımlıyoruz.
List<int> numberss = new List<int>();

Console.WriteLine("10 Adet Sayı Gir");

// Kullanıcıdan 10 sayıyı alıp listeye ekliyoruz.
for (int i = 0; i < 10; i++)
{
    Console.Write($"Sayı {i + 1}: ");
    numberss.Add(int.Parse(Console.ReadLine()));
}

// Kullanıcıdan 11. sayıyı alıp listeye ekliyoruz.
Console.Write("Lütfen 11. Sayıyı Giriniz: ");
numberss.Add(int.Parse(Console.ReadLine()));

// Listeyi büyükten küçüğe sıralıyoruz.
numberss.Sort();

// Ekrana Yazdırıyoruz
Console.WriteLine("\nGüncellenmiş Dizi");
foreach (int number in numberss)
{
    Console.WriteLine(number);
}
#endregion
```
Burada ise dinamik liste yapısından faydalandım. Buradaki diziye kolayca eleman ekleme ve çıkartma işlemi yapabiliriz.
- Kullanıcıdan 10 adet tam sayı alıp listeye ekliyoruz
- Kullanıcıdan 11. elemanı alıp yine Add metodu ile listeye ekliyoruz
- Sort() metodu listeyi küçükten büyüğe sıralıyoruz.





