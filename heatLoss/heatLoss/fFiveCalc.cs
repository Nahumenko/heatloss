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
        // месеж бокс условие
        {
            if (MessageBox.Show( "Госстрой издат -- да\nСНИП 2,04,14-88 -- нет", "Условие", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // надо хапнуть пару значений из таблицы Ж и И
                for (int i = 0; i < 14; i++)
                {
                    
                    /* dgvTemptable[0, i].Value*/
                    MessageBox.Show(calc.tempTable[i].Tcrm_H20.ToString());
                  
                }

            }
            else
            {
                // Надо хапнуть пару значений из таблицы К и Л

            }
        }

        private void fFiveCalc_Load(object sender, EventArgs e)
        {
            calc.tempTable = pereprava.tempTable;
        }
    }
}
