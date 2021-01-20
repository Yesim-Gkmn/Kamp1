using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {   string adi = "engin";
            int yas = 36;

            kurs kurs1 = new kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Engin";
            kurs1.izlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "Java";
            kurs2.egitmen = "Mehmet";
            kurs2.izlenmeOrani = 48;

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "Python";
            kurs3.egitmen = "ayşe";
            kurs3.izlenmeOrani = 78;



            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + ":" + kurs.egitmen);
            }


            

        
        }
    }
    class kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
