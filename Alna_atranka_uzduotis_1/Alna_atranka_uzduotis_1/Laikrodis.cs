using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alna_atranka_uzduotis_1
{
    public struct Laikrodis
    {
        public int minutes;
        public int valandos;

        public Laikrodis(int min, int val)
        {
            minutes = min;
            valandos = val;
        }

        public int PriimtiValandas()
        {
            int valandos = 0;
            bool duomenysTeisingi = false;

            Console.WriteLine("Iveskite valandas:");

            while (duomenysTeisingi == false)
            {
                if (!int.TryParse(Console.ReadLine(), out valandos))
                {
                    Console.WriteLine("Ivesti neteisingi duomenys, pakartokite");
                    duomenysTeisingi = false;
                }
                else if (valandos < 0 || valandos > 24)
                {
                    Console.WriteLine("Ivestas neteisingas skaicius, pakartokite");
                    duomenysTeisingi = false;
                }
                else
                {
                    duomenysTeisingi = true;
                    
                }
                
            }
            return valandos;
        }

        public int PriimtiMinutes()
        {
            int minutes = 0;
            bool duomenysTeisingi = false;

            Console.WriteLine("Iveskite minutes:");

            while (duomenysTeisingi == false)
            {
                if (!int.TryParse(Console.ReadLine(), out minutes))
                {
                    Console.WriteLine("Ivesti neteisingi duomenys, pakartokite");
                    duomenysTeisingi = false;
                }
                else if (minutes < 0 || minutes > 59)
                {
                    Console.WriteLine("Ivestas neteisingas skaicius, pakartokite");
                    duomenysTeisingi = false;
                }
                else
                {
                    duomenysTeisingi = true;

                }

            }

            return minutes;
        }

        public double PaskaiciuotiMazesnijiKampaTarpRodykliu(int aVal, int aMin)
        {
            if(aVal > 12)
            {
                aVal -= 12;
            }

            double laipsniaiTarpRodykliu;
            double laipsniaiMin = aMin * 6;  //360 laipsniu padalinam is 60 minuciu = 6 laipsniai per 1 min
            double laipsniaiVal = aVal * 30 + aMin * 0.5;  //per viena min valanda pajuda 0.5 laipsnio

            //Console.WriteLine($"Laipsniai min: {laipsniaiMin}");
            //Console.WriteLine($"Laipsniai val: {laipsniaiVal}");

            if (laipsniaiMin < laipsniaiVal)
            {
                if((laipsniaiVal - laipsniaiMin) > 180)
                {
                    laipsniaiTarpRodykliu = 360 - (laipsniaiVal - laipsniaiMin);
                    return laipsniaiTarpRodykliu;
                }
                else
                {
                    laipsniaiTarpRodykliu = laipsniaiVal - laipsniaiMin;
                    return laipsniaiTarpRodykliu;
                }
                
            }
            else if (laipsniaiMin > laipsniaiVal)
            {
                if ((laipsniaiMin - laipsniaiVal) > 180)
                {
                    laipsniaiTarpRodykliu = 360 - (laipsniaiMin - laipsniaiVal);
                    return laipsniaiTarpRodykliu;
                }
                else
                {
                    laipsniaiTarpRodykliu = laipsniaiMin - laipsniaiVal;
                    return laipsniaiTarpRodykliu;
                }
            }
            else
            {
                return 0;
            }          
            
        }

        public void ParodytiRezultata(double aLaipsniaiTarpRod)
        {
            Console.WriteLine($"Mazesnis kampas laipsniais tarp rodykliu yra {aLaipsniaiTarpRod}");
            Console.WriteLine("Iseiti is programos iveskite [exit], testi bet koks mygtukas [enter]");
            string iseiti = Console.ReadLine();
            
            if(iseiti == "exit")
            {
                Environment.Exit(0);
            }
        }
    }
}
