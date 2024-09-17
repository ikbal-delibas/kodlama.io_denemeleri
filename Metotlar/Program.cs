using System;




namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1=new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya Elması";
            Urun urun2=new Urun() { Adi="Çilek",Fiyati= 15, Aciklama="Dağ çileği" };
            Urun[] urunler = new Urun[] {urun1,urun2};
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi+"\n"+urun.Fiyati+ "\n" + urun.Aciklama + "\n*************************");
            }
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);

        }
    }
}