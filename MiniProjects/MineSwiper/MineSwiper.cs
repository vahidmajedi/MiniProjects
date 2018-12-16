using System;
using System.Collections;
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
        int row = 10, col = 10, size = 30, MineNo = 15;
        int[,] DataMat = new int[10, 10];
        Button[,] cells = new Button[10, 10];
        Dictionary<int, Color> NumbersColor = new Dictionary<int, Color>()
        {
            {0, Color.Gray}, {1, Color.Blue}, {2, Color.Green}, {3, Color.Red}, {4, Color.Brown},
            {5, Color.GreenYellow}, {6, Color.HotPink}, {7, Color.Khaki}, {8, Color.Indigo}, {9, Color.Orange}
        };

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadField();
            DataMat = AllocateMines(MineNo);
        }

        private void LoadField()
        {
            Point p = new Point();
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    p.X = i;
                    p.Y = j;
                    cells[i, j] = new Button()
                    {
                        Parent = this,
                        Height = size,
                        Width = size,
                        Location = new Point(size * i, size * j),
                        Text = null,
                        Tag = p,
                        TabStop = false,
                        BackgroundImageLayout = ImageLayout.Zoom,
                    };
                    cells[i, j].MouseUp += ButtonClicked;
                }

        }

        private int[,] AllocateMines(int MineNo)
        {
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    DataMat[i, j] = 0;

            Random r = new Random();
            int cnt = 0, Mr, Mc;
            while (cnt < MineNo)
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
                    if (i < 0 || j < 0 || i >= row || j >= col)
                        continue;
                    if (DataMat[i, j] == 9)
                        res++;
                }
            return res;
        }

        private void ButtonClicked(object sender, MouseEventArgs e)
        {
            Button myButton = (Button)sender;
            if (e.Button == MouseButtons.Left)
            {
                myButton.Enabled = false;
                Point p = (Point)myButton.Tag;
                int num = DataMat[p.X, p.Y];
                if (num == 9)
                {
                    myButton.BackColor = Color.Red;
                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < col; j++)
                            DisableButton(i, j, cells[i, j]);
                }
                else if (num == 0)
                {
                    Point[] zeros = new Point[row * col];
                    for (int i = 0; i < row * col; i++)
                        zeros[i] = new Point(-1, -1);
                    zeros[0] = p;
                    int cnt = 0;
                    for (int m = 0; m < row * col; m++)
                    {
                        Point pp = zeros[m];
                        if (pp == new Point(-1, -1))
                            break;
                        for (int i = pp.X - 1; i <= pp.X + 1; i++)
                            for (int j = pp.Y - 1; j <= pp.Y + 1; j++)
                            {
                                if (i < 0 || j < 0 || i >= row || j >= col || (i == pp.X && j == pp.Y))
                                    continue;
                                else if (DataMat[i, j] == 0 && cells[i, j].Enabled == true)
                                {
                                    cnt++;
                                    zeros[cnt] = new Point(i, j);
                                    DisableButton(i, j, cells[i, j]);
                                }
                                else if (DataMat[i, j] > 0 && DataMat[i, j] < 9)
                                    DisableButton(i, j, cells[i, j]);
                            }
                    }
                }
                else
                    DisableButton(p.X, p.Y, myButton);
            }
            else if (e.Button == MouseButtons.Right)
                myButton.BackgroundImage = MineSwiper.Properties.Resources.Flag;
        }

        private void DisableButton(int x, int y, Button btn)
        {
            btn.Enabled = false;
            switch (DataMat[x, y])
            {
                case 9:
                    btn.BackgroundImage = MineSwiper.Properties.Resources.MinePic;
                    break;
                case 0:
                    btn.Text = null;
                    break;
                default:
                    btn.Text = DataMat[x, y].ToString();
                    break;
            }
        }
    }

}
