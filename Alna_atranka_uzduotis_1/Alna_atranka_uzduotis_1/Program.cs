using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alna_atranka_uzduotis_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laikrodis laikrodis = new Laikrodis();
            while (true)
            {
                double laipsniai;

                laikrodis.valandos = laikrodis.PriimtiValandas();
                laikrodis.minutes = laikrodis.PriimtiMinutes();

                laipsniai = laikrodis.PaskaiciuotiMazesnijiKampaTarpRodykliu(laikrodis.valandos, laikrodis.minutes);

                laikrodis.ParodytiRezultata(laipsniai);
            }
            
        }
    }
}
