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
                    };
                    cells[i, j].Click += ButtonClicked;
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

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            Point p = (Point)myButton.Tag;
            int num = DataMat[p.X, p.Y];
            myButton.Enabled = false;
            myButton.BackColor = Color.LightGray;
            if (DataMat[p.X, p.Y] == 9)
            {
                myButton.BackgroundImage = MineSwiper.Properties.Resources.MinePic;
                myButton.BackgroundImageLayout = ImageLayout.Zoom;
                myButton.BackColor = Color.Red;
                for (int i = 0; i < row; i++)
                    for (int j = 0; j < col; j++)
                        cells[i, j].Enabled = false;
            }
            else if (num == 0)
            {
                ArrayList zeros = new ArrayList() { p };
                foreach (Point pp in zeros)
                    for (int i = pp.X - 1; i <= pp.X + 1; i++)
                        for (int j = pp.Y - 1; j <= pp.Y + 1; j++)
                        {
                            if (i < 0 || j < 0 || i > row || j > col || (i == pp.X && j == pp.Y))
                                continue;
                            else
                            {
                                if (DataMat[i, j] == 0)
                                    zeros.Add(new Point(i, j));
                            }
                        }
            }
            else
                myButton.Text = num.ToString();

        }

    }
}
