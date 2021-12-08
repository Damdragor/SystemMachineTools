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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                Авторизация userObj = db.Авторизация.FirstOrDefault(Авторизация => Авторизация.Электронная_почта.Equals(textBox1.Text) && Авторизация.Пароль.Equals(textBox2.Text));
                if (userObj != null)
                {
                    MessageBox.Show(userObj.Электронная_почта, "Вы успешно зашли");
                    Form4 form = new Form4();
                    form.Show();
                }
                else if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("Введите все данные!!!", "Предупреждение");
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
