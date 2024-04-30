namespace PresentationLayer.Vaccine
{
    partial class frmNewEditVaccineOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewEditVaccineOrder));
            this.pnTopBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iconClose = new DevExpress.XtraEditors.SimpleButton();
            this.gpSelectPerson = new System.Windows.Forms.GroupBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbSelectBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResponPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.dtCalender = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.cbVaccineTypes = new System.Windows.Forms.ComboBox();
            this.lblVaccineName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlPersonCard1 = new PresentationLayer.People.Controls.ctrlPersonCard();
            this.pnTopBar.SuspendLayout();
            this.gpSelectPerson.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTopBar
            // 
            this.pnTopBar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnTopBar.Controls.Add(this.lblTitle);
            this.pnTopBar.Controls.Add(this.iconClose);
            this.pnTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnTopBar.Name = "pnTopBar";
            this.pnTopBar.Size = new System.Drawing.Size(1000, 38);
            this.pnTopBar.TabIndex = 115;
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
            this.lblTitle.Size = new System.Drawing.Size(157, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Vaccine Order";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.ImageOptions.Image")));
            this.iconClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.iconClose.Location = new System.Drawing.Point(958, 0);
            this.iconClose.Name = "iconClose";
            this.iconClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.iconClose.Size = new System.Drawing.Size(42, 38);
            this.iconClose.TabIndex = 3;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // gpSelectPerson
            // 
            this.gpSelectPerson.Controls.Add(this.btnAddPerson);
            this.gpSelectPerson.Controls.Add(this.btnFind);
            this.gpSelectPerson.Controls.Add(this.txtSearch);
            this.gpSelectPerson.Controls.Add(this.cbSelectBy);
            this.gpSelectPerson.Controls.Add(this.label1);
            this.gpSelectPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSelectPerson.Location = new System.Drawing.Point(23, 44);
            this.gpSelectPerson.Name = "gpSelectPerson";
            this.gpSelectPerson.Size = new System.Drawing.Size(950, 100);
            this.gpSelectPerson.TabIndex = 117;
            this.gpSelectPerson.TabStop = false;
            this.gpSelectPerson.Text = "Select Person";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = global::PresentationLayer.Properties.Resources.AddPerson_32;
            this.btnAddPerson.Location = new System.Drawing.Point(584, 31);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(48, 40);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = global::PresentationLayer.Properties.Resources.SearchPerson;
            this.btnFind.Location = new System.Drawing.Point(530, 30);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(48, 40);
            this.btnFind.TabIndex = 3;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(325, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 28);
            this.txtSearch.TabIndex = 2;
            // 
            // cbSelectBy
            // 
            this.cbSelectBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectBy.FormattingEnabled = true;
            this.cbSelectBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No"});
            this.cbSelectBy.Location = new System.Drawing.Point(131, 36);
            this.cbSelectBy.Name = "cbSelectBy";
            this.cbSelectBy.Size = new System.Drawing.Size(188, 30);
            this.cbSelectBy.TabIndex = 1;
            this.cbSelectBy.SelectedIndexChanged += new System.EventHandler(this.cbSelectBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select By:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResponPrice);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.lblNotes);
            this.groupBox1.Controls.Add(this.dtCalender);
            this.groupBox1.Controls.Add(this.lblIssueDate);
            this.groupBox1.Controls.Add(this.cbVaccineTypes);
            this.groupBox1.Controls.Add(this.lblVaccineName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.groupBox1.Location = new System.Drawing.Point(23, 506);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 165);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vaccine Information";
            // 
            // lblResponPrice
            // 
            this.lblResponPrice.AutoSize = true;
            this.lblResponPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResponPrice.Location = new System.Drawing.Point(170, 79);
            this.lblResponPrice.Name = "lblResponPrice";
            this.lblResponPrice.Size = new System.Drawing.Size(55, 22);
            this.lblResponPrice.TabIndex = 7;
            this.lblResponPrice.Text = "$00.0";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(108, 79);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 22);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(508, 27);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(417, 119);
            this.txtNotes.TabIndex = 5;
            this.txtNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(440, 34);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(62, 22);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notes:";
            // 
            // dtCalender
            // 
            this.dtCalender.Location = new System.Drawing.Point(165, 120);
            this.dtCalender.Name = "dtCalender";
            this.dtCalender.Size = new System.Drawing.Size(200, 28);
            this.dtCalender.TabIndex = 3;
            this.dtCalender.ValueChanged += new System.EventHandler(this.dtCalender_ValueChanged);
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(59, 124);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(100, 22);
            this.lblIssueDate.TabIndex = 2;
            this.lblIssueDate.Text = "Issue Date:";
            // 
            // cbVaccineTypes
            // 
            this.cbVaccineTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVaccineTypes.FormattingEnabled = true;
            this.cbVaccineTypes.Location = new System.Drawing.Point(165, 30);
            this.cbVaccineTypes.Name = "cbVaccineTypes";
            this.cbVaccineTypes.Size = new System.Drawing.Size(197, 30);
            this.cbVaccineTypes.TabIndex = 1;
            this.cbVaccineTypes.SelectedIndexChanged += new System.EventHandler(this.cbVaccineTypes_SelectedIndexChanged);
            // 
            // lblVaccineName
            // 
            this.lblVaccineName.AutoSize = true;
            this.lblVaccineName.Location = new System.Drawing.Point(33, 34);
            this.lblVaccineName.Name = "lblVaccineName";
            this.lblVaccineName.Size = new System.Drawing.Size(131, 22);
            this.lblVaccineName.TabIndex = 0;
            this.lblVaccineName.Text = "Vaccine Name:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(348, 713);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 46);
            this.btnClose.TabIndex = 120;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Image = global::PresentationLayer.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(492, 713);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 46);
            this.btnSave.TabIndex = 119;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ctrlPersonCard1.Location = new System.Drawing.Point(8, 152);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(992, 331);
            this.ctrlPersonCard1.TabIndex = 116;
            // 
            // frmNewEditVaccineOrder
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 773);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpSelectPerson);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.pnTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewEditVaccineOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewVaccineOrder";
            this.Load += new System.EventHandler(this.frmNewVaccineOrder_Load);
            this.pnTopBar.ResumeLayout(false);
            this.pnTopBar.PerformLayout();
            this.gpSelectPerson.ResumeLayout(false);
            this.gpSelectPerson.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTopBar;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraEditors.SimpleButton iconClose;
        private People.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.GroupBox gpSelectPerson;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSelectBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.DateTimePicker dtCalender;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.ComboBox cbVaccineTypes;
        private System.Windows.Forms.Label lblVaccineName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblResponPrice;
        private System.Windows.Forms.Label lblPrice;
    }
}