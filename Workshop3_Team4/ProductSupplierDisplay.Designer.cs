
namespace Workshop3_Team4
{
    partial class FrmProdSuppDisp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdSuppDisp));
            this.LstPackProdSupp = new System.Windows.Forms.ListBox();
            this.LblHdrProdSupp = new System.Windows.Forms.Label();
            this.BtnProdSuppClose = new System.Windows.Forms.Button();
            this.LblProdSuppSelect = new System.Windows.Forms.Label();
            this.BtnprodsuppSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstPackProdSupp
            // 
            this.LstPackProdSupp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LstPackProdSupp.FormattingEnabled = true;
            this.LstPackProdSupp.ItemHeight = 23;
            this.LstPackProdSupp.Location = new System.Drawing.Point(33, 193);
            this.LstPackProdSupp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LstPackProdSupp.Name = "LstPackProdSupp";
            this.LstPackProdSupp.Size = new System.Drawing.Size(1036, 740);
            this.LstPackProdSupp.TabIndex = 0;
            this.LstPackProdSupp.SelectedIndexChanged += new System.EventHandler(this.LstPackProdSupp_SelectedIndexChanged);
            // 
            // LblHdrProdSupp
            // 
            this.LblHdrProdSupp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblHdrProdSupp.Location = new System.Drawing.Point(33, 109);
            this.LblHdrProdSupp.Name = "LblHdrProdSupp";
            this.LblHdrProdSupp.Size = new System.Drawing.Size(1037, 31);
            this.LblHdrProdSupp.TabIndex = 1;
            // 
            // BtnProdSuppClose
            // 
            this.BtnProdSuppClose.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnProdSuppClose.Location = new System.Drawing.Point(984, 13);
            this.BtnProdSuppClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnProdSuppClose.Name = "BtnProdSuppClose";
            this.BtnProdSuppClose.Size = new System.Drawing.Size(86, 47);
            this.BtnProdSuppClose.TabIndex = 2;
            this.BtnProdSuppClose.Text = "&Close";
            this.BtnProdSuppClose.UseVisualStyleBackColor = true;
            this.BtnProdSuppClose.Click += new System.EventHandler(this.BtnProdSuppClose_Click);
            // 
            // LblProdSuppSelect
            // 
            this.LblProdSuppSelect.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblProdSuppSelect.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LblProdSuppSelect.Location = new System.Drawing.Point(33, 21);
            this.LblProdSuppSelect.Name = "LblProdSuppSelect";
            this.LblProdSuppSelect.Size = new System.Drawing.Size(739, 39);
            this.LblProdSuppSelect.TabIndex = 3;
            this.LblProdSuppSelect.Text = "Product Must be Selected";
            // 
            // BtnprodsuppSave
            // 
            this.BtnprodsuppSave.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnprodsuppSave.Location = new System.Drawing.Point(880, 13);
            this.BtnprodsuppSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnprodsuppSave.Name = "BtnprodsuppSave";
            this.BtnprodsuppSave.Size = new System.Drawing.Size(86, 47);
            this.BtnprodsuppSave.TabIndex = 4;
            this.BtnprodsuppSave.Text = "&Save";
            this.BtnprodsuppSave.UseVisualStyleBackColor = true;
            // 
            // FrmProdSuppDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 960);
            this.Controls.Add(this.BtnprodsuppSave);
            this.Controls.Add(this.LblProdSuppSelect);
            this.Controls.Add(this.BtnProdSuppClose);
            this.Controls.Add(this.LblHdrProdSupp);
            this.Controls.Add(this.LstPackProdSupp);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProdSuppDisp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Supplier";
            this.Load += new System.EventHandler(this.FrmProdSuppDisp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox LstPackProdSupp;
        private System.Windows.Forms.Label LblHdrProdSupp;
       // private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button BtnProdSuppClose;
        public System.Windows.Forms.Label LblProdSuppSelect;
        private System.Windows.Forms.Button BtnprodsuppSave;
    }
}