using BusinessLayer;
using PresentationLayer.Global_Classes;
using PresentationLayer.Login;
using PresentationLayer.People;
using PresentationLayer.Users;
using PresentationLayer.Vaccine;
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
        frmLogin _frmLogin;
        public frmMainForm(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
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

        //Fun to ChecK User Access
        static bool CheckAccessRights(clsUser.enPermissions Permission)
        {

            if (!clsGlobal.CurrentUser.CheckAccessPermission(Convert.ToInt32(Permission)))
            {
                MessageBox.Show("You do not have permission, contact Your admin", "Access denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckAccessRights(clsUser.enPermissions.ManagePeople))
                return;
            Form frm = new frmListPeople();
            frm.ShowDialog();
        }
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckAccessRights(clsUser.enPermissions.ManageUsers))
                return;
            Form frm = new frmListUsers();
            frm.ShowDialog();
        }
        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckAccessRights(clsUser.enPermissions.ManagePatient))
                return;
            Form frm = new frmListPatient();
            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
   
        }
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.Permissions);
            frm.ShowDialog();
        }


        private void newApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckAccessRights(clsUser.enPermissions.ManageApplication))
                return;
            Form frm = new frmNewEditVaccineOrder();
            frm.ShowDialog();
        }
        private void applecationSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckAccessRights(clsUser.enPermissions.ManageApplication))
                return;
            Form frm = new frmListVaccineTypes();
            frm.ShowDialog();
        }
    }
}
