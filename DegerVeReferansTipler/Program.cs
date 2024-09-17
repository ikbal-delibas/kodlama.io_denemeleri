namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1); 
            // yukarıdakiler değer tipidir ve stack te tutulur
            // aşağıdakiler ise referans tipidir ve heap de tutulur. new belekte bir adres oluşturur.
            int[] sayiler1=new int[] {10,20,30};
            int[] sayilar2=new int[] {100,200,300};
            sayiler1 = sayilar2;// artık sayilar1 in bellekteki adresi değişti ve sayilar2 nin bellekteki adresiyle eşleşti
            // artık sayilar1 in bellekte tutulan adresi silinir. artık bellekte [10,20,30] gibi bir listenin adresi yoktur ve sayilar in herhangi bir elemanına ulaşılmak istenirse bellekte sayilar2 nin bellekteki adresine erişilir. bu yüzden sayilar2 nin eleman değişikliği sayisal1 de etkiler
            sayilar2[0] = 999;
            Console.WriteLine(sayiler1[0]);
        }
    }
}