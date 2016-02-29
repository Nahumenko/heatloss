﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace heatLoss
{
    class InputData
    {
        // все переменные представляют сосбой шапку таблицы исходных данных
        public string month;
        public double Tcrm_vozd;
        public double Tcrm_grunt;
        public double Tcrm_H20;
        public double T1_P;
        public double T1_F;
        public double T2_P;
        public double T2_F;




        //конструктор класса исходных данных
        // что бы быстренько ввести переменные
        public InputData(string _month, double _Tcrm_vozd, double _Tcrm_grunt, double _Tcrm_H20, double _T1_P, double _T1_F, double _T2_P, double _T2_F)
        {
            month = _month;
            Tcrm_vozd = _Tcrm_vozd;
            Tcrm_grunt = _Tcrm_grunt;
            Tcrm_H20 = _Tcrm_H20;
            T1_P = _T1_P;
            T1_F = _T1_F;
            T2_P = _T2_P;
            T2_F = _T2_F;
        }
        public InputData()
        {
        }


    }


}
