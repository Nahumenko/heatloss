using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heatLoss
{
    class linterp
    {
        // описание переменных
        public double x0;
        public double x1;
        public double x2;
        public double y0;
        public double y1;
        public double y2;
        public double[,] arr; // массив
    

        //конструктор класса
        // все переменные
        public linterp(double _x0, double _x1, double _x2, double _y0, double _y1, double _y2)
        {
            x0 = _x0;
            x1 = _x1;
            x2 = _x2;
            y0 = _y0;
            y1 = _y1;
            y2 = _y2;
        }

        // конструктор
        public linterp()
        {
        }

        //проверка внутри класса можно ли производить интерполяцию 
        // если фолс то интерполяция не проводилась
        // если вернула тру то интерполяция провелась   
        public bool check()
        {
            bool z;
            if (x0 < x1 && x1 < x2)
            {
                z = true;
                if (y0 == 0) { y0 = (y1 * (x0 - x2) + y2 * (x1 - x0)) / (x1 - x2); }
                if (y1 == 0) { y1 = y0 + (x1 - x0) / (x2 - x0) * (y2 - y0); }
                if (y2 == 0) { y2 = y0 + (y1 - y0) * (x2 - x0) / (x1 - x0); }
            }
            else z = false;
            return z;
        }


        //работа иду с массивом 
        // даёшь массив, отдаёт интерпалированную кушку
        public double massiv(double[,] mass, double x)
        {
            double q=666;
            if (mass[0, 0] == x)
            {
                q = mass[0, 1];                         //провекрака на первый элемент
            }
            else if (mass[mass.GetLength(0), 0] == x)
            {
                q = mass[mass.GetLength(0), mass.GetLength(1)]; // проверка на последний эллемент
            }
            else if (mass[0, 0] > x)
            {
                q = (mass[1, 1] * (x - mass[1, 0]) + mass[1, 1] * (mass[0, 0] - x)) / (mass[0, 0] - mass[1, 0]); //меньше диапазона
            }
            else if (mass[mass.GetLength(0), 0] < x)
            {
                q = mass[mass.GetLength(0)-1,mass.GetLength(1)] + (mass[mass.GetLength(0),mass.GetLength(1)] - mass[mass.GetLength(0) - 1, mass.GetLength(1)]) * (x - mass[mass.GetLength(0)-1,0]) / (mass[mass.GetLength(0) , 0] - mass[mass.GetLength(0)-1,0]); // больше диапазона
            }
            else
            {
                for (i = 0; i < mass.GetLength(0); i++)
                {
                    if (mass[i, 0] > x && x < mass[i++, 0])
                    {
                        q= mass[i, 1] + (x - mass[i, 0]) / (mass[i++, 0] - mass[i, 0]) * (mass[i++, 1] - mass[i, 1]);       // если попадётся между                        
                    }
                }
            }
            return q;
        }
            


            double nx;
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    if(array[,])
                }
            }
        }
    }

}

