using System;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] products = new Product[] { urun1, urun2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("----------");
            }

            Console.WriteLine("--------METOTLAR--------");
            //encapsulation
            SepetMenager sepetMenager = new SepetMenager();
            sepetMenager.Add(urun1);
            sepetMenager.Add(urun2);
            sepetMenager.Add2("Armut", "Yeşil armmut", 12,85);

            sepetMenager.Add2("Elma ","Yeşil elma", 13, 55);

        }
    }
}

// Dont repeat yourself DRY, Clean Code , Best Practice