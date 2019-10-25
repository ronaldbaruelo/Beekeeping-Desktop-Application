namespace ITProject2
{
    partial class frmSite
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.siteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mafIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longtitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtSiteID = new MetroFramework.Controls.MetroTextBox();
            this.txtSiteMaf = new MetroFramework.Controls.MetroTextBox();
            this.txtSiteLast = new MetroFramework.Controls.MetroTextBox();
            this.txtSiteFirst = new MetroFramework.Controls.MetroTextBox();
            this.txtSiteaddress = new MetroFramework.Controls.MetroTextBox();
            this.txtSitephone = new MetroFramework.Controls.MetroTextBox();
            this.txtSitename = new MetroFramework.Controls.MetroTextBox();
            this.txtSiteLatitude = new MetroFramework.Controls.MetroTextBox();
            this.txtSiteLongtitude = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtSiteSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteTableBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(625, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Site ID:";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siteIDDataGridViewTextBoxColumn,
            this.mafIDDataGridViewTextBoxColumn,
            this.sitenameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.latitudeDataGridViewTextBoxColumn,
            this.longtitudeDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.siteTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(37, 434);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(942, 150);
            this.metroGrid1.TabIndex = 14;
            this.metroGrid1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroGrid1_KeyDown);
            // 
            // siteIDDataGridViewTextBoxColumn
            // 
            this.siteIDDataGridViewTextBoxColumn.DataPropertyName = "SiteID";
            this.siteIDDataGridViewTextBoxColumn.HeaderText = "SiteID";
            this.siteIDDataGridViewTextBoxColumn.Name = "siteIDDataGridViewTextBoxColumn";
            // 
            // mafIDDataGridViewTextBoxColumn
            // 
            this.mafIDDataGridViewTextBoxColumn.DataPropertyName = "MafID";
            this.mafIDDataGridViewTextBoxColumn.HeaderText = "MafID";
            this.mafIDDataGridViewTextBoxColumn.Name = "mafIDDataGridViewTextBoxColumn";
            // 
            // sitenameDataGridViewTextBoxColumn
            // 
            this.sitenameDataGridViewTextBoxColumn.DataPropertyName = "Sitename";
            this.sitenameDataGridViewTextBoxColumn.HeaderText = "Sitename";
            this.sitenameDataGridViewTextBoxColumn.Name = "sitenameDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // latitudeDataGridViewTextBoxColumn
            // 
            this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.HeaderText = "Latitude";
            this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
            // 
            // longtitudeDataGridViewTextBoxColumn
            // 
            this.longtitudeDataGridViewTextBoxColumn.DataPropertyName = "Longtitude";
            this.longtitudeDataGridViewTextBoxColumn.HeaderText = "Longtitude";
            this.longtitudeDataGridViewTextBoxColumn.Name = "longtitudeDataGridViewTextBoxColumn";
            // 
            // siteTableBindingSource
            // 
            this.siteTableBindingSource.DataSource = typeof(ITProject2.SiteTable);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(663, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(744, 330);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "&EDIT";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(825, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "&DELETE";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(906, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "&CLOSE";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(803, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "MAF ID:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(608, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Sitename:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(37, 162);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Firstname:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(355, 162);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Lastname:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(351, 247);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Latitude:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(37, 214);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Address:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(724, 162);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(49, 19);
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = "Phone:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(699, 243);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(74, 19);
            this.metroLabel10.TabIndex = 15;
            this.metroLabel10.Text = "Longtitude:";
            // 
            // txtSiteID
            // 
            // 
            // 
            // 
            this.txtSiteID.CustomButton.Image = null;
            this.txtSiteID.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtSiteID.CustomButton.Name = "";
            this.txtSiteID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSiteID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSiteID.CustomButton.TabIndex = 1;
            this.txtSiteID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSiteID.CustomButton.UseSelectable = true;
            this.txtSiteID.CustomButton.Visible = false;
            this.txtSiteID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteTableBindingSource, "SiteID", true));
            this.txtSiteID.Lines = new string[0];
            this.txtSiteID.Location = new System.Drawing.Point(680, 59);
            this.txtSiteID.MaxLength = 32767;
            this.txtSiteID.Name = "txtSiteID";
            this.txtSiteID.PasswordChar = '\0';
            this.txtSiteID.ReadOnly = true;
            this.txtSiteID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSiteID.SelectedText = "";
            this.txtSiteID.SelectionLength = 0;
            this.txtSiteID.SelectionStart = 0;
            this.txtSiteID.ShortcutsEnabled = true;
            this.txtSiteID.Size = new System.Drawing.Size(114, 23);
            this.txtSiteID.TabIndex = 0;
            this.txtSiteID.UseSelectable = true;
            this.txtSiteID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSiteID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSiteID.Click += new System.EventHandler(this.txtSiteID_Click);
            // 
            // txtSiteMaf
            // 
            // 
            // 
            // 
            this.txtSiteMaf.CustomButton.Image = null;
            this.txtSiteMaf.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtSiteMaf.CustomButton.Name = "";
            this.txtSiteMaf.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSiteMaf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSiteMaf.CustomButton.TabIndex = 1;
            this.txtSiteMaf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSiteMaf.CustomButton.UseSelectable = true;
            this.txtSiteMaf.CustomButton.Visible = false;
            this.txtSiteMaf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteTableBindingSource, "MafID", true));
            this.txtSiteMaf.Lines = new string[0];
            this.txtSiteMaf.Location = new System.Drawing.Point(865, 59);
            this.txtSiteMaf.MaxLength = 32767;
            this.txtSiteMaf.Name = "txtSiteMaf";
            this.txtSiteMaf.PasswordChar = '\0';
            this.txtSiteMaf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSiteMaf.SelectedText = "";
            this.txtSiteMaf.SelectionLength = 0;
            this.txtSiteMaf.SelectionStart = 0;
            this.txtSiteMaf.ShortcutsEnabled = true;
            this.txtSiteMaf.Size = new System.Drawing.Size(114, 23);
            this.txtSiteMaf.TabIndex = 1;
            this.txtSiteMaf.UseSelectable = true;
            this.txtSiteMaf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSiteMaf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSiteLast
            // 
            // 
            // 
            // 
            this.txtSiteLast.CustomButton.Image = null;
            this.txtSiteLast.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.txtSiteLast.CustomButton.Name = "";
            this.txtSiteLast.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSiteLast.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSiteLast.CustomButton.TabIndex = 1;
            this.txtSiteLast.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSiteLast.CustomButton.UseSelectable = true;
            this.txtSiteLast.CustomButton.Visible = false;
            this.txtSiteLast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteTableBindingSource, "Lastname", true));
            this.txtSiteLast.Lines = new string[0];
            this.txtSiteLast.Location = new System.Drawing.Point(436, 162);
            this.txtSiteLast.MaxLength = 32767;
            this.txtSiteLast.Name = "txtSiteLast";
            this.txtSiteLast.PasswordChar = '\0';
            this.txtSiteLast.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSiteLast.SelectedText = "";
            this.txtSiteLast.SelectionLength = 0;
            this.txtSiteLast.SelectionStart = 0;
            this.txtSiteLast.ShortcutsEnabled = true;
            this.txtSiteLast.Size = new System.Drawing.Size(250, 23);
            this.txtSiteLast.TabIndex = 4;
            this.txtSiteLast.UseSelectable = true;
            this.txtSiteLast.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSiteLast.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSiteFirst
            // 
            // 
            // 
            // 
            this.txtSiteFirst.CustomButton.Image = null;
            this.txtSiteFirst.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.txtSiteFirst.CustomButton.Name = "";
            this.txtSiteFirst.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSiteFirst.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSiteFirst.CustomButton.TabIndex = 1;
            this.txtSiteFirst.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSiteFirst.CustomButton.UseSelectable = true;
            this.txtSiteFirst.CustomButton.Visible = false;
            this.txtSiteFirst.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteTableBindingSource, "Firstname", true));
            this.txtSiteFirst.Lines = new string[0];
            this.txtSiteFirst.Location = new System.Drawing.Point(126, 162);
            this.txtSiteFirst.MaxLength = 32767;
            this.txtSiteFirst.Name = "txtSiteFirst";
            this.txtSiteFirst.PasswordChar = '\0';
            this.txtSiteFirst.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSiteFirst.SelectedText = "";
            this.txtSiteFirst.SelectionLength = 0;
            this.txtSiteFirst.SelectionStart = 0;
            this.txtSiteFirst.ShortcutsEnabled = true;
            this.txtSiteFirst.Size = new System.Drawing.Size(185, 23);
            this.txtSiteFirst.TabIndex = 3;
            this.txtSiteFirst.UseSelectable = true;
            this.txtSiteFirst.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSiteFirst.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSiteaddress
            // 
            // 
            // 
            // 
            this.txtSiteaddress.CustomButton.Image = null;
            this.txtSiteaddress.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtSiteaddress.CustomButton.Name = "";
            this.txtSiteaddress.CustomButton.Size = new System.Drawing.Size(63, 63);
            this.txtSiteaddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSiteaddress.CustomButton.TabIndex = 1;
            this.txtSiteaddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSiteaddress.CustomButton.UseSelectable = true;
            this.txtSiteaddress.CustomButton.Visible = false;
            this.txtSiteaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteTableBindingSource, "Address", true));
            this.txtSiteaddress.Lines = new string[0];
            this.txtSiteaddress.Location = new System.Drawing.Point(37, 243);
            this.txtSiteaddress.MaxLength = 32767;
            this.txtSiteaddress.Multiline = true;
            this.txtSiteaddress.Name = "txtSiteaddress";
            this.txtSiteaddress.PasswordChar = '\0';
            this.txtSiteaddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSiteaddress.SelectedText = "";
            this.txtSiteaddress.SelectionLength = 0;
            this.txtSiteaddress.SelectionStart = 0;
            this.txtSiteaddress.ShortcutsEnabled = true;
            this.txtSiteaddress.Size = new System.Drawing.Size(274, 65);
            this.txtSiteaddress.TabIndex = 6;
            this.txtSiteaddress.UseSelectable = true;
            this.txtSiteaddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSiteaddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSitephone
            // 
            // 
            // 
            // 
            this.txtSitephone.CustomButton.Image = null;
            this.txtSitephone.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtSitephone.CustomButton.Name = "";
            this.txtSitephone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSitephone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSitephone.CustomButton.TabIndex = 1;
            this.txtSitephone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSitephone.CustomButton.UseSelectable = true;
            this.txtSitephone.CustomButton.Visible = false;
            this.txtSitephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteTableBindingSource, "Phone", true));
            this.txtSitephone.Lines = new string[0];
            this.txtSitephone.Location = new System.Drawing.Point(788, 158);
            this.txtSitephone.MaxLength = 32767;
            this.txtSitephone.Name = "txtSitephone";
            this.txtSitephone.PasswordChar = '\0';
            this.txtSitephone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSitephone.SelectedText = "";
            this.txtSitephone.SelectionLength = 0;
            this.txtSitephone.SelectionStart = 0;
            this.txtSitephone.ShortcutsEnabled = true;
            this.txtSitephone.Size = new System.Drawing.Size(191, 23);
            this.txtSitephone.TabIndex = 5;
            this.txtSitephone.UseSelectable = true;
            this.txtSitephone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSitephone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSitename
            // 
            // 
            // 
            // 
            this.txtSitename.CustomButton.Image = null;
            this.txtSitename.CustomButton.Location = new System.Drawing.Point(277, 1);
            this.txtSitename.CustomButton.Name = "";
            this.txtSitename.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSitename.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSitename.CustomButton.TabIndex = 1;
            this.txtSitename.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSitename.CustomButton.UseSelectable = true;
            this.txtSitename.CustomButton.Visible = false;
            this.txtSitename.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteTableBindingSource, "Sitename", true));
            this.txtSitename.Lines = new string[0];
            this.txtSitename.Location = new System.Drawing.Point(680, 101);
            this.txtSitename.MaxLength = 32767;
            this.txtSitename.Name = "txtSitename";
            this.txtSitename.PasswordChar = '\0';
            this.txtSitename.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSitename.SelectedText = "";
            this.txtSitename.SelectionLength = 0;
            this.txtSitename.SelectionStart = 0;
            this.txtSitename.ShortcutsEnabled = true;
            this.txtSitename.Size = new System.Drawing.Size(299, 23);
            this.txtSitename.TabIndex = 2;
            this.txtSitename.UseSelectable = true;
            this.txtSitename.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSitename.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSiteLatitude
            // 
            // 
            // 
            // 
            this.txtSiteLatitude.CustomButton.Image = null;
            this.txtSiteLatitude.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.txtSiteLatitude.CustomButton.Name = "";
            this.txtSiteLatitude.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSiteLatitude.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSiteLatitude.CustomButton.TabIndex = 1;
            this.txtSiteLatitude.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSiteLatitude.CustomButton.UseSelectable = true;
            this.txtSiteLatitude.CustomButton.Visible = false;
            this.txtSiteLatitude.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteTableBindingSource, "Latitude", true));
            this.txtSiteLatitude.Lines = new string[0];
            this.txtSiteLatitude.Location = new System.Drawing.Point(436, 239);
            this.txtSiteLatitude.MaxLength = 32767;
            this.txtSiteLatitude.Name = "txtSiteLatitude";
            this.txtSiteLatitude.PasswordChar = '\0';
            this.txtSiteLatitude.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSiteLatitude.SelectedText = "";
            this.txtSiteLatitude.SelectionLength = 0;
            this.txtSiteLatitude.SelectionStart = 0;
            this.txtSiteLatitude.ShortcutsEnabled = true;
            this.txtSiteLatitude.Size = new System.Drawing.Size(250, 23);
            this.txtSiteLatitude.TabIndex = 7;
            this.txtSiteLatitude.UseSelectable = true;
            this.txtSiteLatitude.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSiteLatitude.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSiteLongtitude
            // 
            // 
            // 
            // 
            this.txtSiteLongtitude.CustomButton.Image = null;
            this.txtSiteLongtitude.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtSiteLongtitude.CustomButton.Name = "";
            this.txtSiteLongtitude.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSiteLongtitude.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSiteLongtitude.CustomButton.TabIndex = 1;
            this.txtSiteLongtitude.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSiteLongtitude.CustomButton.UseSelectable = true;
            this.txtSiteLongtitude.CustomButton.Visible = false;
            this.txtSiteLongtitude.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.siteTableBindingSource, "Longtitude", true));
            this.txtSiteLongtitude.Lines = new string[0];
            this.txtSiteLongtitude.Location = new System.Drawing.Point(788, 243);
            this.txtSiteLongtitude.MaxLength = 32767;
            this.txtSiteLongtitude.Name = "txtSiteLongtitude";
            this.txtSiteLongtitude.PasswordChar = '\0';
            this.txtSiteLongtitude.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSiteLongtitude.SelectedText = "";
            this.txtSiteLongtitude.SelectionLength = 0;
            this.txtSiteLongtitude.SelectionStart = 0;
            this.txtSiteLongtitude.ShortcutsEnabled = true;
            this.txtSiteLongtitude.Size = new System.Drawing.Size(191, 23);
            this.txtSiteLongtitude.TabIndex = 8;
            this.txtSiteLongtitude.UseSelectable = true;
            this.txtSiteLongtitude.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSiteLongtitude.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(10, 19);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(51, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Search:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Silver;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.txtSiteSearch);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(37, 359);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(942, 58);
            this.metroPanel1.TabIndex = 18;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtSiteSearch
            // 
            // 
            // 
            // 
            this.txtSiteSearch.CustomButton.Image = null;
            this.txtSiteSearch.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.txtSiteSearch.CustomButton.Name = "";
            this.txtSiteSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSiteSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSiteSearch.CustomButton.TabIndex = 1;
            this.txtSiteSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSiteSearch.CustomButton.UseSelectable = true;
            this.txtSiteSearch.CustomButton.Visible = false;
            this.txtSiteSearch.Lines = new string[0];
            this.txtSiteSearch.Location = new System.Drawing.Point(68, 19);
            this.txtSiteSearch.MaxLength = 32767;
            this.txtSiteSearch.Name = "txtSiteSearch";
            this.txtSiteSearch.PasswordChar = '\0';
            this.txtSiteSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSiteSearch.SelectedText = "";
            this.txtSiteSearch.SelectionLength = 0;
            this.txtSiteSearch.SelectionStart = 0;
            this.txtSiteSearch.ShortcutsEnabled = true;
            this.txtSiteSearch.Size = new System.Drawing.Size(316, 23);
            this.txtSiteSearch.TabIndex = 18;
            this.txtSiteSearch.UseSelectable = true;
            this.txtSiteSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSiteSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSiteSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSiteSearch_KeyPress);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(582, 330);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 19;
            this.metroButton1.Text = "&NEW";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // frmSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 624);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtSiteLongtitude);
            this.Controls.Add(this.txtSiteLatitude);
            this.Controls.Add(this.txtSitename);
            this.Controls.Add(this.txtSitephone);
            this.Controls.Add(this.txtSiteaddress);
            this.Controls.Add(this.txtSiteFirst);
            this.Controls.Add(this.txtSiteLast);
            this.Controls.Add(this.txtSiteMaf);
            this.Controls.Add(this.txtSiteID);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmSite";
            this.Text = "SITE OWNER INFORMATION";
            this.Load += new System.EventHandler(this.frmSite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteTableBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource siteTableBindingSource;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtSiteID;
        private MetroFramework.Controls.MetroTextBox txtSiteMaf;
        private MetroFramework.Controls.MetroTextBox txtSiteLast;
        private MetroFramework.Controls.MetroTextBox txtSiteFirst;
        private MetroFramework.Controls.MetroTextBox txtSiteaddress;
        private MetroFramework.Controls.MetroTextBox txtSitephone;
        private MetroFramework.Controls.MetroTextBox txtSitename;
        private MetroFramework.Controls.MetroTextBox txtSiteLatitude;
        private MetroFramework.Controls.MetroTextBox txtSiteLongtitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mafIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longtitudeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn harvestTablesDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtSiteSearch;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}