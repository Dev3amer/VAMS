using BusinessLayer;
using PresentationLayer.Global_Classes;
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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace PresentationLayer.Vaccine
{
    public partial class frmNewEditVaccineOrder : Form
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

        enum enMode {Add = 0, Edit = 1};
        enMode _Mode;

        int _PersonID = -1;
        clsPatient _Patient = new clsPatient();
        public frmNewEditVaccineOrder()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public frmNewEditVaccineOrder(int PatientID)
        {
            InitializeComponent();
            _Mode = enMode.Edit;
            lblTitle.Text = "Edit Order";
            gpSelectPerson.Enabled= false;
            ctrlPersonCard1.LoadPersonInfo(PatientID);
            _Patient = clsPatient.FindByPatientID(PatientID);
            ctrlPersonCard1.Enabled = false;
            txtNotes.Text = _Patient.Notes;
            _PersonID = _Patient.PersonID;
        }
        private void _ResetForm()
        {
            _PersonID = -1;
            _Patient = new clsPatient();
            cbSelectBy.SelectedIndex = 0;
            txtSearch.Clear();
            gpSelectPerson.Enabled = true;
            ctrlPersonCard1.LoadPersonInfo(-2);
            cbVaccineTypes.SelectedIndex= 0;
            dtCalender.Value = DateTime.Now;
            txtNotes.Text = string.Empty;
        }
        private void _LoadVaccineTypes()
        {
            DataTable dtVaccineTypes = clsVaccineType.GetAllVaccines();

            foreach (DataRow row in dtVaccineTypes.Rows)
            {
                cbVaccineTypes.Items.Add(row["VaccineName"]);
            }
            cbVaccineTypes.SelectedIndex= 0;
        }
        private void frmNewVaccineOrder_Load(object sender, EventArgs e)
        {
            _LoadVaccineTypes();
            if (_Mode == enMode.Add)
                cbSelectBy.SelectedIndex = 0;
            else
            {
                clsVaccineType _VaccineType = new clsVaccineType();
                _VaccineType = clsVaccineType.Find(_Patient.VaccineTypeID);
                MessageBox.Show(_VaccineType.VaccineName);
                cbVaccineTypes.SelectedItem = _VaccineType.VaccineName;
            }
        }
        private void dtCalender_ValueChanged(object sender, EventArgs e)
        {
            dtCalender.MinDate = DateTime.Now.AddMonths(-1);
            dtCalender.MaxDate = DateTime.Now;
            dtCalender.Value = DateTime.Now;
        }
        private void cbSelectBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectBy.SelectedIndex == 0)
                txtSearch.Enabled = false;
            else
                txtSearch.Enabled = true;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cbSelectBy.SelectedIndex == 1)
            {
                if(Int32.TryParse(txtSearch.Text, out int PersonID))
                {
                    if (clsPerson.isPersonExist(PersonID))
                    {
                        ctrlPersonCard1.LoadPersonInfo(Convert.ToInt32(txtSearch.Text));
                        _PersonID = ctrlPersonCard1.PersonID;
                        gpSelectPerson.Enabled = false;
                        return;
                    }
                }
            } 
            else if (cbSelectBy.SelectedIndex == 2)
            {

                if (clsPerson.isPersonExist(txtSearch.Text))
                {
                    ctrlPersonCard1.LoadPersonInfo(txtSearch.Text);
                    _PersonID = ctrlPersonCard1.PersonID;
                    gpSelectPerson.Enabled = false;
                    return;
                }
            }
            MessageBox.Show("There is No Person With This Data.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            gpSelectPerson.Enabled = true;
            return;
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            ctrlPersonCard1.LoadPersonInfo(Convert.ToInt32(frm.Tag));
            _PersonID = Convert.ToInt32(frm.Tag);
            if(_PersonID != 0)
                gpSelectPerson.Enabled = false;
        }
        private void cbVaccineTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVaccineTypes.SelectedItem.ToString() == "")
            {
                return;
            }
            clsVaccineType _VaccineType = new clsVaccineType();
            _VaccineType = clsVaccineType.Find(cbVaccineTypes.SelectedItem.ToString());
            lblResponPrice.Text = "$" + _VaccineType.TypeFees.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsVaccineType _VaccineType = new clsVaccineType();
            _VaccineType = clsVaccineType.Find(cbVaccineTypes.SelectedItem.ToString());

            _Patient.PersonID = _PersonID;
            _Patient.VaccineTypeID = _VaccineType.ID;
            _Patient.IssueDate = dtCalender.Value;
            _Patient.Notes = txtNotes.Text;


            if (_Patient.Save())
            {
                if (MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    _ResetForm();
                }
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
