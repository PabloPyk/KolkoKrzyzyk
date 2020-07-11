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
using System.Threading;

namespace KolkoKrzyzyk
{
    public partial class Form2 : Form
    {
        public List<Button> lstBtnCalc = null;
        Thread th;
        public Form2()
        {
            InitializeComponent();
            lstBtnCalc = new List<Button>()
            {
                btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8
            };

        }

        int klikniec = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            Class1 fieldAndTurnObject = a.main(klikniec);
            label3.Text = fieldAndTurnObject.turn;
            btn0.Text = fieldAndTurnObject.fieldValue;
            btn0.Enabled = false;
            Boolean checkWin = a.checkWin(lstBtnCalc, fieldAndTurnObject.fieldValue);
            Boolean checkDraw = a.checkDraw(lstBtnCalc);
            if (checkWin)
            {
                openNewWindow(fieldAndTurnObject.fieldValue);
                return;
            }
            if (checkDraw)
            {
                openNewWindow("Remis");
            }
            klikniec++;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            Class1 fieldAndTurnObject = a.main(klikniec);
            label3.Text = fieldAndTurnObject.turn;
            btn1.Text = fieldAndTurnObject.fieldValue;
            btn1.Enabled = false;
            Boolean checkWin = a.checkWin(lstBtnCalc, fieldAndTurnObject.fieldValue);
            Boolean checkDraw = a.checkDraw(lstBtnCalc);
            if (checkWin)
            {
                openNewWindow(fieldAndTurnObject.fieldValue);
                return;
            }
            if (checkDraw)
            {
                openNewWindow("Remis");
            }
            klikniec++;
        }



        private void btn2_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            Class1 fieldAndTurnObject = a.main(klikniec);
            label3.Text = fieldAndTurnObject.turn;
            btn2.Text = fieldAndTurnObject.fieldValue;
            btn2.Enabled = false;
            Boolean checkWin = a.checkWin(lstBtnCalc, fieldAndTurnObject.fieldValue);
            Boolean checkDraw = a.checkDraw(lstBtnCalc);
            if (checkWin)
            {
                openNewWindow(fieldAndTurnObject.fieldValue);
                return;
            }
            if (checkDraw)
            {
                openNewWindow("Remis");
            }
            klikniec++;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            Class1 fieldAndTurnObject = a.main(klikniec);
            label3.Text = fieldAndTurnObject.turn;
            btn4.Text = fieldAndTurnObject.fieldValue;
            btn4.Enabled = false;
            Boolean checkWin = a.checkWin(lstBtnCalc, fieldAndTurnObject.fieldValue);
            Boolean checkDraw = a.checkDraw(lstBtnCalc);
            if (checkWin)
            {
                openNewWindow(fieldAndTurnObject.fieldValue);
                return;
            }
            if (checkDraw)
            {
                openNewWindow("Remis");
            }
            klikniec++;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            Class1 fieldAndTurnObject = a.main(klikniec);
            label3.Text = fieldAndTurnObject.turn;
            btn3.Text = fieldAndTurnObject.fieldValue;
            btn3.Enabled = false;
            Boolean checkWin = a.checkWin(lstBtnCalc, fieldAndTurnObject.fieldValue);
            Boolean checkDraw = a.checkDraw(lstBtnCalc);
            if (checkWin)
            {
                openNewWindow(fieldAndTurnObject.fieldValue);
                return;
            }
            if (checkDraw)
            {
                openNewWindow("Remis");
            }
            klikniec++;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            Class1 fieldAndTurnObject = a.main(klikniec);
            label3.Text = fieldAndTurnObject.turn;
            btn5.Text = fieldAndTurnObject.fieldValue;
            btn5.Enabled = false;
            Boolean checkWin = a.checkWin(lstBtnCalc, fieldAndTurnObject.fieldValue);
            Boolean checkDraw = a.checkDraw(lstBtnCalc);
            if (checkWin)
            {
                openNewWindow(fieldAndTurnObject.fieldValue);
                return;
            }
            if (checkDraw)
            {
                openNewWindow("Remis");
            }
            klikniec++;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            Class1 fieldAndTurnObject = a.main(klikniec);
            label3.Text = fieldAndTurnObject.turn;
            btn6.Text = fieldAndTurnObject.fieldValue;
            btn6.Enabled = false;
            Boolean checkWin = a.checkWin(lstBtnCalc, fieldAndTurnObject.fieldValue);
            Boolean checkDraw = a.checkDraw(lstBtnCalc);
            if (checkWin)
            {
                openNewWindow(fieldAndTurnObject.fieldValue);
                return;
            }
            if (checkDraw)
            {
                openNewWindow("Remis");
            }
            klikniec++;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            Class1 fieldAndTurnObject = a.main(klikniec);
            label3.Text = fieldAndTurnObject.turn;
            btn7.Text = fieldAndTurnObject.fieldValue;
            btn7.Enabled = false;
            Boolean checkWin = a.checkWin(lstBtnCalc, fieldAndTurnObject.fieldValue);
            Boolean checkDraw = a.checkDraw(lstBtnCalc);
            if (checkWin)
            {
                openNewWindow(fieldAndTurnObject.fieldValue);
                return;
            }
            if (checkDraw)
            {
                openNewWindow("Remis");
            }
            klikniec++;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Class1 a = new Class1();
            Class1 fieldAndTurnObject = a.main(klikniec);
            label3.Text = fieldAndTurnObject.turn;
            btn8.Text = fieldAndTurnObject.fieldValue;
            btn8.Enabled = false;
            Boolean checkWin = a.checkWin(lstBtnCalc, fieldAndTurnObject.fieldValue);
            Boolean checkDraw = a.checkDraw(lstBtnCalc);
            if (checkWin)
            {
                openNewWindow(fieldAndTurnObject.fieldValue);
                return;
            }
            if (checkDraw)
            {
                openNewWindow("Remis");
            }
            klikniec++;
        }

        private void opennewform3(object obj)
        {
            Application.Run(new Form4(obj));

        }
        private void openNewWindow(string winner)
        {
            this.Close();
            th = new Thread(opennewform3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start(winner);
        }
    }
}
