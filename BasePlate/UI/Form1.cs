using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp15.BasePlate.UI;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            guna2TextBox1.Text = string.Format("@n{0}u{1}l", Environment.UserName, Environment.MachineName);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "DiscordBypass123454")
            {
                this.Hide();
                Console.Beep(50, 60);
                var Home = new Main();
                Home.ShowDialog();
            }
        }
    }
}
