using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20232907_While_Ornek2
{
    internal class Program
    {
        //While Örnek
        //Kullanıcıdan 2 adet sayı talep edelim
        //Kullanıcının girmiş olduğu sayıları toplayalım
        //İşlem sonunda kullanıcı tekrar işlem yapmak isterse aynı işlemleri yaptıralım
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;
            while (true)
            {
                Console.Write("Birinci Sayıyı Giriniz : ");
                sayi1 = int.Parse(Console.ReadLine());
                Console.Write("İkinci Sayıyı Giriniz : ");
                sayi2= int.Parse(Console.ReadLine());
                toplam = sayi1 + sayi2;
                Console.Write("Sayıların Toplamı : " +toplam);
                Console.Write("Yeni Bir İşlem Yapmak İster misiniz ? (e) : ");
                string devam=Console.ReadLine();
                if (devam!="e")
                {
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
