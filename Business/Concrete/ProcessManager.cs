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
            //return new Sonuc() { IslemSonucu=girdi.Sayi1+15};
            int son;
            if (girdi.islem =="t")
            {
                son = girdi.Sayi1 + girdi.Sayi2;
                return new Sonuc { IslemSonucu = son };
            }
            else if (girdi.islem =="-")
            {
                son = girdi.Sayi1 - girdi.Sayi2;
                return new Sonuc { IslemSonucu = son };
            }
            else if (girdi.islem =="*")
            {
                son = girdi.Sayi1 * girdi.Sayi2;
                return new Sonuc { IslemSonucu = son };
            }
            else if (girdi.islem =="/")
            {
                son = girdi.Sayi1 / girdi.Sayi2;
                return new Sonuc { IslemSonucu = son };
            }
            else
            {
                return new Sonuc { IslemSonucu = 55555555 };
            }
        }

    }
}
