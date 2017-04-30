using myGraph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public graph MGr = new graph();
        private Bitmap bmp = null;
        public Form1()
        {
            InitializeComponent();
            MGr.EdgeList = new List<Edge>();
            MGr.VertexList = new List<Vertex>();
        }

        private void DrawCircle(Color col,PaintEventArgs e,int X,int Y)
        {
             Pen Перо = new Pen(col,3);
             Brush Заливка = new SolidBrush(col);
             e.Graphics.FillEllipse(Заливка, X, Y, 20, 20);
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            PaintEventArgs kek = new PaintEventArgs(g, new Rectangle(pictureBox1.Left, pictureBox1.Top,pictureBox1.Right, pictureBox1.Bottom));
            if (check(e.X, e.Y) == null)
            {
                MGr.VertexList.Add(new Vertex(1, e.X, e.Y));
                DrawCircle(Color.Black,kek, e.X, e.Y);
            }
            else
            {
                DrawCircle(Color.Blue, kek, check(e.X, e.Y).X, check(e.X, e.Y).Y);
            }
            
        }
        public Vertex check(int x,int y)
        {
            foreach (var temp in MGr.VertexList)
            {
                if (x > temp.X && x < temp.X + 20 && y > temp.Y && y < temp.Y+20)
                    return temp;
            }
            return null;
        }
    }
}
