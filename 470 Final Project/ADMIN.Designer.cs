namespace _370_Final_Project
{
    partial class ADMIN
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
            this.ADMIN_LOGIN_ID = new System.Windows.Forms.TextBox();
            this.ADMIN_LOGIN_PASSWORD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LOGIN_ADMIN_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ADMIN_LOGIN_ID
            // 
            this.ADMIN_LOGIN_ID.Location = new System.Drawing.Point(322, 176);
            this.ADMIN_LOGIN_ID.Name = "ADMIN_LOGIN_ID";
            this.ADMIN_LOGIN_ID.Size = new System.Drawing.Size(187, 22);
            this.ADMIN_LOGIN_ID.TabIndex = 0;
            // 
            // ADMIN_LOGIN_PASSWORD
            // 
            this.ADMIN_LOGIN_PASSWORD.Location = new System.Drawing.Point(322, 267);
            this.ADMIN_LOGIN_PASSWORD.Name = "ADMIN_LOGIN_PASSWORD";
            this.ADMIN_LOGIN_PASSWORD.Size = new System.Drawing.Size(187, 22);
            this.ADMIN_LOGIN_PASSWORD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "PASSWORD";
            // 
            // LOGIN_ADMIN_BUTTON
            // 
            this.LOGIN_ADMIN_BUTTON.Location = new System.Drawing.Point(359, 376);
            this.LOGIN_ADMIN_BUTTON.Name = "LOGIN_ADMIN_BUTTON";
            this.LOGIN_ADMIN_BUTTON.Size = new System.Drawing.Size(124, 50);
            this.LOGIN_ADMIN_BUTTON.TabIndex = 4;
            this.LOGIN_ADMIN_BUTTON.Text = "LOGIN";
            this.LOGIN_ADMIN_BUTTON.UseVisualStyleBackColor = true;
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 697);
            this.Controls.Add(this.LOGIN_ADMIN_BUTTON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ADMIN_LOGIN_PASSWORD);
            this.Controls.Add(this.ADMIN_LOGIN_ID);
            this.Name = "ADMIN";
            this.Text = "ADMIN LOGIN";
            this.Load += new System.EventHandler(this.ADMIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ADMIN_LOGIN_ID;
        private System.Windows.Forms.TextBox ADMIN_LOGIN_PASSWORD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LOGIN_ADMIN_BUTTON;
    }
}