namespace patika_w5_Array
{
    internal class Program
    {
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


            Console.ReadKey();
        }
    }
}
