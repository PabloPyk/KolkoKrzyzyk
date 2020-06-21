using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Windows.Forms;

namespace TicTacToeLogic
{
    public class Class1
    {
        public String turn;
        public String fieldValue;
        public Class1 main(int klikniec)
        {
            if (klikniec % 2 == 0)
            {
                Class1 S = new Class1();
                S.turn = "X";
                S.fieldValue = "O";
                return S;
            }
            Class1 D = new Class1();
            D.turn = "O";
            D.fieldValue = "X";
            return D;
        }

        public Boolean checkWin(Button btn0, Button btn1, Button btn2)
        {
            if (btn0.Text == "O" && btn1.Text == "O" && btn2.Text == "O")
            {
                return true;
            }
            return false;
        }

    }
}
