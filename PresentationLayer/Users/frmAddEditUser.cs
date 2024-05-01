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
using static DevExpress.XtraEditors.Mask.MaskSettings;
using static PresentationLayer.People.frmAddUpdatePerson;

namespace PresentationLayer.Users
{
    public partial class frmAddEditUser : Form
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
        
        enum enMode {Add=0 ,Edit=1};
        enMode _Mode;

        clsUser _User = new clsUser();
        private int _UserID = -1;
        int _Permissions = 0;
        public frmAddEditUser()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.Edit;
            _UserID = UserID;
        }
        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();
                
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";
            }
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = true;
            rbYes.Checked = true;
        }
        private void _LoadData()
        {
            _User = clsUser.FindByUserID(_UserID);
            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }
            //the following code will not be executed if the person was not found
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;

            if(_User.Permissions == Convert.ToInt16(clsUser.enPermissions.All))
            {
                rbYes.Checked = true;
                gpPerrmissions.Enabled = false;
            }
            else
            {
                rbNo.Checked = true;

                if((Convert.ToInt16(clsUser.enPermissions.ManagePeople) & _User.Permissions) == Convert.ToInt16(clsUser.enPermissions.ManagePeople))
                    chkPeopleManagement.Checked= true;

                if ((Convert.ToInt16(clsUser.enPermissions.ManageUsers) & _User.Permissions) == Convert.ToInt16(clsUser.enPermissions.ManageUsers))
                    chkUsersManagement.Checked = true;

                if ((Convert.ToInt16(clsUser.enPermissions.ManagePatient) & _User.Permissions) == Convert.ToInt16(clsUser.enPermissions.ManagePatient))
                    chkPatientManagement.Checked = true;

                if ((Convert.ToInt16(clsUser.enPermissions.ManageApplication) & _User.Permissions) == Convert.ToInt16(clsUser.enPermissions.ManageApplication))
                    chkApplicationManagement.Checked = true;
            }
        }
        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Edit)
                _LoadData();
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            };
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            };

            //incase update make sure not to use anothers user name
            if (_User.UserName != txtUserName.Text.Trim())
            {
                if (clsUser.isUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                };
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            };
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            gpPerrmissions.Enabled = !rbYes.Checked;
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

            _User.UserName = txtUserName.Text.Trim().ToString();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = chkIsActive.Checked;
            if(rbYes.Checked)
                _Permissions += Convert.ToInt32(clsUser.enPermissions.All);
            else
            {
                if(chkPeopleManagement.Checked)
                    _Permissions += Convert.ToInt32(clsUser.enPermissions.ManagePeople);
                
                if(chkPatientManagement.Checked)
                    _Permissions += Convert.ToInt32(clsUser.enPermissions.ManagePatient);

                if (chkApplicationManagement.Checked)
                    _Permissions += Convert.ToInt32(clsUser.enPermissions.ManageApplication);

                if (chkUsersManagement.Checked)
                    _Permissions += Convert.ToInt32(clsUser.enPermissions.ManageUsers);
            }

            _User.Permissions = _Permissions;

            if (_User.Save())
            {
                if (MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
