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
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            cbOperator.SelectedIndex = frmMain.OperatorIdx;
            nudOperand1.Value = frmMain.MinOperand;
            nudOperand2.Value = frmMain.MaxOperand;
            tbTime.Value = frmMain.MaxTime;
            lblTime.Text = tbTime.Value.ToString() + " s";
        }

        private void tbTime_Scroll(object sender, EventArgs e)
        {
            lblTime.Text = tbTime.Value.ToString() + " s";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nudOperand1.Value >= nudOperand2.Value)
                MessageBox.Show("Select Right Operands");
            frmMain.MinOperand = (int)nudOperand1.Value;
            frmMain.MaxOperand = (int)nudOperand2.Value;
            frmMain.MaxTime = tbTime.Value;
            frmMain.Operator= (string)cbOperator.SelectedItem;
            frmMain.OperatorIdx = cbOperator.SelectedIndex;
            btnCancel_Click(sender, e);
        }

    }
}
