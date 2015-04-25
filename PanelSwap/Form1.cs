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
        System.Media.SoundPlayer swapSound = new System.Media.SoundPlayer(@"C:\Users\zakaria\Desktop\Page_Turn_Sounds_3.wav");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.AllowDrop = true;
            panel3.AllowDrop = true;
            panel4.AllowDrop = true;
            panel1.AllowDrop = true;
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
           // Panel p=new Panel();
            //p.Location=new Point(e.X,e.Y);

            panelSwap(panel1, panel2);

        }

       

        private void panel3_DragDrop(object sender, DragEventArgs e)
        {
           // Panel p = new Panel();
           // p.Location = new Point(e.X, e.Y);
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
            swapSound.Play();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            panel2.DoDragDrop(panel1, DragDropEffects.All);
        }
        
    
        private void panel3_MouseDown_1(object sender, MouseEventArgs e)
        {
            panel3.DoDragDrop(panel1, DragDropEffects.All);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            panel4.DoDragDrop(panel1, DragDropEffects.All);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
          
           panelSwap(panel1, panel2);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

    }
}
