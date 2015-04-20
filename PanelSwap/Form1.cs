using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelSwap
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.AllowDrop = true;
            panel3.AllowDrop = true;
            panel4.AllowDrop = true;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.DoDragDrop(panel1, DragDropEffects.All);
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            panelSwap(panel1, panel2);

        }

       

        private void panel3_DragDrop(object sender, DragEventArgs e)
        {
            panelSwap(panel1, panel3);
            panelSwap(panel2, panel3);

        }

        private void panel3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel4_DragDrop(object sender, DragEventArgs e)
        {
            panelSwap(panel1, panel4);
            panelSwap(panel2, panel4);
            panelSwap(panel4, panel3);

        }

        public void panelSwap(Panel a, Panel b)
        {
            Point temp = new Point(b.Location.X, b.Location.Y);
            b.Location = new Point(a.Location.X, a.Location.Y);
            a.Location = temp;
        }

    }
}
