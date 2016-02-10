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
    public partial class NominalDiameter : Form
    {
        public NominalDiameter()
        {
            InitializeComponent();
        }

        private void NominalDiameter_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.nominalDiameter". При необходимости она может быть перемещена или удалена.
            this.nominalDiameterTableAdapter.Fill(this._BD01_02_2016DataSet.nominalDiameter);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.nominalDiameterTableAdapter.Update(this._BD01_02_2016DataSet.nominalDiameter);
        }
    }
}
