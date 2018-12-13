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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void tbTime_Scroll(object sender, EventArgs e)
        {
            lblTime.Text = tbTime.Value.ToString() + " s";
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            cbOperator.SelectedIndex = 0;
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
            frmMain.Time = tbTime.Value;
            frmMain.Operator= (string)cbOperator.SelectedItem;
            btnCancel_Click(sender, e);
        }
    }
}
