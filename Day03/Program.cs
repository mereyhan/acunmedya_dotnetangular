namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TakeNumberForSum();
            // WhileLoopExample();
            // FindUniqueElement();
            // FindLongAndShortWords();
            // SortWords();
            // DynamicExpandingString();
            // ReverseWords();
            // OrtalamaHesapla();
            // FilterSmallNumbers();
            // AdjustStudentScores();

            /*
            
             *  Metot (Fonksiyon) nedir?
                    Fonksiyon (işlev veya yordam), belirli bir işlemi gerçekleştiren ve gerektiğinde tekrar tekrar çağrılabilen kod bloklarıdır.


             *  Metotları neden kullanırız?
                    Kod tekrarını önleme, kodun okunabilirliğini artırma, kakımı kolaylaştırma, modülerlik sağlama, hata takibini kolaylaştırma
                    gibi imkanlar sağladığı için.
            
             *  return değeri döndüren metot ile void metot arasındaki fark nedir?
                    void metot, sağrıldığı zaman sadece içerisindeki işlemleri gerçekleştirir ve referans tutamaz.
                    return değeri döndüren metot ise referans değer alarak işlemlerini gerçekleştirir, sonra bir değer döndürür.
            
             *  Metotların parametreleri nasıl çalışır?
                    var sayılan değer olarak kullanılabilir.
                    return değeri döndürmek için referans alınabilir.
                    dizilerin ilk isimleri referans tutuculardır. bu şekilde, bir fonksiyon yardımıyla dizi üzerinde işlem yapılabilir.

            */
        }

        // Kullanıcıdan alınan notları 50-100 arasına ayarlayan algoritma
        static void AdjustStudentScores()
        {
            List<double> ogrenciNotlari = new List<double>();
            int counter = 0;

            while (true)
            {
                Console.Write("Öğrencilerin notlarını giriniz (çıkış için negatif sayı giriniz): ");
                double item = double.Parse(Console.ReadLine());


                if (item < 0)
                {
                    break;
                }
                else if (item < 50)
                {
                    item = 50;
                    ogrenciNotlari.Add(item);
                    Console.WriteLine($"{++counter}. öğrencinin notu {item} olarak eklendi");
                }
                else if (item > 100)
                {
                    item = 100;
                    ogrenciNotlari.Add(item);
                    Console.WriteLine($"{++counter}. öğrencinin notu {item} olarak eklendi");
                }
                else
                {
                    ogrenciNotlari.Add(item);
                    Console.WriteLine($"{++counter}. öğrencinin notu {item} olarak eklendi");
                }
            }

            Console.WriteLine("ogrenci notları:");
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"{i + 1}- {ogrenciNotlari[i]}");
            }
        }

        // 10'dan küçük olan sayıları filtreleyen algoritma
        static void FilterSmallNumbers()
        {
            List<int> kucukSayilar = new List<int>();
            int counter = 0;

            while (true)
            {
                Console.Write("10'dan küçük olanları sıralanacak sayıları giriniz (çıkış için negatif sayı giriniz): ");
                int item = int.Parse(Console.ReadLine());

                if (item < 0)
                {
                    break;
                }
                else if (item < 10)
                {
                    kucukSayilar.Add(item);
                    counter++;
                }
                else
                {
                    Console.WriteLine("Girilen sayı listeye eklenmedi");
                }

            }

            Console.WriteLine("Girilen sayilar:");
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"{i + 1}- {kucukSayilar[i]}");
            }
        }

        // Ortalama hesaplayan algoritma
        static void OrtalamaHesapla()
        {
            int toplam = 0, counter = 0;

            while (true)
            {
                Console.Write($"ortalamaları alınacak {++counter}. sayıyı girin (Çıkmak için '-1'): ");
                int item = int.Parse(Console.ReadLine());

                if (item == -1)
                {
                    counter--;
                    break;
                }

                toplam += item;
            }

            Console.WriteLine($"Girdiğiniz sayıların ortalaması: {toplam / counter}");
        }


        // Kullanıcıdan alınan cümleyi tersten sıralayan algoritma
        static void ReverseWords()
        {
            Console.Write("Kelimelerini tersten sıralamak istediğiniz cümleyi yazınız: ");
            string input03 = Console.ReadLine();

            string[] words03 = input03.Split(' ');
            Array.Reverse(words03);

            Console.WriteLine("Alfabetik sıralı kelimeler:");
            for (int i = 0; i < words03.Length; i++)
            {
                Console.WriteLine($"{i + 1}- {words03[i]}");
            }
        }


        // Kullanıcıdan alınan kelimeleri dinamik olarak genişleyen bir string listesine ekleyen algoritma
        static void DynamicExpandingString()
        {
            List<string> words02 = new List<string>();
            int counter = 0;

            while (true)
            {
                Console.Write("Bir kelime girin (Çıkmak için 'EXIT'): ");
                string input02 = Console.ReadLine();

                if (input02.ToUpper() == "EXIT")
                {
                    break;
                }

                words02.Add(input02);
                counter++;
            }

            Console.WriteLine("Girilen kelimeler:");
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"{i + 1}- {words02[i]}");
            }
        }


        // Kullanıcıdan alınan cümleyi alfabetik olarak sıralayan algoritma
        static void SortWords()
        {
            Console.Write("Kelimelerini alfabetik olarak sıralamak istediğiniz cümleyi yazınız: ");
            string input01 = Console.ReadLine();

            string[] words01 = input01.Split(' ');
            Array.Sort(words01, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("Alfabetik sıralı kelimeler:");
            for(int i = 0; i < words01.Length; i++)
            {
                Console.WriteLine($"{i+1}- {words01[i]}");
            }
        }


        // En uzun ve en kısa kelimeleri bulan algoritma
        static void FindLongAndShortWords()
        {
            string[] dizi02 = { "Apple", "Pear", "Cherry", "Banana", "Orange", "Quince", "Pineapple" };
            var result02 = LongAndShortWords(dizi02);
            Console.WriteLine($"En kısa kelime: {result02.Item1}, Uzunluğu: {result02.Item1.Length} char");
            Console.WriteLine($"En uzun kelime: {result02.Item2}, Uzunluğu: {result02.Item2.Length} char");
        }
        static Tuple<string, string> LongAndShortWords(string[] dizi)
        {
            string shortWord = dizi[0], longWord = dizi[0];

            foreach (var currentWord in dizi)
            {
                if (currentWord.Length < shortWord.Length)
                {
                    shortWord = currentWord;
                }

                if (currentWord.Length > longWord.Length)
                {
                    longWord = currentWord;
                }
            }

            // tuple ile aynı anda iki değer döndürdük
            return new Tuple<string, string>(shortWord, longWord);
        }


        // Dizide en çok tekrar eden elemanı bulan algoritma
        static void FindUniqueElement()
        {
            int[] dizi01 = { 1, 3, 2, 3, 4, 1, 3, 5, 3, 1 };
            var result01 = UniqueElement(dizi01);
            Console.WriteLine($"En çok tekrar eden eleman: {result01.Key}, Tekrar Sayısı: {result01.Value}");
        }
        static KeyValuePair<int, int> UniqueElement(int[] dizi)
        {
            Dictionary<int, int> sayacV = new Dictionary<int, int>();
            int maxValue = 0, maxKey = 0;

            foreach (var sayacK in dizi)
            {
                sayacV[sayacK] = sayacV.ContainsKey(sayacK) ? sayacV[sayacK] + 1 : 1;
            }

            foreach (var pair in sayacV)
            {
                if (pair.Value > maxValue)
                {
                    maxValue = pair.Value;
                    maxKey = pair.Key;
                }
            }

            return new KeyValuePair<int, int>(maxKey, maxValue);
        }


        // while loop example
        static void WhileLoopExample()
        {
            int controller = 0;
            while (controller == 0)
            {
                Console.Write("Enter a number between 10 and 100: ");
                int number02 = int.Parse(Console.ReadLine());

                if (number02 > 10 & number02 < 100)
                {
                    Console.WriteLine("Your number is: " + number02);
                    controller = 1;
                }
                else
                {
                    Console.WriteLine("Try again. Your number is wrong");
                }

            }
        }


        // algorithm for summing the digits of a number
        static void TakeNumberForSum()
        {
            Console.Write("Enter a number: ");
            int number01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: " + TotalNumbers(number01));
        }
        static int TotalNumbers(int i)
        {
            if (i < 10)
            {
                return i;
            }
            else
            {
                return (i % 10) + TotalNumbers(i / 10);
            }
        }
    }
}
