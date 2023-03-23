using CronometroApp.clases;
using CronometroApp.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CronometroApp
{
    public partial class FrmCronometro : Form
    {
        Cronometro cr;
        public FrmCronometro(ICronometro cronometro)
        {
            InitializeComponent();
            cr = (Cronometro)cronometro;
            cr.setLabel(label1);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            cr.Start();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            cr.Pause();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            cr.Stop();
        }
    }
}
