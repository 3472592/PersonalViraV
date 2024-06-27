using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViraV
{
    public partial class ViraVMain : Form
    {
        public ViraVMain()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            ViraV Vira = new();
            Vira.Show();
            this.Hide();
        }
    }
}
