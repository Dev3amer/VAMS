using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.People
{
    public partial class frmListPeople : Form
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


        DataTable PeopleDataTable = new DataTable();
        private void _RefreshDGV()
        {
            PeopleDataTable = clsPerson.GetAllPeople();
            dgvPeople.DataSource = PeopleDataTable;
            lblResponRecords.Text = PeopleDataTable.Rows.Count.ToString();
        }
        public frmListPeople()
        {
            InitializeComponent();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            _RefreshDGV();
            cbFilterList.SelectedIndex = 0;
            txtFilter.Visible = false;

            if (dgvPeople.Rows.Count > 0)
            {
                dgvPeople.Columns[0].Width = 105;
                dgvPeople.Columns[1].Width = 115;
                dgvPeople.Columns[2].Width = 115;
                dgvPeople.Columns[3].Width = 135;
                dgvPeople.Columns[4].Width = 115;
                dgvPeople.Columns[5].Width = 80;
                dgvPeople.Columns[6].Width = 125;
                dgvPeople.Columns[7].Width = 110;
                dgvPeople.Columns[8].Width = 130;
                dgvPeople.Columns[9].Width = 140;

            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            DataView PeopleDataView = PeopleDataTable.DefaultView;
            if (cbFilterList.Text != "Person ID")
            {
                PeopleDataView.RowFilter = $"[{cbFilterList.Text}] Like '{txtFilter.Text.Trim()}%'";
            }
            else
            {
                if (!(Int32.TryParse(txtFilter.Text, out int result)))
                {
                    txtFilter.Text = string.Empty;
                }
                if (txtFilter.Text.Trim() == "")
                {
                    PeopleDataView.RowFilter = string.Empty;
                }
                else
                    PeopleDataView.RowFilter = $"[{cbFilterList.Text}] = {txtFilter.Text.Trim()}";
            }
        }
        private void cbFilterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterList.SelectedIndex != 0)
                txtFilter.Visible = true;
            else
                txtFilter.Visible = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmAddUpdatePerson();
            frm1.ShowDialog();
            _RefreshDGV();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmAddUpdatePerson();
            frm1.ShowDialog();
            _RefreshDGV();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshDGV();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsPerson.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshDGV();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            Form frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

    }
}
