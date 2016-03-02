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
        double qnf_crG;      // значение для подземной прокоадки на непроектный режим режим работы 
        double qn_crG;       // значения интерполированые из таблицы
        double q2nf_nadz;    //персчёт надземные обратка
        double q1nf_nadz;   //персчёт надземные подача
        double q1n_nadz;    //табличные надземные подача
        double q2n_nadz;    //табличные надземные обратка
        double Beta;        //коэффициент местных тепловых потерь i-го участка теплосети
        double L;           //длина участка, метры
        double qni;         //ранее полученные пароксимированные потери;
        double Qn_crG;             // потери средне годовые
        double Q1n_crG;             // потери средне годовые подача
        double Q2n_crG;             // потери средне годовые обратка
        double qbi;                  // для ТП принемаемых на баланс
        double Zbi;             // Чичсло часов в расматриваемом периоде
        double Qnb_crG;         // понятно да
        double Z_per;           //часы периода
        double Zotkl;           //часы отключения
        double QnOtkl_crG;      // потери отключения
        double qotkl;
        double Qnorm_crG;       //Нормируемые часовые значения среднегодовых тепловых 
        double Q1norm_crG;      //Нормируемые часовые значения среднегодовых тепловых 
        double Q2norm_crG;      //Нормируемые часовые значения среднегодовых тепловых 
        double K1;              //кафики
        double K2;
        double K;
        double K3;
        double SummQnorm_crG;    //Нормируемые часовые значения среднегодовых потерь по видам прокладок в целом 
        double Qnorm;           //средние за расчетный период часовые нормируемые значения тепловых потерь 
        double Q1norm_podz;     //подземная прокладка при отдельно уложенном трубопроводе,подача
        double Q2norm_podz;     //подземная прокладка при отдельно уложенном трубопроводе, обратка
        double t1_crPer;        //средние температуры сетевой воды в подающем и обрат-ном трубопроводах 
        double t2_crPer;        //за рассматриваемый расчетный период, цельсий
        double taoGr_crPer;     //средняя температура грунта за рассматриваемый расчетный период
        double taoV_crPer;      //средняя температура воздуха за рассматриваемый расчетный период
        double Q1norm_vozd;     //подающий трубопровод   надземная прокладка
        double Q2norm_vozd;     //обратный трубопровод надземная прокладка
        double Q1norm_pom;      //прокладка в помещении подающий трубопровод
        double Q2norm_pom;      //прокладка в помещении обратный трубопровод
        double Q1norm_tunnel;      //прокладка в тунеле подающий трубопровод
        double Q2norm_tunnel;      //прокладка в тунеле обратный трубопровод
        double SummQ1norm_crGPodz;
        double SummQ2norm_crGPodz;
        double SummQ1norm_crGVozd;
        double SummQ2norm_crGVozd;
        double SummQ1norm_crGPom;
        double SummQ2norm_crGPom;
        double SummQ1norm_crGTunnel;
        double SummQ2norm_crGTunnel;



        // всё что было выше полная хуйня не обращай внимание я это делал в бреду
        public List<InputTableData> tempTable = new List<InputTableData>();
        
        public void vvod(InputTableData x)
        {
            tempTable.Add(x);          
        }


        //всё что было ниже тоже что-то не понятное не обращай внимание я это делал в бреду 



















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
        //Спросить у ВНА о константах 15,40 нужно ли их изменение
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

        //Производится пересчет нормативных значений, определенных в соответствии с 5.4.7.1, 
        //на фактический среднегодовой режим работы участков теплосети по фор-мулам:

        //подземная прокладка
        //два трубопровода в режиме подающего трубопровода
        public double twoTubesUndergroundChanged(double qn_crG, double t1_crG, double t2_crG, double taoGr_crG,Direction direction)
        {
            if(direction == Direction.FLOW)
            return qnf_crG = qn_crG * (t1_crG - taoGr_crG) / (0.5 * (t1_crG + t2_crG) - taoGr_crG);//подача 
            else
            {
                return qnf_crG = qn_crG * (t2_crG - taoGr_crG) / (0.5 * (t1_crG + t2_crG) - taoGr_crG);
            }

        }
        //Спросить у ВНА, ЧТо за таоН
        //надземная прокладка
        public double onePipeAirChanged(double q1n_nadz, double t1_crG, double t2_crG, double taoV_crG, Direction direction)
        {
            if (direction == Direction.FLOW)
            {
                return q2nf_nadz = q1n_nadz * (t2_crG - taoV_crG) / (t1_crG - taoV_crG);
            }
            else
            {
                return q1nf_nadz = q2n_nadz * (t1_crG - taoV_crG) / (t2_crG - taoV_crG);
            }
        }

        //Расчет нормативных среднегодовых потерь 
        //Для водяной тепловой сети значения часовых среднегодовых нормативных тепло-вых потерь
        //для участков подземной двухтрубной прокладки
       public double LossTwoTubesUnderground(double qni, double Beta, double L)
        {
            return Qn_crG = qni * L * Beta;
        }


        //для участков надземной прокладки, прокладки в помещениях (технических подпо-льях), 
        //в тоннелях (проходных каналах), а также отдельно уложенных трубопрово-дов подземной прокладки
        //Написал два одинаковых метода, потом выщемими
        public double LossOnePipe(double qni, double Beta, double L,Direction direction)
        {
            if (direction == Direction.FLOW)
            {
                return Q1n_crG = qni * L * Beta;
            }
            else
            {
                return Q2n_crG = qni * L * Beta;
            }
        }

        //Для трубопроводов принимаемых на баланс в течение расчетного периода  норма-тивные часовые значения 
        //среднегодовых тепловых потерь определяются раздельно по каждому виду прокладки с предполагаемым числом 
        //часов их работы в расчет-ный период 
        public double LossPipeBalans(double qbi, double Zbi, double Qnb_crG, double Z_per)
        {
            return Qnb_crG = qbi * Beta * L * Zbi / Z_per;
        }

        //Для трубопроводов, отключаемых в течении расчетного периода, нормативные ча-совые значения среднегодовых потерь
        //определяются раздельно по каждому виду прокладки с предполагаемым числом часов отключения
        public double lossPipeOff(double qotkl, double Zotkl, double Qnb_crG, double Z_per)
        {
           return QnOtkl_crG = qotkl * Beta * L * Zotkl / Z_per;
        }

        //Нормирование тепловых потерь через теплоизоляционные конструк-ции трубопроводов водяных тепловых сетей
        //для подземной двухтрубной прокладки  
        public double NormAvarageAnnualHeatLossUnderground(double Qn_crG, double K)
        {
           return Qnorm_crG = Qn_crG * K;
        }

        //для участков надземной прокладки, прокладки в помещениях (технических подпо-льях), 
        //тоннелях (проходных каналах), а также отдельно уложенных трубопроводов подземной прокладки:
        public double NormAvarageAnnualHeatLoss(double K1, double K2, double Q1n_crG, double Q2n_crG,Direction direction)
        {
            if (direction == Direction.FLOW)
            {
                return Q1norm_crG = Q1n_crG * K1;
            }
            else
            {
                return Q2norm_crG = Q2n_crG * K2;
            }
        }

        //средние за расчетный период часовые нормируемые значения тепловых потерь пу-тем пересчета нормируемых
        //среднегодовых потерь с расчетного (проектного) сред-негодового режима на режим работы теплосети в расчетном периоде
        //двухтрубная подземная прокладка
        public double twoTibesUndergroundNormAvarege(double SummQnorm_crG, double t1_crPer, double t2_crPer, double taoGr_crPer, double t1_crG, double t2_crG,double taoGr_crG)
        {
            return Qnorm = SummQnorm_crG * (t1_crPer + t2_crPer - 2 * taoGr_crPer) / (t1_crG + t2_crG - 2 * taoGr_crG);
        }

        //подземная прокладка при отдельно уложенном трубопроводе
       public double onePipeUndergroundNormalAvarage(double SummQ1norm_crGPodz, double SummQ2norm_crGPodz, double t1_crPer, double t2_crPer, double taoGr_crPer, double t1_crG, double t2_crG, double taoGr_crG, Direction direction)
        {
            if (direction == Direction.FLOW)
            {
                return Q1norm_podz = SummQ1norm_crGPodz * (t1_crPer - taoGr_crPer) / (t1_crG - taoGr_crG);
            }
            else
            {
                return Q2norm_podz = SummQ2norm_crGPodz * (t2_crPer - taoGr_crPer) / (t2_crG - taoGr_crG);
            }
        }

        //надземная прокладка
        public double onePipeAirNormalAvarage(double SummQ1norm_crGVozd, double SummQ2norm_crGVozd, double t1_crPer, double t2_crPer, double taoV_crPer, double t1_crG, double t2_crG, double taoV_crG, Direction direction)
        {
            if (direction == Direction.FLOW)
            {
                return Q1norm_vozd = SummQ1norm_crGVozd * (t1_crPer - taoV_crPer) / (t1_crG - taoV_crG);
            }
            else
            {
                return Q2norm_vozd = SummQ2norm_crGVozd * (t2_crPer - taoV_crPer) / (t2_crG - taoV_crG);
            }
        }

        //прокладка в помещении
        public double onePipeHouseNormalAvarage(double SummQ1norm_crGPom, double SummQ2norm_crGPom, double t1_crPer, double t2_crPer, double t1_crG, double t2_crG, Direction direction)
        {
            if (direction == Direction.FLOW)
            {
                return Q1norm_pom = SummQ1norm_crGPom * (t1_crPer - 15) / (t1_crG - 15);
            }
            else
            {
                return Q2norm_pom = SummQ2norm_crGPom * (t2_crPer - 15) / (t2_crG - 15);
            }
        }

        //прокладка в канале
        public double onePipeTunnelNormalAvarage(double SummQ1norm_crGPom, double SummQ2norm_crGPom, double t1_crPer, double t2_crPer, double t1_crG, double t2_crG, Direction direction)
        {
            if (direction == Direction.FLOW)
            {
                return Q1norm_tunnel = SummQ1norm_crGTunnel * (t1_crPer - 40) / (t1_crG - 40);
            }
            else
            {
                return Q2norm_tunnel = SummQ2norm_crGTunnel * (t2_crPer - 40) / (t2_crG - 40);
            }
        }
        

    }
}
