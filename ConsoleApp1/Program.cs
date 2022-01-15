using Business.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessManager processManager = new ProcessManager();
            Girdi girdi = new Girdi() { Sayi1 = 155, Sayi2 = 5, islem = "top" };
            var result=processManager.StartProcess(girdi);
            Console.WriteLine(result.IslemSonucu);
        }
    }
}
