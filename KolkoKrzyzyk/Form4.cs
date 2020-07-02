using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace KolkoKrzyzyk
{
    public partial class Form4 : Form

    {
        Thread th;
        public Form4(object obj)
        {
            InitializeComponent();
            label2.Text = obj.ToString();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void opennewform1(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
