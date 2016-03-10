using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        // проверка ввода

        {
    

            // месеж бокс условие воздушка 
            if (cbType.SelectedIndex == 3 && checkBox1.Checked==false && checkBox2.Checked==false)
            {

                // вот по этим значениям нужно брать данные из таблицы
                calc.deltaT1_vozd = calc.onePipeAir(Direction.FLOW);
                calc.deltaT2_vozd = calc.onePipeAir(Direction.RETURN);
                //заносим массив
                double[,] heatLossMass = new double[dgv_heatloss.RowCount, dgv_heatloss.ColumnCount];
                for (int i = 0; i < dgv_heatloss.RowCount; i++)
                {
                    for (int j = 0; j < dgv_heatloss.ColumnCount; j++)
                    {
                        heatLossMass[i, j] = Convert.ToDouble(dgv_heatloss[j, i].EditedFormattedValue);
                        // MessageBox.Show(heatLossMass[i, j].ToString());  
                    }
                }
                MessageBox.Show(lin.massiv(heatLossMass, calc.deltaT1_vozd).ToString());
                MessageBox.Show(lin.massiv(heatLossMass, calc.deltaT2_vozd).ToString());




                // надо хапнуть пару значений из таблицы Ж и И смотри методику страницу 20 пункт 5,4,5 (вроде это до 1994)

                // интерпалируем значения взятые из таблицы и присваимваем ку1 и ку 2
                MessageBox.Show("yes");

            }
            if (cbType.SelectedIndex == 0 && cbYear.SelectedIndex == 1 && cbNhwInYear.SelectedIndex == 1)
            {
                // Надо хапнуть пару значений из таблицы К и Л смотри методику страницу 20 пункт 5,4,5( с 1994)
                // потом используем метод из калькулейшен ферст
                // интерпалируем по значениям хапнутым из таблицы
                MessageBox.Show("no");
            }


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
            this.dgv_heatloss.DataSource = this.standardHeatLossTableAdapter.sql_hl(Convert.ToInt32(cbType.SelectedValue), checkBox2.Checked, checkBox1.Checked, Convert.ToInt32(cboutD.SelectedValue));

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
           // MessageBox.Show(lin.massiv(heatLossMass, Convert.ToDouble(tbDiametr.Text)).ToString());


            // попробую всё заносить в массив 
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { dgv_heatloss.Visible = true; }
            else { dgv_heatloss.Visible = false; }
        }
    }
}
