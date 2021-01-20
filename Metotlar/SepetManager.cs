using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Adi + " Sepete Eklendi");
        }

        public void Ekle2(string urunAdi, double fiyatı, int stok)
        {
            Console.WriteLine("Sepete Eklendi " + urunAdi + fiyatı + " Stok: " + stok);
        }
    }
}
