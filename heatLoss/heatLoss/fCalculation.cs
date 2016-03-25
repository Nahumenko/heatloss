using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using System.IO;

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

        private void button1_Click(object sender, EventArgs e)
        {
            const string template = "template.xlsm";
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            // Открываем книгу
            excel.Application.Workbooks.Open(Path.Combine(Environment.CurrentDirectory., template);


        }
    }
}
