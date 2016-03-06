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

        
        fFiveCalc fFiveCalc = new fFiveCalc();
       public fInitalData fInitaldata = new fInitalData();

        public fCalculation()
        {
            InitializeComponent();
        }

        private void btnInitalData_Click(object sender, EventArgs e)
        {
            fInitaldata.ShowDialog();
        }

        private void fCalculation_Load(object sender, EventArgs e)
        {

        }

        private void btnFiveCalc_Click(object sender, EventArgs e)
        {
            fFiveCalc.Owner = fInitaldata;
            fFiveCalc.ShowDialog();
            
        }
    }
}
