using System;
using System.Collections.Generic;
namespace OyunDenemesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu = new Oyuncu() {Ad="İkbal",SoyAd="Delibaş",Tc="1234567890",DogumYili="2000" };
            Oyuncu edevlet = new Edevlet() { Ad = "İl", SoyAd = "Delibaş", Tc = "1234567890", DogumYili = "2000" };
            EdevletManager edevletManager = new EdevletManager();
            edevletManager.Karsilastir(oyuncu,edevlet);
            OyuncuManager oyuncuManager = new OyuncuManager();
            oyuncuManager.Delete(oyuncu);
            oyuncuManager.Update(oyuncu);

            Oyun oyun = new Oyun() { Fiyat = 100, OyunAdi = "Valorant" };
            OyunManager oyunManager = new OyunManager();
            oyunManager.Add(oyun,oyuncu);

            Kampanya kampanya = new Kampanya() { Ad = "Kampanya 1 " };
            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.Add(kampanya);
        }
    }
}
