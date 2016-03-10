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
        //передаю в него таблицу исходных данных

        public fFiveCalc()
        {
            InitializeComponent();

        }

        private void btnCalc_Click(object sender, EventArgs e)
        // проверка ввода

        {
            linterp lin = new linterp();
            double[,] ma = new double[5, 2];
            ma[0, 0] = 3;
            ma[1, 0] = 4;
            ma[2, 0] = 5;
            ma[3, 0] = 6;
            ma[4, 0] = 7;
            ma[0, 1] = 60;
            ma[1, 1] = 80;
            ma[2, 1] = 100;
            ma[3, 1] = 120;
            ma[4, 1] = 140;

            MessageBox.Show(lin.massiv(ma, 7).ToString());
            
            // месеж бокс условие воздушка 
            if (cbType.SelectedIndex == 0 && cbNhwInYear.SelectedIndex == 0 && cbYear.SelectedIndex == 0)
            {
                
                // вот по этим значениям нужно брать данные из таблицы
                double x1 = calc.onePipeAir(Direction.FLOW);
                double x2 = calc.onePipeAir(Direction.RETURN);
                MessageBox.Show(x1.ToString());
                MessageBox.Show(x2.ToString());

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

            for(int i = 0; i < dgv_heatloss.RowCount; i++)
            {
                for(int j; j < dgv_heatloss.ColumnCount; j++)
                {

                }
            }

            // попробую всё заносить в массив 
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { dgv_heatloss.Visible = true; }
            else { dgv_heatloss.Visible = false; }
        }
    }
}
