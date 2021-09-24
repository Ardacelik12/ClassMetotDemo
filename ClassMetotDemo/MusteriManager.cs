using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Musteriekle(Musteri musteri1)
        {
            Console.WriteLine("musteri " + musteri1.Musteri_adi + " eklendi");


        }

        public void Musterisil(Musteri musteri1)
        {


            Console.WriteLine("musteri" + musteri1.Musteri_adi + "silindi");


        }

        public void MusteriListele( Musteri[] musteriler)
        {


            foreach (Musteri item in musteriler)
            {
                Console.WriteLine("musteri adi :" + item.Musteri_adi);
                Console.WriteLine(" musteri yas :" + item.yas);
                Console.WriteLine("********************************************");


            }

        }

        internal void MusteriListele()
        {
            throw new NotImplementedException();
        } 
    }
}
