using System.Linq;
using System.Linq.Expressions;

namespace Atilla_A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            int islem, i ,sayi;
            i = 0;
            int sayac = 1;
            var sayilar = Array.Empty<int>();

            Console.WriteLine("Hangi İşlemi Yapmak İstedğinizi Seçiniz\n 1 = Toplama\n 2 = Çıkarma\n 3 = Çarpma\n 4 = Bölme\n 5 = Mod");
            islem = Convert.ToInt32(Console.ReadLine());


            while (i < 1)
            {
                
                Console.Write(sayac+".Sayıyı Giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                sayilar = sayilar.Append(sayi).ToArray();

                sayac++;
                
                Console.Write("Sayı Eklemek için 'E'ye Basınız: ");
                string devam = Console.ReadLine();
                

                if (devam != "E")
                {
                    i=2;
                    
                }


            }

            switch (islem)
            {
                case 1:
                    foreach(int x in sayilar)
                    {
                        i += x;
                        
                    }
                    Console.WriteLine(i);
                    break;

                case 2:
                    foreach (int x in sayilar)
                    {
                        i -= x;

                    }
                    Console.WriteLine(i);
                    break;

                case 3:
                    foreach (int x in sayilar)
                    {
                        i *= x;

                    }
                    Console.WriteLine(i);
                    break;

                case 4:
                    foreach (int x in sayilar)
                    {
                        i /= x;

                    }
                    Console.WriteLine(i);
                    break;

                case 5:
                    foreach (int x in sayilar)
                    {
                        i %= x;

                    }
                    Console.WriteLine(i);
                    break;
             
            }
            Console.ReadKey ();
        }
    }
}