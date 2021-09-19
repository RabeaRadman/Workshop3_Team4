
namespace Workshop3_Team4
{
    partial class AddProdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProdForm));
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.btnAddProdCancel = new System.Windows.Forms.Button();
            this.btnAddProdOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(149, 88);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(263, 27);
            this.txtProdName.TabIndex = 17;
            // 
            // btnAddProdCancel
            // 
            this.btnAddProdCancel.Location = new System.Drawing.Point(327, 169);
            this.btnAddProdCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProdCancel.Name = "btnAddProdCancel";
            this.btnAddProdCancel.Size = new System.Drawing.Size(86, 31);
            this.btnAddProdCancel.TabIndex = 15;
            this.btnAddProdCancel.Text = "Cancel";
            this.btnAddProdCancel.UseVisualStyleBackColor = true;
            this.btnAddProdCancel.Click += new System.EventHandler(this.btnAddProdCancel_Click);
            // 
            // btnAddProdOK
            // 
            this.btnAddProdOK.Location = new System.Drawing.Point(149, 169);
            this.btnAddProdOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProdOK.Name = "btnAddProdOK";
            this.btnAddProdOK.Size = new System.Drawing.Size(86, 31);
            this.btnAddProdOK.TabIndex = 14;
            this.btnAddProdOK.Text = "OK";
            this.btnAddProdOK.UseVisualStyleBackColor = true;
            this.btnAddProdOK.Click += new System.EventHandler(this.btnAddProdOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product Name:";
            // 
            // AddProdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 311);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.btnAddProdCancel);
            this.Controls.Add(this.btnAddProdOK);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddProdForm";
            this.Text = "Add Products";
            this.Load += new System.EventHandler(this.AddProdForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Button btnAddProdCancel;
        private System.Windows.Forms.Button btnAddProdOK;
        private System.Windows.Forms.Label label2;
    }
}