using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15.BasePlate.UI
{
    public partial class Main : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();
        public Main()
        {
            AllocConsole();
            InitializeComponent();
        }
        public void SendNoti(string msg)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("BYPASSED WORD");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"] {msg}\n");
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        static string BadWordsBypasser(string dsg)
        {
            var l = dsg.Length;
            var sb = new StringBuilder();
            var r = new Random();
            for (int i = 0; i < l; i++)
            {
                sb.Append(dsg[i]);
                if (i < l - 1 && r.Next(2) == 0)
                {
                    sb.Append($"<sound:{i}>");
                }
            }
            return sb.ToString();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string bypass = BadWordsBypasser(guna2TextBox1.Text);
            SendNoti(bypass);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }
    }
}
