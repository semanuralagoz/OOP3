using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace OOP3
{
    public class TasitKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Tasit  kredisi odeme planı hesaplandı");
        }

        public void Ekle()
        {
            Console.WriteLine("Tasıt kredisi odeme planına eklendi");
        }
    }
}
