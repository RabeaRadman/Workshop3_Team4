
namespace Workshop3_Team4
{
    partial class ProductsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxProds = new System.Windows.Forms.ListBox();
            this.btnProdExit = new System.Windows.Forms.Button();
            this.btnProdDel = new System.Windows.Forms.Button();
            this.btnProdAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Product ID";
            // 
            // listBoxProds
            // 
            this.listBoxProds.FormattingEnabled = true;
            this.listBoxProds.ItemHeight = 20;
            this.listBoxProds.Location = new System.Drawing.Point(40, 73);
            this.listBoxProds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxProds.Name = "listBoxProds";
            this.listBoxProds.ScrollAlwaysVisible = true;
            this.listBoxProds.Size = new System.Drawing.Size(393, 424);
            this.listBoxProds.TabIndex = 28;
            // 
            // btnProdExit
            // 
            this.btnProdExit.Location = new System.Drawing.Point(331, 525);
            this.btnProdExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProdExit.Name = "btnProdExit";
            this.btnProdExit.Size = new System.Drawing.Size(86, 31);
            this.btnProdExit.TabIndex = 27;
            this.btnProdExit.Text = "&Exit";
            this.btnProdExit.UseVisualStyleBackColor = true;
            this.btnProdExit.Click += new System.EventHandler(this.btnProdExit_Click);
            // 
            // btnProdDel
            // 
            this.btnProdDel.Location = new System.Drawing.Point(197, 525);
            this.btnProdDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProdDel.Name = "btnProdDel";
            this.btnProdDel.Size = new System.Drawing.Size(86, 31);
            this.btnProdDel.TabIndex = 26;
            this.btnProdDel.Text = "&Delete";
            this.btnProdDel.UseVisualStyleBackColor = true;
            this.btnProdDel.Click += new System.EventHandler(this.btnProdDel_Click);
            // 
            // btnProdAdd
            // 
            this.btnProdAdd.Location = new System.Drawing.Point(58, 525);
            this.btnProdAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProdAdd.Name = "btnProdAdd";
            this.btnProdAdd.Size = new System.Drawing.Size(86, 31);
            this.btnProdAdd.TabIndex = 25;
            this.btnProdAdd.Text = "Add/Edit";
            this.btnProdAdd.UseVisualStyleBackColor = true;
            this.btnProdAdd.Click += new System.EventHandler(this.btnProdAdd_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 608);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxProds);
            this.Controls.Add(this.btnProdExit);
            this.Controls.Add(this.btnProdDel);
            this.Controls.Add(this.btnProdAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductsForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProdExit;
        private System.Windows.Forms.Button btnProdDel;
        private System.Windows.Forms.Button btnProdAdd;
        public System.Windows.Forms.ListBox listBoxProds;
    }
}

