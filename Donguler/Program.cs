using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
           // string kurslar1 = "Yazılım geliştirme kampı";
            //string kurslar2 = "Proglamlamaya başlangıç";
            //string kurslar3 = " java";

            string[] kurslar = new string[] { "Yazılım geliştirme kampı", 
                "Proglamlamaya başlangıç", "java","python","C++"};

            for (int i = 0; i<kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine( kurs);
            }
            Console.WriteLine("sayfa sonu- footer");
        }
    }
}
