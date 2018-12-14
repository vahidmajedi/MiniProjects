using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames
{
    public partial class frmMain : Form
    {
        public static int MaxOperand = 1000, MinOperand = 0, MaxTime = 3;
        public static string Operator = "+";
        int result, score = 0, test_run = 0;
        float CurrentTime = 0;
        bool FinishFlag = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pbTime.Value = pbTime.Maximum;
            lblOperator.Text = Operator;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Button btnNo = (Button)sender;
            txtResult.Text += btnNo.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Compare();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = null;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblOperator.Text = Operator;
            Random r = new Random();
            int operand1 = r.Next(MinOperand, MaxOperand);
            int operand2 = r.Next(MinOperand, MaxOperand);
            lblOperand1.Text = operand1.ToString();
            lblOperand2.Text = operand2.ToString();

            switch (Operator)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    result = operand1 / operand2;
                    break;
                case "%":
                    result = operand1 % operand2;
                    break;
            }

            CurrentTime = 0;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float err = 0.05F;
            CurrentTime += (float)timer.Interval / 1000;
            if (CurrentTime > MaxTime)
            {
                timer.Stop();
                pbTime.Value = pbTime.Minimum;
                lblTime.Text = "0";
                Console.Beep(2000, 1000);
            }
            else
            {
                pbTime.Value = pbTime.Maximum - (int)((CurrentTime * pbTime.Maximum) / MaxTime);
                lblTime.Text = (MaxTime - Math.Floor(CurrentTime)).ToString();
                if (((MaxTime - CurrentTime) < (3 + err) && (MaxTime - CurrentTime) > (3 - err)) ||
                    ((MaxTime - CurrentTime) < (2 + err) && (MaxTime - CurrentTime) > (2 - err)) ||
                    ((MaxTime - CurrentTime) < (1 + err) && (MaxTime - CurrentTime) > (1 - err)))
                    Console.Beep(2000, 400);
            }
        }

        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Compare();
        }

        private void Compare()
        {
            int myResult = Convert.ToInt32(txtResult.Text);
            test_run++;
            if (myResult == result)
                score++;
            tstlbl.Text = score + "/" + test_run;
            txtResult.Text = null;
            CurrentTime = 0;
            timer.Stop();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetting SettingForm = new frmSetting();
            SettingForm.ShowDialog();        
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
