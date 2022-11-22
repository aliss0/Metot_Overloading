using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler
            string sayi = "999";
            int outSayi;
            bool sonuc = int.TryParse(sayi, out outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            int tsonuc;
            Metotlar instance = new Metotlar();
            instance.Topla(4, 3, out tsonuc);
            Console.WriteLine(tsonuc);

            int ifade = 9999;
            instance.EkranaYazdır(Convert.ToString(ifade));
            instance.EkranaYazdır("Ali", "Uygun");
            Console.ReadLine();
        }
    }
    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdır(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdır(string veri1, string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}
