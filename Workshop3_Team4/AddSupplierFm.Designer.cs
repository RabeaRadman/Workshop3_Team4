
namespace Workshop3_Team4
{
    partial class AddSupplierFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplierFm));
            this.suplrTB = new System.Windows.Forms.TextBox();
            this.suplrName = new System.Windows.Forms.Label();
            this.addsplBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.supplierIDBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // suplrTB
            // 
            this.suplrTB.Location = new System.Drawing.Point(151, 93);
            this.suplrTB.Name = "suplrTB";
            this.suplrTB.Size = new System.Drawing.Size(243, 27);
            this.suplrTB.TabIndex = 0;
            this.suplrTB.Tag = "Supplier Name";
            // 
            // suplrName
            // 
            this.suplrName.AutoSize = true;
            this.suplrName.Location = new System.Drawing.Point(37, 97);
            this.suplrName.Name = "suplrName";
            this.suplrName.Size = new System.Drawing.Size(108, 20);
            this.suplrName.TabIndex = 1;
            this.suplrName.Text = "Supplier Name";
            // 
            // addsplBtn
            // 
            this.addsplBtn.Location = new System.Drawing.Point(37, 372);
            this.addsplBtn.Name = "addsplBtn";
            this.addsplBtn.Size = new System.Drawing.Size(94, 29);
            this.addsplBtn.TabIndex = 2;
            this.addsplBtn.Text = "Save";
            this.addsplBtn.UseVisualStyleBackColor = true;
            this.addsplBtn.Click += new System.EventHandler(this.addsplBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(305, 372);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(89, 29);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click_1);
            // 
            // supplierIDBx
            // 
            this.supplierIDBx.Location = new System.Drawing.Point(151, 48);
            this.supplierIDBx.Name = "supplierIDBx";
            this.supplierIDBx.Size = new System.Drawing.Size(243, 27);
            this.supplierIDBx.TabIndex = 0;
            this.supplierIDBx.Tag = "SupplierID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suplier ID";
            // 
            // AddSupplierFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(432, 451);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addsplBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suplrName);
            this.Controls.Add(this.supplierIDBx);
            this.Controls.Add(this.suplrTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSupplierFm";
            this.Text = "Add Supplier";
            this.Load += new System.EventHandler(this.AddSupplierFm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox suplrTB;
        private System.Windows.Forms.Label suplrName;
        private System.Windows.Forms.Button addsplBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox supplierIDBx;
        private System.Windows.Forms.Label label1;
    }
}