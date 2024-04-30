namespace PresentationLayer.Vaccine
{
    partial class frmListVaccineTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListVaccineTypes));
            this.dgvVaccineTypes = new System.Windows.Forms.DataGridView();
            this.cmsVacciens = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnTopBar = new System.Windows.Forms.Panel();
            this.iconClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddVaccineType = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbVaccineTypeImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccineTypes)).BeginInit();
            this.cmsVacciens.SuspendLayout();
            this.pnTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVaccineTypeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVaccineTypes
            // 
            this.dgvVaccineTypes.AllowUserToAddRows = false;
            this.dgvVaccineTypes.AllowUserToDeleteRows = false;
            this.dgvVaccineTypes.AllowUserToResizeRows = false;
            this.dgvVaccineTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvVaccineTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaccineTypes.ContextMenuStrip = this.cmsVacciens;
            this.dgvVaccineTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVaccineTypes.Location = new System.Drawing.Point(14, 343);
            this.dgvVaccineTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVaccineTypes.MultiSelect = false;
            this.dgvVaccineTypes.Name = "dgvVaccineTypes";
            this.dgvVaccineTypes.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVaccineTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVaccineTypes.RowHeadersWidth = 51;
            this.dgvVaccineTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVaccineTypes.Size = new System.Drawing.Size(813, 312);
            this.dgvVaccineTypes.TabIndex = 141;
            this.dgvVaccineTypes.TabStop = false;
            // 
            // cmsVacciens
            // 
            this.cmsVacciens.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsVacciens.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsVacciens.Name = "contextMenuStrip1";
            this.cmsVacciens.Size = new System.Drawing.Size(171, 80);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(170, 38);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(170, 38);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(122, 668);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(26, 21);
            this.lblRecordsCount.TabIndex = 146;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 666);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 145;
            this.label2.Text = "# Records:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "ID",
            "Description",
            "Minimum Age",
            "Fees"});
            this.cbFilterBy.Location = new System.Drawing.Point(116, 309);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(210, 24);
            this.cbFilterBy.TabIndex = 1;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(333, 309);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(256, 24);
            this.txtFilterValue.TabIndex = 2;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 142;
            this.label1.Text = "Filter By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vaccine Management";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 231);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(838, 53);
            this.lblTitle.TabIndex = 148;
            this.lblTitle.Text = "Manage Vaccine Types";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTopBar
            // 
            this.pnTopBar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnTopBar.Controls.Add(this.label3);
            this.pnTopBar.Controls.Add(this.iconClose);
            this.pnTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnTopBar.Name = "pnTopBar";
            this.pnTopBar.Size = new System.Drawing.Size(840, 38);
            this.pnTopBar.TabIndex = 140;
            this.pnTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTopBar_MouseDown);
            this.pnTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopBar_MouseMove);
            this.pnTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTopBar_MouseUp);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.ImageOptions.Image")));
            this.iconClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.iconClose.Location = new System.Drawing.Point(798, 0);
            this.iconClose.Name = "iconClose";
            this.iconClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.iconClose.Size = new System.Drawing.Size(42, 38);
            this.iconClose.TabIndex = 3;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // btnAddVaccineType
            // 
            this.btnAddVaccineType.Image = global::PresentationLayer.Properties.Resources.Addvaccine;
            this.btnAddVaccineType.Location = new System.Drawing.Point(779, 300);
            this.btnAddVaccineType.Name = "btnAddVaccineType";
            this.btnAddVaccineType.Size = new System.Drawing.Size(48, 38);
            this.btnAddVaccineType.TabIndex = 3;
            this.btnAddVaccineType.UseVisualStyleBackColor = true;
            this.btnAddVaccineType.Click += new System.EventHandler(this.btnAddVaccineType_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(699, 663);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbVaccineTypeImage
            // 
            this.pbVaccineTypeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbVaccineTypeImage.Image = global::PresentationLayer.Properties.Resources.vaccines;
            this.pbVaccineTypeImage.InitialImage = null;
            this.pbVaccineTypeImage.Location = new System.Drawing.Point(307, 46);
            this.pbVaccineTypeImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbVaccineTypeImage.Name = "pbVaccineTypeImage";
            this.pbVaccineTypeImage.Size = new System.Drawing.Size(220, 180);
            this.pbVaccineTypeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVaccineTypeImage.TabIndex = 147;
            this.pbVaccineTypeImage.TabStop = false;
            // 
            // frmListVaccineTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 707);
            this.Controls.Add(this.btnAddVaccineType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvVaccineTypes);
            this.Controls.Add(this.pbVaccineTypeImage);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListVaccineTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVaccineTypes";
            this.Load += new System.EventHandler(this.frmVaccineTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccineTypes)).EndInit();
            this.cmsVacciens.ResumeLayout(false);
            this.pnTopBar.ResumeLayout(false);
            this.pnTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVaccineTypeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddVaccineType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvVaccineTypes;
        private System.Windows.Forms.ContextMenuStrip cmsVacciens;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbVaccineTypeImage;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton iconClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnTopBar;
    }
}