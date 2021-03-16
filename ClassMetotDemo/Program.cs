using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.AdSoyad = "Joseph Addison";
            musteri1.Yas = 48;
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.AdSoyad = "Karen Armstrong";
            musteri2.Yas = 36;
            musteri2.Id = 2;


            Musteri[] musteriler = new Musteri[] {musteri1, musteri2 };
            MusteriManager musteriler1 = new MusteriManager();
            musteriler1.Ekle(musteri1);

            foreach (Musteri musteri in musteriler)
            {
                musteriler1.Listeleme(musteri);
            }
                musteriler1.Silme(musteri2);
        }
    }
}
