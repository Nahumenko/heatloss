using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heatLoss
{
    class claculationFirst
    {
        public double deltaTcv;    //Температурный напор подземная прокладка, Цельсий
        double t1_crG;      //среднегодовая температура сетевой воды в подающем и обратном тру-бопроводах определенные 
        double t2_crG;      //из проектного температурного графика, градус Цельсия
        double taoGr_crG;   //среднегодовая температура грунта согласно ТАБЛИЦЫ КОТОРУЮ НУЖНО ДАБОАВИТЬ, Цельсий
                            // depth;       //Примечание. Если глубина 0,7 и менее тогда вместо тао грунта берёться тао воздуха но только для
                            //СНиП 2.04.14-88 «Тепловая изоляция оборудования и трубопроводов», метры
        public double deltaT1_podz;// подача одиночная подземная прокладка температкрный напор, цельсий
        public double deltaT2_podz;// обратка одиночная подземная прокладка температкрный напор, цельсий
        public double deltaT1_vozd;// подача воздушка температкрный напор, цельсий
        public double deltaT2_vozd;// обратка воздушка температкрный напор, цельсий
        double taoV_crG;    // среднегодова температура воздуха всё их ТОЙ ЖЕ ТАБЛИЦЫ, цельсий
        double normTempInHouse = 15;// средня температурав домеме и проходном канале
        double normTempInTunel = 40;//средняя температура в тунеле
        public double deltaT1_pom;  // температурный напор для подачи при прокладки в помещении или тех подвале ,цельсий
        public double deltaT2_pom;  // температурный напор для обратки при прокладки в помещении или тех подвале ,цельсий
        public double deltaT1_tunel;// температурный напор для обратки при прокладки в проходном канале или тоннеле ,цельсий 
        public double deltaT2_tunel;// температурный напор для обратки при прокладки в проходном канале или тоннеле ,цельсий
        public double qnf_crG;      // значение для подземной прокоадки на непроектный режим режим работы 
        public double deltaTnp; // проектная температура пара
                                //   double qn_crG;       // значения интерполированые из таблицы
                                // double q2nf_nadz;    //персчёт надземные обратка
                                //double q1nf_nadz;   //персчёт надземные подача
                                //double q1n_nadz;    //табличные надземные подача
                                //double q2n_nadz;    //табличные надземные обратка
                                //double Beta;        //коэффициент местных тепловых потерь i-го участка теплосети
                                //double L;           //длина участка, метры
                                //double qni;         //ранее полученные пароксимированные потери;
        double Qn_crG;             // потери средне годовые
        double Q1n_crG;             // потери средне годовые подача
        double Q2n_crG;             // потери средне годовые обратка
                                    // double qbi;                  // для ТП принемаемых на баланс
                                    //double Zbi;             // Чичсло часов в расматриваемом периоде
                                    //double Qnb_crG;         // понятно да
                                    //double Z_per;           //часы периода
                                    //double Zotkl;           //часы отключения
        double QnOtkl_crG;      // потери отключения
                                // double qotkl;
        double Qnorm_crG;       //Нормируемые часовые значения среднегодовых тепловых 
        double Q1norm_crG;      //Нормируемые часовые значения среднегодовых тепловых 
        double Q2norm_crG;      //Нормируемые часовые значения среднегодовых тепловых 
                                //double K1;              //кафики
                                //double K2;
                                //double K;
                                //double K3;
                                //double SummQnorm_crG;    //Нормируемые часовые значения среднегодовых потерь по видам прокладок в целом 
        double Qnorm;           //средние за расчетный период часовые нормируемые значения тепловых потерь 
        double Q1norm_podz;     //подземная прокладка при отдельно уложенном трубопроводе,подача
        double Q2norm_podz;     //подземная прокладка при отдельно уложенном трубопроводе, обратка
                                //double t1_crPer;        //средние температуры сетевой воды в подающем и обрат-ном трубопроводах 
                                //double t2_crPer;        //за рассматриваемый расчетный период, цельсий
                                //double taoGr_crPer;     //средняя температура грунта за рассматриваемый расчетный период
                                //double taoV_crPer;      //средняя температура воздуха за рассматриваемый расчетный период
        double Q1norm_vozd;     //подающий трубопровод   надземная прокладка
        double Q2norm_vozd;     //обратный трубопровод надземная прокладка
        double Q1norm_pom;      //прокладка в помещении подающий трубопровод
        double Q2norm_pom;      //прокладка в помещении обратный трубопровод
        double Q1norm_tunnel;      //прокладка в тунеле подающий трубопровод
        double Q2norm_tunnel;      //прокладка в тунеле обратный трубопровод
        //double SummQ1norm_crGPodz;
        //double SummQ2norm_crGPodz;
        //double SummQ1norm_crGVozd;
        //double SummQ2norm_crGVozd;
        //double SummQ1norm_crGPom;
        //double SummQ2norm_crGPom;
        //double SummQ1norm_crGTunnel;
        //double SummQ2norm_crGTunnel;




        // таблица
        public List<InputTableData> tempTable = new List<InputTableData>();

        // надземная прокладка
        public double onePipeAir(Direction direction)
        {
            t1_crG = tempTable[12].T1_P;
            t2_crG = tempTable[12].T2_P;
            taoV_crG = tempTable[12].Tcrm_vozd;

            double z;
            if (direction == Direction.FLOW)
                deltaT1_vozd = z = t1_crG - taoV_crG;          //для подачи
            else
                deltaT2_vozd = z = t2_crG - taoV_crG;           //для обратки
            return z;
        }
        public double[] onePipeAirMass(Direction direction)
        {
            double[] z = new double[14];
            for (int i = 0; i < 14; i++)
            {
                t1_crG = tempTable[i].T1_P;
                t2_crG = tempTable[i].T2_P;
                taoV_crG = tempTable[i].Tcrm_vozd;
                if (direction == Direction.FLOW)
                    z[i] = t1_crG - taoV_crG;          //для подачи
                else
                    z[i] = t2_crG - taoV_crG;           //для обратки
            }
            return z;
        }
        //подземная прокладка таблицы Б две трубы
        public double twoTubesUnderground(bool depth)
        {
            t1_crG = tempTable[12].T1_P;
            t2_crG = tempTable[12].T2_P;
            taoGr_crG = tempTable[12].Tcrm_grunt;
            taoV_crG = tempTable[12].Tcrm_vozd;
            double z;
            if (depth == false) { deltaTcv = z = ((t1_crG + t2_crG) / 2) - taoGr_crG; }
            else { deltaTcv = z = ((t1_crG + t2_crG) / 2) - taoV_crG; }
            return z;
        }
        //массив
        public double[] twoTubesUndergroundMass(bool depth)
        {
            double[] Tmass = new double[14];
            if (depth == false)
            {
                for (int i = 0; i < 14; i++)
                {
                    Tmass[i] = ((tempTable[i].T1_P + tempTable[i].T2_P) / 2) - tempTable[i].Tcrm_grunt;
                }
            }
            else
            {
                for (int i = 0; i < 14; i++)
                {
                    Tmass[i] = ((tempTable[i].T1_P + tempTable[i].T2_P) / 2) - tempTable[i].Tcrm_vozd;
                }
            }
            return Tmass;
        }
        // подземная прокладка подача отдельно обратка отдельно В,Г 
        public double onePipeUndergtound(Direction direction, bool depth)
        {
            t1_crG = tempTable[12].T1_P;
            t2_crG = tempTable[12].T2_P;
            taoGr_crG = tempTable[12].Tcrm_grunt;
            taoV_crG = tempTable[12].Tcrm_vozd;
            double z;
            if (depth == false)
            {
                if (direction == Direction.FLOW)
                    z = deltaT1_podz = t1_crG - taoGr_crG;            //для подачи
                else z = deltaT2_podz = t2_crG - taoGr_crG;           //для обратки}
            }
            else
            {
                if (direction == Direction.FLOW)
                    z = deltaT1_podz = t1_crG - taoV_crG;            //для подачи
                else z = deltaT2_podz = t2_crG - taoV_crG;           //для обратки
            }
            return z;
        }
        public double[] onePipeUndergtoundMass(Direction direction, bool depth)
        {
            double[] z = new double[14];
            for (int i = 0; i < 14; i++)
            {
                t1_crG = tempTable[i].T1_P;
                t2_crG = tempTable[i].T2_P;
                taoGr_crG = tempTable[i].Tcrm_grunt;
                taoV_crG = tempTable[i].Tcrm_vozd;
                if (depth == false)
                {
                    if (direction == Direction.FLOW)
                        z[i] = deltaT1_podz = t1_crG - taoGr_crG;            //для подачи
                    else z[i] = deltaT2_podz = t2_crG - taoGr_crG;           //для обратки}
                }
                else
                {
                    if (direction == Direction.FLOW)
                        z[i] = deltaT1_podz = t1_crG - taoV_crG;            //для подачи
                    else z[i] = deltaT2_podz = t2_crG - taoV_crG;           //для обратки
                }
            }
            return z;
        }

        //для трубопровода расположено в здании, проходном канале
        public double onePipeHouse(Direction direction)
        {
            t1_crG = tempTable[12].T1_P;
            t2_crG = tempTable[12].T2_P;
            double z;
            if (direction == Direction.FLOW)
                z = deltaT1_pom = t1_crG - normTempInHouse;            //для подачи
            else z = deltaT2_pom = t2_crG - normTempInHouse;           //для обратки
            return z;
        }
        public double[] onePipeHouseMass(Direction direction)
        {
            double[] z = new double[14];
            for (int i = 0; i < 14; i++)
            {
                t1_crG = tempTable[i].T1_P;
                t2_crG = tempTable[i].T2_P;

                if (direction == Direction.FLOW)
                    z[i] = deltaT1_pom = t1_crG - normTempInHouse;            //для подачи
                else z[i] = deltaT2_pom = t2_crG - normTempInHouse;           //для обратки
            }
            return z;
        }

        //для трубопроводов расположенных в канале туннеле
        public double onePipeTunnel(Direction direction)
        {
            t1_crG = tempTable[12].T1_P;
            t2_crG = tempTable[12].T2_P;
            double z;
            if (direction == Direction.FLOW)
                z = deltaT1_tunel = t1_crG - normTempInTunel;            //для подачи
            else z = deltaT2_tunel = t2_crG - normTempInTunel;           //для обратки
            return z;
        }
        public double[] onePipeTunnelMass(Direction direction)
        {
            double[] z = new double[14];
            for (int i = 0; i < 14; i++)
            {
                t1_crG = tempTable[i].T1_P;
                t2_crG = tempTable[i].T2_P;

                if (direction == Direction.FLOW)
                    z[i] = deltaT1_tunel = t1_crG - normTempInTunel;            //для подачи
                else z[i] = deltaT2_tunel = t2_crG - normTempInTunel;           //для обратки 
            }
            return z;
        }

        //подземная прокладка
        //два трубопровода в режиме подающего трубопровода
        public double twoTubesUndergroundChanged(double z, Direction direction)
        {
            t1_crG = tempTable[12].T1_P;
            t2_crG = tempTable[12].T2_P;
            taoGr_crG = tempTable[12].Tcrm_grunt;

            if (direction == Direction.FLOW)
                z = qnf_crG = z * (t1_crG - taoGr_crG) / (0.5 * (t1_crG + t2_crG) - taoGr_crG);//подача 
            else
            {
                z = qnf_crG = z * (t2_crG - taoGr_crG) / (0.5 * (t1_crG + t2_crG) - taoGr_crG);
            }
            return z;

        }

        //надземная прокладка
        public double onePipeAirChanged(double q, Direction direction, string s)
        {
            double t;
            t1_crG = tempTable[12].T1_P;
            t2_crG = tempTable[12].T2_P;
            taoV_crG = tempTable[12].Tcrm_vozd;
            switch (s)
            {
                default:
                    t = taoV_crG;
                    break;
                case "Tunel":
                    t = deltaT1_tunel;
                    break;
                case "house":
                    t = deltaT2_pom;
                    break;
            }
            if (direction == Direction.FLOW)
            {
                q = q * (t2_crG - t) / (t1_crG - t);
            }
            else
            {
                q = q * (t1_crG - t) / (t2_crG - t);
            }
            return q;
        }
        public double[] onePipeAirChangedMass(double[] q, Direction direction, string s)
        {
            double t;
            for (int i = 0; i < 14; i++)
            {
                t1_crG = tempTable[i].T1_P;
                t2_crG = tempTable[i].T2_P;
                taoV_crG = tempTable[i].Tcrm_vozd;
                switch (s)
                {
                    default:
                        t = taoV_crG;
                        break;
                    case "Tunel":
                        t = deltaT1_tunel;
                        break;
                    case "house":
                        t = deltaT2_pom;
                        break;
                }
                if (direction == Direction.FLOW)
                {
                    q[i] = q[i] * (t2_crG - t) / (t1_crG - t);
                }
                else
                {
                    q[i] = q[i] * (t1_crG - t) / (t2_crG - t);
                }

            }
            return q;
        }
        // для паропровода подземной прокладки
        public double steamOnePipeUnderGround()
        {
            return deltaTnp = tempTable[12].T1_P - tempTable[12].Tcrm_grunt;
        }
        public double[] steamOnePipeUnderGroundMAss()
        {
            double[] f = new double[14];
            for (int i = 0; i < 14; i++)
            {
                f[i] = tempTable[i].T1_P - tempTable[i].Tcrm_grunt;
            }
            return f;
        }
    }
}
