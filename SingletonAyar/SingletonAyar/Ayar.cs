using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signleton
{
    public class Ayar
    {
        private static Ayar ornek;

        private int ses = 0;

        private int parlaklik = 0;

        public static Ayar SesAyari
        {
            get
            {
                if (ornek == null)
                {
                    ornek = new Ayar();
                }
                return ornek;
            }
        }

        private Ayar()
        {
            Console.WriteLine("Ayar adında nesne örneği oluştu.");
        }

        public void SesArttir(int miktar)
        {
            ses += miktar;
        }

        public void SesAzalt(int miktar)
        {
            ses -= miktar;
        }

        public void ParlaklikArttir(int miktar)
        {
            parlaklik += miktar;
        }

        public void ParlaklikAzalt(int miktar)
        {
            parlaklik -= miktar;
        }

        public void SesDegerGoster()
        {
            Console.WriteLine($"Şuanda ses miktarı : {ses}");
        }

        public void ParlaklikDegerGoster()
        {
            Console.WriteLine($"Şuanda parlaklık miktarı : {parlaklik}");
        }
    }
}