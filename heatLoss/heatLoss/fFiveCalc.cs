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

            // основной алгоритм в кейсе
            if (cbType.SelectedIndex == 0 || cbType.SelectedIndex == 1 || cbType.SelectedIndex == 2)
            {
                // выборка суперпозиции
                bool superPoz;
                if (cbType.SelectedIndex == 0)
                    superPoz = true;
                else superPoz = false;
                //кол-во труб
                switch (cbPipeNumber.SelectedIndex)
                {
                    case -1:
                        MessageBox.Show("Выберите тип подземной прокладки", "Ошибка");
                        break;
                    //двухтрубная
                    case 0:
                        this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl_addDtSP(Convert.ToInt32(cbOutDiam.SelectedValue), cbYear.Checked, cbNhwInYear.Checked, superPoz, Convert.ToInt32(cbType.SelectedValue));
                        calc.twoTubesUnderground(cBoxDepth.Checked);
                        //заносим массив
                        double[,] heatLossMass = inMass(dgv_heatloss.RowCount, dgv_heatloss.ColumnCount);
                        //дополниттельная проверка на кол-во строк в массиве
                        if (heatLossMass.GetLength(0) != 0)
                        {
                            lblQ.Visible = true;
                            lblTemP.Visible = true;
                            lblTemP.Text = ("Значение Делта Т св = " + calc.deltaTcv);
                            //интерполяция
                            double q;
                            if (cbType.SelectedIndex == 0 || cbType.SelectedIndex == 1)
                            {
                                q = lin.massiv(heatLossMass, calc.deltaTcv); // кушки куда-то нужно девать
                                // условие на непроектный режим подземка
                                q = noProjectPipe(q);
                                lblQ.Text = ("Значение Ку Подз =" + q);
                                //График
                                chart1.Visible = true;
                                paintingChart(heatLossMass, calc.deltaTcv, q);
                                //вывод данных и дальнейший расчёт
                            }
                            else
                            {
                                q = lin.massiv(heatLossMass, calc.deltaTcv) * 0.8; // кушки куда-то нужно девать
                                // условие на непроектный режим подземка
                                q = noProjectPipe(q);
                                MessageBox.Show(this.insulationKt2TableAdapter1.sql_Kt2(Convert.ToInt32(comBInsulationType.SelectedValue), Convert.ToInt32(cbType.SelectedValue), Convert.ToInt32(cbOutDiam.SelectedValue)).ToString());
                                lblQ.Text = ("Значение Ку Подз =" + q);
                                //График
                                chart1.Visible = true;
                                paintingChart(heatLossMass, calc.deltaTcv, q);
                            }


                        }
                        else MessageBox.Show("В базе данных нет значений для заданых условий");
                        break;
                    //подача отдельно
                    case 1:
                        //таблица
                        this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl_addDtSP2(Convert.ToInt32(cbOutDiam.SelectedValue), cbYear.Checked, cbNhwInYear.Checked, superPoz, Convert.ToInt32(cbType.SelectedValue));
                        calc.onePipeUndergtound(Direction.FLOW, cBoxDepth.Checked);
                        //заносим массив
                        heatLossMass = inMass(dgv_heatloss.RowCount, dgv_heatloss.ColumnCount);
                        //дополниттельная проверка на кол-во строк в массиве
                        if (heatLossMass.GetLength(0) != 0)
                        {
                            lblQ.Visible = true;
                            lblTemP.Visible = true;
                            lblTemP.Text = ("Значение Делта Т1 подз = " + calc.deltaT1_podz);
                            //интерполяция
                            double q = lin.massiv(heatLossMass, calc.deltaT1_podz); // кушки куда-то нужно девать
                            lblQ.Text = ("Значение Ку1 Подз =" + q);
                            //График
                            chart1.Visible = true;
                            paintingChart(heatLossMass, calc.deltaT1_podz, q);
                            //вывод данных и дальнейший расчёт
                        }
                        else MessageBox.Show("В базе данных нет значений для заданых условий");
                        break;
                    case 2:
                        //таблица
                        this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl_addDtSP3(Convert.ToInt32(cbOutDiam.SelectedValue), cbYear.Checked, cbNhwInYear.Checked, superPoz, Convert.ToInt32(cbType.SelectedValue));
                        calc.onePipeUndergtound(Direction.RETURN, cBoxDepth.Checked);
                        //заносим массив
                        heatLossMass = inMass(dgv_heatloss.RowCount, dgv_heatloss.ColumnCount);
                        //дополниттельная проверка на кол-во строк в массиве
                        if (heatLossMass.GetLength(0) != 0)
                        {
                            lblQ.Visible = true;
                            lblTemP.Visible = true;
                            lblTemP.Text = ("Значение Делта Т2 подз = " + calc.deltaT2_podz);
                            //интерполяция
                            double q = lin.massiv(heatLossMass, calc.deltaT2_podz); // кушки куда-то нужно девать
                            lblQ.Text = ("Значение Ку2 Подз =" + q);
                            //График
                            chart1.Visible = true;
                            paintingChart(heatLossMass, calc.deltaT2_podz, q);
                            //вывод данных и дальнейший расчёт
                        }
                        else MessageBox.Show("В базе данных нет значений для заданых условий");
                        break;
                }
            }



            // месеж бокс условие воздушка 
            if (cbType.SelectedIndex == 3)
            {
                this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl(Convert.ToInt32(cbType.SelectedValue), cbNhwInYear.Checked, cbYear.Checked, Convert.ToInt32(cbOutDiam.SelectedValue));
                // расчёт
                calc.onePipeAir(Direction.FLOW);
                calc.onePipeAir(Direction.RETURN);
                //заносим массив
                double[,] heatLossMass = inMass(dgv_heatloss.RowCount, dgv_heatloss.ColumnCount);
                //дополниттельная проверка на кол-во строк в массиве
                if (heatLossMass.GetLength(0) != 0)
                {
                    lblQ.Visible = true;
                    lblTemP.Visible = true;
                    lblTemP.Text = ("Значение Делта Т1 возд = " + calc.deltaT1_vozd + "      Значение Делта Т2 возд = " + calc.deltaT2_vozd);
                    //интерполяция
                    double q1 = lin.massiv(heatLossMass, calc.deltaT1_vozd); // кушки куда-то нужно девать
                    double q2 = lin.massiv(heatLossMass, calc.deltaT2_vozd); // кушки куда-то нужно девать

                    // проверка на непроект   
                    string s = "vozd";
                    q1 = noProjecrPipe(q1, s);
                    q2 = noProjecrPipe(q2, s);
                    lblQ.Text = ("Значение Ку1 возд = " + q1 + "      Значение Ку1 возд = " + q2);
                    //График
                    chart1.Visible = true;
                    paintingChart(heatLossMass, calc.deltaT1_vozd, q1, calc.deltaT2_vozd, q2);
                    //вывод данных и дальнейший расчёт
                }
                else MessageBox.Show("В базе данных нет значений для заданых условий");
            }

            if (cbType.SelectedIndex == 5)
            {
                this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl(Convert.ToInt32(cbType.SelectedValue), cbNhwInYear.Checked, cbYear.Checked, Convert.ToInt32(cbOutDiam.SelectedValue));
                // расчёт
                calc.onePipeHouse(Direction.FLOW);
                calc.onePipeHouse(Direction.RETURN);
                double[,] heatLossMass = inMass(dgv_heatloss.RowCount, dgv_heatloss.ColumnCount);
                //дополниттельная проверка на кол-во строк в массиве
                if (heatLossMass.GetLength(0) != 0)
                {
                    lblQ.Visible = true;
                    lblTemP.Visible = true;
                    lblTemP.Text = ("Значение Делта Т1 пом = " + calc.deltaT1_pom + "      Значение Делта Т2 возд = " + calc.deltaT2_pom);
                    //интерполяция
                    double q1 = lin.massiv(heatLossMass, calc.deltaT1_pom); // кушки куда-то нужно девать
                    double q2 = lin.massiv(heatLossMass, calc.deltaT2_pom); // кушки куда-то нужно девать
                    // проверка на непроект   
                    string s = "house";
                    q1 = noProjecrPipe(q1, s);
                    q2 = noProjecrPipe(q2, s);
                    lblQ.Text = ("Значение Ку1 пом = " + q1 + "      Значение Ку1 пом = " + q2);
                    //График
                    chart1.Visible = true;
                    paintingChart(heatLossMass, calc.deltaT1_pom, q1, calc.deltaT2_pom, q2);
                    //вывод данных и дальнейший расчёт
                }
                else MessageBox.Show("В базе данных нет значений для заданых условий");
            }
            if (cbType.SelectedIndex == 6)
            {
                this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl(Convert.ToInt32(cbType.SelectedValue), cbNhwInYear.Checked, cbYear.Checked, Convert.ToInt32(cbOutDiam.SelectedValue));
                // расчёт
                calc.onePipeTunnel(Direction.FLOW);
                calc.onePipeTunnel(Direction.RETURN);
                double[,] heatLossMass = inMass(dgv_heatloss.RowCount, dgv_heatloss.ColumnCount);
                //дополниттельная проверка на кол-во строк в массиве
                if (heatLossMass.GetLength(0) != 0)
                {
                    lblQ.Visible = true;
                    lblTemP.Visible = true;
                    lblTemP.Text = ("Значение Делта Т1 тун = " + calc.deltaT1_tunel + "      Значение Делта Т2 тун = " + calc.deltaT2_tunel);
                    //интерполяция
                    double q1 = lin.massiv(heatLossMass, calc.deltaT1_tunel); // кушки куда-то нужно девать
                    double q2 = lin.massiv(heatLossMass, calc.deltaT2_tunel); // кушки куда-то нужно девать
                    // проверка на непроект   
                    string s = "Tunel";
                    q1 = noProjecrPipe(q1, s);
                    q2 = noProjecrPipe(q2, s);
                    lblQ.Text = ("Значение Ку1 пом = " + q1 + "      Значение Ку1 пом = " + q2);
                    //График
                    chart1.Visible = true;
                    paintingChart(heatLossMass, calc.deltaT1_tunel, q1, calc.deltaT2_tunel, q2);
                    //вывод данных и дальнейший расчёт
                }
                else MessageBox.Show("В базе данных нет значений для заданых условий");
            }
            if (cbType.SelectedIndex == 8 || cbType.SelectedIndex == 9)
            {
                this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.Sql_steem8(Convert.ToInt32(cbOutDiam.SelectedValue), cbYear.Checked, cbNhwInYear.Checked, Convert.ToInt32(cBoxPipes.SelectedValue));
                // расчёт
                double t = 0;
                string strT = "Ошибка";
                string strQ = "Ошибка";
                // условие паропровода и конденсатопровода
                switch (cBoxPipes.SelectedIndex)
                {
                    case 0:
                        t = calc.steamOnePipeUnderGround();
                        strT = "Значение Делта Тнк подз = ";
                        strQ = "Значение Ку нк подз = ";
                        break;
                    case 1:
                        t = calc.tempTable[12].T2_P;
                        strT = "Значение Делта Тнп подз = ";
                        strQ = "Значение Ку нп подз = ";
                        break;
                }

                double[,] heatLossMass = inMass(dgv_heatloss.RowCount, dgv_heatloss.ColumnCount);
                //дополниттельная проверка на кол-во строк в массиве
                if (heatLossMass.GetLength(0) != 0)
                {
                    lblQ.Visible = true;
                    lblTemP.Visible = true;
                    lblTemP.Text = (strT + t);
                    //интерполяция
                    double q = lin.massiv(heatLossMass, t); // кушки куда-то нужно девать                   
                    lblQ.Text = (strQ + q);
                    //График
                    chart1.Visible = true;
                    paintingChart(heatLossMass, t, q);
                    //вывод данных и дальнейший расчёт
                }
                else MessageBox.Show("В базе данных нет значений для заданых условий");
            }
     


        }
        // для не проектной надземной прокладки
        private double noProjecrPipe(double q, string s)
        {
            switch (cBoxNoProeject.SelectedIndex)
            {
                case 1:
                    q = calc.onePipeAirChanged(q, Direction.FLOW, s);
                    break;
                case 2:
                    q = calc.onePipeAirChanged(q, Direction.RETURN, s);
                    break;
            }
            return q;
        }
        // для не проектной подземной прокладки
        private double noProjectPipe(double q)
        {
            switch (cBoxNoProeject.SelectedIndex)
            {
                case 1:
                    q = calc.twoTubesUndergroundChanged(q, Direction.FLOW);
                    break;
                case 2:
                    q = calc.twoTubesUndergroundChanged(q, Direction.RETURN);
                    break;
            }
            return q;
        }

        private void fFiveCalc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.pipeline". При необходимости она может быть перемещена или удалена.
            this.pipelineTableAdapter.Fill(this._BD01_02_2016DataSet.pipeline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.insulationType". При необходимости она может быть перемещена или удалена.
            this.insulationTypeTableAdapter.Fill(this._BD01_02_2016DataSet.insulationType);
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

            //провекра кол-ва труб в котловане
            cbPipeNumberCheck();



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
        //рисование графика
        private void paintingChart(double[,] mass, double t, double q)
        {
            chart1.Series.Clear(); // чищу на всякий пожарный
            chart1.Series.Add("справочные значения");
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart1.Series[0].BorderWidth = 3;
            chart1.Series[0].LabelBorderWidth = 3;
            chart1.Series[0].MarkerBorderWidth = 3;
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                chart1.Series[0].Points.AddXY(mass[i, 0], mass[i, 1]);
            }
            chart1.Series.Add("расчётные значения");
            chart1.Series[1].Color = Color.GreenYellow;
            chart1.Series[1].MarkerSize = 15;
            chart1.Series[1].ChartType = SeriesChartType.Point;
            chart1.Series[1].MarkerStyle = MarkerStyle.Cross;
            chart1.Series[1].Points.AddXY(t, q);
        }
        //рисование графика перегрузка на две точки
        private void paintingChart(double[,] mass, double t0, double q0, double t1, double q1)
        {
            paintingChart(mass, t0, q0);
            chart1.Series[1].Points.AddXY(t1, q1);
        }


        //провекра кол-ва труб в котловане на видимость
        // отоброжение не отображение елементов в зависимости установок
        private void cbPipeNumberCheck()
        {
            if (cbType.SelectedIndex == 0 || cbType.SelectedIndex == 1 || cbType.SelectedIndex == 2)
            {
                cBoxNoProeject.Visible = true;
                cbPipeNumber.Visible = true;
                cBoxNoProeject.Items.Clear();
                cBoxNoProeject.Items.Add("Проектный режим работы");
                cBoxNoProeject.Items.Add("Два в режиме подающего");
                cBoxNoProeject.Items.Add("Два в режиме обратного");
            }
            else if (cbType.SelectedIndex == 3 || cbType.SelectedIndex == 5 || cbType.SelectedIndex == 6)
            {
                cBoxNoProeject.Visible = true;
                cbPipeNumber.Visible = false;
                cBoxNoProeject.Items.Clear();
                cBoxNoProeject.Items.Add("Проектный режим работы");
                cBoxNoProeject.Items.Add("Подающий в режиме обратного");
                cBoxNoProeject.Items.Add("Обратный в режиме подающего");

            }
            else
            {
                cbPipeNumber.Visible = false;
                cBoxNoProeject.Visible = false;
            }
            if (cbType.SelectedIndex == 0 || cbType.SelectedIndex == 1)
                cBoxDepth.Visible = true;
            else
            {
                cBoxDepth.Visible = false;
                cBoxDepth.Checked = false;
            }
            if (cbType.SelectedIndex == 2)
                comBInsulationType.Visible = true;
            else comBInsulationType.Visible = false;


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
            //провекра кол-ва труб в котловане
            cbPipeNumberCheck();
        }

        private void fFiveCalc_FormClosing(object sender, FormClosingEventArgs e)
        {
            lblQ.Visible = false;
            lblTemP.Visible = false;
            chart1.Visible = false;
        }


    }
}
