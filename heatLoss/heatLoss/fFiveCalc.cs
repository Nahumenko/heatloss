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
        public fFiveCalc()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        // проверка ввода
        // месеж бокс условие
        {
            if (MessageBox.Show( "Госстрой издат -- да\nСНИП 2,04,14-88 -- нет", "Условие", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // надо хапнуть пару значений из таблицы Ж и И
                calcu

            }
            else
            {
                // Надо хапнуть пару значений из таблицы К и Л
            }
        }
    }
}
