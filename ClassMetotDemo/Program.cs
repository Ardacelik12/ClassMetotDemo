using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            musteri1.Musteri_adi = "arda celik";
            musteri1.yas = 24;
            musteri2.Musteri_adi = " samet eralp";
            musteri2.yas = 34;
            MusteriManager methods = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2};

            methods.MusteriListele(musteriler);   
            

        }
    }
}
