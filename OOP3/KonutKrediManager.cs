using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class KonutKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("konut kredisi odeme planı hesaplandı");
        }

        public void Ekle()
        {
            Console.WriteLine("Konut kredisi odeme planına eklendi");
        }
    }
}