using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.mainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region degiskenler

            #endregion

            string name = "murat"; // text degiskenlerini tutar

            int maas = -170002; // tam sayı degerlerini tutar

            double kusuratlı = 16.50; // reel sayı degerlerini tutar

            char harf = 'a'; // tek tırnakla kullanılır tek deger tutar

            name = Console.ReadLine(); // kullanıcıdan string degerleri alir

            maas = Convert.ToInt32(Console.ReadLine()); // degerleri alır ve int cevirir 

            maas = int.Parse(Console.ReadLine()); // alinan degerleri int e cevirir

            kusuratlı = double.Parse(Console.ReadLine()); // alınan degeri double cevirir


        }
    }
}
