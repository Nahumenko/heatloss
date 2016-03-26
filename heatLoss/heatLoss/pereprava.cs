using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heatLoss
{
   static class pereprava
    {
        // таблица исходных данных
        static public List<InputTableData> tempTable = new List<InputTableData>();
        // Флаг админа
        static public bool check = false;
        //Переменые вывода данных
        static public double L;// длинна участа
        static public double Q1,Q2; //кушки , потери тепла
        static public double[,] heatLossMass; // масив потерь
        static public double T1,T2;// расчитанные перепады
        static public string methodOflyining;// тип прокладки
        static public string outsideDiametr;
        static public double[] t1mass;
        static public double[] t2mass;
        static public double[] q1mass;
        static public double[] q2mass;
        
        // флаг двух труб
        static public bool Tcheck; // true 1 // false 2

    }
}
