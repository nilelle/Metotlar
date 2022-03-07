using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        public static int ArttırVeTopla(ref int x, ref int y)
        {
            x += 1;
            y += y;
            return (x + y);
        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int sonuc =ArttırVeTopla(ref x,ref y);
            Console.WriteLine(sonuc);
            Console.ReadKey();  


        }
    }
}
