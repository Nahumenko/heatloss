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
    public partial class SysWaterVolume : Form
    {
        public SysWaterVolume()
        {
            InitializeComponent();
        }

        private void SysWaterVolume_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.heatEquipment". При необходимости она может быть перемещена или удалена.
            this.heatEquipmentTableAdapter.Fill(this._BD01_02_2016DataSet.heatEquipment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.sysTemperatureDifference". При необходимости она может быть перемещена или удалена.
            this.sysTemperatureDifferenceTableAdapter.Fill(this._BD01_02_2016DataSet.sysTemperatureDifference);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_BD01_02_2016DataSet.sysWaterVolume". При необходимости она может быть перемещена или удалена.
            this.sysWaterVolumeTableAdapter.Fill(this._BD01_02_2016DataSet.sysWaterVolume);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sysWaterVolumeTableAdapter.Update(this._BD01_02_2016DataSet.sysWaterVolume);
        }
    }
}
