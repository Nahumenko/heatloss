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

        



        //Интерполяция для двухтрубной подземной прокладки
        public double twoTubesUnderground(double t1_crG, double t2_crG, double taoGr_crG)
        {
            return deltaTcv = ((t1_crG + t2_crG) / 2) - taoGr_crG;
        }


        //для подающего отдельно
        public double onePipeUndergtoundFlow()

    }
}
