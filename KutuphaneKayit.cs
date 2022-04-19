using System;
using CSharpOOP.Kutuphane;

namespace CSharpOOP.Kutuphane
{
    public class KutuphaneKayit 
    {
        public string KitapAdi { get; set; }
        
        public Yayinevi Yayinevi { get; set; }

        public Tur Tur { get; set; }    

        public DateTime TeslimTarihi { get; set; }

        public Uye Uye { get; set; }



        //Constructor üzerinden property leri SET ETMEK
        public KutuphaneKayit(Uye uye,string kitapadi, DateTime date)
        {
            this.Uye = uye;
            this.KitapAdi = kitapadi;
            this.TeslimTarihi = date;
          
        }

    }
}
