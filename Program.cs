using System;
using CSharpOOP.Kutuphane;

namespace CSharpOOP
{
   public class Program
    {
        static void Main(string[] args)
        {


            #region Kutuphane

            Tur tur = new Tur("Masal");
            Yayinevi yayinevi = new Yayinevi("Denizbank", 2000);

            Uye uye = new Uye("Dilek Eda", "Gündüz", "12345678910", "istanbul","5555555123");

            Kitap kitap = new Kitap("Pamuk Prenses", DateTime.Now, tur,yayinevi, "Okuma" );

           
            Kutuphaneİslem kutuphaneislem = new Kutuphaneİslem();

            DateTime newdate = new DateTime(2022, 04, 10);

            kutuphaneislem.kitapal(uye, kitap.Ad, newdate);
            kutuphaneislem.kitapiade(uye, kitap.Ad, DateTime.Now);


            #endregion
