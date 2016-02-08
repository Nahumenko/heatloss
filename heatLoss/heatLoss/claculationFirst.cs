using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heatLoss
{
    class claculationFirst
    {
        double deltaTcv;    //Температурный напор подземная прокладка, Цельсий
        double t1_crG;      //среднегодовая температура сетевой воды в подающем и обратном тру-бопроводах определенные 
        double t2_crG;      //из проектного температурного графика, градус Цельсия
        double taoGr_crG;   //среднегодовая температура грунта согласно ТАБЛИЦЫ КОТОРУЮ НУЖНО ДАБОАВИТЬ, Цельсий
        double depth;       //Примечание. Если глубина 0,7 и менее тогда вместо тао грунта берёться тао воздуха но только для
                            //СНиП 2.04.14-88 «Тепловая изоляция оборудования и трубопроводов»
        double deltaT1_podz;// подача одиночная подземная прокладка
        double deltaT2_podz;// обратка одиночная подземная прокладка
        double deltaT1_vozd;// подача воздушка
        double deltaT2_vozd;// обратка воздушка








        //Интерполяция для двухтрубной подземной прокладки
        public double twoTubesUnderground(double t1_crG, double t2_crG, double taoGr_crG)
        {
            return deltaTcv = ((t1_crG + t2_crG) / 2) - taoGr_crG;
        }


        //для отдельно зарытых труб подающего и обратного трубопровода
        public double onePipeUndergtound(Direction direction, double t1_crG, double t2_crG, double taoGr_crG)
        {
            if (direction== Direction.FLOW)            
                return deltaTcv = t1_crG - taoGr_crG;            //для подачи
            else return deltaTcv = t2_crG - taoGr_crG;           //для обратки
        }

        //5,44 пропустил там голая выборка


        public double onePipeAir(Direction direction, double t1_crG, double t2_crG, double taoGr_crG)
        {
            if (direction == Direction.FLOW)
                return deltaT1_podz = t1_crG - taoGr_crG;            //для подачи
            else return deltaT2_podz = t2_crG - taoGr_crG;           //для обратки
        }

    }
}
