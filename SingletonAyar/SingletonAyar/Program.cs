using Signleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAyar
{

    /*
     Tekillik dokusu (Singleton pattern): Bir sınıftan program çalışırken sadece bir örnek oluşturulması isteniyorsa bu doku kullanılabilir. 
    Örnek : Bir uygulamanın tekrar tekrar açılmasını engellemek için.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Ayar ayarSiniffOrnegi1 = Ayar.SesAyari;
            Ayar ayarSiniffOrnegi2 = Ayar.SesAyari;

            Console.WriteLine("**************************************************");

            ayarSiniffOrnegi1.SesArttir(5);
            ayarSiniffOrnegi1.SesDegerGoster();

            ayarSiniffOrnegi1.SesArttir(2);
            ayarSiniffOrnegi1.SesDegerGoster();

            ayarSiniffOrnegi1.SesAzalt(1);
            ayarSiniffOrnegi1.SesDegerGoster();

            Console.WriteLine("**************************************************");

            ayarSiniffOrnegi1.ParlaklikArttir(5);
            ayarSiniffOrnegi1.ParlaklikDegerGoster();

            ayarSiniffOrnegi1.ParlaklikArttir(2);
            ayarSiniffOrnegi1.ParlaklikDegerGoster();

            ayarSiniffOrnegi1.ParlaklikAzalt(1);
            ayarSiniffOrnegi1.SesDegerGoster();

            Console.WriteLine("**************************************************");

            ayarSiniffOrnegi2.SesArttir(5);
            ayarSiniffOrnegi1.SesDegerGoster();

            ayarSiniffOrnegi1.ParlaklikArttir(5);
            ayarSiniffOrnegi1.ParlaklikDegerGoster();

            Console.WriteLine("**************************************************");

            Console.Read();

        }
    }
}