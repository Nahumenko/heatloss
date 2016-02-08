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
                            //СНиП 2.04.14-88 «Тепловая изоляция оборудования и трубопроводов», метры
        double deltaT1_podz;// подача одиночная подземная прокладка температкрный напор, цельсий
        double deltaT2_podz;// обратка одиночная подземная прокладка температкрный напор, цельсий
        double deltaT1_vozd;// подача воздушка температкрный напор, цельсий
        double deltaT2_vozd;// обратка воздушка температкрный напор, цельсий
        double taoV_crG;    // среднегодова температура воздуха всё их ТОЙ ЖЕ ТАБЛИЦЫ, цельсий
        double deltaT1_pom;  // температурный напор для подачи при прокладки в помещении или тех подвале ,цельсий
        double deltaT2_pom;  // температурный напор для обратки при прокладки в помещении или тех подвале ,цельсий
        double deltaT1_tunel;// температурный напор для обратки при прокладки в проходном канале или тоннеле ,цельсий 
        double deltaT2_tunel;// температурный напор для обратки при прокладки в проходном канале или тоннеле ,цельсий









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

        // надземная прокладка
        public double onePipeAir(Direction direction, double t1_crG, double t2_crG, double taoGr_crG)
        {
            if (direction == Direction.FLOW)
                return deltaT1_vozd = t1_crG - taoV_crG;            //для подачи
            else return deltaT2_vozd = t2_crG - taoV_crG;           //для обратки
        }

        //для трубопроводов расположенных в помещении (техническом подполье) или тоннеле (проходном канале)

        public double onePipeHouse(Direction direction, double t1_crG, double t2_crG)
        {
            if (direction == Direction.FLOW)
                return deltaT1_pom = t1_crG - 15;            //для подачи
            else return deltaT2_pom = t2_crG - 15;           //для обратки
        }

        //для трубопроводов расположенных в канале туннеле
        public double onePipeTunnel(Direction direction, double t1_crG, double t2_crG)
        {
            if (direction == Direction.FLOW)
                return deltaT1_tunel = t1_crG - 40;            //для подачи
            else return deltaT2_tunel = t2_crG - 40;           //для обратки
        }
    }
}
