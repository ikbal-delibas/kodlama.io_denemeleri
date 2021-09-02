using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDenemesi
{
    public class OyunManager 
    {
        public void Add(Oyun oyun,Oyuncu oyuncu)
        {
            Console.WriteLine("{0}, {1} oyununu satın alındı.",oyuncu.Ad,oyun.OyunAdi);
        }

        public void Delete(Oyun oyun, Oyuncu oyuncu)
        {
            Console.WriteLine("{0}, {1} oyununu sildi.", oyuncu.Ad, oyun.OyunAdi);
        }

        
    }
}
