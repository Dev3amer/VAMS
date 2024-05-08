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

namespace PresentationLayer.VaccineTypes
{
    public partial class frmAddEditVaccineType : Form
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
        enum enMode { Add = 0, Edit = 1 };
        enMode _Mode;

        int _VaccineTypeID = -1;
        clsVaccineType _VaccineType = new clsVaccineType();
        public frmAddEditVaccineType()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public frmAddEditVaccineType(int VaccineTypeID)
        {
            InitializeComponent();
            _VaccineTypeID = VaccineTypeID;
            _Mode = enMode.Edit;
            lblTitle.Text = "Edit Vaccine Type";
            lblHeader.Text = "Edit Vaccine Type";
            lblResponVaccineID.Text = _VaccineTypeID.ToString();
            _VaccineType = clsVaccineType.Find(_VaccineTypeID);
            txtVaccineName.Text = _VaccineType.VaccineName;
            txtVaccineDescription.Text = _VaccineType.VaccineDescription;
            txtMinimumAllowedAge.Text = _VaccineType.MinimumAllowedAge.ToString();
            txtTypeFees.Text = _VaccineType.TypeFees.ToString();
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
            _VaccineType.VaccineName = txtVaccineName.Text;
            _VaccineType.VaccineDescription = txtVaccineDescription.Text;
            _VaccineType.MinimumAllowedAge = Convert.ToInt32(txtMinimumAllowedAge.Text);
            _VaccineType.TypeFees = Convert.ToSingle(txtTypeFees.Text);

            if (_VaccineType.Save())
            {
                if (MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVaccineName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVaccineName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtVaccineName, "Vaccine Name cannot be blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtVaccineName, null);
            };
        }

        private void txtVaccineDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVaccineDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtVaccineDescription, "Vaccine Description Name cannot be blank");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(txtVaccineDescription, null);
            };
        }

        private void txtMinimumAllowedAge_Validating(object sender, CancelEventArgs e)
        {
            if (!(Int32.TryParse(txtMinimumAllowedAge.Text.Trim(),out int res)))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMinimumAllowedAge, "Age cannot be blank or String");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMinimumAllowedAge, null);
            };
        }

        private void txtTypeFees_Validating(object sender, CancelEventArgs e)
        {
            if (!(Int32.TryParse(txtTypeFees.Text.Trim(), out int res)))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTypeFees, "Fees cannot be blank or String");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTypeFees, null);
            };
        }
    }
}
