using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace heatLoss
{
    public partial class fFiveCalc : Form
    {
        // создаю рассчётный касс
        claculationFirst calc = new claculationFirst();
        //класс интерполяции
        linterp lin = new linterp();
        //передаю в него таблицу исходных данных

        public fFiveCalc()
        {
            InitializeComponent();

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            // проверка ввода
            // проверка ввода

            // обновление таблицы
            this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl(Convert.ToInt32(cbType.SelectedValue), cbNhwInYear.Checked, cbYear.Checked, Convert.ToInt32(cbOutDiam.SelectedValue));
            if (cbType.SelectedIndex == 0)
            {

            }
            // месеж бокс условие воздушка 
            if (cbType.SelectedIndex == 3)
            {
                // вот по этим значениям нужно брать данные из таблицы
              double x=  calc.deltaT1_vozd = calc.onePipeAir(Direction.FLOW);
             double xx=   calc.deltaT2_vozd = calc.onePipeAir(Direction.RETURN);
                //заносим массив
                double[,] heatLossMass = inMass(dgv_heatloss.RowCount, dgv_heatloss.ColumnCount);
                //дополниттельная проверка на кол-во строк в массиве
                if (heatLossMass.GetLength(0) != 0)
                {
                    MessageBox.Show(lin.massiv(heatLossMass, calc.deltaT1_vozd).ToString());
                    MessageBox.Show(lin.massiv(heatLossMass, calc.deltaT2_vozd).ToString());
                    chart1.Series.Clear();
                    chart1.Series.Add("табличные значения");
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                    chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
                    for (int i = 0; i < heatLossMass.GetLength(0); i++)
                    {
                        chart1.Series[0].Points.AddXY(heatLossMass[i, 0], heatLossMass[i, 1]);
                    }
                    chart1.Series.Add("линейная интерполяция");
                    chart1.Series[1].ChartType = SeriesChartType.Point;
                    chart1.Series[1].MarkerStyle = MarkerStyle.Cross;
                    chart1.Series[1].Points.AddXY(x, lin.massiv(heatLossMass, calc.deltaT1_vozd));
                    chart1.Series[1].Points.AddXY(xx, lin.massiv(heatLossMass, calc.deltaT2_vozd));
                    // интерпалируем значения взятые из таблицы и присваимваем ку1 и ку 2
                }
                else MessageBox.Show("В базе данных нет значений для заданого диаметра");

            }
            //график
            /* double[] x = new double[5];
             x[0] = 1; x[1] = 2; x[2] = 3; x[3] = 4; x[4] = 5;
             double[] y = new double[5];
             y[0] = 1; y[1] = 5; y[2] = 3; y[3] = 4; y[4] = 8;

             chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint; // тут сам поизменяет/повыбирайте тип вывода графика
             for (int i = 0; i < 5; i++)
             {
                 chart1.Series[0].Points.AddXY(x[i], y[i]);
             }

             chart1.Series.Add("zalupaZaica");
             chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
             for (int i = 0; i < 5; i++)
             {
                 chart1.Series[1].Points.AddXY(x[i], y[i]);
             }

             chart1.Series.Add("zalupaMurzatogoZaica");
             chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
             chart1.Series[2].Points.AddXY(5, 5);*/
            //график
        }

        private void fFiveCalc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.methodOfLaying". При необходимости она может быть перемещена или удалена.
            this.methodOfLayingTableAdapter.Fill(this._BD01_02_2016DataSet.methodOfLaying);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.outsideDiameter". При необходимости она может быть перемещена или удалена.
            this.outsideDiameterTableAdapter.Fill(this._BD01_02_2016DataSet.outsideDiameter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.deltaT". При необходимости она может быть перемещена или удалена.
            this.deltaTTableAdapter.Fill(this._BD01_02_2016DataSet.deltaT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.standardHeatLoss". При необходимости она может быть перемещена или удалена.
            this.standardHeatLossTableAdapter.Fill(this._BD01_02_2016DataSet.standardHeatLoss);
            // буру данные из переправы
            calc.tempTable = pereprava.tempTable;
            //сделать потом
            // this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl(Convert.ToInt32(cbType.SelectedValue), checkBox2.Checked, checkBox1.Checked, Convert.ToInt32(cboutD.SelectedValue));
            // проверка на властелина энергии
            if (pereprava.check)
            {
                checkBox3.Visible = true;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbType.SelectedIndex.ToString());
            //  this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl(cbType.SelectedIndex, checkBox2.Checked, checkBox1.Checked, Convert.ToInt32(tbDiametr.Text));
            this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl(Convert.ToInt32(cbType.SelectedValue), cbNhwInYear.Checked, cbYear.Checked, Convert.ToInt32(cbOutDiam.SelectedValue));

            // попробую всё заносить в массив 
            double[,] heatLossMass = new double[dgv_heatloss.RowCount, dgv_heatloss.ColumnCount];
            for (int i = 0; i < dgv_heatloss.RowCount; i++)
            {
                for (int j = 0; j < dgv_heatloss.ColumnCount; j++)
                {
                    heatLossMass[i, j] = Convert.ToDouble(dgv_heatloss[j, i].EditedFormattedValue);
                    // MessageBox.Show(heatLossMass[i, j].ToString());  
                }
            }
            // попробую всё заносить в массив 
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { dgv_heatloss.Visible = true; }
            else { dgv_heatloss.Visible = false; }
        }

        //ввод данных из строки в масиив
        public double[,] inMass(int row, int col)
        {
            double[,] newMass = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    newMass[i, j] = Convert.ToDouble(this.dgv_heatloss[j, i].EditedFormattedValue);
                }
            }
            return newMass;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
