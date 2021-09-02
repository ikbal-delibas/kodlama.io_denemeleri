
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDenemesi
{
    public class EdevletManager
    {
        public void Karsilastir(Oyuncu oyuncu,Oyuncu oyuncu1)
        {
            if(oyuncu.Ad==oyuncu1.Ad&& oyuncu.Tc == oyuncu1.Tc && oyuncu.SoyAd == oyuncu1.SoyAd && oyuncu.DogumYili == oyuncu1.DogumYili)
            {
                OyuncuManager oyuncuManager = new OyuncuManager();
                oyuncuManager.Add(oyuncu);
            }
            else
                Console.WriteLine("Girdiğiniz bilgiler yanlıştır");
        }
    }
}
