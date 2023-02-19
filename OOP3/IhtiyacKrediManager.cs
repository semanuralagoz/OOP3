using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace OOP3
{
    public class İhtiyacKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("ihtiyac kredisi odeme planı hesaplandı");
        }

        public void Ekle()
        {
            Console.WriteLine("İhtiyac kredisi odeme planına eklendi");
        }
    }
}
