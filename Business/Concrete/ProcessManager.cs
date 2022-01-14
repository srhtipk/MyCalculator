using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProcessManager : IProcessService
    {

        public Sonuc StartProcess(Girdi girdi)
        {
            if (girdi.Islem=="+")
            {
                int son = girdi.Sayi1 + girdi.Sayi2;
                return new Sonuc { IslemSonucu = son };
            }
            else if (girdi.Islem == "-")
            {
                int son = girdi.Sayi1 - girdi.Sayi2;
                return new Sonuc { IslemSonucu = son };
            }
            else if (girdi.Islem == "*")
            {
                int son = girdi.Sayi1 * girdi.Sayi2;
                return new Sonuc { IslemSonucu = son };
            }
            else if (girdi.Islem == "/")
            {
                int son = girdi.Sayi1 / girdi.Sayi2;
                return new Sonuc { IslemSonucu = son };
            }
            else
            {
                return new Sonuc { IslemSonucu = 0 };
            }
        }

    }
}
