namespace ITProject2
{
    partial class Beekeeper
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
            this.txtBeeContactName = new MetroFramework.Controls.MetroTextBox();
            this.beekeeperTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBeePosition = new MetroFramework.Controls.MetroTextBox();
            this.txtBeephone = new MetroFramework.Controls.MetroTextBox();
            this.txtBeeaddress = new MetroFramework.Controls.MetroTextBox();
            this.txtBeeFirst = new MetroFramework.Controls.MetroTextBox();
            this.txtBeeLast = new MetroFramework.Controls.MetroTextBox();
            this.txtBeeID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtBeeSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.BeeGrid = new MetroFramework.Controls.MetroGrid();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactEmergencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.beekeeperTableBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BeeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBeeContactName
            // 
            // 
            // 
            // 
            this.txtBeeContactName.CustomButton.Image = null;
            this.txtBeeContactName.CustomButton.Location = new System.Drawing.Point(356, 1);
            this.txtBeeContactName.CustomButton.Name = "";
            this.txtBeeContactName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBeeContactName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBeeContactName.CustomButton.TabIndex = 1;
            this.txtBeeContactName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBeeContactName.CustomButton.UseSelectable = true;
            this.txtBeeContactName.CustomButton.Visible = false;
            this.txtBeeContactName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.beekeeperTableBindingSource, "ContactEmergency", true));
            this.txtBeeContactName.Lines = new string[0];
            this.txtBeeContactName.Location = new System.Drawing.Point(89, 35);
            this.txtBeeContactName.MaxLength = 32767;
            this.txtBeeContactName.Name = "txtBeeContactName";
            this.txtBeeContactName.PasswordChar = '\0';
            this.txtBeeContactName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBeeContactName.SelectedText = "";
            this.txtBeeContactName.SelectionLength = 0;
            this.txtBeeContactName.SelectionStart = 0;
            this.txtBeeContactName.ShortcutsEnabled = true;
            this.txtBeeContactName.Size = new System.Drawing.Size(378, 23);
            this.txtBeeContactName.TabIndex = 30;
            this.txtBeeContactName.UseSelectable = true;
            this.txtBeeContactName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBeeContactName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // beekeeperTableBindingSource
            // 
            this.beekeeperTableBindingSource.DataSource = typeof(ITProject2.BeekeeperTable);
            // 
            // txtBeePosition
            // 
            // 
            // 
            // 
            this.txtBeePosition.CustomButton.Image = null;
            this.txtBeePosition.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.txtBeePosition.CustomButton.Name = "";
            this.txtBeePosition.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBeePosition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBeePosition.CustomButton.TabIndex = 1;
            this.txtBeePosition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBeePosition.CustomButton.UseSelectable = true;
            this.txtBeePosition.CustomButton.Visible = false;
            this.txtBeePosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.beekeeperTableBindingSource, "Position", true));
            this.txtBeePosition.Lines = new string[0];
            this.txtBeePosition.Location = new System.Drawing.Point(565, 233);
            this.txtBeePosition.MaxLength = 32767;
            this.txtBeePosition.Name = "txtBeePosition";
            this.txtBeePosition.PasswordChar = '\0';
            this.txtBeePosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBeePosition.SelectedText = "";
            this.txtBeePosition.SelectionLength = 0;
            this.txtBeePosition.SelectionStart = 0;
            this.txtBeePosition.ShortcutsEnabled = true;
            this.txtBeePosition.Size = new System.Drawing.Size(254, 23);
            this.txtBeePosition.TabIndex = 27;
            this.txtBeePosition.UseSelectable = true;
            this.txtBeePosition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBeePosition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBeephone
            // 
            // 
            // 
            // 
            this.txtBeephone.CustomButton.Image = null;
            this.txtBeephone.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtBeephone.CustomButton.Name = "";
            this.txtBeephone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBeephone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBeephone.CustomButton.TabIndex = 1;
            this.txtBeephone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBeephone.CustomButton.UseSelectable = true;
            this.txtBeephone.CustomButton.Visible = false;
            this.txtBeephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.beekeeperTableBindingSource, "Phone", true));
            this.txtBeephone.Lines = new string[0];
            this.txtBeephone.Location = new System.Drawing.Point(675, 150);
            this.txtBeephone.MaxLength = 32767;
            this.txtBeephone.Name = "txtBeephone";
            this.txtBeephone.PasswordChar = '\0';
            this.txtBeephone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBeephone.SelectedText = "";
            this.txtBeephone.SelectionLength = 0;
            this.txtBeephone.SelectionStart = 0;
            this.txtBeephone.ShortcutsEnabled = true;
            this.txtBeephone.Size = new System.Drawing.Size(144, 23);
            this.txtBeephone.TabIndex = 25;
            this.txtBeephone.UseSelectable = true;
            this.txtBeephone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBeephone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBeeaddress
            // 
            // 
            // 
            // 
            this.txtBeeaddress.CustomButton.Image = null;
            this.txtBeeaddress.CustomButton.Location = new System.Drawing.Point(322, 1);
            this.txtBeeaddress.CustomButton.Name = "";
            this.txtBeeaddress.CustomButton.Size = new System.Drawing.Size(63, 63);
            this.txtBeeaddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBeeaddress.CustomButton.TabIndex = 1;
            this.txtBeeaddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBeeaddress.CustomButton.UseSelectable = true;
            this.txtBeeaddress.CustomButton.Visible = false;
            this.txtBeeaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.beekeeperTableBindingSource, "Address", true));
            this.txtBeeaddress.Lines = new string[0];
            this.txtBeeaddress.Location = new System.Drawing.Point(27, 229);
            this.txtBeeaddress.MaxLength = 32767;
            this.txtBeeaddress.Multiline = true;
            this.txtBeeaddress.Name = "txtBeeaddress";
            this.txtBeeaddress.PasswordChar = '\0';
            this.txtBeeaddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBeeaddress.SelectedText = "";
            this.txtBeeaddress.SelectionLength = 0;
            this.txtBeeaddress.SelectionStart = 0;
            this.txtBeeaddress.ShortcutsEnabled = true;
            this.txtBeeaddress.Size = new System.Drawing.Size(386, 65);
            this.txtBeeaddress.TabIndex = 26;
            this.txtBeeaddress.UseSelectable = true;
            this.txtBeeaddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBeeaddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBeeFirst
            // 
            // 
            // 
            // 
            this.txtBeeFirst.CustomButton.Image = null;
            this.txtBeeFirst.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtBeeFirst.CustomButton.Name = "";
            this.txtBeeFirst.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBeeFirst.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBeeFirst.CustomButton.TabIndex = 1;
            this.txtBeeFirst.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBeeFirst.CustomButton.UseSelectable = true;
            this.txtBeeFirst.CustomButton.Visible = false;
            this.txtBeeFirst.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.beekeeperTableBindingSource, "Firstname", true));
            this.txtBeeFirst.Lines = new string[0];
            this.txtBeeFirst.Location = new System.Drawing.Point(116, 154);
            this.txtBeeFirst.MaxLength = 32767;
            this.txtBeeFirst.Name = "txtBeeFirst";
            this.txtBeeFirst.PasswordChar = '\0';
            this.txtBeeFirst.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBeeFirst.SelectedText = "";
            this.txtBeeFirst.SelectionLength = 0;
            this.txtBeeFirst.SelectionStart = 0;
            this.txtBeeFirst.ShortcutsEnabled = true;
            this.txtBeeFirst.Size = new System.Drawing.Size(164, 23);
            this.txtBeeFirst.TabIndex = 23;
            this.txtBeeFirst.UseSelectable = true;
            this.txtBeeFirst.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBeeFirst.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBeeLast
            // 
            // 
            // 
            // 
            this.txtBeeLast.CustomButton.Image = null;
            this.txtBeeLast.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtBeeLast.CustomButton.Name = "";
            this.txtBeeLast.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBeeLast.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBeeLast.CustomButton.TabIndex = 1;
            this.txtBeeLast.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBeeLast.CustomButton.UseSelectable = true;
            this.txtBeeLast.CustomButton.Visible = false;
            this.txtBeeLast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.beekeeperTableBindingSource, "Lastname", true));
            this.txtBeeLast.Lines = new string[0];
            this.txtBeeLast.Location = new System.Drawing.Point(383, 150);
            this.txtBeeLast.MaxLength = 32767;
            this.txtBeeLast.Name = "txtBeeLast";
            this.txtBeeLast.PasswordChar = '\0';
            this.txtBeeLast.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBeeLast.SelectedText = "";
            this.txtBeeLast.SelectionLength = 0;
            this.txtBeeLast.SelectionStart = 0;
            this.txtBeeLast.ShortcutsEnabled = true;
            this.txtBeeLast.Size = new System.Drawing.Size(164, 23);
            this.txtBeeLast.TabIndex = 24;
            this.txtBeeLast.UseSelectable = true;
            this.txtBeeLast.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBeeLast.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBeeID
            // 
            // 
            // 
            // 
            this.txtBeeID.CustomButton.Image = null;
            this.txtBeeID.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtBeeID.CustomButton.Name = "";
            this.txtBeeID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBeeID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBeeID.CustomButton.TabIndex = 1;
            this.txtBeeID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBeeID.CustomButton.UseSelectable = true;
            this.txtBeeID.CustomButton.Visible = false;
            this.txtBeeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.beekeeperTableBindingSource, "ID", true));
            this.txtBeeID.Lines = new string[0];
            this.txtBeeID.Location = new System.Drawing.Point(705, 93);
            this.txtBeeID.MaxLength = 32767;
            this.txtBeeID.Name = "txtBeeID";
            this.txtBeeID.PasswordChar = '\0';
            this.txtBeeID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBeeID.SelectedText = "";
            this.txtBeeID.SelectionLength = 0;
            this.txtBeeID.SelectionStart = 0;
            this.txtBeeID.ShortcutsEnabled = true;
            this.txtBeeID.Size = new System.Drawing.Size(114, 23);
            this.txtBeeID.TabIndex = 21;
            this.txtBeeID.UseSelectable = true;
            this.txtBeeID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBeeID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(11, 39);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(48, 19);
            this.metroLabel10.TabIndex = 41;
            this.metroLabel10.Text = "Name:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(594, 154);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(49, 19);
            this.metroLabel9.TabIndex = 40;
            this.metroLabel9.Text = "Phone:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(27, 200);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 19);
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "Address:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(464, 233);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(57, 19);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Position:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(286, 154);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 19);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = "Lastname:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(27, 154);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "Firstname:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(565, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Beekeeper ID:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(744, 408);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "&CLOSE";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(663, 408);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "&DELETE";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(582, 408);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "&EDIT";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(501, 408);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(419, 408);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 32;
            this.btnNew.Text = "&NEW";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Silver;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.txtBeeSearch);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(27, 448);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(792, 58);
            this.metroPanel1.TabIndex = 42;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtBeeSearch
            // 
            // 
            // 
            // 
            this.txtBeeSearch.CustomButton.Image = null;
            this.txtBeeSearch.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.txtBeeSearch.CustomButton.Name = "";
            this.txtBeeSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBeeSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBeeSearch.CustomButton.TabIndex = 1;
            this.txtBeeSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBeeSearch.CustomButton.UseSelectable = true;
            this.txtBeeSearch.CustomButton.Visible = false;
            this.txtBeeSearch.Lines = new string[0];
            this.txtBeeSearch.Location = new System.Drawing.Point(68, 19);
            this.txtBeeSearch.MaxLength = 32767;
            this.txtBeeSearch.Name = "txtBeeSearch";
            this.txtBeeSearch.PasswordChar = '\0';
            this.txtBeeSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBeeSearch.SelectedText = "";
            this.txtBeeSearch.SelectionLength = 0;
            this.txtBeeSearch.SelectionStart = 0;
            this.txtBeeSearch.ShortcutsEnabled = true;
            this.txtBeeSearch.Size = new System.Drawing.Size(316, 23);
            this.txtBeeSearch.TabIndex = 18;
            this.txtBeeSearch.UseSelectable = true;
            this.txtBeeSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBeeSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBeeSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBeeSearch_KeyPress);
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
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel11);
            this.metroPanel2.Controls.Add(this.txtBeeContactName);
            this.metroPanel2.Controls.Add(this.metroLabel10);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(27, 315);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(792, 70);
            this.metroPanel2.TabIndex = 43;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(11, 10);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(126, 19);
            this.metroLabel11.TabIndex = 44;
            this.metroLabel11.Text = "Emergency Contact:";
            // 
            // BeeGrid
            // 
            this.BeeGrid.AllowUserToAddRows = false;
            this.BeeGrid.AllowUserToResizeRows = false;
            this.BeeGrid.AutoGenerateColumns = false;
            this.BeeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BeeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BeeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BeeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BeeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BeeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.contactEmergencyDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
            this.BeeGrid.DataSource = this.beekeeperTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BeeGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.BeeGrid.EnableHeadersVisualStyles = false;
            this.BeeGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BeeGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BeeGrid.Location = new System.Drawing.Point(27, 522);
            this.BeeGrid.Name = "BeeGrid";
            this.BeeGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BeeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BeeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BeeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BeeGrid.Size = new System.Drawing.Size(792, 181);
            this.BeeGrid.TabIndex = 44;
            this.BeeGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BeeGrid_KeyDown);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
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
            // contactEmergencyDataGridViewTextBoxColumn
            // 
            this.contactEmergencyDataGridViewTextBoxColumn.DataPropertyName = "ContactEmergency";
            this.contactEmergencyDataGridViewTextBoxColumn.HeaderText = "ContactEmergency";
            this.contactEmergencyDataGridViewTextBoxColumn.Name = "contactEmergencyDataGridViewTextBoxColumn";
            this.contactEmergencyDataGridViewTextBoxColumn.Width = 150;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // Beekeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 735);
            this.Controls.Add(this.BeeGrid);
            this.Controls.Add(this.txtBeePosition);
            this.Controls.Add(this.txtBeephone);
            this.Controls.Add(this.txtBeeaddress);
            this.Controls.Add(this.txtBeeFirst);
            this.Controls.Add(this.txtBeeLast);
            this.Controls.Add(this.txtBeeID);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel2);
            this.Name = "Beekeeper";
            this.Text = "Beekeeper Information";
            this.Load += new System.EventHandler(this.Beekeeper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beekeeperTableBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BeeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtBeeContactName;
        private MetroFramework.Controls.MetroTextBox txtBeePosition;
        private MetroFramework.Controls.MetroTextBox txtBeephone;
        private MetroFramework.Controls.MetroTextBox txtBeeaddress;
        private MetroFramework.Controls.MetroTextBox txtBeeFirst;
        private MetroFramework.Controls.MetroTextBox txtBeeLast;
        private MetroFramework.Controls.MetroTextBox txtBeeID;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtBeeSearch;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroGrid BeeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactEmergencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource beekeeperTableBindingSource;
    }
}