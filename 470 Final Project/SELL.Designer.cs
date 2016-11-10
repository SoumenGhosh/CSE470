namespace _370_Final_Project
{
    partial class SELL
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
            this.SELL_PRODUCT_ID = new System.Windows.Forms.TextBox();
            this.SELL_DATE_BOX = new System.Windows.Forms.TextBox();
            this.SELL_PRICE = new System.Windows.Forms.TextBox();
            this.SELL_QUANTITY = new System.Windows.Forms.TextBox();
            this.SELL_EMPLOYEE_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SELL_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SELL_PRODUCT_ID
            // 
            this.SELL_PRODUCT_ID.Location = new System.Drawing.Point(439, 114);
            this.SELL_PRODUCT_ID.Name = "SELL_PRODUCT_ID";
            this.SELL_PRODUCT_ID.Size = new System.Drawing.Size(100, 22);
            this.SELL_PRODUCT_ID.TabIndex = 0;
            this.SELL_PRODUCT_ID.TextChanged += new System.EventHandler(this.SELL_PRODUCT_ID_TextChanged);
            // 
            // SELL_DATE_BOX
            // 
            this.SELL_DATE_BOX.Location = new System.Drawing.Point(439, 359);
            this.SELL_DATE_BOX.Name = "SELL_DATE_BOX";
            this.SELL_DATE_BOX.Size = new System.Drawing.Size(100, 22);
            this.SELL_DATE_BOX.TabIndex = 1;
            // 
            // SELL_PRICE
            // 
            this.SELL_PRICE.Location = new System.Drawing.Point(439, 194);
            this.SELL_PRICE.Name = "SELL_PRICE";
            this.SELL_PRICE.Size = new System.Drawing.Size(100, 22);
            this.SELL_PRICE.TabIndex = 1;
            // 
            // SELL_QUANTITY
            // 
            this.SELL_QUANTITY.Location = new System.Drawing.Point(439, 269);
            this.SELL_QUANTITY.Name = "SELL_QUANTITY";
            this.SELL_QUANTITY.Size = new System.Drawing.Size(100, 22);
            this.SELL_QUANTITY.TabIndex = 2;
            // 
            // SELL_EMPLOYEE_ID
            // 
            this.SELL_EMPLOYEE_ID.Location = new System.Drawing.Point(439, 436);
            this.SELL_EMPLOYEE_ID.Name = "SELL_EMPLOYEE_ID";
            this.SELL_EMPLOYEE_ID.Size = new System.Drawing.Size(100, 22);
            this.SELL_EMPLOYEE_ID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "PRODUCT ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "SELL PRICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "QUANTITY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "DATE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "EMPLOYEE ID";
            // 
            // SELL_OK
            // 
            this.SELL_OK.Location = new System.Drawing.Point(724, 531);
            this.SELL_OK.Name = "SELL_OK";
            this.SELL_OK.Size = new System.Drawing.Size(178, 82);
            this.SELL_OK.TabIndex = 9;
            this.SELL_OK.Text = "OK";
            this.SELL_OK.UseVisualStyleBackColor = true;
            this.SELL_OK.Click += new System.EventHandler(this.SELL_OK_Click);
            // 
            // SELL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 724);
            this.Controls.Add(this.SELL_OK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SELL_EMPLOYEE_ID);
            this.Controls.Add(this.SELL_QUANTITY);
            this.Controls.Add(this.SELL_PRICE);
            this.Controls.Add(this.SELL_DATE_BOX);
            this.Controls.Add(this.SELL_PRODUCT_ID);
            this.Name = "SELL";
            this.Text = "SELL";
            this.Load += new System.EventHandler(this.SELL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SELL_PRODUCT_ID;
        private System.Windows.Forms.TextBox SELL_DATE_BOX;
        private System.Windows.Forms.TextBox SELL_PRICE;
        private System.Windows.Forms.TextBox SELL_QUANTITY;
        private System.Windows.Forms.TextBox SELL_EMPLOYEE_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SELL_OK;
    }
}