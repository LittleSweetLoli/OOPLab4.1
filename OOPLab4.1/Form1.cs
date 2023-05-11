using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab4._1
{
    public partial class Form1 : Form
    {
        int mouseX, mouseY; // переменные отвечающие за координаты мыши
        int rad = 20; // диаметр кругов
        public static List<Ccircle> Circles = new List<Ccircle>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e) // создание кругов при нажатии мыши на форму
        {
            if (CreateBt.Checked == true)
            {
                Ccircle temp = new Ccircle(mouseX, mouseY, rad);
                temp.vyd = true;

                if (AllBt.Checked == false)
                {
                    check();
                }
                else
                {
                    check();
                }
                Circles.Add(temp);
                this.Invalidate();
            }
            else if (CtrlBt.Checked == true)
            {
                foreach (Ccircle ccircle in Circles)
                {
                    if ((mouseX - (ccircle.x + Math.Sqrt(rad * rad + rad * rad))) * (mouseX - (ccircle.x + Math.Sqrt(rad * rad + rad * rad))) + (mouseY - (ccircle.y + Math.Sqrt(rad * rad + rad * rad))) * (mouseY - (ccircle.y + Math.Sqrt(rad * rad + rad * rad))) <= ccircle.r * ccircle.r)
                    {
                        ccircle.vyd = true;
                        this.Invalidate();
                    }
                }
            }
            else if (AllBt.Checked == true)
            {
                check();
                foreach (Ccircle ccircle in Circles)
                {
                    if ((mouseX - (ccircle.x + Math.Sqrt(rad * rad + rad * rad))) * (mouseX - (ccircle.x + Math.Sqrt(rad * rad + rad * rad))) + (mouseY - (ccircle.y + Math.Sqrt(rad * rad + rad * rad))) * (mouseY - (ccircle.y + Math.Sqrt(rad * rad + rad * rad))) <= ccircle.r * ccircle.r)
                    {
                        ccircle.vyd = true;
                        this.Invalidate();
                    }
                }
            }
            else
            {
                foreach (Ccircle ccircle in Circles)
                {
                    if ((mouseX - (ccircle.x + Math.Sqrt(rad * rad + rad * rad))) * (mouseX - (ccircle.x + Math.Sqrt(rad * rad + rad * rad))) + (mouseY - (ccircle.y + Math.Sqrt(rad * rad + rad * rad))) * (mouseY - (ccircle.y + Math.Sqrt(rad * rad + rad * rad))) <= ccircle.r * ccircle.r)
                    {
                        check();
                        ccircle.vyd = true;
                        this.Invalidate();
                    }
                }
            }
        }

        private void check()
        {
            foreach (Ccircle c in Circles)
            {
                c.vyd = false;
            }
        }
        private void ch()
        {
            if (AllBt.Checked == true)
            {
                checkAll();
                this.Invalidate();
            }
            else
            {
                check();
                Circles.Last().vyd = true;
                this.Invalidate();
            }
        }

        private void checkAll()
        {
            foreach (Ccircle c in Circles)
            {
                c.vyd = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X; mouseY = e.Y;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Control)
            {
                CtrlBt.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                CtrlBt.Checked = true;
            }
            if (e.KeyCode == Keys.Delete)
            {
                DelEl(sender, e);
            }
        }

        void DelEl(object sender, KeyEventArgs e)
        {

            for (int i = 0; i < Circles.Count;)
            {
                if (Circles[i].vyd == true)
                {
                    Circles.Remove(Circles[i]);
                    i = 0;
                }
                else
                    i++;
            }
            if (Circles.Count > 0)
            {
                ch();

            }
            this.Invalidate();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Ccircle ccircle in Circles)
            {
                Pen pen = new Pen(Color.Aqua);
                if (ccircle.vyd)
                {
                    pen.Color = Color.Blue; // цвет при выделении 
                }
                else
                {
                    pen.Color = Color.Red; // цвет без выделения
                }
                e.Graphics.DrawEllipse(pen, ccircle.x, ccircle.y, ccircle.r * 2, ccircle.r * 2);
            }
        }

        private void AllBt_CheckedChanged(object sender, EventArgs e)
        {
            if (AllBt.Checked == true)
            {

            }
            else
            {
                if (Circles.Count > 0)
                {
                    check();
                    Circles.Last().vyd = true;
                    this.Invalidate();
                }
            }
        }

        private void CtrlBt_CheckedChanged(object sender, EventArgs e)
        {

        }

    }

    public class Ccircle
    {
        public int x, y, r;
        public bool vyd;
        public Ccircle(int x, int y, int r) { this.x = x; this.y = y; this.r = r; }
        ~Ccircle() { }

    };

}