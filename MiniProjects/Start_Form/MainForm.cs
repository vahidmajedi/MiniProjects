using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start_Form
{
    public partial class frmMain : Form
    {
        public static int MaxOperand = 1000, MinOperand = 0, Time = 3;
        public static string Operator = "+";
        int result, score = 0, test_run = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Button btnNo = (Button)sender;
            txtResult.Text += btnNo.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = null;
        }

        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Compare();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
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
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStart startForm = new frmStart();
            startForm.ShowDialog();        
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int operand1 = r.Next(MinOperand, MaxOperand);
            int operand2 = r.Next(MinOperand, MaxOperand);
            lblOperand1.Text = operand1.ToString();
            lblOperand2.Text = operand2.ToString();
            lblOperator.Text = Operator;
            pbTime.Maximum = Time;
            pbTime.Value = Time / 2;
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
        }
    }
}
