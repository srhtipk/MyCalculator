using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Girdi:IEntity
    {
        public int Sayi1 { get; set; }
        public int Sayi2 { get; set; }
        public string islem { get; set; }
    }
}
