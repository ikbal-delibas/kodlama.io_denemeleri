using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik2
{
    class DortIslem
    {
        public void Toplama(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
        }
        public void Cikarma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine(sonuc);
        }
        public void Carpma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine(sonuc);
        }
        public void Bolme(int sayi1, int sayi2)
        {
            if (sayi2 == 0)
            {
                Console.WriteLine("Bölen sayı 0 olamaz!");
            }
            else
            {
                double sonuc = sayi1 / sayi2;
                Console.WriteLine(sonuc);

            }
            
        }
    }
}
