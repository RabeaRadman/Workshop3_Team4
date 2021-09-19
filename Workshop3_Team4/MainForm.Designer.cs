
namespace Workshop3_Team4
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.BtnOpenPackages = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.displayallBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.PaleGreen;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProducts.ForeColor = System.Drawing.Color.Black;
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.Location = new System.Drawing.Point(465, 146);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(174, 172);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "&Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(407, 509);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 89);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BtnOpenPackages
            // 
            this.BtnOpenPackages.BackColor = System.Drawing.Color.Azure;
            this.BtnOpenPackages.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnOpenPackages.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpenPackages.Image")));
            this.BtnOpenPackages.Location = new System.Drawing.Point(280, 146);
            this.BtnOpenPackages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOpenPackages.Name = "BtnOpenPackages";
            this.BtnOpenPackages.Size = new System.Drawing.Size(179, 172);
            this.BtnOpenPackages.TabIndex = 0;
            this.BtnOpenPackages.Text = "P&ackages";
            this.BtnOpenPackages.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnOpenPackages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnOpenPackages.UseVisualStyleBackColor = false;
            this.BtnOpenPackages.Click += new System.EventHandler(this.BtnOpenPackages_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuppliers.Image = ((System.Drawing.Image)(resources.GetObject("btnSuppliers.Image")));
            this.btnSuppliers.Location = new System.Drawing.Point(280, 326);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(179, 156);
            this.btnSuppliers.TabIndex = 2;
            this.btnSuppliers.Text = "&Suppliers";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "TRAVEL EXPERTS ADMINISTRATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayallBtn
            // 
            this.displayallBtn.BackColor = System.Drawing.Color.Azure;
            this.displayallBtn.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.displayallBtn.Image = ((System.Drawing.Image)(resources.GetObject("displayallBtn.Image")));
            this.displayallBtn.Location = new System.Drawing.Point(465, 326);
            this.displayallBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.displayallBtn.Name = "displayallBtn";
            this.displayallBtn.Size = new System.Drawing.Size(174, 156);
            this.displayallBtn.TabIndex = 3;
            this.displayallBtn.Text = "&Display All";
            this.displayallBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.displayallBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.displayallBtn.UseVisualStyleBackColor = false;
            this.displayallBtn.Click += new System.EventHandler(this.displayallBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 681);
            this.Controls.Add(this.BtnOpenPackages);
            this.Controls.Add(this.displayallBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Travel Experts ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button BtnOpenPackages;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button displayallBtn;
    }
}