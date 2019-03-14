using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaghettiCode
{
    class Drink
    {
        int drinkType, drinkMl, withMilk, milkCapacity, withSugar, SugarCubes;
        public Drink(int a, int b, int c, int d, int e, int f)
        {
            this.drinkType = a;
            this.drinkMl = b;
            this.withMilk = c;
            this.milkCapacity = d;
            this.withSugar = e;
            this.SugarCubes = f;
        }
        public string Create()
        {
            string food = "";
            int ml = 0;
            string size = "";
            string milk = "bez mleka";
            string shugar = "";

            //switch (drinkType)
            //{
            //    case 1:
            //        food = "Woda";
            //        break;
            //    case 2:
            //        food = "Herbata";
            //        break;
            //    case 3:
            //        food = "Kawa";
            //        break;
            //    case 4:
            //        food = "Porcja rosołu";
            //        break;
            //    default:
            //        break;
            //}

            //switch (drinkMl)
            //{
            //    case 1:
            //        ml = 50;
            //        break;
            //    case 2:
            //        ml = 100;
            //        break;
            //    case 3:
            //        ml = 150;
            //        break;
            //    case 4:
            //        ml = 200;
            //        break;
            //    default:
            //        break;
            //}

            //if (ml > 150)
            //{
            //    size = "duża";
            //}
            //else if (ml > 100 && ml <= 150)
            //{
            //    size = "średnia";
            //}
            //else if (ml > 0)
            //{
            //    size = "mała";
            //}

            //if (withMilk != 0)
            //{
            //    milk = "z mlekiem";
            //    int milkMl = 0;
            //    switch (milkCapacity)
            //    {
            //        case 1:
            //            milkMl = 50;
            //            break;
            //        case 2:
            //            milkMl = 100;
            //            break;
            //        case 3:
            //            milkMl = 150;
            //            break;
            //        case 4:
            //            milkMl = 200;
            //            break;
            //        default:
            //            break;
            //    }
            //    milk += $" {milkMl} ml";
            //}


            if (withSugar != 20)
            {
                shugar = "bez cukru.";
            }
            else
            {
                shugar = "z cukrem";
                if (SugarCubes > 0)
                {
                    shugar += " 1";
                    if (SugarCubes > 1)
                    {
                        shugar = shugar.Replace(" 1", " 2");
                        if (SugarCubes > 2)
                        {
                            shugar = shugar.Replace(" 2", " 3");
                            if (SugarCubes == 4)
                            {
                                shugar = shugar.Replace(" 3", " 4");
                            }
                        }
                    }
                }
                shugar += " kostki.";
            }


            food += $"; {size} {ml} ml; {milk}; {shugar}";

            return food;

        }
    }
}
