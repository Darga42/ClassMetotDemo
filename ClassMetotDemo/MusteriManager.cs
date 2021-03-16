using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" "+"Id Numaralı"+" "+musteri.Yas+" "+"Yaşında"+" "+musteri.AdSoyad+" "+"İsimli Kullanıcı Eklendi");;
        }

        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi=" + "Id : " + musteri.Id + " " + musteri.AdSoyad + " " + "Yaş" + musteri.Yas);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" "+"Id Numaralı"+" "+musteri.Yas+"Yaşında"+musteri.AdSoyad+"İsimli Kullanıcı Silindi");
        }

    }
}
