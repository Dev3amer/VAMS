namespace PresentationLayer.VaccineTypes
{
    partial class frmAddEditVaccineType
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditVaccineType));
            this.lblVaccineName = new System.Windows.Forms.Label();
            this.pnTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iconClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtVaccineName = new System.Windows.Forms.TextBox();
            this.lblVaccineDescription = new System.Windows.Forms.Label();
            this.txtVaccineDescription = new System.Windows.Forms.RichTextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblMinimumAllowedAge = new System.Windows.Forms.Label();
            this.txtMinimumAllowedAge = new System.Windows.Forms.TextBox();
            this.lblTypeFees = new System.Windows.Forms.Label();
            this.txtTypeFees = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResponVaccineID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pnTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVaccineName
            // 
            this.lblVaccineName.AutoSize = true;
            this.lblVaccineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblVaccineName.Location = new System.Drawing.Point(78, 179);
            this.lblVaccineName.Name = "lblVaccineName";
            this.lblVaccineName.Size = new System.Drawing.Size(131, 22);
            this.lblVaccineName.TabIndex = 1;
            this.lblVaccineName.Text = "Vaccine Name:";
            // 
            // pnTopBar
            // 
            this.pnTopBar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnTopBar.Controls.Add(this.lblTitle);
            this.pnTopBar.Controls.Add(this.iconClose);
            this.pnTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnTopBar.Name = "pnTopBar";
            this.pnTopBar.Size = new System.Drawing.Size(558, 38);
            this.pnTopBar.TabIndex = 116;
            this.pnTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTopBar_MouseDown);
            this.pnTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopBar_MouseMove);
            this.pnTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTopBar_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblTitle.Location = new System.Drawing.Point(3, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Add Vaccine Type";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.ImageOptions.Image")));
            this.iconClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.iconClose.Location = new System.Drawing.Point(516, 0);
            this.iconClose.Name = "iconClose";
            this.iconClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.iconClose.Size = new System.Drawing.Size(42, 38);
            this.iconClose.TabIndex = 3;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // txtVaccineName
            // 
            this.txtVaccineName.Location = new System.Drawing.Point(215, 179);
            this.txtVaccineName.Name = "txtVaccineName";
            this.txtVaccineName.Size = new System.Drawing.Size(299, 24);
            this.txtVaccineName.TabIndex = 2;
            this.txtVaccineName.Validating += new System.ComponentModel.CancelEventHandler(this.txtVaccineName_Validating);
            // 
            // lblVaccineDescription
            // 
            this.lblVaccineDescription.AutoSize = true;
            this.lblVaccineDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblVaccineDescription.Location = new System.Drawing.Point(35, 228);
            this.lblVaccineDescription.Name = "lblVaccineDescription";
            this.lblVaccineDescription.Size = new System.Drawing.Size(174, 22);
            this.lblVaccineDescription.TabIndex = 118;
            this.lblVaccineDescription.Text = "Vaccine Description:";
            // 
            // txtVaccineDescription
            // 
            this.txtVaccineDescription.Location = new System.Drawing.Point(215, 232);
            this.txtVaccineDescription.Name = "txtVaccineDescription";
            this.txtVaccineDescription.Size = new System.Drawing.Size(299, 108);
            this.txtVaccineDescription.TabIndex = 3;
            this.txtVaccineDescription.Text = "";
            this.txtVaccineDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtVaccineDescription_Validating);
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeader.Location = new System.Drawing.Point(0, 57);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(558, 48);
            this.lblHeader.TabIndex = 120;
            this.lblHeader.Text = "Add Vaccine Type";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinimumAllowedAge
            // 
            this.lblMinimumAllowedAge.AutoSize = true;
            this.lblMinimumAllowedAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblMinimumAllowedAge.Location = new System.Drawing.Point(19, 368);
            this.lblMinimumAllowedAge.Name = "lblMinimumAllowedAge";
            this.lblMinimumAllowedAge.Size = new System.Drawing.Size(190, 22);
            this.lblMinimumAllowedAge.TabIndex = 121;
            this.lblMinimumAllowedAge.Text = "Minimum Allowed Age:";
            // 
            // txtMinimumAllowedAge
            // 
            this.txtMinimumAllowedAge.Location = new System.Drawing.Point(215, 370);
            this.txtMinimumAllowedAge.Name = "txtMinimumAllowedAge";
            this.txtMinimumAllowedAge.Size = new System.Drawing.Size(299, 24);
            this.txtMinimumAllowedAge.TabIndex = 4;
            this.txtMinimumAllowedAge.Validating += new System.ComponentModel.CancelEventHandler(this.txtMinimumAllowedAge_Validating);
            // 
            // lblTypeFees
            // 
            this.lblTypeFees.AutoSize = true;
            this.lblTypeFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblTypeFees.Location = new System.Drawing.Point(108, 414);
            this.lblTypeFees.Name = "lblTypeFees";
            this.lblTypeFees.Size = new System.Drawing.Size(101, 22);
            this.lblTypeFees.TabIndex = 123;
            this.lblTypeFees.Text = "Type Fees:";
            // 
            // txtTypeFees
            // 
            this.txtTypeFees.Location = new System.Drawing.Point(215, 414);
            this.txtTypeFees.Name = "txtTypeFees";
            this.txtTypeFees.Size = new System.Drawing.Size(299, 24);
            this.txtTypeFees.TabIndex = 5;
            this.txtTypeFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtTypeFees_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(62, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 125;
            this.label2.Text = "Vaccine Type ID:";
            // 
            // lblResponVaccineID
            // 
            this.lblResponVaccineID.AutoSize = true;
            this.lblResponVaccineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblResponVaccineID.Location = new System.Drawing.Point(211, 130);
            this.lblResponVaccineID.Name = "lblResponVaccineID";
            this.lblResponVaccineID.Size = new System.Drawing.Size(40, 22);
            this.lblResponVaccineID.TabIndex = 126;
            this.lblResponVaccineID.Text = "N/A";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(141, 464);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 34);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Image = global::PresentationLayer.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(285, 464);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(0, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(10, 10);
            this.simpleButton1.TabIndex = 1;
            // 
            // frmAddEditVaccineType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 512);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblResponVaccineID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTypeFees);
            this.Controls.Add(this.lblTypeFees);
            this.Controls.Add(this.txtMinimumAllowedAge);
            this.Controls.Add(this.lblMinimumAllowedAge);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txtVaccineDescription);
            this.Controls.Add(this.lblVaccineDescription);
            this.Controls.Add(this.txtVaccineName);
            this.Controls.Add(this.pnTopBar);
            this.Controls.Add(this.lblVaccineName);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditVaccineType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditVaccineType";
            this.pnTopBar.ResumeLayout(false);
            this.pnTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVaccineName;
        private System.Windows.Forms.Panel pnTopBar;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraEditors.SimpleButton iconClose;
        private System.Windows.Forms.TextBox txtVaccineName;
        private System.Windows.Forms.Label lblVaccineDescription;
        private System.Windows.Forms.RichTextBox txtVaccineDescription;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblMinimumAllowedAge;
        private System.Windows.Forms.TextBox txtMinimumAllowedAge;
        private System.Windows.Forms.Label lblTypeFees;
        private System.Windows.Forms.TextBox txtTypeFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResponVaccineID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}