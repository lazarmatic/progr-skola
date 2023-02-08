using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            nacrtajElipse(g);
            nacrtajRuke(g);
        }

        private void nacrtajRuke(Graphics g)
        {
            Pen linija = new Pen(Color.Red);
            linija.Width = 6f;
            g.DrawLine(linija, 150, 125, 100, 120);
            g.DrawLine(linija, 150, 95, 100, 120);

        }

        private void nacrtajElipse(Graphics g)
        {
            Pen olovka = new Pen(Color.Chocolate);
            olovka.Width = 5f;

            Rectangle pravougaonikElipse = new Rectangle(110, 60, 90, 90);
            g.DrawEllipse(olovka, pravougaonikElipse);
            g.DrawEllipse(olovka, 100, 150, 110, 100);
            g.DrawEllipse(olovka, 80, 250, 145, 140);
        }
    }
}
