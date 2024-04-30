using BusinessLayer;
using PresentationLayer.VaccineTypes;
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
    public partial class frmListVaccineTypes : Form
    {
        //Methods To Make Form Move With Mouse
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
        private void pnTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - LastLocation.X) + e.X, (this.Location.Y - LastLocation.Y) + e.Y);

                this.Update();
            }
        }
        public frmListVaccineTypes()
        {
            InitializeComponent();
        }
        private static DataTable _dtAllVaccineTypes;
        private void _RefreshDGV()
        {
            _dtAllVaccineTypes = clsVaccineType.GetAllVaccines();
            dgvVaccineTypes.DataSource = _dtAllVaccineTypes;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvVaccineTypes.Rows.Count.ToString();
        }
        private void frmVaccineTypes_Load(object sender, EventArgs e)
        {
            _RefreshDGV();

            if (dgvVaccineTypes.Rows.Count == 0)
                return;

            dgvVaccineTypes.Columns[0].HeaderText = "ID";
            dgvVaccineTypes.Columns[0].Width = 50;

            dgvVaccineTypes.Columns[1].HeaderText = "Vaccine Name";
            dgvVaccineTypes.Columns[1].Width = 110;

            dgvVaccineTypes.Columns[2].HeaderText = "Description";
            dgvVaccineTypes.Columns[2].Width = 310;

            dgvVaccineTypes.Columns[3].HeaderText = "Minimum Age";
            dgvVaccineTypes.Columns[3].Width = 100;

            dgvVaccineTypes.Columns[4].HeaderText = "Fees";
            dgvVaccineTypes.Columns[4].Width = 70;
        }
        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int VaccineID = (int)dgvVaccineTypes.CurrentRow.Cells[0].Value;
            if (clsVaccineType.DeleteVaccine(VaccineID))
            {
                MessageBox.Show("Vaccine Type has been Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshDGV();
            }

            else
                MessageBox.Show("Vaccine Type is not Deleted.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAddVaccineType_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditVaccineType();
            frm.ShowDialog();
            _RefreshDGV();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditVaccineType((int)dgvVaccineTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshDGV();
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex != 0)
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
                case "ID":
                    FilterColumn = "VaccineTypeID";
                    break;
                case "Vaccine Name":
                    FilterColumn = "VaccineName";
                    break;

                case "Description":
                    FilterColumn = "VaccineDescription";
                    break;

                case "Minimum Age":
                    FilterColumn = "MinimumAllowedAge";
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
                _dtAllVaccineTypes.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvVaccineTypes.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "VaccineName" && FilterColumn != "VaccineDescription")
                _dtAllVaccineTypes.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllVaccineTypes.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllVaccineTypes.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Fees" || cbFilterBy.Text == "Patient ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
