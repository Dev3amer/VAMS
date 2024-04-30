namespace PresentationLayer.Vaccine
{
    partial class frmVaccineCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVaccineCard));
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.iconClose = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pnTopBar = new System.Windows.Forms.Panel();
            this.pnContiner = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblResponPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResponIssueDate = new System.Windows.Forms.Label();
            this.lblResponNotes = new System.Windows.Forms.Label();
            this.lblResponVaccineName = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblVaccineName = new System.Windows.Forms.Label();
            this.printDocumentVaccine = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogVaccine = new System.Windows.Forms.PrintPreviewDialog();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlPersonCard1 = new PresentationLayer.People.Controls.ctrlPersonCard();
            this.pnTopBar.SuspendLayout();
            this.pnContiner.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(868, 631);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 38);
            this.btnPrint.TabIndex = 141;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.ImageOptions.Image")));
            this.iconClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.iconClose.Location = new System.Drawing.Point(938, 0);
            this.iconClose.Name = "iconClose";
            this.iconClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.iconClose.Size = new System.Drawing.Size(42, 38);
            this.iconClose.TabIndex = 3;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vaccine Card";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTopBar
            // 
            this.pnTopBar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnTopBar.Controls.Add(this.label3);
            this.pnTopBar.Controls.Add(this.iconClose);
            this.pnTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnTopBar.Name = "pnTopBar";
            this.pnTopBar.Size = new System.Drawing.Size(980, 38);
            this.pnTopBar.TabIndex = 139;
            this.pnTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTopBar_MouseDown);
            this.pnTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopBar_MouseMove);
            this.pnTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTopBar_MouseUp);
            // 
            // pnContiner
            // 
            this.pnContiner.Controls.Add(this.lblTitle);
            this.pnContiner.Controls.Add(this.groupBox1);
            this.pnContiner.Controls.Add(this.ctrlPersonCard1);
            this.pnContiner.Location = new System.Drawing.Point(0, 44);
            this.pnContiner.Name = "pnContiner";
            this.pnContiner.Size = new System.Drawing.Size(980, 581);
            this.pnContiner.TabIndex = 142;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(980, 53);
            this.lblTitle.TabIndex = 142;
            this.lblTitle.Text = "Vaccine Card";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResponPrice
            // 
            this.lblResponPrice.AutoSize = true;
            this.lblResponPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResponPrice.Location = new System.Drawing.Point(173, 79);
            this.lblResponPrice.Name = "lblResponPrice";
            this.lblResponPrice.Size = new System.Drawing.Size(55, 22);
            this.lblResponPrice.TabIndex = 7;
            this.lblResponPrice.Text = "$00.0";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(108, 79);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 22);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResponIssueDate);
            this.groupBox1.Controls.Add(this.lblResponNotes);
            this.groupBox1.Controls.Add(this.lblResponVaccineName);
            this.groupBox1.Controls.Add(this.lblResponPrice);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblNotes);
            this.groupBox1.Controls.Add(this.lblIssueDate);
            this.groupBox1.Controls.Add(this.lblVaccineName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.groupBox1.Location = new System.Drawing.Point(12, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 160);
            this.groupBox1.TabIndex = 143;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vaccine Information";
            // 
            // lblResponIssueDate
            // 
            this.lblResponIssueDate.AutoSize = true;
            this.lblResponIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponIssueDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResponIssueDate.Location = new System.Drawing.Point(173, 124);
            this.lblResponIssueDate.Name = "lblResponIssueDate";
            this.lblResponIssueDate.Size = new System.Drawing.Size(82, 22);
            this.lblResponIssueDate.TabIndex = 10;
            this.lblResponIssueDate.Text = "00-00-00";
            // 
            // lblResponNotes
            // 
            this.lblResponNotes.AutoSize = true;
            this.lblResponNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponNotes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResponNotes.Location = new System.Drawing.Point(505, 34);
            this.lblResponNotes.Name = "lblResponNotes";
            this.lblResponNotes.Size = new System.Drawing.Size(40, 22);
            this.lblResponNotes.TabIndex = 9;
            this.lblResponNotes.Text = "N/A";
            // 
            // lblResponVaccineName
            // 
            this.lblResponVaccineName.AutoSize = true;
            this.lblResponVaccineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponVaccineName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResponVaccineName.Location = new System.Drawing.Point(173, 34);
            this.lblResponVaccineName.Name = "lblResponVaccineName";
            this.lblResponVaccineName.Size = new System.Drawing.Size(126, 22);
            this.lblResponVaccineName.TabIndex = 8;
            this.lblResponVaccineName.Text = "Vaccine Name";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(440, 34);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(68, 22);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notes:";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.Location = new System.Drawing.Point(64, 124);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(111, 22);
            this.lblIssueDate.TabIndex = 2;
            this.lblIssueDate.Text = "Issue Date:";
            // 
            // lblVaccineName
            // 
            this.lblVaccineName.AutoSize = true;
            this.lblVaccineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaccineName.Location = new System.Drawing.Point(33, 34);
            this.lblVaccineName.Name = "lblVaccineName";
            this.lblVaccineName.Size = new System.Drawing.Size(144, 22);
            this.lblVaccineName.TabIndex = 0;
            this.lblVaccineName.Text = "Vaccine Name:";
            // 
            // printDocumentVaccine
            // 
            this.printDocumentVaccine.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentVaccine_PrintPage_1);
            // 
            // printPreviewDialogVaccine
            // 
            this.printPreviewDialogVaccine.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogVaccine.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogVaccine.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogVaccine.Document = this.printDocumentVaccine;
            this.printPreviewDialogVaccine.Enabled = true;
            this.printPreviewDialogVaccine.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogVaccine.Icon")));
            this.printPreviewDialogVaccine.Name = "printPreviewDialogVaccine";
            this.printPreviewDialogVaccine.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = global::PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(764, 631);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 38);
            this.btnClose.TabIndex = 143;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ctrlPersonCard1.Location = new System.Drawing.Point(1, 63);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(965, 335);
            this.ctrlPersonCard1.TabIndex = 141;
            // 
            // frmVaccineCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 681);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnContiner);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVaccineCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVaccineCard";
            this.Load += new System.EventHandler(this.frmVaccineCard_Load);
            this.pnTopBar.ResumeLayout(false);
            this.pnTopBar.PerformLayout();
            this.pnContiner.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton iconClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnTopBar;
        private System.Windows.Forms.Panel pnContiner;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResponIssueDate;
        private System.Windows.Forms.Label lblResponNotes;
        private System.Windows.Forms.Label lblResponVaccineName;
        private System.Windows.Forms.Label lblResponPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblVaccineName;
        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Drawing.Printing.PrintDocument printDocumentVaccine;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogVaccine;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}