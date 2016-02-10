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
    public partial class OutsideDiameter : Form
    {
        public OutsideDiameter()
        {
            InitializeComponent();
        }

        private void OutsideDiameter_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.outsideDiameter". При необходимости она может быть перемещена или удалена.
            this.outsideDiameterTableAdapter.Fill(this._BD01_02_2016DataSet.outsideDiameter);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.outsideDiameterTableAdapter.Update(this._BD01_02_2016DataSet.outsideDiameter);
        }
    }
}
