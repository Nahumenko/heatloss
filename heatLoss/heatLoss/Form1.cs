﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        private void сообщитьОПролемеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/1Rvw2X3JUEZhitx8P5W06GPXulvBK2lRabc4j1MjAYbo/viewform?usp=send_form");
        }

        private void отправитьОтзывToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/11tuqMnsxrRshlET-zbtlzCHDYGETmZbX_RNNbm3DTsk/viewform?usp=send_form");
        }

        private void отправитьПредложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/19d-rJdhVJezor4cf6tUDdQU5WJesmW7kTAM-NeCcshI/viewform?usp=send_form");
        }
    }
}
