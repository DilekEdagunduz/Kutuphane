using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Kutuphane
{
    public class Kitap
    {
        public string Ad { get; set; }
        public DateTime DateTime { get; set; }
        public List<Yazar> Yazarlar { get; set; }
        public Tur TurClass { get; set; }
        public Yayinevi YayineviClass { get; set; } 
        public string ISBBNo { get;} = Guid.NewGuid().ToString();
        public string aciklama { get; set; }

        public Kitap(string ad, DateTime datetime, Tur tur, Yayinevi yayinevi,  string aciklama)
        {
            this.Ad = ad;
            this.DateTime = datetime;
            this.TurClass = tur;
            this.YayineviClass = yayinevi;
            this.aciklama = aciklama;
        }
    }
}
