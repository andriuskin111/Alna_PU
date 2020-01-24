using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alna_atranka_uzduotis_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        saka0
                      /       \
                     /         \
                saka1           saka2
                /    \          /    \
               /      \        /      \
          saka11    saka12  saka21    saka22
                    /       /         /    \
                   /       /         /      \
            saka121    saka211  saka221    saka222
                        /       /
                       /       /
               saka2111    saka2211
                            /   \
                           /     \
                   saka22111     saka22112
                                   /
                                  /
                              saka221121

            */

         //-------------------- sukuriam objektus (sakas) ---------------//
            Saka saka0 = new Saka();
            Saka saka1 = new Saka();
            Saka saka2 = new Saka();
            Saka saka11 = new Saka();
            Saka saka12 = new Saka();
            Saka saka21 = new Saka();
            Saka saka22 = new Saka();
            Saka saka121 = new Saka();
            Saka saka211 = new Saka();
            Saka saka221 = new Saka();
            Saka saka222 = new Saka();
            Saka saka2111 = new Saka();
            Saka saka2211 = new Saka();
            Saka saka22111 = new Saka();
            Saka saka22112 = new Saka();
            Saka saka221121 = new Saka();

         //----- sukuriam Listus<> i kuriuos desim objektus(sakas) -----//
            saka0.sakos = new List<Saka>();
            saka1.sakos = new List<Saka>();
            saka2.sakos = new List<Saka>();
            saka11.sakos = new List<Saka>();
            saka12.sakos = new List<Saka>();
            saka21.sakos = new List<Saka>();
            saka22.sakos = new List<Saka>();
            saka121.sakos = new List<Saka>();
            saka211.sakos = new List<Saka>();
            saka221.sakos = new List<Saka>();
            saka222.sakos = new List<Saka>();
            saka2111.sakos = new List<Saka>();
            saka2211.sakos = new List<Saka>();
            saka22111.sakos = new List<Saka>();
            saka22112.sakos = new List<Saka>();
            saka221121.sakos = new List<Saka>();

            // saka0 pridedam sakas
            saka0.sakos.Add(saka1);
            saka0.sakos.Add(saka2);

            // saka1 pridedam sakas
            saka1.sakos.Add(saka11);
            saka1.sakos.Add(saka12);

            // saka2 pridedam sakas
            saka2.sakos.Add(saka21);
            saka2.sakos.Add(saka22);

            // saka12 pridedam sakas
            saka12.sakos.Add(saka121);

            // saka21 pridedam sakas
            saka21.sakos.Add(saka211);

            //// saka22 pridedam sakas
            saka22.sakos.Add(saka221);
            saka22.sakos.Add(saka222);

            //// saka211  pridedam sakas
            saka211.sakos.Add(saka2111);

            //// saka221  pridedam sakas
            saka221.sakos.Add(saka2211);

            //// saka2211  pridedam sakas
            saka2211.sakos.Add(saka22111);
            saka2211.sakos.Add(saka22112);

            //// saka22112  pridedam sakas
            saka22112.sakos.Add(saka221121);

            Console.WriteLine($"Giliasias lygis yra: {SurastiMedzioStrukturosGiliausiaLygmeni(1, saka0.sakos)}"); // 1 nes saka0 yra pirmame lygyje

            Console.ReadLine();
        }

        public static int SurastiMedzioStrukturosGiliausiaLygmeni(int lygis, List<Saka> saka)
        {
            int giliausiasLygis = lygis; // siuo momentu giliausias lygis tampa gautuoju
                
            if (saka.Count > 0)  // Tikrinam ar gautame List<> yra objektai
            {
                for (int i = 0; i < saka.Count; i++) // tikrinam gauto listo objektu Listus<> ar turi dar objektu
                {
                   // jeigu siuo metu esantis giliausias lygis maziau negu metodo grazintas, jis tampa tokiu koki grazino metodas 
                   if(giliausiasLygis < SurastiMedzioStrukturosGiliausiaLygmeni(lygis + 1, saka.ElementAt(i).sakos))
                    {
                        giliausiasLygis = SurastiMedzioStrukturosGiliausiaLygmeni(lygis + 1, saka.ElementAt(i).sakos);
                    }
                   
                }  
                
            }

            return giliausiasLygis;

        }
    }
}
