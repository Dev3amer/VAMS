using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Vaccine
{
    public partial class frmListPatient : Form
    {
        //Methods To Make Form Move With Mouse
        private bool MouseDown = false;
        private Point LastLocation;
        public frmListPatient()
        {
            InitializeComponent();
        }
        private void pnTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            LastLocation = e.Location;
        }
        private void pnTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }
        private void pnTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - LastLocation.X) + e.X, (this.Location.Y - LastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private static DataTable _dtAllPatients;
        private void _RefreshDGV()
        {
            _dtAllPatients = clsPatient.GetAllPatients();
            dgvPatients.DataSource = _dtAllPatients;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvPatients.Rows.Count.ToString();
        }
        private void frmVaccineTypes_Load(object sender, EventArgs e)
        {
            _RefreshDGV();

            if (dgvPatients.Rows.Count == 0)
                return;

            dgvPatients.Columns[0].HeaderText = "Patient ID";
            dgvPatients.Columns[0].Width = 80;


            dgvPatients.Columns[1].HeaderText = "National No";
            dgvPatients.Columns[1].Width = 90;

            dgvPatients.Columns[2].HeaderText = "Full Name";
            dgvPatients.Columns[2].Width = 150;

            dgvPatients.Columns[3].HeaderText = "Vaccine Name";
            dgvPatients.Columns[3].Width = 120;

            dgvPatients.Columns[4].HeaderText = "Issue Date";
            dgvPatients.Columns[4].Width = 110;

            dgvPatients.Columns[5].HeaderText = "Fees";
            dgvPatients.Columns[5].Width = 90;
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.SelectedIndex != 0)
            {
                txtFilterValue.Visible = true;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
            else
                txtFilterValue.Visible = false;
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilterBy.Text)
            {
                case "Patient ID":
                    FilterColumn = "PatientID";
                    break;
                case "National No":
                    FilterColumn = "NationalNo";
                    break;

                case "Full Name":
                    FilterColumn = "Full Name";
                    break;

                case "Vaccine Name":
                    FilterColumn = "VaccineName";
                    break;

                case "Issue Date":
                    FilterColumn = "Issue Date";
                    break;

                case "Fees":
                    FilterColumn = "TypeFees";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllPatients.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvPatients.Rows.Count.ToString();
                return;
            }

             if (FilterColumn != "TypeFees" && FilterColumn != "PatientID")
                _dtAllPatients.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllPatients.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllPatients.Rows.Count.ToString();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Fees" || cbFilterBy.Text == "Patient ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewEditVaccineOrder();
            frm.ShowDialog();
            _RefreshDGV();
        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewEditVaccineOrder();
            frm.ShowDialog();
            _RefreshDGV();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PatientID = (int)dgvPatients.CurrentRow.Cells[0].Value;
            
            if (clsPatient.DeletePatient(PatientID))
            {
                MessageBox.Show("Patient has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshDGV();
            }

            else
                MessageBox.Show("Patient is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNewEditVaccineOrder((int)dgvPatients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmVaccineCard((int)dgvPatients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
