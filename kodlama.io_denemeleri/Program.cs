using System;
using System.Collections.Generic;

namespace kodlama.io_denemeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> liste = new MyList<string>();
            liste.Add("a");
            liste.Add("b");
            liste.Add("c");
            liste.Add("d");
            liste.Add("e");
            liste.Add("f");
            liste.Yazdir();
        }
    }
}
