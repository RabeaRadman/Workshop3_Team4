namespace Workshop3_Team4
{
    partial class FrmPackages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPackages));
            this.PnlPackages = new System.Windows.Forms.Panel();
            this.TxtWelcome = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.mnuPack = new System.Windows.Forms.MenuStrip();
            this.ToolmnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolmnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolmnuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolmnuDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolmnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlAddModify = new System.Windows.Forms.Panel();
            this.CmbEdit = new System.Windows.Forms.ComboBox();
            this.BtnProdSuppGet = new System.Windows.Forms.Button();
            this.BtnProdSuppSave = new System.Windows.Forms.Button();
            this.LblPackProdCode = new System.Windows.Forms.Label();
            this.LblProdCodeValidate = new System.Windows.Forms.Label();
            this.LblPackACValidate = new System.Windows.Forms.Label();
            this.LblPackBaseValidate = new System.Windows.Forms.Label();
            this.LblPackDescValidate = new System.Windows.Forms.Label();
            this.LblPackEndValidate = new System.Windows.Forms.Label();
            this.LblPackStartValidate = new System.Windows.Forms.Label();
            this.LblPackNameValidate = new System.Windows.Forms.Label();
            this.LblPackageID = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtPackName = new System.Windows.Forms.TextBox();
            this.LblPackName = new System.Windows.Forms.Label();
            this.LblPackStartDate = new System.Windows.Forms.Label();
            this.LblPackEndDate = new System.Windows.Forms.Label();
            this.LblPackDesc = new System.Windows.Forms.Label();
            this.DatePickEndDate = new System.Windows.Forms.DateTimePicker();
            this.TxtPackDesc = new System.Windows.Forms.TextBox();
            this.DatePickStartDate = new System.Windows.Forms.DateTimePicker();
            this.LblPackBasePrice = new System.Windows.Forms.Label();
            this.TxtPackAgency = new System.Windows.Forms.TextBox();
            this.TxtPackBasePrice = new System.Windows.Forms.TextBox();
            this.LblAgencyComm = new System.Windows.Forms.Label();
            this.PnlDelete = new System.Windows.Forms.Panel();
            this.LblProdSuppName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LstPackPrdSpp = new System.Windows.Forms.ListBox();
            this.BtnPPSDelete = new System.Windows.Forms.Button();
            this.LblPackRemove = new System.Windows.Forms.Label();
            this.BtnPackDelete = new System.Windows.Forms.Button();
            this.pac = new System.Windows.Forms.DataGridView();
            this.PackageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgBasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgAgencyCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlPackages.SuspendLayout();
            this.mnuPack.SuspendLayout();
            this.PnlAddModify.SuspendLayout();
            this.PnlDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pac)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPackages
            // 
            this.PnlPackages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlPackages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlPackages.Controls.Add(this.TxtWelcome);
            this.PnlPackages.Controls.Add(this.LblTitle);
            this.PnlPackages.Controls.Add(this.mnuPack);
            this.PnlPackages.Controls.Add(this.PnlAddModify);
            this.PnlPackages.Controls.Add(this.PnlDelete);
            this.PnlPackages.Location = new System.Drawing.Point(72, 13);
            this.PnlPackages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlPackages.Name = "PnlPackages";
            this.PnlPackages.Size = new System.Drawing.Size(1064, 904);
            this.PnlPackages.TabIndex = 20;
            // 
            // TxtWelcome
            // 
            this.TxtWelcome.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtWelcome.Enabled = false;
            this.TxtWelcome.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtWelcome.ForeColor = System.Drawing.Color.RoyalBlue;
            this.TxtWelcome.Location = new System.Drawing.Point(31, 45);
            this.TxtWelcome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtWelcome.Multiline = true;
            this.TxtWelcome.Name = "TxtWelcome";
            this.TxtWelcome.ReadOnly = true;
            this.TxtWelcome.Size = new System.Drawing.Size(996, 120);
            this.TxtWelcome.TabIndex = 21;
            this.TxtWelcome.Text = "\r\nWelcome to Packages Maintenance\r\n\r\nPlease select option from the menu above";
            this.TxtWelcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblTitle
            // 
            this.LblTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(31, 64);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(813, 40);
            this.LblTitle.TabIndex = 33;
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuPack
            // 
            this.mnuPack.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuPack.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolmnuAdd,
            this.ToolmnuEdit,
            this.ToolmnuRemove,
            this.ToolmnuDisplay,
            this.ToolmnuClose});
            this.mnuPack.Location = new System.Drawing.Point(0, 0);
            this.mnuPack.Name = "mnuPack";
            this.mnuPack.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuPack.Size = new System.Drawing.Size(1060, 38);
            this.mnuPack.TabIndex = 32;
            // 
            // ToolmnuAdd
            // 
            this.ToolmnuAdd.Name = "ToolmnuAdd";
            this.ToolmnuAdd.Size = new System.Drawing.Size(63, 32);
            this.ToolmnuAdd.Text = "&Add";
            this.ToolmnuAdd.Click += new System.EventHandler(this.ToolmnuAdd_Click);
            // 
            // ToolmnuEdit
            // 
            this.ToolmnuEdit.Name = "ToolmnuEdit";
            this.ToolmnuEdit.Size = new System.Drawing.Size(60, 32);
            this.ToolmnuEdit.Text = "&Edit";
            this.ToolmnuEdit.Click += new System.EventHandler(this.ToolmnuEdit_Click);
            // 
            // ToolmnuRemove
            // 
            this.ToolmnuRemove.Name = "ToolmnuRemove";
            this.ToolmnuRemove.Size = new System.Drawing.Size(82, 32);
            this.ToolmnuRemove.Text = "&Delete";
            this.ToolmnuRemove.Click += new System.EventHandler(this.ToolmnuRemove_Click);
            // 
            // ToolmnuDisplay
            // 
            this.ToolmnuDisplay.Name = "ToolmnuDisplay";
            this.ToolmnuDisplay.Size = new System.Drawing.Size(90, 32);
            this.ToolmnuDisplay.Text = "&Display";
            this.ToolmnuDisplay.Click += new System.EventHandler(this.ToolmnuDisplay_Click_1);
            // 
            // ToolmnuClose
            // 
            this.ToolmnuClose.Name = "ToolmnuClose";
            this.ToolmnuClose.Size = new System.Drawing.Size(57, 32);
            this.ToolmnuClose.Text = "&Exit";
            this.ToolmnuClose.Click += new System.EventHandler(this.ToolmnuClose_Click);
            // 
            // PnlAddModify
            // 
            this.PnlAddModify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlAddModify.Controls.Add(this.CmbEdit);
            this.PnlAddModify.Controls.Add(this.BtnProdSuppGet);
            this.PnlAddModify.Controls.Add(this.BtnProdSuppSave);
            this.PnlAddModify.Controls.Add(this.LblPackProdCode);
            this.PnlAddModify.Controls.Add(this.LblProdCodeValidate);
            this.PnlAddModify.Controls.Add(this.LblPackACValidate);
            this.PnlAddModify.Controls.Add(this.LblPackBaseValidate);
            this.PnlAddModify.Controls.Add(this.LblPackDescValidate);
            this.PnlAddModify.Controls.Add(this.LblPackEndValidate);
            this.PnlAddModify.Controls.Add(this.LblPackStartValidate);
            this.PnlAddModify.Controls.Add(this.LblPackNameValidate);
            this.PnlAddModify.Controls.Add(this.LblPackageID);
            this.PnlAddModify.Controls.Add(this.BtnSave);
            this.PnlAddModify.Controls.Add(this.TxtPackName);
            this.PnlAddModify.Controls.Add(this.LblPackName);
            this.PnlAddModify.Controls.Add(this.LblPackStartDate);
            this.PnlAddModify.Controls.Add(this.LblPackEndDate);
            this.PnlAddModify.Controls.Add(this.LblPackDesc);
            this.PnlAddModify.Controls.Add(this.DatePickEndDate);
            this.PnlAddModify.Controls.Add(this.TxtPackDesc);
            this.PnlAddModify.Controls.Add(this.DatePickStartDate);
            this.PnlAddModify.Controls.Add(this.LblPackBasePrice);
            this.PnlAddModify.Controls.Add(this.TxtPackAgency);
            this.PnlAddModify.Controls.Add(this.TxtPackBasePrice);
            this.PnlAddModify.Controls.Add(this.LblAgencyComm);
            this.PnlAddModify.Location = new System.Drawing.Point(31, 127);
            this.PnlAddModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlAddModify.Name = "PnlAddModify";
            this.PnlAddModify.Size = new System.Drawing.Size(996, 761);
            this.PnlAddModify.TabIndex = 37;
            this.PnlAddModify.Visible = false;
            // 
            // CmbEdit
            // 
            this.CmbEdit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmbEdit.FormattingEnabled = true;
            this.CmbEdit.Location = new System.Drawing.Point(25, 490);
            this.CmbEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbEdit.Name = "CmbEdit";
            this.CmbEdit.Size = new System.Drawing.Size(958, 27);
            this.CmbEdit.TabIndex = 38;
            this.CmbEdit.Visible = false;
            this.CmbEdit.SelectedIndexChanged += new System.EventHandler(this.CmbEdit_SelectedIndexChanged);
            // 
            // BtnProdSuppGet
            // 
            this.BtnProdSuppGet.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProdSuppGet.Location = new System.Drawing.Point(316, 545);
            this.BtnProdSuppGet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnProdSuppGet.Name = "BtnProdSuppGet";
            this.BtnProdSuppGet.Size = new System.Drawing.Size(453, 35);
            this.BtnProdSuppGet.TabIndex = 47;
            this.BtnProdSuppGet.Text = "Get Product";
            this.BtnProdSuppGet.UseVisualStyleBackColor = true;
            this.BtnProdSuppGet.Visible = false;
            this.BtnProdSuppGet.Click += new System.EventHandler(this.BtnProdSuppGet_Click);
            // 
            // BtnProdSuppSave
            // 
            this.BtnProdSuppSave.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProdSuppSave.Location = new System.Drawing.Point(316, 607);
            this.BtnProdSuppSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnProdSuppSave.Name = "BtnProdSuppSave";
            this.BtnProdSuppSave.Size = new System.Drawing.Size(453, 35);
            this.BtnProdSuppSave.TabIndex = 46;
            this.BtnProdSuppSave.Text = "Save Product";
            this.BtnProdSuppSave.UseVisualStyleBackColor = true;
            this.BtnProdSuppSave.Visible = false;
            this.BtnProdSuppSave.Click += new System.EventHandler(this.BtnProdSuppSave_Click);
            // 
            // LblPackProdCode
            // 
            this.LblPackProdCode.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPackProdCode.Location = new System.Drawing.Point(148, 651);
            this.LblPackProdCode.Name = "LblPackProdCode";
            this.LblPackProdCode.Size = new System.Drawing.Size(738, 35);
            this.LblPackProdCode.TabIndex = 45;
            this.LblPackProdCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblProdCodeValidate
            // 
            this.LblProdCodeValidate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblProdCodeValidate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblProdCodeValidate.Location = new System.Drawing.Point(131, 646);
            this.LblProdCodeValidate.Name = "LblProdCodeValidate";
            this.LblProdCodeValidate.Size = new System.Drawing.Size(738, 40);
            this.LblProdCodeValidate.TabIndex = 43;
            this.LblProdCodeValidate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPackACValidate
            // 
            this.LblPackACValidate.ForeColor = System.Drawing.Color.DarkRed;
            this.LblPackACValidate.Location = new System.Drawing.Point(320, 413);
            this.LblPackACValidate.Name = "LblPackACValidate";
            this.LblPackACValidate.Size = new System.Drawing.Size(423, 19);
            this.LblPackACValidate.TabIndex = 42;
            // 
            // LblPackBaseValidate
            // 
            this.LblPackBaseValidate.ForeColor = System.Drawing.Color.DarkRed;
            this.LblPackBaseValidate.Location = new System.Drawing.Point(320, 350);
            this.LblPackBaseValidate.Name = "LblPackBaseValidate";
            this.LblPackBaseValidate.Size = new System.Drawing.Size(423, 24);
            this.LblPackBaseValidate.TabIndex = 41;
            // 
            // LblPackDescValidate
            // 
            this.LblPackDescValidate.ForeColor = System.Drawing.Color.DarkRed;
            this.LblPackDescValidate.Location = new System.Drawing.Point(320, 284);
            this.LblPackDescValidate.Name = "LblPackDescValidate";
            this.LblPackDescValidate.Size = new System.Drawing.Size(423, 24);
            this.LblPackDescValidate.TabIndex = 40;
            // 
            // LblPackEndValidate
            // 
            this.LblPackEndValidate.ForeColor = System.Drawing.Color.DarkRed;
            this.LblPackEndValidate.Location = new System.Drawing.Point(320, 225);
            this.LblPackEndValidate.Name = "LblPackEndValidate";
            this.LblPackEndValidate.Size = new System.Drawing.Size(423, 17);
            this.LblPackEndValidate.TabIndex = 39;
            // 
            // LblPackStartValidate
            // 
            this.LblPackStartValidate.ForeColor = System.Drawing.Color.DarkRed;
            this.LblPackStartValidate.Location = new System.Drawing.Point(320, 159);
            this.LblPackStartValidate.Name = "LblPackStartValidate";
            this.LblPackStartValidate.Size = new System.Drawing.Size(423, 24);
            this.LblPackStartValidate.TabIndex = 39;
            // 
            // LblPackNameValidate
            // 
            this.LblPackNameValidate.ForeColor = System.Drawing.Color.DarkRed;
            this.LblPackNameValidate.Location = new System.Drawing.Point(320, 96);
            this.LblPackNameValidate.Name = "LblPackNameValidate";
            this.LblPackNameValidate.Size = new System.Drawing.Size(423, 21);
            this.LblPackNameValidate.TabIndex = 38;
            // 
            // LblPackageID
            // 
            this.LblPackageID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPackageID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblPackageID.Location = new System.Drawing.Point(23, 16);
            this.LblPackageID.Name = "LblPackageID";
            this.LblPackageID.Size = new System.Drawing.Size(746, 31);
            this.LblPackageID.TabIndex = 37;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.Location = new System.Drawing.Point(315, 436);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(453, 35);
            this.BtnSave.TabIndex = 36;
            this.BtnSave.Text = "Save Package";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtPackName
            // 
            this.TxtPackName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPackName.Location = new System.Drawing.Point(315, 58);
            this.TxtPackName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPackName.Name = "TxtPackName";
            this.TxtPackName.Size = new System.Drawing.Size(611, 34);
            this.TxtPackName.TabIndex = 0;
            this.TxtPackName.Tag = "Package Name";
            this.TxtPackName.DoubleClick += new System.EventHandler(this.TxtPackName_Click);
            // 
            // LblPackName
            // 
            this.LblPackName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPackName.Location = new System.Drawing.Point(31, 58);
            this.LblPackName.Name = "LblPackName";
            this.LblPackName.Size = new System.Drawing.Size(183, 31);
            this.LblPackName.TabIndex = 20;
            this.LblPackName.Text = "Package Name:";
            // 
            // LblPackStartDate
            // 
            this.LblPackStartDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPackStartDate.Location = new System.Drawing.Point(31, 121);
            this.LblPackStartDate.Name = "LblPackStartDate";
            this.LblPackStartDate.Size = new System.Drawing.Size(183, 31);
            this.LblPackStartDate.TabIndex = 21;
            this.LblPackStartDate.Text = "Package Start Date:";
            this.LblPackStartDate.UseMnemonic = false;
            // 
            // LblPackEndDate
            // 
            this.LblPackEndDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPackEndDate.Location = new System.Drawing.Point(31, 187);
            this.LblPackEndDate.Name = "LblPackEndDate";
            this.LblPackEndDate.Size = new System.Drawing.Size(183, 31);
            this.LblPackEndDate.TabIndex = 22;
            this.LblPackEndDate.Text = "Package End Date:";
            // 
            // LblPackDesc
            // 
            this.LblPackDesc.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPackDesc.Location = new System.Drawing.Point(31, 246);
            this.LblPackDesc.Name = "LblPackDesc";
            this.LblPackDesc.Size = new System.Drawing.Size(261, 31);
            this.LblPackDesc.TabIndex = 23;
            this.LblPackDesc.Text = "Package Description:";
            // 
            // DatePickEndDate
            // 
            this.DatePickEndDate.CustomFormat = "";
            this.DatePickEndDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePickEndDate.Location = new System.Drawing.Point(316, 187);
            this.DatePickEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DatePickEndDate.Name = "DatePickEndDate";
            this.DatePickEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DatePickEndDate.Size = new System.Drawing.Size(610, 34);
            this.DatePickEndDate.TabIndex = 2;
            this.DatePickEndDate.Tag = "Package End Date";
            // 
            // TxtPackDesc
            // 
            this.TxtPackDesc.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPackDesc.Location = new System.Drawing.Point(316, 246);
            this.TxtPackDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPackDesc.Name = "TxtPackDesc";
            this.TxtPackDesc.Size = new System.Drawing.Size(610, 34);
            this.TxtPackDesc.TabIndex = 3;
            this.TxtPackDesc.Tag = "Package Description";
            // 
            // DatePickStartDate
            // 
            this.DatePickStartDate.CustomFormat = "";
            this.DatePickStartDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePickStartDate.Location = new System.Drawing.Point(316, 121);
            this.DatePickStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DatePickStartDate.Name = "DatePickStartDate";
            this.DatePickStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DatePickStartDate.Size = new System.Drawing.Size(610, 34);
            this.DatePickStartDate.TabIndex = 1;
            this.DatePickStartDate.Tag = "Package Start Date";
            // 
            // LblPackBasePrice
            // 
            this.LblPackBasePrice.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPackBasePrice.Location = new System.Drawing.Point(31, 309);
            this.LblPackBasePrice.Name = "LblPackBasePrice";
            this.LblPackBasePrice.Size = new System.Drawing.Size(183, 31);
            this.LblPackBasePrice.TabIndex = 25;
            this.LblPackBasePrice.Text = "Package Base Price:";
            // 
            // TxtPackAgency
            // 
            this.TxtPackAgency.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPackAgency.Location = new System.Drawing.Point(316, 375);
            this.TxtPackAgency.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPackAgency.Name = "TxtPackAgency";
            this.TxtPackAgency.Size = new System.Drawing.Size(452, 34);
            this.TxtPackAgency.TabIndex = 5;
            this.TxtPackAgency.Tag = "Package Agency Commission";
            // 
            // TxtPackBasePrice
            // 
            this.TxtPackBasePrice.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPackBasePrice.Location = new System.Drawing.Point(315, 312);
            this.TxtPackBasePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPackBasePrice.Name = "TxtPackBasePrice";
            this.TxtPackBasePrice.Size = new System.Drawing.Size(452, 34);
            this.TxtPackBasePrice.TabIndex = 4;
            this.TxtPackBasePrice.Tag = "Package Base Price";
            // 
            // LblAgencyComm
            // 
            this.LblAgencyComm.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAgencyComm.Location = new System.Drawing.Point(31, 375);
            this.LblAgencyComm.Name = "LblAgencyComm";
            this.LblAgencyComm.Size = new System.Drawing.Size(261, 35);
            this.LblAgencyComm.TabIndex = 27;
            this.LblAgencyComm.Text = "Package Commission Price:";
            // 
            // PnlDelete
            // 
            this.PnlDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlDelete.Controls.Add(this.LblProdSuppName);
            this.PnlDelete.Controls.Add(this.label1);
            this.PnlDelete.Controls.Add(this.label2);
            this.PnlDelete.Controls.Add(this.LstPackPrdSpp);
            this.PnlDelete.Controls.Add(this.BtnPPSDelete);
            this.PnlDelete.Controls.Add(this.LblPackRemove);
            this.PnlDelete.Controls.Add(this.BtnPackDelete);
            this.PnlDelete.Controls.Add(this.pac);
            this.PnlDelete.Location = new System.Drawing.Point(31, 127);
            this.PnlDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlDelete.Name = "PnlDelete";
            this.PnlDelete.Size = new System.Drawing.Size(991, 761);
            this.PnlDelete.TabIndex = 39;
            this.PnlDelete.Visible = false;
            // 
            // LblProdSuppName
            // 
            this.LblProdSuppName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblProdSuppName.Location = new System.Drawing.Point(23, 548);
            this.LblProdSuppName.Name = "LblProdSuppName";
            this.LblProdSuppName.Size = new System.Drawing.Size(746, 36);
            this.LblProdSuppName.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 40;
            this.label1.Text = "Packages:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 31);
            this.label2.TabIndex = 41;
            this.label2.Text = "Products:";
            // 
            // LstPackPrdSpp
            // 
            this.LstPackPrdSpp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LstPackPrdSpp.FormattingEnabled = true;
            this.LstPackPrdSpp.HorizontalScrollbar = true;
            this.LstPackPrdSpp.ItemHeight = 23;
            this.LstPackPrdSpp.Location = new System.Drawing.Point(23, 588);
            this.LstPackPrdSpp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LstPackPrdSpp.Name = "LstPackPrdSpp";
            this.LstPackPrdSpp.Size = new System.Drawing.Size(960, 119);
            this.LstPackPrdSpp.TabIndex = 41;
            this.LstPackPrdSpp.SelectedIndexChanged += new System.EventHandler(this.LstPackPrdSpp_SelectedIndexChanged);
            // 
            // BtnPPSDelete
            // 
            this.BtnPPSDelete.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPPSDelete.Location = new System.Drawing.Point(823, 709);
            this.BtnPPSDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPPSDelete.Name = "BtnPPSDelete";
            this.BtnPPSDelete.Size = new System.Drawing.Size(160, 39);
            this.BtnPPSDelete.TabIndex = 40;
            this.BtnPPSDelete.Text = "Delete Product";
            this.BtnPPSDelete.UseVisualStyleBackColor = true;
            this.BtnPPSDelete.Click += new System.EventHandler(this.BtnPPSDelete_Click);
            // 
            // LblPackRemove
            // 
            this.LblPackRemove.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPackRemove.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblPackRemove.Location = new System.Drawing.Point(25, 16);
            this.LblPackRemove.Name = "LblPackRemove";
            this.LblPackRemove.Size = new System.Drawing.Size(709, 31);
            this.LblPackRemove.TabIndex = 38;
            // 
            // BtnPackDelete
            // 
            this.BtnPackDelete.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnPackDelete.Location = new System.Drawing.Point(823, 472);
            this.BtnPackDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPackDelete.Name = "BtnPackDelete";
            this.BtnPackDelete.Size = new System.Drawing.Size(160, 45);
            this.BtnPackDelete.TabIndex = 1;
            this.BtnPackDelete.Text = "Delete Package";
            this.BtnPackDelete.UseVisualStyleBackColor = true;
            this.BtnPackDelete.Click += new System.EventHandler(this.BtnPackDelete_Click);
            // 
            // pac
            // 
            this.pac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageId,
            this.PkgName,
            this.PkgStartDate,
            this.PkgEndDate,
            this.PkgDesc,
            this.PkgBasePrice,
            this.PkgAgencyCommission});
            this.pac.Location = new System.Drawing.Point(25, 68);
            this.pac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pac.Name = "pac";
            this.pac.RowHeadersWidth = 51;
            this.pac.RowTemplate.Height = 25;
            this.pac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pac.Size = new System.Drawing.Size(958, 383);
            this.pac.TabIndex = 0;
            this.pac.SelectionChanged += new System.EventHandler(this.GridRemove_SelectionChanged);
            // 
            // PackageId
            // 
            this.PackageId.DataPropertyName = "PackageId";
            this.PackageId.HeaderText = "Package ID";
            this.PackageId.MinimumWidth = 6;
            this.PackageId.Name = "PackageId";
            this.PackageId.Width = 125;
            // 
            // PkgName
            // 
            this.PkgName.DataPropertyName = "PkgName";
            this.PkgName.HeaderText = "Package Name";
            this.PkgName.MinimumWidth = 6;
            this.PkgName.Name = "PkgName";
            this.PkgName.Width = 125;
            // 
            // PkgStartDate
            // 
            this.PkgStartDate.DataPropertyName = "PkgStartDate";
            this.PkgStartDate.HeaderText = "Package Start Date";
            this.PkgStartDate.MinimumWidth = 6;
            this.PkgStartDate.Name = "PkgStartDate";
            this.PkgStartDate.Width = 125;
            // 
            // PkgEndDate
            // 
            this.PkgEndDate.DataPropertyName = "PkgEndDate";
            this.PkgEndDate.HeaderText = "Package End Date";
            this.PkgEndDate.MinimumWidth = 6;
            this.PkgEndDate.Name = "PkgEndDate";
            this.PkgEndDate.Width = 125;
            // 
            // PkgDesc
            // 
            this.PkgDesc.DataPropertyName = "PkgDesc";
            this.PkgDesc.HeaderText = "Package Desc";
            this.PkgDesc.MinimumWidth = 6;
            this.PkgDesc.Name = "PkgDesc";
            this.PkgDesc.Width = 125;
            // 
            // PkgBasePrice
            // 
            this.PkgBasePrice.DataPropertyName = "PkgBasePrice";
            this.PkgBasePrice.HeaderText = "Package Base Price";
            this.PkgBasePrice.MinimumWidth = 6;
            this.PkgBasePrice.Name = "PkgBasePrice";
            this.PkgBasePrice.Width = 125;
            // 
            // PkgAgencyCommission
            // 
            this.PkgAgencyCommission.DataPropertyName = "PkgAgencyCommission";
            this.PkgAgencyCommission.HeaderText = "Package Agency Commision";
            this.PkgAgencyCommission.MinimumWidth = 6;
            this.PkgAgencyCommission.Name = "PkgAgencyCommission";
            this.PkgAgencyCommission.Width = 125;
            // 
            // FrmPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1198, 932);
            this.Controls.Add(this.PnlPackages);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPackages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packages";
            this.Load += new System.EventHandler(this.FrmPackages_Load);
            this.PnlPackages.ResumeLayout(false);
            this.PnlPackages.PerformLayout();
            this.mnuPack.ResumeLayout(false);
            this.mnuPack.PerformLayout();
            this.PnlAddModify.ResumeLayout(false);
            this.PnlAddModify.PerformLayout();
            this.PnlDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlPackages;
        private System.Windows.Forms.DateTimePicker DatePickEndDate;
        private System.Windows.Forms.DateTimePicker DatePickStartDate;
        private System.Windows.Forms.TextBox TxtPackAgency;
        private System.Windows.Forms.Label LblAgencyComm;
        private System.Windows.Forms.TextBox TxtPackBasePrice;
        private System.Windows.Forms.Label LblPackBasePrice;
        private System.Windows.Forms.TextBox TxtPackDesc;
        private System.Windows.Forms.Label LblPackDesc;
        private System.Windows.Forms.Label LblPackEndDate;
        private System.Windows.Forms.Label LblPackStartDate;
        private System.Windows.Forms.TextBox TxtPackName;
        private System.Windows.Forms.Label LblPackName;
        private System.Windows.Forms.MenuStrip mnuPack;
        private System.Windows.Forms.ToolStripMenuItem ToolmnuAdd;
        private System.Windows.Forms.ToolStripMenuItem ToolmnuEdit;
        private System.Windows.Forms.ToolStripMenuItem ToolmnuRemove;
        private System.Windows.Forms.ToolStripMenuItem ToolmnuClose;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Panel PnlAddModify;
        private System.Windows.Forms.Label LblPackageID;
        private System.Windows.Forms.TextBox TxtWelcome;
        private System.Windows.Forms.ComboBox CmbEdit;
        private System.Windows.Forms.Label LblPackNameValidate;
        private System.Windows.Forms.Label LblProdCodeValidate;
        private System.Windows.Forms.Label LblPackACValidate;
        private System.Windows.Forms.Label LblPackBaseValidate;
        private System.Windows.Forms.Label LblPackDescValidate;
        private System.Windows.Forms.Label LblPackEndValidate;
        private System.Windows.Forms.Label LblPackStartValidate;
        public System.Windows.Forms.Label LblPackProdCode;
        private System.Windows.Forms.Button BtnProdSuppSave;
        private System.Windows.Forms.Button BtnProdSuppGet;
        private System.Windows.Forms.Panel PnlDelete;
        private System.Windows.Forms.Label LblPackRemove;
        private System.Windows.Forms.Button BtnPackDelete;
        private System.Windows.Forms.DataGridView pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgBasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgAgencyCommission;
        private System.Windows.Forms.Button BtnPPSDelete;
        private System.Windows.Forms.ListBox LstPackPrdSpp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblProdSuppName;
        private System.Windows.Forms.ToolStripMenuItem ToolmnuDisplay;
    }
}