using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety -  tip güvenliği
            //Do not repeat yourself - kendini tekrarlama
            //değer tutucu , alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış But. Gös.");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış but. Gös.");
            }
            else
            {
                Console.WriteLine("değişmedi but. Göst.");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);



        }
    }
}
