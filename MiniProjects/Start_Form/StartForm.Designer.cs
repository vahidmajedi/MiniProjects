namespace Start_Form
{
    partial class frmStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudOperand1 = new System.Windows.Forms.NumericUpDown();
            this.nudOperand2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TrackBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudOperand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOperand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Number:";
            // 
            // nudOperand1
            // 
            this.nudOperand1.Location = new System.Drawing.Point(92, 12);
            this.nudOperand1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudOperand1.Name = "nudOperand1";
            this.nudOperand1.Size = new System.Drawing.Size(67, 20);
            this.nudOperand1.TabIndex = 2;
            // 
            // nudOperand2
            // 
            this.nudOperand2.Location = new System.Drawing.Point(253, 13);
            this.nudOperand2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudOperand2.Name = "nudOperand2";
            this.nudOperand2.Size = new System.Drawing.Size(67, 20);
            this.nudOperand2.TabIndex = 3;
            this.nudOperand2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operator:";
            // 
            // cbOperator
            // 
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.cbOperator.Location = new System.Drawing.Point(408, 10);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(33, 21);
            this.cbOperator.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Think Time:";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(141, 55);
            this.tbTime.Maximum = 20;
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(204, 45);
            this.tbTime.TabIndex = 7;
            this.tbTime.Value = 3;
            this.tbTime.Scroll += new System.EventHandler(this.tbTime_Scroll);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(114, 66);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(21, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "3 s";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(117, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 33);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(242, 117);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 33);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 176);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudOperand2);
            this.Controls.Add(this.nudOperand1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.frmStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOperand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOperand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudOperand1;
        private System.Windows.Forms.NumericUpDown nudOperand2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}

