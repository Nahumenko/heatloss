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

        {
            // месеж бокс условие воздушка 
            if (cbType.SelectedIndex == 0 && cbYear.SelectedIndex == 0)
            {
                // вот по этим значениям нужно брать данные из таблицы
                double x1 = calc.onePipeAir(Direction.FLOW);
                double x2 = calc.onePipeAir(Direction.RETURN);
                MessageBox.Show(x1.ToString());
                MessageBox.Show(x2.ToString());

                // надо хапнуть пару значений из таблицы Ж и И смотри методику страницу 20 пункт 5,4,5 (вроде это до 1994)

                // интерпалируем значения взятые из таблицы и присваимваем ку1 и ку 2
                MessageBox.Show("yes");
            }
            if (cbType.SelectedIndex == 0 && cbYear.SelectedIndex == 1)
            {
                // Надо хапнуть пару значений из таблицы К и Л смотри методику страницу 20 пункт 5,4,5( с 1994)
                // потом используем метод из калькулейшен ферст
                // интерпалируем по значениям хапнутым из таблицы
                MessageBox.Show("no");
            }


        }

        private void fFiveCalc_Load(object sender, EventArgs e)
        {
            // буру данные из переправы
            calc.tempTable = pereprava.tempTable;
        }
    }
}
