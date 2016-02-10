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
    public partial class EditorReferenceTables : Form
    {
        public EditorReferenceTables()
        {
            InitializeComponent();
        }

        private void температурыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TempRegion temp_region = new TempRegion();
            temp_region.Owner = this;
            temp_region.ShowDialog();
        }

        private void наружныйДиаментрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutsideDiameter outside_diameter = new OutsideDiameter();
            outside_diameter.Owner = this;
            outside_diameter.ShowDialog();
        }

        private void условныйДиаметрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NominalDiameter nominal_diameter = new NominalDiameter();
            nominal_diameter.Owner = this;
            nominal_diameter.ShowDialog();
        }

        private void объемВодыВСистемеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SysWaterVolume sys_water_volume = new SysWaterVolume();
            sys_water_volume.Owner = this;
            sys_water_volume.ShowDialog();
        }

        private void теплопотериToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Heatloss heatloss = new Heatloss();
            heatloss.Owner = this;
            heatloss.ShowDialog();
        }
    }
}
