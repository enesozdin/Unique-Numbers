using System;

namespace Unique_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İstediğiniz sayı miktarını giriniz:");
            int hedef = int.Parse(Console.ReadLine());
            int[] sayi = new int[hedef];
            Random rnd = new Random();
            Console.Clear();
            Console.WriteLine("Sıralanmış sayılarınız:");
            for (int i = 0; i < hedef; i++)
            {
                sayi[i] = rnd.Next(10, 50);
                for (int j = 0; j < i; j++)
                {
                    if (sayi[i] == sayi[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            for (int sonuc = 0; sonuc <hedef; sonuc++)
            {
                Array.Sort(sayi);
                Console.WriteLine(sayi[sonuc]);
                
            }
            Console.WriteLine("Çıkış yapmak için herhangi tuşa basınız.");
            Console.Read();
        }
    }
}
