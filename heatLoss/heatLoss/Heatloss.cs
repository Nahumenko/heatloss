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
    public partial class Heatloss : Form
    {
        public Heatloss()
        {
            InitializeComponent();
        }

        private void Heatloss_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.insulationType". При необходимости она может быть перемещена или удалена.
            this.insulationTypeTableAdapter.Fill(this._BD01_02_2016DataSet.insulationType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.methodOfLaying". При необходимости она может быть перемещена или удалена.
            this.methodOfLayingTableAdapter.Fill(this._BD01_02_2016DataSet.methodOfLaying);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.heatDissipation". При необходимости она может быть перемещена или удалена.
            this.heatDissipationTableAdapter.Fill(this._BD01_02_2016DataSet.heatDissipation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.deltaT". При необходимости она может быть перемещена или удалена.
            this.deltaTTableAdapter.Fill(this._BD01_02_2016DataSet.deltaT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.outsideDiameter". При необходимости она может быть перемещена или удалена.
            this.outsideDiameterTableAdapter.Fill(this._BD01_02_2016DataSet.outsideDiameter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.pipeline". При необходимости она может быть перемещена или удалена.
            this.pipelineTableAdapter.Fill(this._BD01_02_2016DataSet.pipeline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.standardHeatLoss". При необходимости она может быть перемещена или удалена.
            this.standardHeatLossTableAdapter.Fill(this._BD01_02_2016DataSet.standardHeatLoss);

        }

        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.standardHeatLossTableAdapter.Update(this._BD01_02_2016DataSet);
            this.standardHeatLossTableAdapter.Update(this._BD01_02_2016DataSet.standardHeatLoss);
            //MessageBox.Show("Проверка работы кнопки","Проверка");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.standardHeatLossTableAdapter.Update(this._BD01_02_2016DataSet.standardHeatLoss);
        }
    }
}
