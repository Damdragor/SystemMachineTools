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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Tick += new EventHandler(RefreshLabel);
            timer.Interval = 1000;
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void RefreshLabel(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("HH:mm:ss");
            label6.Text = DateTime.Now.ToShortDateString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
