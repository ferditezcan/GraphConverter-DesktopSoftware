using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSoftware
{
    public partial class HelpUserControl : UserControl
    {
        public HelpUserControl()
        {
            InitializeComponent();
        }
        private void HelpUserControl_Load(object sender, EventArgs e)
        {
            panel4.Hide();
        }
        private void CleardataButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel4.Hide();
        }

      
    }
}
