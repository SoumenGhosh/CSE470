namespace _370_Final_Project
{
    partial class OTHERS
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
            this.SEARCH_BUTTON = new System.Windows.Forms.Button();
            this.SELL_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SEARCH_BUTTON
            // 
            this.SEARCH_BUTTON.Location = new System.Drawing.Point(88, 300);
            this.SEARCH_BUTTON.Name = "SEARCH_BUTTON";
            this.SEARCH_BUTTON.Size = new System.Drawing.Size(334, 172);
            this.SEARCH_BUTTON.TabIndex = 0;
            this.SEARCH_BUTTON.Text = "SEARCH";
            this.SEARCH_BUTTON.UseVisualStyleBackColor = true;
            this.SEARCH_BUTTON.Click += new System.EventHandler(this.SEARCH_BUTTON_Click);
            // 
            // SELL_BUTTON
            // 
            this.SELL_BUTTON.Location = new System.Drawing.Point(772, 300);
            this.SELL_BUTTON.Name = "SELL_BUTTON";
            this.SELL_BUTTON.Size = new System.Drawing.Size(334, 172);
            this.SELL_BUTTON.TabIndex = 1;
            this.SELL_BUTTON.Text = "SELL";
            this.SELL_BUTTON.UseVisualStyleBackColor = true;
            this.SELL_BUTTON.Click += new System.EventHandler(this.SELL_BUTTON_Click);
            // 
            // OTHERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 722);
            this.Controls.Add(this.SELL_BUTTON);
            this.Controls.Add(this.SEARCH_BUTTON);
            this.Name = "OTHERS";
            this.Text = "OTHERS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SEARCH_BUTTON;
        private System.Windows.Forms.Button SELL_BUTTON;
    }
}