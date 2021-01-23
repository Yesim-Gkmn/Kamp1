using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //double fiyati = 15;
            //string aciklama = "amasya Elması";

            //string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Kaprpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("---------------Metorlar----------------------------");
            //instance-Örnek
            //encapsulation

            Sepetmanager sepetmanager = new Sepetmanager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);


            sepetmanager.Ekle2("Armut", "Yeşil", 12,10);
            sepetmanager.Ekle2("Elma", "Yeşil", 12,9);
            sepetmanager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);

        }
    }
}
