
namespace Workshop3_Team4
{
    partial class ModProdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModProdForm));
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.btnModProdCancel = new System.Windows.Forms.Button();
            this.btnModProdOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(143, 80);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(188, 27);
            this.txtProdName.TabIndex = 23;
            // 
            // txtProdID
            // 
            this.txtProdID.Location = new System.Drawing.Point(143, 32);
            this.txtProdID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(114, 27);
            this.txtProdID.TabIndex = 22;
            // 
            // btnModProdCancel
            // 
            this.btnModProdCancel.Location = new System.Drawing.Point(245, 139);
            this.btnModProdCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModProdCancel.Name = "btnModProdCancel";
            this.btnModProdCancel.Size = new System.Drawing.Size(86, 31);
            this.btnModProdCancel.TabIndex = 21;
            this.btnModProdCancel.Text = "Cancel";
            this.btnModProdCancel.UseVisualStyleBackColor = true;
            this.btnModProdCancel.Click += new System.EventHandler(this.btnModProdCancel_Click);
            // 
            // btnModProdOK
            // 
            this.btnModProdOK.Location = new System.Drawing.Point(43, 139);
            this.btnModProdOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModProdOK.Name = "btnModProdOK";
            this.btnModProdOK.Size = new System.Drawing.Size(86, 31);
            this.btnModProdOK.TabIndex = 20;
            this.btnModProdOK.Text = "OK";
            this.btnModProdOK.UseVisualStyleBackColor = true;
            this.btnModProdOK.Click += new System.EventHandler(this.btnModProdOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Product ID:";
            // 
            // ModProdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(381, 243);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.btnModProdCancel);
            this.Controls.Add(this.btnModProdOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModProdForm";
            this.Text = "Modify Products";
            this.Load += new System.EventHandler(this.ModProdForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtProdName;
        public System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.Button btnModProdCancel;
        private System.Windows.Forms.Button btnModProdOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}