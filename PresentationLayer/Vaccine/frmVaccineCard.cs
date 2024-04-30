using BusinessLayer;
using DevExpress.DirectX.Common.Direct2D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Vaccine
{
    public partial class frmVaccineCard : Form
    {
        int _PaitentID = -1;
        clsPatient _Patient;
        public frmVaccineCard(int PaitentID)
        {
            InitializeComponent();
            _PaitentID = PaitentID;
        }
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

        //------------Start Methods For Print Vaccine Card--------------
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(printPreviewDialogVaccine.ShowDialog() == DialogResult.OK)
            {
                printDocumentVaccine.Print();
            }
        }
        private void printDocumentVaccine_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int DocWidth = this.pnContiner.Width, DocHeight = this.pnContiner.Height;

            Bitmap bmp = new Bitmap(DocWidth, DocHeight);

            Rectangle Rec = new Rectangle(0, 0, bmp.Width,bmp.Height);

            this.pnContiner.DrawToBitmap(bmp, Rec);

            e.Graphics.DrawImage(bmp, Rec);
        }
        //------------End Methods For Print Vaccine Card--------------
        private void frmVaccineCard_Load(object sender, EventArgs e)
        {
            //Set Default Paper Size For Printing
            printDocumentVaccine.DefaultPageSettings.PaperSize = new PaperSize("Vaccine Card", this.pnContiner.Width, this.pnContiner.Height);
            _Patient = clsPatient.FindByPatientID(_PaitentID);
            ctrlPersonCard1.LoadPersonInfo(_Patient.PersonID);
            lblResponIssueDate.Text = _Patient.IssueDate.ToShortDateString(); 
            lblResponNotes.Text = _Patient.Notes;


            clsVaccineType _Vaccine = clsVaccineType.Find(_Patient.VaccineTypeID);
            lblResponVaccineName.Text = _Vaccine.VaccineName;
            lblResponPrice.Text = "$" + _Vaccine.TypeFees.ToString();

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
