using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace shaperotating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        shapedpiesa sp1 = new shapedpiesa();

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            //sp1.loadValuesIntoPatrate();
            //sp1.drawShapedPiesa(ref g);
            sp1.fill(ref sp1.lshapeRTR);
            sp1.valoare = "lshapeRTR";
            sp1.drawTheShape(ref g);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sp1.patrate = sp1.lshapeRTL;
            sp1.drawTheShape(ref g);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sp1.patrate = sp1.lshapeRTR;
            sp1.drawTheShape(ref g);
        }
    }
}
