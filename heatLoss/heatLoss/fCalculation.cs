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
    public partial class fCalculation : Form
    {
        fInitalData fInitaldata = new fInitalData();
        public fCalculation()
        {
            InitializeComponent();
        }

        private void btnInitalData_Click(object sender, EventArgs e)
        {
            fInitaldata.ShowDialog();
        }
    }
}
