namespace MiniGames
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.lblOperand1 = new System.Windows.Forms.Label();
            this.lblOperand2 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.tatlbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstlbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbTime = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.stsMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOperand1
            // 
            this.lblOperand1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOperand1.Location = new System.Drawing.Point(40, 156);
            this.lblOperand1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblOperand1.Name = "lblOperand1";
            this.lblOperand1.Size = new System.Drawing.Size(107, 49);
            this.lblOperand1.TabIndex = 0;
            this.lblOperand1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperand2
            // 
            this.lblOperand2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOperand2.Location = new System.Drawing.Point(233, 156);
            this.lblOperand2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblOperand2.Name = "lblOperand2";
            this.lblOperand2.Size = new System.Drawing.Size(107, 49);
            this.lblOperand2.TabIndex = 1;
            this.lblOperand2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperator
            // 
            this.lblOperator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOperator.Location = new System.Drawing.Point(163, 156);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(53, 49);
            this.lblOperator.TabIndex = 2;
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(350, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResult
            // 
            this.txtResult.AcceptsTab = true;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtResult.Location = new System.Drawing.Point(380, 156);
            this.txtResult.Margin = new System.Windows.Forms.Padding(7);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(142, 48);
            this.txtResult.TabIndex = 4;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResult_KeyPress);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(40, 265);
            this.btn1.Margin = new System.Windows.Forms.Padding(7);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(82, 78);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(135, 265);
            this.btn2.Margin = new System.Windows.Forms.Padding(7);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(82, 78);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(231, 265);
            this.btn3.Margin = new System.Windows.Forms.Padding(7);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(82, 78);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(231, 357);
            this.btn6.Margin = new System.Windows.Forms.Padding(7);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(82, 78);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(135, 357);
            this.btn5.Margin = new System.Windows.Forms.Padding(7);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(82, 78);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(40, 357);
            this.btn4.Margin = new System.Windows.Forms.Padding(7);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(82, 78);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(231, 448);
            this.btn9.Margin = new System.Windows.Forms.Padding(7);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(82, 78);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(135, 448);
            this.btn8.Margin = new System.Windows.Forms.Padding(7);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(82, 78);
            this.btn8.TabIndex = 12;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(40, 448);
            this.btn7.Margin = new System.Windows.Forms.Padding(7);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(82, 78);
            this.btn7.TabIndex = 11;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(231, 540);
            this.btnOK.Margin = new System.Windows.Forms.Padding(7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 78);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(135, 540);
            this.btn0.Margin = new System.Windows.Forms.Padding(7);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(82, 78);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(40, 540);
            this.btnC.Margin = new System.Windows.Forms.Padding(7);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(82, 78);
            this.btnC.TabIndex = 14;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // stsMain
            // 
            this.stsMain.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tatlbl,
            this.tstlbl});
            this.stsMain.Location = new System.Drawing.Point(0, 687);
            this.stsMain.Name = "stsMain";
            this.stsMain.Padding = new System.Windows.Forms.Padding(2, 0, 33, 0);
            this.stsMain.Size = new System.Drawing.Size(558, 22);
            this.stsMain.TabIndex = 17;
            this.stsMain.Text = "sts";
            // 
            // tatlbl
            // 
            this.tatlbl.Name = "tatlbl";
            this.tatlbl.Size = new System.Drawing.Size(0, 17);
            // 
            // tstlbl
            // 
            this.tstlbl.Name = "tstlbl";
            this.tstlbl.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(558, 49);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(70, 41);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(208, 42);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(208, 42);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(81, 41);
            this.helpToolStripMenuItem.Text = "help";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(357, 265);
            this.btnStart.Margin = new System.Windows.Forms.Padding(7);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(170, 85);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Begin Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(357, 364);
            this.btnClose.Margin = new System.Windows.Forms.Padding(7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(170, 85);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pbTime
            // 
            this.pbTime.Location = new System.Drawing.Point(40, 87);
            this.pbTime.Margin = new System.Windows.Forms.Padding(7);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(488, 36);
            this.pbTime.Step = 1;
            this.pbTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbTime.TabIndex = 21;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblTime.Location = new System.Drawing.Point(409, 525);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 29);
            this.lblTime.TabIndex = 22;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 709);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pbTime);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblOperand2);
            this.Controls.Add(this.lblOperand1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blow Down Brain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperand1;
        private System.Windows.Forms.Label lblOperand2;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStripStatusLabel tatlbl;
        private System.Windows.Forms.ToolStripStatusLabel tstlbl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ProgressBar pbTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
    }
}