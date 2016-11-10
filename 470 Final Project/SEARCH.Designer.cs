namespace _370_Final_Project
{
    partial class SEARCH
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
            this.SEARCH_NAME = new System.Windows.Forms.TextBox();
            this.SEARCH_MIN_PRICE = new System.Windows.Forms.TextBox();
            this.SEARCH_MAX_PRICE = new System.Windows.Forms.TextBox();
            this.BY_BRAND = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SEARCH_VIEW = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SEARCH_VIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // SEARCH_NAME
            // 
            this.SEARCH_NAME.Location = new System.Drawing.Point(77, 71);
            this.SEARCH_NAME.Name = "SEARCH_NAME";
            this.SEARCH_NAME.Size = new System.Drawing.Size(611, 22);
            this.SEARCH_NAME.TabIndex = 0;
            this.SEARCH_NAME.TextChanged += new System.EventHandler(this.SEARCH_NAME_TextChanged);
            // 
            // SEARCH_MIN_PRICE
            // 
            this.SEARCH_MIN_PRICE.Location = new System.Drawing.Point(994, 71);
            this.SEARCH_MIN_PRICE.Name = "SEARCH_MIN_PRICE";
            this.SEARCH_MIN_PRICE.Size = new System.Drawing.Size(103, 22);
            this.SEARCH_MIN_PRICE.TabIndex = 1;
            // 
            // SEARCH_MAX_PRICE
            // 
            this.SEARCH_MAX_PRICE.Location = new System.Drawing.Point(1174, 71);
            this.SEARCH_MAX_PRICE.Name = "SEARCH_MAX_PRICE";
            this.SEARCH_MAX_PRICE.Size = new System.Drawing.Size(103, 22);
            this.SEARCH_MAX_PRICE.TabIndex = 2;
            // 
            // BY_BRAND
            // 
            this.BY_BRAND.Location = new System.Drawing.Point(461, 127);
            this.BY_BRAND.Name = "BY_BRAND";
            this.BY_BRAND.Size = new System.Drawing.Size(121, 39);
            this.BY_BRAND.TabIndex = 4;
            this.BY_BRAND.Text = "BY BRAND ";
            this.BY_BRAND.UseVisualStyleBackColor = true;
            this.BY_BRAND.Click += new System.EventHandler(this.BY_BRAND_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "BY MODEL ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "BY CATAGORY ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1026, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "MIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1216, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "MAX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1113, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "PRICE";
            // 
            // SEARCH_VIEW
            // 
            this.SEARCH_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SEARCH_VIEW.Location = new System.Drawing.Point(69, 194);
            this.SEARCH_VIEW.Name = "SEARCH_VIEW";
            this.SEARCH_VIEW.RowTemplate.Height = 24;
            this.SEARCH_VIEW.Size = new System.Drawing.Size(1208, 475);
            this.SEARCH_VIEW.TabIndex = 11;
            // 
            // SEARCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 751);
            this.Controls.Add(this.SEARCH_VIEW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BY_BRAND);
            this.Controls.Add(this.SEARCH_MAX_PRICE);
            this.Controls.Add(this.SEARCH_MIN_PRICE);
            this.Controls.Add(this.SEARCH_NAME);
            this.Name = "SEARCH";
            this.Text = "SEARCH";
            ((System.ComponentModel.ISupportInitialize)(this.SEARCH_VIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SEARCH_NAME;
        private System.Windows.Forms.TextBox SEARCH_MIN_PRICE;
        private System.Windows.Forms.TextBox SEARCH_MAX_PRICE;
        private System.Windows.Forms.Button BY_BRAND;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView SEARCH_VIEW;
    }
}