using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager KrediManager)
        {
            KrediManager.Hesapla();

        }


        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Ekle();
                kredi.Hesapla();
                


            }
        }




    }
}
