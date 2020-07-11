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
    public partial class Form3 : Form
    {
        public List<Button> lstBtnCalc = null;
        Thread th;
        public Form3()
        {
            InitializeComponent();
            lstBtnCalc = new List<Button>()
            {
                button0, button1, button2, button3, button4, button5, button6, button7, button8
            };
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Class2 a = new Class2();
            Class2 fieldAndTurnObject = a.main(lstBtnCalc);
            button0.Text = fieldAndTurnObject.fieldValue;
            button0.Enabled = false;
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
                return;
            }
            if (fieldAndTurnObject.fieldValue == "O")
            {
                int b = a.Compbutt(lstBtnCalc);
                lstBtnCalc[b].Text = "X";
                lstBtnCalc[b].Enabled = false;
            }
            Boolean checkWinComp = a.checkWin(lstBtnCalc, fieldAndTurnObject.turn);
            if (checkWinComp)
            {
                openNewWindow(fieldAndTurnObject.turn);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class2 a = new Class2();
            Class2 fieldAndTurnObject = a.main(lstBtnCalc);
            button1.Text = fieldAndTurnObject.fieldValue;
            button1.Enabled = false;
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
            if (fieldAndTurnObject.fieldValue == "O")
            {
                int b = a.Compbutt(lstBtnCalc);
                lstBtnCalc[b].Text = "X";
                lstBtnCalc[b].Enabled = false;
            }
            Boolean checkWinComp = a.checkWin(lstBtnCalc, fieldAndTurnObject.turn);
            if (checkWinComp)
            {
                openNewWindow(fieldAndTurnObject.turn);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class2 a = new Class2();
            Class2 fieldAndTurnObject = a.main(lstBtnCalc);
            button2.Text = fieldAndTurnObject.fieldValue;
            button2.Enabled = false;
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
            if (fieldAndTurnObject.fieldValue == "O")
            {
                int b = a.Compbutt(lstBtnCalc);
                lstBtnCalc[b].Text = "X";
                lstBtnCalc[b].Enabled = false;
            }
            Boolean checkWinComp = a.checkWin(lstBtnCalc, fieldAndTurnObject.turn);
            if (checkWinComp)
            {
                openNewWindow(fieldAndTurnObject.turn);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class2 a = new Class2();
            Class2 fieldAndTurnObject = a.main(lstBtnCalc);
            button3.Text = fieldAndTurnObject.fieldValue;
            button3.Enabled = false;
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
            if (fieldAndTurnObject.fieldValue == "O")
            {
                int b = a.Compbutt(lstBtnCalc);
                lstBtnCalc[b].Text = "X";
                lstBtnCalc[b].Enabled = false;
            }
            Boolean checkWinComp = a.checkWin(lstBtnCalc, fieldAndTurnObject.turn);
            if (checkWinComp)
            {
                openNewWindow(fieldAndTurnObject.turn);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class2 a = new Class2();
            Class2 fieldAndTurnObject = a.main(lstBtnCalc);
            button4.Text = fieldAndTurnObject.fieldValue;
            button4.Enabled = false;
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
            if (fieldAndTurnObject.fieldValue == "O")
            {
                int b = a.Compbutt(lstBtnCalc);
                lstBtnCalc[b].Text = "X";
                lstBtnCalc[b].Enabled = false;
            }
            Boolean checkWinComp = a.checkWin(lstBtnCalc, fieldAndTurnObject.turn);
            if (checkWinComp)
            {
                openNewWindow(fieldAndTurnObject.turn);
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class2 a = new Class2();
            Class2 fieldAndTurnObject = a.main(lstBtnCalc);
            button5.Text = fieldAndTurnObject.fieldValue;
            button5.Enabled = false;
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
            if (fieldAndTurnObject.fieldValue == "O")
            {
                int b = a.Compbutt(lstBtnCalc);
                lstBtnCalc[b].Text = "X";
                lstBtnCalc[b].Enabled = false;
            }
            Boolean checkWinComp = a.checkWin(lstBtnCalc, fieldAndTurnObject.turn);
            if (checkWinComp)
            {
                openNewWindow(fieldAndTurnObject.turn);
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Class2 a = new Class2();
            Class2 fieldAndTurnObject = a.main(lstBtnCalc);
            button6.Text = fieldAndTurnObject.fieldValue;
            button6.Enabled = false;
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
            if (fieldAndTurnObject.fieldValue == "O")
            {
                int b = a.Compbutt(lstBtnCalc);
                lstBtnCalc[b].Text = "X";
                lstBtnCalc[b].Enabled = false;
            }
            Boolean checkWinComp = a.checkWin(lstBtnCalc, fieldAndTurnObject.turn);
            if (checkWinComp)
            {
                openNewWindow(fieldAndTurnObject.turn);
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Class2 a = new Class2();
            Class2 fieldAndTurnObject = a.main(lstBtnCalc);
            button7.Text = fieldAndTurnObject.fieldValue;
            button7.Enabled = false;
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
            if (fieldAndTurnObject.fieldValue == "O")
            {
                int b = a.Compbutt(lstBtnCalc);
                lstBtnCalc[b].Text = "X";
                lstBtnCalc[b].Enabled = false;
            }
            Boolean checkWinComp = a.checkWin(lstBtnCalc, fieldAndTurnObject.turn);
            if (checkWinComp)
            {
                openNewWindow(fieldAndTurnObject.turn);
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Class2 a = new Class2();
            Class2 fieldAndTurnObject = a.main(lstBtnCalc);
            button8.Text = fieldAndTurnObject.fieldValue;
            button8.Enabled = false;
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
            if (fieldAndTurnObject.fieldValue == "O")
            {
                int b = a.Compbutt(lstBtnCalc);
                lstBtnCalc[b].Text = "X";
                lstBtnCalc[b].Enabled = false;
            }
            Boolean checkWinComp = a.checkWin(lstBtnCalc, fieldAndTurnObject.turn);
            if (checkWinComp)
            {
                openNewWindow(fieldAndTurnObject.turn);
                return;
            }
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
