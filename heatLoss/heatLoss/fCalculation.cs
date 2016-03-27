using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace heatLoss
{
    public partial class fCalculation : Form
    {
        fFiveCalc fFiveCalc = new fFiveCalc();
        public fInitalData fInitaldata = new fInitalData();
        public fCalculation()
        {
            InitializeComponent();
        }
        private void btnInitalData_Click(object sender, EventArgs e)
        {
            fInitaldata.ShowDialog();
        }
        private void fCalculation_Load(object sender, EventArgs e)
        {
        }
        private void btnFiveCalc_Click(object sender, EventArgs e)
        {
            fFiveCalc.Owner = fInitaldata;
            fFiveCalc.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //подключаем ексель
            //загружаю шаблон
            Microsoft.Office.Interop.Excel.Application Excelapp = new Microsoft.Office.Interop.Excel.Application();
            Excelapp.Application.Workbooks.Add(Path.GetFullPath(@"..\..\Resources\template.xlsx"));
            // активный первый лист
            Excelapp.Sheets[1].activate();
            //вывод исходных данных
            for (int i = 0; i < 14; i++)
            {
                Excelapp.Cells[i + 6, 1] = pereprava.tempTable[i].month;
                Excelapp.Cells[i + 6, 2] = pereprava.tempTable[i].Tcrm_vozd;
                Excelapp.Cells[i + 6, 3] = pereprava.tempTable[i].Tcrm_grunt;
                Excelapp.Cells[i + 6, 4] = pereprava.tempTable[i].Tcrm_H20;
                Excelapp.Cells[i + 6, 5] = pereprava.tempTable[i].T1_P;
                Excelapp.Cells[i + 6, 6] = pereprava.tempTable[i].T1_F;
                Excelapp.Cells[i + 6, 7] = pereprava.tempTable[i].T2_P;
                Excelapp.Cells[i + 6, 8] = pereprava.tempTable[i].T2_F;
            }
            // вывод на второй лист
            Excelapp.Sheets[2].activate();
            // тип прокладки
            Excelapp.Cells[2, 1] = pereprava.methodOflyining;
            // разнос на две трубы
            switch (pereprava.Tcheck == true)
            {
                case true:
                    Excelapp.Cells[3, 1] = "Q";
                    Excelapp.Cells[3, 2] = pereprava.outsideDiametr;
                    Excelapp.Cells[3, 3] = pereprava.L;
                    Excelapp.Cells[3, 4] = pereprava.Q1;
                    Excelapp.Cells[3, 5] = pereprava.L * pereprava.Q1;
                    break;
                case false:
                    Excelapp.Cells[3, 1] = "Q1";
                    Excelapp.Cells[4, 1] = "Q2";
                    Excelapp.Cells[3, 2] = pereprava.outsideDiametr;
                    Excelapp.Cells[4, 2] = pereprava.outsideDiametr;
                    Excelapp.Cells[3, 3] = pereprava.L;
                    Excelapp.Cells[3, 4] = pereprava.Q1;
                    Excelapp.Cells[3, 5] = pereprava.L * pereprava.Q1;
                    Excelapp.Cells[4, 3] = pereprava.L;
                    Excelapp.Cells[4, 4] = pereprava.Q2;
                    Excelapp.Cells[4, 5] = pereprava.L * pereprava.Q2;
                    break;
            }
            // вывод Делта т если есть права админаэ
            if (pereprava.check == true)
            {
                for (int i = 0; i < pereprava.heatLossMass.GetLength(0); i++)
                {
                    for (int j = 0; j < pereprava.heatLossMass.GetLength(1); j++)
                    {
                        Excelapp.Cells[i + 3, j + 7] = pereprava.heatLossMass[i, j];
                    }
                }
            }

            //вывод Т и КУ
            if (pereprava.Tcheck == true)
            {
                // один ТП
                for (int i = 0; i < 14; i++)
                {
                    Excelapp.Cells[i + 7, 2] = pereprava.t1mass[i];
                    Excelapp.Cells[i + 7, 3] = pereprava.q1mass[i];
                    Excelapp.Cells[i + 7, 1] = pereprava.tempTable[i].month;
                }
            }
            else
            {
                // два ТП
                Excelapp.Cells[6, 4] = "t2";
                Excelapp.Cells[6, 5] = "q2";
                for (int i = 0; i < 14; i++)
                {
                    Excelapp.Cells[i + 7, 2] = pereprava.t1mass[i];
                    Excelapp.Cells[i + 7, 3] = pereprava.q1mass[i];
                    Excelapp.Cells[i + 7, 1] = pereprava.tempTable[i].month;
                    Excelapp.Cells[i + 7, 4] = pereprava.t2mass[i];
                    Excelapp.Cells[i + 7, 5] = pereprava.q2mass[i];
                }
            }
            //показываем ексель
            Excelapp.Visible = true;
        }
    }
}
