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
    public class Class2
    {
        public String turn;
        public String fieldValue;
        public Class2 main(List<Button> buttons)
        {
            Class2 S = new Class2();
            S.turn = "X";
            S.fieldValue = "O";
            return S;
        }

        public int Compbutt(List<Button> buttons)
        {
            return getComputerMove(buttons);
        }

        private int getComputerMove(List<Button> buttons)
        {
            List<int> availableButtons = new List<int>();
            var random = new Random();
            for (int i = 0; i < 9; i++)
            {
                if (buttons[i].Enabled)
                {
                    availableButtons.Add(i);
                }
            }
            int index = random.Next(availableButtons.Count);
            return availableButtons[index];
        }

        public Boolean checkWin(List<Button> buttons, string value)
        {
            Boolean row = checkRow(buttons, value);
            Boolean column = checkColumn(buttons, value);
            Boolean lCross = leftCross(buttons, value);
            Boolean rCross = rightCross(buttons, value);
            return row || column || lCross || rCross;
        }

        private Boolean checkRow(List<Button> buttons, string value)
        {
            int iteration = 0;
            for (int i = 0; i < 3; i++)
            {
                if (buttons[0 + iteration].Text == value && buttons[1 + iteration].Text == value && buttons[2 + iteration].Text == value)
                {
                    return true;
                }
                iteration = iteration + 3;
            }
            return false;
        }

        private Boolean checkColumn(List<Button> buttons, string value)
        {
            int iteration = 0;
            for (int i = 0; i < 3; i++)
            {
                if (buttons[0 + iteration].Text == value && buttons[3 + iteration].Text == value && buttons[6 + iteration].Text == value)
                {
                    return true;
                }
                iteration++;
            }
            return false;
        }

        private Boolean leftCross(List<Button> buttons, string value)
        {
            if (buttons[0].Text == value && buttons[4].Text == value && buttons[8].Text == value)
            {
                return true;
            }
            return false;

        }

        private Boolean rightCross(List<Button> buttons, string value)
        {
            if (buttons[2].Text == value && buttons[4].Text == value && buttons[6].Text == value)
            {
                return true;
            }
            return false;
        }
        public Boolean checkDraw(List<Button> buttons)
        {
            for (int i = 0; i < 9; i++)
            {
                if (buttons[i].Text != "O" && buttons[i].Text != "X")

                {
                    return false;
                }
            }
            return true;

        }
    }
}
