using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample702
{
    class Program
    {
        static void Main(string[] args)
        {
            Access ac = new Access();

            ac.Data2 = 20;
            ac.showDatas();

            Console.WriteLine("ac.data1 = {0}", ac.Data1);
        }
    }
}