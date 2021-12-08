using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemMachineTools
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Tick += new EventHandler(RefreshLabel);
            timer.Interval = 1000;
            timer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void RefreshLabel(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("HH:mm:ss");
            label2.Text = DateTime.Now.ToShortDateString();
        }
    }
}
