namespace ITProject2
{
    partial class Orchardcs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtOrchardname = new MetroFramework.Controls.MetroTextBox();
            this.orchardTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtOrchardphone = new MetroFramework.Controls.MetroTextBox();
            this.txtOrchardaddress = new MetroFramework.Controls.MetroTextBox();
            this.txtOrchardFirst = new MetroFramework.Controls.MetroTextBox();
            this.txtOrchardLast = new MetroFramework.Controls.MetroTextBox();
            this.txtOrchardID = new MetroFramework.Controls.MetroTextBox();
            this.lblOPhone = new MetroFramework.Controls.MetroLabel();
            this.lblOAddress = new MetroFramework.Controls.MetroLabel();
            this.lblOLast = new MetroFramework.Controls.MetroLabel();
            this.lblOFirst = new MetroFramework.Controls.MetroLabel();
            this.lblOName = new MetroFramework.Controls.MetroLabel();
            this.btnOrchardClose = new MetroFramework.Controls.MetroButton();
            this.btnOrchardDelete = new MetroFramework.Controls.MetroButton();
            this.btnOrhardEdit = new MetroFramework.Controls.MetroButton();
            this.btnOrchardSave = new MetroFramework.Controls.MetroButton();
            this.btnOrchardNew = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.lblOid = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtOrchardSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblOSearch = new MetroFramework.Controls.MetroLabel();
            this.OrchardGrid = new MetroFramework.Controls.MetroGrid();
            this.orchardIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orchardnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orchardTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrchardGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrchardname
            // 
            // 
            // 
            // 
            this.txtOrchardname.CustomButton.Image = null;
            this.txtOrchardname.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.txtOrchardname.CustomButton.Name = "";
            this.txtOrchardname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOrchardname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrchardname.CustomButton.TabIndex = 1;
            this.txtOrchardname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrchardname.CustomButton.UseSelectable = true;
            this.txtOrchardname.CustomButton.Visible = false;
            this.txtOrchardname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orchardTableBindingSource, "Orchardname", true));
            this.txtOrchardname.Lines = new string[0];
            this.txtOrchardname.Location = new System.Drawing.Point(442, 84);
            this.txtOrchardname.MaxLength = 32767;
            this.txtOrchardname.Name = "txtOrchardname";
            this.txtOrchardname.PasswordChar = '\0';
            this.txtOrchardname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrchardname.SelectedText = "";
            this.txtOrchardname.SelectionLength = 0;
            this.txtOrchardname.SelectionStart = 0;
            this.txtOrchardname.ShortcutsEnabled = true;
            this.txtOrchardname.Size = new System.Drawing.Size(243, 23);
            this.txtOrchardname.TabIndex = 1;
            this.txtOrchardname.UseSelectable = true;
            this.txtOrchardname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrchardname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // orchardTableBindingSource
            // 
            this.orchardTableBindingSource.DataSource = typeof(ITProject2.OrchardTable);
            // 
            // txtOrchardphone
            // 
            // 
            // 
            // 
            this.txtOrchardphone.CustomButton.Image = null;
            this.txtOrchardphone.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.txtOrchardphone.CustomButton.Name = "";
            this.txtOrchardphone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOrchardphone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrchardphone.CustomButton.TabIndex = 1;
            this.txtOrchardphone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrchardphone.CustomButton.UseSelectable = true;
            this.txtOrchardphone.CustomButton.Visible = false;
            this.txtOrchardphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orchardTableBindingSource, "Phone", true));
            this.txtOrchardphone.Lines = new string[0];
            this.txtOrchardphone.Location = new System.Drawing.Point(735, 227);
            this.txtOrchardphone.MaxLength = 32767;
            this.txtOrchardphone.Name = "txtOrchardphone";
            this.txtOrchardphone.PasswordChar = '\0';
            this.txtOrchardphone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrchardphone.SelectedText = "";
            this.txtOrchardphone.SelectionLength = 0;
            this.txtOrchardphone.SelectionStart = 0;
            this.txtOrchardphone.ShortcutsEnabled = true;
            this.txtOrchardphone.Size = new System.Drawing.Size(243, 23);
            this.txtOrchardphone.TabIndex = 5;
            this.txtOrchardphone.UseSelectable = true;
            this.txtOrchardphone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrchardphone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOrchardaddress
            // 
            // 
            // 
            // 
            this.txtOrchardaddress.CustomButton.Image = null;
            this.txtOrchardaddress.CustomButton.Location = new System.Drawing.Point(474, 2);
            this.txtOrchardaddress.CustomButton.Name = "";
            this.txtOrchardaddress.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtOrchardaddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrchardaddress.CustomButton.TabIndex = 1;
            this.txtOrchardaddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrchardaddress.CustomButton.UseSelectable = true;
            this.txtOrchardaddress.CustomButton.Visible = false;
            this.txtOrchardaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orchardTableBindingSource, "Address", true));
            this.txtOrchardaddress.Lines = new string[0];
            this.txtOrchardaddress.Location = new System.Drawing.Point(38, 227);
            this.txtOrchardaddress.MaxLength = 32767;
            this.txtOrchardaddress.Multiline = true;
            this.txtOrchardaddress.Name = "txtOrchardaddress";
            this.txtOrchardaddress.PasswordChar = '\0';
            this.txtOrchardaddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrchardaddress.SelectedText = "";
            this.txtOrchardaddress.SelectionLength = 0;
            this.txtOrchardaddress.SelectionStart = 0;
            this.txtOrchardaddress.ShortcutsEnabled = true;
            this.txtOrchardaddress.Size = new System.Drawing.Size(514, 42);
            this.txtOrchardaddress.TabIndex = 4;
            this.txtOrchardaddress.UseSelectable = true;
            this.txtOrchardaddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrchardaddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOrchardFirst
            // 
            // 
            // 
            // 
            this.txtOrchardFirst.CustomButton.Image = null;
            this.txtOrchardFirst.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.txtOrchardFirst.CustomButton.Name = "";
            this.txtOrchardFirst.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOrchardFirst.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrchardFirst.CustomButton.TabIndex = 1;
            this.txtOrchardFirst.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrchardFirst.CustomButton.UseSelectable = true;
            this.txtOrchardFirst.CustomButton.Visible = false;
            this.txtOrchardFirst.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orchardTableBindingSource, "Firstname", true));
            this.txtOrchardFirst.Lines = new string[0];
            this.txtOrchardFirst.Location = new System.Drawing.Point(113, 160);
            this.txtOrchardFirst.MaxLength = 32767;
            this.txtOrchardFirst.Name = "txtOrchardFirst";
            this.txtOrchardFirst.PasswordChar = '\0';
            this.txtOrchardFirst.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrchardFirst.SelectedText = "";
            this.txtOrchardFirst.SelectionLength = 0;
            this.txtOrchardFirst.SelectionStart = 0;
            this.txtOrchardFirst.ShortcutsEnabled = true;
            this.txtOrchardFirst.Size = new System.Drawing.Size(243, 23);
            this.txtOrchardFirst.TabIndex = 3;
            this.txtOrchardFirst.UseSelectable = true;
            this.txtOrchardFirst.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrchardFirst.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOrchardLast
            // 
            // 
            // 
            // 
            this.txtOrchardLast.CustomButton.Image = null;
            this.txtOrchardLast.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.txtOrchardLast.CustomButton.Name = "";
            this.txtOrchardLast.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOrchardLast.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrchardLast.CustomButton.TabIndex = 1;
            this.txtOrchardLast.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrchardLast.CustomButton.UseSelectable = true;
            this.txtOrchardLast.CustomButton.Visible = false;
            this.txtOrchardLast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orchardTableBindingSource, "Lastname", true));
            this.txtOrchardLast.Lines = new string[0];
            this.txtOrchardLast.Location = new System.Drawing.Point(735, 160);
            this.txtOrchardLast.MaxLength = 32767;
            this.txtOrchardLast.Name = "txtOrchardLast";
            this.txtOrchardLast.PasswordChar = '\0';
            this.txtOrchardLast.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrchardLast.SelectedText = "";
            this.txtOrchardLast.SelectionLength = 0;
            this.txtOrchardLast.SelectionStart = 0;
            this.txtOrchardLast.ShortcutsEnabled = true;
            this.txtOrchardLast.Size = new System.Drawing.Size(243, 23);
            this.txtOrchardLast.TabIndex = 2;
            this.txtOrchardLast.UseSelectable = true;
            this.txtOrchardLast.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrchardLast.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOrchardID
            // 
            // 
            // 
            // 
            this.txtOrchardID.CustomButton.Image = null;
            this.txtOrchardID.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtOrchardID.CustomButton.Name = "";
            this.txtOrchardID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOrchardID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrchardID.CustomButton.TabIndex = 1;
            this.txtOrchardID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrchardID.CustomButton.UseSelectable = true;
            this.txtOrchardID.CustomButton.Visible = false;
            this.txtOrchardID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orchardTableBindingSource, "OrchardID", true));
            this.txtOrchardID.Lines = new string[0];
            this.txtOrchardID.Location = new System.Drawing.Point(864, 84);
            this.txtOrchardID.MaxLength = 32767;
            this.txtOrchardID.Name = "txtOrchardID";
            this.txtOrchardID.PasswordChar = '\0';
            this.txtOrchardID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrchardID.SelectedText = "";
            this.txtOrchardID.SelectionLength = 0;
            this.txtOrchardID.SelectionStart = 0;
            this.txtOrchardID.ShortcutsEnabled = true;
            this.txtOrchardID.Size = new System.Drawing.Size(114, 23);
            this.txtOrchardID.TabIndex = 0;
            this.txtOrchardID.UseSelectable = true;
            this.txtOrchardID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrchardID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblOPhone
            // 
            this.lblOPhone.AutoSize = true;
            this.lblOPhone.Location = new System.Drawing.Point(680, 231);
            this.lblOPhone.Name = "lblOPhone";
            this.lblOPhone.Size = new System.Drawing.Size(49, 19);
            this.lblOPhone.TabIndex = 40;
            this.lblOPhone.Text = "Phone:";
            // 
            // lblOAddress
            // 
            this.lblOAddress.AutoSize = true;
            this.lblOAddress.Location = new System.Drawing.Point(38, 198);
            this.lblOAddress.Name = "lblOAddress";
            this.lblOAddress.Size = new System.Drawing.Size(59, 19);
            this.lblOAddress.TabIndex = 38;
            this.lblOAddress.Text = "Address:";
            // 
            // lblOLast
            // 
            this.lblOLast.AutoSize = true;
            this.lblOLast.Location = new System.Drawing.Point(662, 160);
            this.lblOLast.Name = "lblOLast";
            this.lblOLast.Size = new System.Drawing.Size(67, 19);
            this.lblOLast.TabIndex = 34;
            this.lblOLast.Text = "Lastname:";
            // 
            // lblOFirst
            // 
            this.lblOFirst.AutoSize = true;
            this.lblOFirst.Location = new System.Drawing.Point(38, 164);
            this.lblOFirst.Name = "lblOFirst";
            this.lblOFirst.Size = new System.Drawing.Size(69, 19);
            this.lblOFirst.TabIndex = 32;
            this.lblOFirst.Text = "Firstname:";
            // 
            // lblOName
            // 
            this.lblOName.AutoSize = true;
            this.lblOName.Location = new System.Drawing.Point(335, 88);
            this.lblOName.Name = "lblOName";
            this.lblOName.Size = new System.Drawing.Size(101, 19);
            this.lblOName.TabIndex = 29;
            this.lblOName.Text = "Orchard Name:";
            // 
            // btnOrchardClose
            // 
            this.btnOrchardClose.Location = new System.Drawing.Point(903, 297);
            this.btnOrchardClose.Name = "btnOrchardClose";
            this.btnOrchardClose.Size = new System.Drawing.Size(75, 23);
            this.btnOrchardClose.TabIndex = 10;
            this.btnOrchardClose.Text = "&CLOSE";
            this.btnOrchardClose.UseSelectable = true;
            this.btnOrchardClose.Click += new System.EventHandler(this.btnOrchardClose_Click);
            // 
            // btnOrchardDelete
            // 
            this.btnOrchardDelete.Location = new System.Drawing.Point(822, 297);
            this.btnOrchardDelete.Name = "btnOrchardDelete";
            this.btnOrchardDelete.Size = new System.Drawing.Size(75, 23);
            this.btnOrchardDelete.TabIndex = 9;
            this.btnOrchardDelete.Text = "&DELETE";
            this.btnOrchardDelete.UseSelectable = true;
            this.btnOrchardDelete.Click += new System.EventHandler(this.btnOrchardDelete_Click);
            // 
            // btnOrhardEdit
            // 
            this.btnOrhardEdit.Location = new System.Drawing.Point(741, 297);
            this.btnOrhardEdit.Name = "btnOrhardEdit";
            this.btnOrhardEdit.Size = new System.Drawing.Size(75, 23);
            this.btnOrhardEdit.TabIndex = 8;
            this.btnOrhardEdit.Text = "&EDIT";
            this.btnOrhardEdit.UseSelectable = true;
            this.btnOrhardEdit.Click += new System.EventHandler(this.btnOrhardEdit_Click);
            // 
            // btnOrchardSave
            // 
            this.btnOrchardSave.Location = new System.Drawing.Point(660, 297);
            this.btnOrchardSave.Name = "btnOrchardSave";
            this.btnOrchardSave.Size = new System.Drawing.Size(75, 23);
            this.btnOrchardSave.TabIndex = 7;
            this.btnOrchardSave.Text = "&SAVE";
            this.btnOrchardSave.UseSelectable = true;
            this.btnOrchardSave.Click += new System.EventHandler(this.btnOrchardSave_Click);
            // 
            // btnOrchardNew
            // 
            this.btnOrchardNew.Location = new System.Drawing.Point(578, 297);
            this.btnOrchardNew.Name = "btnOrchardNew";
            this.btnOrchardNew.Size = new System.Drawing.Size(75, 23);
            this.btnOrchardNew.TabIndex = 6;
            this.btnOrchardNew.Text = "&NEW";
            this.btnOrchardNew.UseSelectable = true;
            this.btnOrchardNew.Click += new System.EventHandler(this.btnOrchardNew_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
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
            this.metroGrid1.Location = new System.Drawing.Point(38, 418);
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
            this.metroGrid1.Size = new System.Drawing.Size(647, 150);
            this.metroGrid1.TabIndex = 41;
            // 
            // lblOid
            // 
            this.lblOid.AutoSize = true;
            this.lblOid.Location = new System.Drawing.Point(757, 88);
            this.lblOid.Name = "lblOid";
            this.lblOid.Size = new System.Drawing.Size(77, 19);
            this.lblOid.TabIndex = 20;
            this.lblOid.Text = "Orchard ID:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Silver;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.txtOrchardSearch);
            this.metroPanel1.Controls.Add(this.lblOSearch);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(38, 343);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(940, 58);
            this.metroPanel1.TabIndex = 12;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtOrchardSearch
            // 
            // 
            // 
            // 
            this.txtOrchardSearch.CustomButton.Image = null;
            this.txtOrchardSearch.CustomButton.Location = new System.Drawing.Point(294, 1);
            this.txtOrchardSearch.CustomButton.Name = "";
            this.txtOrchardSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOrchardSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrchardSearch.CustomButton.TabIndex = 1;
            this.txtOrchardSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrchardSearch.CustomButton.UseSelectable = true;
            this.txtOrchardSearch.CustomButton.Visible = false;
            this.txtOrchardSearch.Lines = new string[0];
            this.txtOrchardSearch.Location = new System.Drawing.Point(126, 15);
            this.txtOrchardSearch.MaxLength = 32767;
            this.txtOrchardSearch.Name = "txtOrchardSearch";
            this.txtOrchardSearch.PasswordChar = '\0';
            this.txtOrchardSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrchardSearch.SelectedText = "";
            this.txtOrchardSearch.SelectionLength = 0;
            this.txtOrchardSearch.SelectionStart = 0;
            this.txtOrchardSearch.ShortcutsEnabled = true;
            this.txtOrchardSearch.Size = new System.Drawing.Size(316, 23);
            this.txtOrchardSearch.TabIndex = 1;
            this.txtOrchardSearch.UseSelectable = true;
            this.txtOrchardSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrchardSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtOrchardSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrchardSearch_KeyPress);
            // 
            // lblOSearch
            // 
            this.lblOSearch.AutoSize = true;
            this.lblOSearch.Location = new System.Drawing.Point(59, 15);
            this.lblOSearch.Name = "lblOSearch";
            this.lblOSearch.Size = new System.Drawing.Size(51, 19);
            this.lblOSearch.TabIndex = 17;
            this.lblOSearch.Text = "Search:";
            // 
            // OrchardGrid
            // 
            this.OrchardGrid.AllowUserToAddRows = false;
            this.OrchardGrid.AllowUserToResizeRows = false;
            this.OrchardGrid.AutoGenerateColumns = false;
            this.OrchardGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OrchardGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrchardGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrchardGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrchardGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.OrchardGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrchardGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orchardIDDataGridViewTextBoxColumn,
            this.orchardnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.OrchardGrid.DataSource = this.orchardTableBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrchardGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.OrchardGrid.EnableHeadersVisualStyles = false;
            this.OrchardGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OrchardGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OrchardGrid.Location = new System.Drawing.Point(38, 418);
            this.OrchardGrid.Name = "OrchardGrid";
            this.OrchardGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrchardGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.OrchardGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrchardGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrchardGrid.Size = new System.Drawing.Size(940, 150);
            this.OrchardGrid.TabIndex = 11;
            this.OrchardGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrchardGrid_CellContentClick);
            this.OrchardGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrchardGrid_KeyDown);
            // 
            // orchardIDDataGridViewTextBoxColumn
            // 
            this.orchardIDDataGridViewTextBoxColumn.DataPropertyName = "OrchardID";
            this.orchardIDDataGridViewTextBoxColumn.HeaderText = "OrchardID";
            this.orchardIDDataGridViewTextBoxColumn.Name = "orchardIDDataGridViewTextBoxColumn";
            // 
            // orchardnameDataGridViewTextBoxColumn
            // 
            this.orchardnameDataGridViewTextBoxColumn.DataPropertyName = "Orchardname";
            this.orchardnameDataGridViewTextBoxColumn.HeaderText = "Orchardname";
            this.orchardnameDataGridViewTextBoxColumn.Name = "orchardnameDataGridViewTextBoxColumn";
            this.orchardnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // Orchardcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 591);
            this.Controls.Add(this.OrchardGrid);
            this.Controls.Add(this.txtOrchardname);
            this.Controls.Add(this.txtOrchardphone);
            this.Controls.Add(this.txtOrchardaddress);
            this.Controls.Add(this.txtOrchardFirst);
            this.Controls.Add(this.txtOrchardLast);
            this.Controls.Add(this.txtOrchardID);
            this.Controls.Add(this.lblOPhone);
            this.Controls.Add(this.lblOAddress);
            this.Controls.Add(this.lblOLast);
            this.Controls.Add(this.lblOFirst);
            this.Controls.Add(this.lblOName);
            this.Controls.Add(this.btnOrchardClose);
            this.Controls.Add(this.btnOrchardDelete);
            this.Controls.Add(this.btnOrhardEdit);
            this.Controls.Add(this.btnOrchardSave);
            this.Controls.Add(this.btnOrchardNew);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.lblOid);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Orchardcs";
            this.Text = "Orchard Information";
            this.Load += new System.EventHandler(this.Orchardcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orchardTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrchardGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtOrchardname;
        private System.Windows.Forms.BindingSource orchardTableBindingSource;
        private MetroFramework.Controls.MetroTextBox txtOrchardphone;
        private MetroFramework.Controls.MetroTextBox txtOrchardaddress;
        private MetroFramework.Controls.MetroTextBox txtOrchardFirst;
        private MetroFramework.Controls.MetroTextBox txtOrchardLast;
        private MetroFramework.Controls.MetroTextBox txtOrchardID;
        private MetroFramework.Controls.MetroLabel lblOPhone;
        private MetroFramework.Controls.MetroLabel lblOAddress;
        private MetroFramework.Controls.MetroLabel lblOLast;
        private MetroFramework.Controls.MetroLabel lblOFirst;
        private MetroFramework.Controls.MetroLabel lblOName;
        private MetroFramework.Controls.MetroButton btnOrchardClose;
        private MetroFramework.Controls.MetroButton btnOrchardDelete;
        private MetroFramework.Controls.MetroButton btnOrhardEdit;
        private MetroFramework.Controls.MetroButton btnOrchardSave;
        private MetroFramework.Controls.MetroButton btnOrchardNew;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel lblOid;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtOrchardSearch;
        private MetroFramework.Controls.MetroLabel lblOSearch;
        private MetroFramework.Controls.MetroGrid OrchardGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn orchardIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orchardnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}