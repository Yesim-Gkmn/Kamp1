using System;

namespace Kamp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Oranı");

            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }



            if (sistemeGirisYapmismi== true)


            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap Butonu");
            }
            
    
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
