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
    public partial class fInitalData : Form
    {
        public fInitalData()
        {
            InitializeComponent();

        }

        private void fInitalData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.region". При необходимости она может быть перемещена или удалена.
            this.regionTableAdapter.Fill(this._BD01_02_2016DataSet.region);

        }

        private void cbchoseMouth_CheckedChanged(object sender, EventArgs e)
        {
            if (cbchoseMouth.Checked)
            {
                lblFrom.Visible = true;
                lblTo.Visible = true;
                cbFrom.Visible = true;
                cbTo.Visible = true;
            }
            else
            {
                lblFrom.Visible = false;
                lblTo.Visible = false;
                cbFrom.Visible = false;
                cbTo.Visible = false;
            }
        }
    }
}
