namespace ITProject2
{
    partial class Harvest
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
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtHarvestSitename = new MetroFramework.Controls.MetroTextBox();
            this.txtHarvestBeekeeper = new MetroFramework.Controls.MetroTextBox();
            this.txtHarvestMaf = new MetroFramework.Controls.MetroTextBox();
            this.txtHarvestID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtHarvestweight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cboArea = new MetroFramework.Controls.MetroComboBox();
            this.txtharvestSiteID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.txtHarvestSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.HarvestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harvestTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mafIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beekeeperInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.harvestTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(533, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 48);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "&DELETE";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(394, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 48);
            this.btnEdit.TabIndex = 42;
            this.btnEdit.Text = "&EDIT";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(255, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 48);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(116, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(106, 48);
            this.btnNew.TabIndex = 40;
            this.btnNew.Text = "&NEW";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.HarvestID,
            this.siteIDDataGridViewTextBoxColumn,
            this.mafIDDataGridViewTextBoxColumn,
            this.sitenameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.beekeeperInitialDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.harvestTableBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(76, 147);
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
            this.metroGrid1.Size = new System.Drawing.Size(943, 392);
            this.metroGrid1.TabIndex = 45;
            this.metroGrid1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroGrid1_KeyDown);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Yellow;
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.btnDelete);
            this.metroPanel1.Controls.Add(this.btnNew);
            this.metroPanel1.Controls.Add(this.btnEdit);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(127, 678);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(873, 74);
            this.metroPanel1.TabIndex = 46;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(672, 12);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(106, 48);
            this.metroButton1.TabIndex = 45;
            this.metroButton1.Text = "&CLOSE";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtHarvestSitename
            // 
            // 
            // 
            // 
            this.txtHarvestSitename.CustomButton.Image = null;
            this.txtHarvestSitename.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtHarvestSitename.CustomButton.Name = "";
            this.txtHarvestSitename.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHarvestSitename.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHarvestSitename.CustomButton.TabIndex = 1;
            this.txtHarvestSitename.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHarvestSitename.CustomButton.UseSelectable = true;
            this.txtHarvestSitename.CustomButton.Visible = false;
            this.txtHarvestSitename.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.harvestTableBindingSource, "Sitename", true));
            this.txtHarvestSitename.Lines = new string[0];
            this.txtHarvestSitename.Location = new System.Drawing.Point(334, 625);
            this.txtHarvestSitename.MaxLength = 32767;
            this.txtHarvestSitename.Name = "txtHarvestSitename";
            this.txtHarvestSitename.PasswordChar = '\0';
            this.txtHarvestSitename.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHarvestSitename.SelectedText = "";
            this.txtHarvestSitename.SelectionLength = 0;
            this.txtHarvestSitename.SelectionStart = 0;
            this.txtHarvestSitename.ShortcutsEnabled = true;
            this.txtHarvestSitename.Size = new System.Drawing.Size(164, 23);
            this.txtHarvestSitename.TabIndex = 50;
            this.txtHarvestSitename.UseSelectable = true;
            this.txtHarvestSitename.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHarvestSitename.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHarvestSitename.Click += new System.EventHandler(this.txtHarvestname_Click);
            // 
            // txtHarvestBeekeeper
            // 
            // 
            // 
            // 
            this.txtHarvestBeekeeper.CustomButton.Image = null;
            this.txtHarvestBeekeeper.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtHarvestBeekeeper.CustomButton.Name = "";
            this.txtHarvestBeekeeper.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHarvestBeekeeper.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHarvestBeekeeper.CustomButton.TabIndex = 1;
            this.txtHarvestBeekeeper.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHarvestBeekeeper.CustomButton.UseSelectable = true;
            this.txtHarvestBeekeeper.CustomButton.Visible = false;
            this.txtHarvestBeekeeper.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.harvestTableBindingSource, "BeekeeperInitial", true));
            this.txtHarvestBeekeeper.Lines = new string[0];
            this.txtHarvestBeekeeper.Location = new System.Drawing.Point(893, 625);
            this.txtHarvestBeekeeper.MaxLength = 32767;
            this.txtHarvestBeekeeper.Name = "txtHarvestBeekeeper";
            this.txtHarvestBeekeeper.PasswordChar = '\0';
            this.txtHarvestBeekeeper.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHarvestBeekeeper.SelectedText = "";
            this.txtHarvestBeekeeper.SelectionLength = 0;
            this.txtHarvestBeekeeper.SelectionStart = 0;
            this.txtHarvestBeekeeper.ShortcutsEnabled = true;
            this.txtHarvestBeekeeper.Size = new System.Drawing.Size(164, 23);
            this.txtHarvestBeekeeper.TabIndex = 53;
            this.txtHarvestBeekeeper.UseSelectable = true;
            this.txtHarvestBeekeeper.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHarvestBeekeeper.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHarvestBeekeeper.Click += new System.EventHandler(this.txtHarvestBeekeeper_Click);
            // 
            // txtHarvestMaf
            // 
            // 
            // 
            // 
            this.txtHarvestMaf.CustomButton.Image = null;
            this.txtHarvestMaf.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtHarvestMaf.CustomButton.Name = "";
            this.txtHarvestMaf.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHarvestMaf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHarvestMaf.CustomButton.TabIndex = 1;
            this.txtHarvestMaf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHarvestMaf.CustomButton.UseSelectable = true;
            this.txtHarvestMaf.CustomButton.Visible = false;
            this.txtHarvestMaf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.harvestTableBindingSource, "MafID", true));
            this.txtHarvestMaf.Lines = new string[0];
            this.txtHarvestMaf.Location = new System.Drawing.Point(642, 584);
            this.txtHarvestMaf.MaxLength = 32767;
            this.txtHarvestMaf.Name = "txtHarvestMaf";
            this.txtHarvestMaf.PasswordChar = '\0';
            this.txtHarvestMaf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHarvestMaf.SelectedText = "";
            this.txtHarvestMaf.SelectionLength = 0;
            this.txtHarvestMaf.SelectionStart = 0;
            this.txtHarvestMaf.ShortcutsEnabled = true;
            this.txtHarvestMaf.Size = new System.Drawing.Size(164, 23);
            this.txtHarvestMaf.TabIndex = 49;
            this.txtHarvestMaf.UseSelectable = true;
            this.txtHarvestMaf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHarvestMaf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHarvestID
            // 
            // 
            // 
            // 
            this.txtHarvestID.CustomButton.Image = null;
            this.txtHarvestID.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtHarvestID.CustomButton.Name = "";
            this.txtHarvestID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHarvestID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHarvestID.CustomButton.TabIndex = 1;
            this.txtHarvestID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHarvestID.CustomButton.UseSelectable = true;
            this.txtHarvestID.CustomButton.Visible = false;
            this.txtHarvestID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.harvestTableBindingSource, "HarvestID", true));
            this.txtHarvestID.Lines = new string[0];
            this.txtHarvestID.Location = new System.Drawing.Point(76, 584);
            this.txtHarvestID.MaxLength = 32767;
            this.txtHarvestID.Name = "txtHarvestID";
            this.txtHarvestID.PasswordChar = '\0';
            this.txtHarvestID.ReadOnly = true;
            this.txtHarvestID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHarvestID.SelectedText = "";
            this.txtHarvestID.SelectionLength = 0;
            this.txtHarvestID.SelectionStart = 0;
            this.txtHarvestID.ShortcutsEnabled = true;
            this.txtHarvestID.Size = new System.Drawing.Size(164, 23);
            this.txtHarvestID.TabIndex = 47;
            this.txtHarvestID.UseSelectable = true;
            this.txtHarvestID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHarvestID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(812, 629);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(75, 19);
            this.metroLabel9.TabIndex = 58;
            this.metroLabel9.Text = "Beekeeper:";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(9, 629);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 56;
            this.metroLabel4.Text = "Type:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 588);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 19);
            this.metroLabel3.TabIndex = 55;
            this.metroLabel3.Text = "Harvest ID:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(564, 586);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Text = "MAF ID:";
            // 
            // cboType
            // 
            this.cboType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.harvestTableBindingSource, "Type", true));
            this.cboType.FormattingEnabled = true;
            this.cboType.ItemHeight = 23;
            this.cboType.Items.AddRange(new object[] {
            "White",
            "Amber",
            "Manuka",
            "Rewa",
            "Ling",
            "Kamahi"});
            this.cboType.Location = new System.Drawing.Point(76, 623);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(164, 29);
            this.cboType.TabIndex = 59;
            this.cboType.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(821, 588);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(40, 19);
            this.metroLabel5.TabIndex = 61;
            this.metroLabel5.Text = "Area:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(251, 629);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 63;
            this.metroLabel6.Text = "Sitename:";
            // 
            // txtHarvestweight
            // 
            // 
            // 
            // 
            this.txtHarvestweight.CustomButton.Image = null;
            this.txtHarvestweight.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtHarvestweight.CustomButton.Name = "";
            this.txtHarvestweight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHarvestweight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHarvestweight.CustomButton.TabIndex = 1;
            this.txtHarvestweight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHarvestweight.CustomButton.UseSelectable = true;
            this.txtHarvestweight.CustomButton.Visible = false;
            this.txtHarvestweight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.harvestTableBindingSource, "weight", true));
            this.txtHarvestweight.Lines = new string[0];
            this.txtHarvestweight.Location = new System.Drawing.Point(640, 625);
            this.txtHarvestweight.MaxLength = 32767;
            this.txtHarvestweight.Name = "txtHarvestweight";
            this.txtHarvestweight.PasswordChar = '\0';
            this.txtHarvestweight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHarvestweight.SelectedText = "";
            this.txtHarvestweight.SelectionLength = 0;
            this.txtHarvestweight.SelectionStart = 0;
            this.txtHarvestweight.ShortcutsEnabled = true;
            this.txtHarvestweight.Size = new System.Drawing.Size(164, 23);
            this.txtHarvestweight.TabIndex = 64;
            this.txtHarvestweight.UseSelectable = true;
            this.txtHarvestweight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHarvestweight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(567, 629);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(53, 19);
            this.metroLabel7.TabIndex = 65;
            this.metroLabel7.Text = "Weight:";
            // 
            // cboArea
            // 
            this.cboArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.harvestTableBindingSource, "Area", true));
            this.cboArea.FormattingEnabled = true;
            this.cboArea.ItemHeight = 23;
            this.cboArea.Items.AddRange(new object[] {
            "Taupo",
            "Rotorua",
            "Reporua",
            "Whakatane",
            "Waikete"});
            this.cboArea.Location = new System.Drawing.Point(893, 584);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(164, 29);
            this.cboArea.TabIndex = 66;
            this.cboArea.UseSelectable = true;
            this.cboArea.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // txtharvestSiteID
            // 
            // 
            // 
            // 
            this.txtharvestSiteID.CustomButton.Image = null;
            this.txtharvestSiteID.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtharvestSiteID.CustomButton.Name = "";
            this.txtharvestSiteID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtharvestSiteID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtharvestSiteID.CustomButton.TabIndex = 1;
            this.txtharvestSiteID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtharvestSiteID.CustomButton.UseSelectable = true;
            this.txtharvestSiteID.CustomButton.Visible = false;
            this.txtharvestSiteID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.harvestTableBindingSource, "SiteID", true));
            this.txtharvestSiteID.Lines = new string[0];
            this.txtharvestSiteID.Location = new System.Drawing.Point(334, 584);
            this.txtharvestSiteID.MaxLength = 32767;
            this.txtharvestSiteID.Name = "txtharvestSiteID";
            this.txtharvestSiteID.PasswordChar = '\0';
            this.txtharvestSiteID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtharvestSiteID.SelectedText = "";
            this.txtharvestSiteID.SelectionLength = 0;
            this.txtharvestSiteID.SelectionStart = 0;
            this.txtharvestSiteID.ShortcutsEnabled = true;
            this.txtharvestSiteID.Size = new System.Drawing.Size(164, 23);
            this.txtharvestSiteID.TabIndex = 68;
            this.txtharvestSiteID.UseSelectable = true;
            this.txtharvestSiteID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtharvestSiteID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(264, 588);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 69;
            this.metroLabel2.Text = "Site ID:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Silver;
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.txtHarvestSearch);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(638, 83);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(393, 37);
            this.metroPanel2.TabIndex = 71;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // txtHarvestSearch
            // 
            // 
            // 
            // 
            this.txtHarvestSearch.CustomButton.Image = null;
            this.txtHarvestSearch.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.txtHarvestSearch.CustomButton.Name = "";
            this.txtHarvestSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHarvestSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHarvestSearch.CustomButton.TabIndex = 1;
            this.txtHarvestSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHarvestSearch.CustomButton.UseSelectable = true;
            this.txtHarvestSearch.CustomButton.Visible = false;
            this.txtHarvestSearch.Lines = new string[0];
            this.txtHarvestSearch.Location = new System.Drawing.Point(65, 6);
            this.txtHarvestSearch.MaxLength = 32767;
            this.txtHarvestSearch.Name = "txtHarvestSearch";
            this.txtHarvestSearch.PasswordChar = '\0';
            this.txtHarvestSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHarvestSearch.SelectedText = "";
            this.txtHarvestSearch.SelectionLength = 0;
            this.txtHarvestSearch.SelectionStart = 0;
            this.txtHarvestSearch.ShortcutsEnabled = true;
            this.txtHarvestSearch.Size = new System.Drawing.Size(316, 23);
            this.txtHarvestSearch.TabIndex = 18;
            this.txtHarvestSearch.UseSelectable = true;
            this.txtHarvestSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHarvestSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHarvestSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarvestSearch_KeyPress);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(647, 90);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(51, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Search:";
            // 
            // HarvestID
            // 
            this.HarvestID.DataPropertyName = "HarvestID";
            this.HarvestID.HeaderText = "HarvestID";
            this.HarvestID.Name = "HarvestID";
            // 
            // harvestTableBindingSource
            // 
            this.harvestTableBindingSource.DataSource = typeof(ITProject2.HarvestTable);
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
            this.sitenameDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // beekeeperInitialDataGridViewTextBoxColumn
            // 
            this.beekeeperInitialDataGridViewTextBoxColumn.DataPropertyName = "BeekeeperInitial";
            this.beekeeperInitialDataGridViewTextBoxColumn.HeaderText = "BeekeeperInitial";
            this.beekeeperInitialDataGridViewTextBoxColumn.Name = "beekeeperInitialDataGridViewTextBoxColumn";
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.Width = 150;
            // 
            // siteTableBindingSource
            // 
            this.siteTableBindingSource.DataSource = typeof(ITProject2.SiteTable);
            // 
            // Harvest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 772);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.txtharvestSiteID);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cboArea);
            this.Controls.Add(this.txtHarvestweight);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtHarvestSitename);
            this.Controls.Add(this.txtHarvestBeekeeper);
            this.Controls.Add(this.txtHarvestMaf);
            this.Controls.Add(this.txtHarvestID);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Harvest";
            this.Text = "Harvest Data Entry";
            this.Load += new System.EventHandler(this.Harvest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.harvestTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtHarvestSitename;
        private MetroFramework.Controls.MetroTextBox txtHarvestBeekeeper;
        private MetroFramework.Controls.MetroTextBox txtHarvestMaf;
        private MetroFramework.Controls.MetroTextBox txtHarvestID;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cboType;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.BindingSource harvestTableBindingSource;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtHarvestweight;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cboArea;
        private MetroFramework.Controls.MetroTextBox txtharvestSiteID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.BindingSource siteTableBindingSource;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtHarvestSearch;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HarvestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mafIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beekeeperInitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
    }
}