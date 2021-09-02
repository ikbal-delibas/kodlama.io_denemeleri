using System;
using System.Collections.Generic;
using System.Text;

namespace OyunDenemesi
{
    public interface IOyuncuManager
    {
        void Add(Oyuncu oyuncu);
        void Update(Oyuncu oyuncu);
        void Delete(Oyuncu oyuncu);


    }
}
