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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.season". При необходимости она может быть перемещена или удалена.
            this.seasonTableAdapter.Fill(this._BD01_02_2016DataSet.season);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.temperature". При необходимости она может быть перемещена или удалена.
            this.temperatureTableAdapter.Fill(this._BD01_02_2016DataSet.temperature);
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
                //this.dgvTemptable.DataSource = this.temperatureTableAdapter.selectSeasonName(Convert.ToInt32(this.cbFrom.Text), Convert.ToInt32(this.cbTo.Text));
            }
            else
            {
                lblFrom.Visible = false;
                lblTo.Visible = false;
                cbFrom.Visible = false;
                cbTo.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            // тут должен быть код который сохраняет данные в какой-то массив
            //и добавляет кнопку начала рапсчёта на форму  Fcalculation
        }

        private void selectSeasonNameToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void cbTo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void cbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgvTemptable.DataSource = this.temperatureTableAdapter.selectSeasonName(Convert.ToInt32(cbFrom.SelectedValue.ToString()), Convert.ToInt32(cbTo.SelectedValue.ToString()), Convert.ToInt32(comboBox1.SelectedValue.ToString()));
        }

        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgvTemptable.DataSource = this.temperatureTableAdapter.selectSeasonName(Convert.ToInt32(cbFrom.SelectedValue.ToString()), Convert.ToInt32(cbTo.SelectedValue.ToString()), Convert.ToInt32(comboBox1.SelectedValue.ToString()));
        }
    }
}
