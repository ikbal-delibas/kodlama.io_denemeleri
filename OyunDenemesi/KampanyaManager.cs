using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDenemesi
{
    public class KampanyaManager : IOyuncuManager
    {
        public void Add(Oyuncu kampanya)
        {
            Console.WriteLine("{0} kampanyası eklendi",kampanya.Ad);
        }

        public void Delete(Oyuncu kampanya)
        {
            Console.WriteLine("{0} kampanyası silindi", kampanya.Ad);
        }

        public void Update(Oyuncu kampanya)
        {
            Console.WriteLine("{0} kampanyası güncellendi", kampanya.Ad);
        }
    }
}
