using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeLogic;

namespace KolkoKrzyzyk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int klikniec = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            Class1 fieldAndTurnObject = a.main(klikniec);
            label3.Text = fieldAndTurnObject.turn;
            btn0.Text = fieldAndTurnObject.fieldValue;
            btn0.Enabled = false;
            klikniec++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            Class1 fieldAndTurnObject = a.main(klikniec);
            label3.Text = fieldAndTurnObject.turn;
            btn1.Text = fieldAndTurnObject.fieldValue;
            btn1.Enabled = false;
            klikniec++;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            Class1 fieldAndTurnObject = a.main(klikniec);
            label3.Text = fieldAndTurnObject.turn;
            btn2.Text = fieldAndTurnObject.fieldValue;
            btn2.Enabled = false;
            Boolean checkWin = a.checkWin(btn0, btn1, btn2);
            if (checkWin)
            {
                label3.Text = "wygrana";
            }
            klikniec++;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            //btn4.Text = a.main(klikniec);
            klikniec++;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            //btn3.Text = a.main(klikniec);
            klikniec++;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            //btn5.Text = a.main(klikniec);
            klikniec++;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            //btn6.Text = a.main(klikniec);
            klikniec++;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            //btn7.Text = a.main(klikniec);
            klikniec++;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            //btn8.Text = a.main(klikniec);
            klikniec++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
