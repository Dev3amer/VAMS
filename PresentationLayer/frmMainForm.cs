using PresentationLayer.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private bool MouseDown = false;
        private Point LastLocation;
        private void pnTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            LastLocation = e.Location;
        }

        private void pnTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }

        private void pnTopBar_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - LastLocation.X) + e.X, (this.Location.Y - LastLocation.Y) + e.Y);

                this.Update();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListPeople();
            frm.ShowDialog();
        }

        
    }
}
