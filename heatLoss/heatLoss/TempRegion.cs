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
    public partial class TempRegion : Form
    {
        public TempRegion()
        {
            InitializeComponent();
        }

        private void TempRegion_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.season". При необходимости она может быть перемещена или удалена.
            this.seasonTableAdapter.Fill(this._BD01_02_2016DataSet.season);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.region". При необходимости она может быть перемещена или удалена.
            this.regionTableAdapter.Fill(this._BD01_02_2016DataSet.region);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.temperature". При необходимости она может быть перемещена или удалена.
            this.temperatureTableAdapter.Fill(this._BD01_02_2016DataSet.temperature);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.temperatureTableAdapter.Update(this._BD01_02_2016DataSet.temperature);
        }
    }
}
