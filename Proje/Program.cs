using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen_Cinsiyetinizi_Secin_(E veya K)");
            string cinsiyet = Console.ReadLine();

            Console.WriteLine("Yaşınızı_Girin");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("tolam calısma günün");
            int gun = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maaş Bilgisini Girin");
            int maas = Convert.ToInt32(Console.ReadLine());

            switch (cinsiyet)
            {
                case "E":
                    if(yas>= 60)
                    {
                        Console.WriteLine("Emeklileğe Hoşgeldiniz");
                        Console.WriteLine("Piriminiz " + (maas * 10));

                    }
                    else if(gun >= 6000) 
                    {
                        Console.WriteLine("Emeklileğe Hoşgeldiniz");
                        Console.WriteLine("Piriminiz " + (maas * 11));
                    }
                    else
                    {
                        Console.WriteLine("Emekli Olamadınız");

                    }

                    break;

                case "K":
                    if (yas >= 58)
                    {
                        Console.WriteLine("Emeklileğe Hoşgeldiniz");
                        Console.WriteLine("Piriminiz " + (maas * 10));

                    }
                    else if (gun >= 4500)
                    {
                        Console.WriteLine("Emeklileğe Hoşgeldiniz");
                        Console.WriteLine("Piriminiz " + (maas * 11));
                    }
                    else
                    {
                        Console.WriteLine("Emekli Olamadınız");

                    }
                    break;

                default:
                    Console.WriteLine("Yanlış Giriş Yaptınız");
                    break;

            }


        }
    }
}
