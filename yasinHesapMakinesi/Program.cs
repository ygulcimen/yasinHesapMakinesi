using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yasinHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İlk sayıyı giriniz : ");
            double ilkSayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz : ");
            double ikinciSayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hangi işlemi yapmak istiyorsunuz? +, -, /, * ");
            string islem = Console.ReadLine();
            

            switch (islem)
            {
                case "+":
                    double sonuc = ilkSayi + ikinciSayi;
                    Console.WriteLine("İşleminizin sonucu : " + sonuc);
                    break;
                case "-":
                    sonuc = ilkSayi - ikinciSayi;
                    Console.WriteLine("İşleminizin sonucu : " + sonuc);
                    break;
                case "/":
                    sonuc = ilkSayi / ikinciSayi;
                    Console.WriteLine("İşleminizin sonucu : " + sonuc);
                    break;
                case "*":
                    sonuc = ilkSayi * ikinciSayi;
                    Console.WriteLine("İşleminizin sonucu : " + sonuc);
                    break;
                default:
                    Console.WriteLine("Lütfen programı yeniden başlatıp geçerli bir işlem giriniz");
                    break;
            }
            
            Console.ReadLine();









  
        }
    }
}
