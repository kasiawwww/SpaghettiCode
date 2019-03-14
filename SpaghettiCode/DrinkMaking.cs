using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaghettiCode
{
    class DrinkMaking
    {
        public string PickDrinkType(int drinkType)
        {
            switch (drinkType)
            {
                case 1:
                    return "Woda";
                case 2:
                    return "Herbata";                  
                case 3:
                    return "Kawa";                   
                case 4:
                    return "Porcja rosołu";                   
                default:
                    return "";                    
            }
        }
        public int PickDrinkSize(int drinkMl, out string sizeDescription)
        {
            switch (drinkMl)
            {
                case 1:
                    sizeDescription = "mała";
                    return 50;
                case 2:
                    sizeDescription = "mała";
                    return 100;
                case 3:
                    sizeDescription = "średnia";
                    return 150;
                case 4:
                    sizeDescription = "duża";
                    return 200;
                default:
                    sizeDescription = "";
                    return 0;
            }
        }
        public int PickMilkAddition(int withMilk, int milkCapacity)
        {
            if (withMilk != 0)
            {
                milk = "z mlekiem";
                int milkMl = 0;
                switch (milkCapacity)
                {
                    case 1:
                        milkMl = 50;
                        break;
                    case 2:
                        milkMl = 100;
                        break;
                    case 3:
                        milkMl = 150;
                        break;
                    case 4:
                        milkMl = 200;
                        break;
                    default:
                        break;
                }
                milk += $" {milkMl} ml";
            }
        }

    }
}
