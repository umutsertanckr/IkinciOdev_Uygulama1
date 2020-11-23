using System;

namespace IkinciOdev_Uygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            double uzun, kısa;
            Dikdörtgen hesap = new Dikdörtgen();
            Console.Write("Uzun Kenarı Girin: ");
            uzun = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kısa Kenarı Girin: ");
            kısa = Convert.ToDouble(Console.ReadLine());
            hesap.alanhesapla(uzun, kısa);
            hesap.cevrehesapla(uzun, kısa);
        }
    }
    class Dikdörtgen
    {
        double h, b;
        public void alanhesapla(double u, double k)
        {
            h = u * k;
            Console.WriteLine("Alanı: " + h);
        }
        public void cevrehesapla(double u, double k)
        {
            b = (u + k) * 2;
            Console.WriteLine("Çevresi: " + b);
        }
    }
}
