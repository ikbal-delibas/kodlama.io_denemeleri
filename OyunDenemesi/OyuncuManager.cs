using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDenemesi
{
    public class OyuncuManager : IOyuncuManager
    {
        public void Add(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu eklendi.");
        }

        public void Delete(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu silindi.");
        }

        public void Update(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu güncellendi.");
        }
    }
}
