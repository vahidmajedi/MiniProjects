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
        int row = 10, col = 10, size = 30;
        int[,] DataMat = new int[10, 10];
        Button[,] cells = new Button[10, 10];

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadField();
            DataMat = AllocateMines(20);
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    cells[i, j].Text = DataMat[i, j].ToString();
        }

        private int[,] AllocateMines(int MineNo)
        {
            for (int i = 0; i < DataMat.GetLength(0); i++)
                for (int j = 0; j < DataMat.GetLength(1); j++)
                    DataMat[i, j] = 0;

            Random r = new Random();
            int cnt = 0, Mr, Mc;
            while (cnt <= MineNo)
            {
                Mr = r.Next(row);
                Mc = r.Next(col);
                if (DataMat[Mr, Mc] == 0)
                {
                    cnt++;
                    DataMat[Mr, Mc] = 9;
                }
            }
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    if (DataMat[i, j] == 0)
                        DataMat[i, j] = ButtonAround(i, j);
             return DataMat;
        }
              
        private int ButtonAround(int r, int c)
        {
            int res = 0;
            for (int i = r - 1; i <= r + 1; i++)
                for (int j = c - 1; j <= c + 1; j++)
                {
                    if (i < 0 || j < 0)
                        continue;
                    if (DataMat[i, j] == 9)
                        res++;
                }
            return res;
        }

        private void LoadField()
        {
            int cnt = -1;
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    cnt++;
                    cells[i, j] = new Button()
                    {
                        Parent = this,
                        Height = size,
                        Width = size,
                        Location = new Point(size * i, size * j),
                        Text = null,
                        Tag = cnt,
                        Name = "btn" + cnt,
                    };
                    cells[i, j].Click += ButtonClicked;
                    cells[i, j].EnabledChanged += ButtonEnableChanged;
                }

        }
      
        private void ButtonClicked(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            myButton.Enabled = false;
        }

        private void ButtonEnableChanged(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            myButton.BackColor = Color.LightGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }
    }
}
