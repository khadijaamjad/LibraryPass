namespace VP_LibraryPass
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbStu = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbTeacher = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbTopic = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ddType = new Bunifu.Framework.UI.BunifuDropdown();
            this.ddSubject = new Bunifu.Framework.UI.BunifuDropdown();
            this.dtpDD = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpCD = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnSubmit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnView = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.dgvStored = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStored)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(235, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(216, 30);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Research Library Pass";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 89);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(76, 21);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Issued To:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(32, 130);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(64, 21);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Subject:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(32, 172);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(129, 21);
            this.bunifuCustomLabel4.TabIndex = 3;
            this.bunifuCustomLabel4.Text = "Assignment type:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(367, 130);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(65, 21);
            this.bunifuCustomLabel5.TabIndex = 4;
            this.bunifuCustomLabel5.Text = "Teacher:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(32, 217);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(48, 21);
            this.bunifuCustomLabel6.TabIndex = 5;
            this.bunifuCustomLabel6.Text = "Topic:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(32, 265);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(77, 21);
            this.bunifuCustomLabel7.TabIndex = 6;
            this.bunifuCustomLabel7.Text = "Due Date:";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(32, 320);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(45, 21);
            this.bunifuCustomLabel8.TabIndex = 7;
            this.bunifuCustomLabel8.Text = "Date:";
            // 
            // tbStu
            // 
            this.tbStu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbStu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbStu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbStu.HintForeColor = System.Drawing.Color.Empty;
            this.tbStu.HintText = "";
            this.tbStu.isPassword = false;
            this.tbStu.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.tbStu.LineIdleColor = System.Drawing.Color.Gray;
            this.tbStu.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.tbStu.LineThickness = 3;
            this.tbStu.Location = new System.Drawing.Point(167, 76);
            this.tbStu.Margin = new System.Windows.Forms.Padding(4);
            this.tbStu.Name = "tbStu";
            this.tbStu.Size = new System.Drawing.Size(478, 33);
            this.tbStu.TabIndex = 8;
            this.tbStu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbTeacher
            // 
            this.tbTeacher.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbTeacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTeacher.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTeacher.HintForeColor = System.Drawing.Color.Empty;
            this.tbTeacher.HintText = "";
            this.tbTeacher.isPassword = false;
            this.tbTeacher.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.tbTeacher.LineIdleColor = System.Drawing.Color.Gray;
            this.tbTeacher.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.tbTeacher.LineThickness = 3;
            this.tbTeacher.Location = new System.Drawing.Point(449, 117);
            this.tbTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.tbTeacher.Name = "tbTeacher";
            this.tbTeacher.Size = new System.Drawing.Size(196, 33);
            this.tbTeacher.TabIndex = 9;
            this.tbTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbTopic
            // 
            this.tbTopic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbTopic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTopic.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTopic.HintForeColor = System.Drawing.Color.Empty;
            this.tbTopic.HintText = "";
            this.tbTopic.isPassword = false;
            this.tbTopic.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.tbTopic.LineIdleColor = System.Drawing.Color.Gray;
            this.tbTopic.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.tbTopic.LineThickness = 3;
            this.tbTopic.Location = new System.Drawing.Point(167, 205);
            this.tbTopic.Margin = new System.Windows.Forms.Padding(4);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.Size = new System.Drawing.Size(478, 33);
            this.tbTopic.TabIndex = 10;
            this.tbTopic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ddType
            // 
            this.ddType.BackColor = System.Drawing.Color.Transparent;
            this.ddType.BorderRadius = 3;
            this.ddType.DisabledColor = System.Drawing.Color.Gray;
            this.ddType.ForeColor = System.Drawing.Color.White;
            this.ddType.Items = new string[] {
        "Written",
        "Oral",
        "Both"};
            this.ddType.Location = new System.Drawing.Point(167, 171);
            this.ddType.Name = "ddType";
            this.ddType.NomalColor = System.Drawing.Color.DarkTurquoise;
            this.ddType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ddType.selectedIndex = -1;
            this.ddType.Size = new System.Drawing.Size(478, 25);
            this.ddType.TabIndex = 11;
            // 
            // ddSubject
            // 
            this.ddSubject.BackColor = System.Drawing.Color.Transparent;
            this.ddSubject.BorderRadius = 3;
            this.ddSubject.DisabledColor = System.Drawing.Color.Gray;
            this.ddSubject.ForeColor = System.Drawing.Color.White;
            this.ddSubject.Items = new string[] {
        "HCI",
        "VP",
        "WEB",
        "DSA",
        "CAO",
        "DLD",
        "CP",
        "CF",
        "DCN"};
            this.ddSubject.Location = new System.Drawing.Point(167, 126);
            this.ddSubject.Name = "ddSubject";
            this.ddSubject.NomalColor = System.Drawing.Color.DarkTurquoise;
            this.ddSubject.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ddSubject.selectedIndex = -1;
            this.ddSubject.Size = new System.Drawing.Size(187, 25);
            this.ddSubject.TabIndex = 12;
            // 
            // dtpDD
            // 
            this.dtpDD.BackColor = System.Drawing.Color.DarkTurquoise;
            this.dtpDD.BorderRadius = 0;
            this.dtpDD.ForeColor = System.Drawing.Color.White;
            this.dtpDD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDD.FormatCustom = null;
            this.dtpDD.Location = new System.Drawing.Point(167, 249);
            this.dtpDD.Name = "dtpDD";
            this.dtpDD.Size = new System.Drawing.Size(478, 40);
            this.dtpDD.TabIndex = 13;
            this.dtpDD.Value = new System.DateTime(2019, 12, 15, 13, 25, 33, 315);
            // 
            // dtpCD
            // 
            this.dtpCD.BackColor = System.Drawing.Color.DarkTurquoise;
            this.dtpCD.BorderRadius = 0;
            this.dtpCD.Enabled = false;
            this.dtpCD.ForeColor = System.Drawing.Color.White;
            this.dtpCD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCD.FormatCustom = null;
            this.dtpCD.Location = new System.Drawing.Point(167, 302);
            this.dtpCD.Name = "dtpCD";
            this.dtpCD.Size = new System.Drawing.Size(478, 39);
            this.dtpCD.TabIndex = 14;
            this.dtpCD.Value = new System.DateTime(2019, 12, 15, 14, 15, 21, 0);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.btnSubmit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.BorderRadius = 0;
            this.btnSubmit.ButtonText = "Submit";
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.DisabledColor = System.Drawing.Color.Gray;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSubmit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Iconimage")));
            this.btnSubmit.Iconimage_right = null;
            this.btnSubmit.Iconimage_right_Selected = null;
            this.btnSubmit.Iconimage_Selected = null;
            this.btnSubmit.IconMarginLeft = 0;
            this.btnSubmit.IconMarginRight = 0;
            this.btnSubmit.IconRightVisible = true;
            this.btnSubmit.IconRightZoom = 0D;
            this.btnSubmit.IconVisible = true;
            this.btnSubmit.IconZoom = 90D;
            this.btnSubmit.IsTab = false;
            this.btnSubmit.Location = new System.Drawing.Point(516, 359);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Normalcolor = System.Drawing.Color.DarkTurquoise;
            this.btnSubmit.OnHovercolor = System.Drawing.Color.MediumTurquoise;
            this.btnSubmit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSubmit.selected = false;
            this.btnSubmit.Size = new System.Drawing.Size(129, 41);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Textcolor = System.Drawing.Color.White;
            this.btnSubmit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(672, 13);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(31, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 16;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnView
            // 
            this.btnView.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.btnView.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnView.BorderRadius = 0;
            this.btnView.ButtonText = "View";
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.DisabledColor = System.Drawing.Color.Gray;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Iconcolor = System.Drawing.Color.Transparent;
            this.btnView.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnView.Iconimage")));
            this.btnView.Iconimage_right = null;
            this.btnView.Iconimage_right_Selected = null;
            this.btnView.Iconimage_Selected = null;
            this.btnView.IconMarginLeft = 0;
            this.btnView.IconMarginRight = 0;
            this.btnView.IconRightVisible = true;
            this.btnView.IconRightZoom = 0D;
            this.btnView.IconVisible = true;
            this.btnView.IconZoom = 90D;
            this.btnView.IsTab = false;
            this.btnView.Location = new System.Drawing.Point(379, 359);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnView.Name = "btnView";
            this.btnView.Normalcolor = System.Drawing.Color.DarkTurquoise;
            this.btnView.OnHovercolor = System.Drawing.Color.MediumTurquoise;
            this.btnView.OnHoverTextColor = System.Drawing.Color.White;
            this.btnView.selected = false;
            this.btnView.Size = new System.Drawing.Size(129, 41);
            this.btnView.TabIndex = 17;
            this.btnView.Text = "View";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Textcolor = System.Drawing.Color.White;
            this.btnView.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.btnBack);
            this.gbData.Controls.Add(this.dgvStored);
            this.gbData.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbData.Location = new System.Drawing.Point(12, 89);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(664, 324);
            this.gbData.TabIndex = 18;
            this.gbData.TabStop = false;
            this.gbData.Text = "Stored data";
            this.gbData.Enter += new System.EventHandler(this.gbData_Enter);
            // 
            // dgvStored
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStored.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStored.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvStored.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStored.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStored.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvStored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStored.DoubleBuffered = true;
            this.dgvStored.EnableHeadersVisualStyles = false;
            this.dgvStored.HeaderBgColor = System.Drawing.Color.DarkTurquoise;
            this.dgvStored.HeaderForeColor = System.Drawing.Color.DarkTurquoise;
            this.dgvStored.Location = new System.Drawing.Point(31, 41);
            this.dgvStored.Name = "dgvStored";
            this.dgvStored.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStored.Size = new System.Drawing.Size(606, 224);
            this.dgvStored.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 0;
            this.btnBack.ButtonText = "Back";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBack.Iconimage")));
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 90D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(508, 275);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.DarkTurquoise;
            this.btnBack.OnHovercolor = System.Drawing.Color.MediumTurquoise;
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(129, 41);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 432);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dtpCD);
            this.Controls.Add(this.dtpDD);
            this.Controls.Add(this.ddSubject);
            this.Controls.Add(this.ddType);
            this.Controls.Add(this.tbTopic);
            this.Controls.Add(this.tbTeacher);
            this.Controls.Add(this.tbStu);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStored)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbTopic;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbTeacher;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbStu;
        private Bunifu.Framework.UI.BunifuDatepicker dtpCD;
        private Bunifu.Framework.UI.BunifuDatepicker dtpDD;
        private Bunifu.Framework.UI.BunifuDropdown ddSubject;
        private Bunifu.Framework.UI.BunifuDropdown ddType;
        private Bunifu.Framework.UI.BunifuFlatButton btnSubmit;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnView;
        private System.Windows.Forms.GroupBox gbData;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvStored;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
    }
}

