namespace _370_Final_Project
{
    partial class MANAGER_LOGIN
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
            this.LOGIN_MANAGER_BUTTON = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MANAGER_LOGIN_PASSWORD = new System.Windows.Forms.TextBox();
            this.MANAGER_LOGIN_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LOGIN_MANAGER_BUTTON
            // 
            this.LOGIN_MANAGER_BUTTON.Location = new System.Drawing.Point(343, 416);
            this.LOGIN_MANAGER_BUTTON.Name = "LOGIN_MANAGER_BUTTON";
            this.LOGIN_MANAGER_BUTTON.Size = new System.Drawing.Size(124, 50);
            this.LOGIN_MANAGER_BUTTON.TabIndex = 9;
            this.LOGIN_MANAGER_BUTTON.Text = "LOGIN";
            this.LOGIN_MANAGER_BUTTON.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "LOGIN ID";
            // 
            // MANAGER_LOGIN_PASSWORD
            // 
            this.MANAGER_LOGIN_PASSWORD.Location = new System.Drawing.Point(306, 307);
            this.MANAGER_LOGIN_PASSWORD.Name = "MANAGER_LOGIN_PASSWORD";
            this.MANAGER_LOGIN_PASSWORD.Size = new System.Drawing.Size(187, 22);
            this.MANAGER_LOGIN_PASSWORD.TabIndex = 6;
            // 
            // MANAGER_LOGIN_ID
            // 
            this.MANAGER_LOGIN_ID.Location = new System.Drawing.Point(306, 216);
            this.MANAGER_LOGIN_ID.Name = "MANAGER_LOGIN_ID";
            this.MANAGER_LOGIN_ID.Size = new System.Drawing.Size(187, 22);
            this.MANAGER_LOGIN_ID.TabIndex = 5;
            // 
            // MANAGER_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 640);
            this.Controls.Add(this.LOGIN_MANAGER_BUTTON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MANAGER_LOGIN_PASSWORD);
            this.Controls.Add(this.MANAGER_LOGIN_ID);
            this.Name = "MANAGER_LOGIN";
            this.Text = "MANAGER LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LOGIN_MANAGER_BUTTON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MANAGER_LOGIN_PASSWORD;
        private System.Windows.Forms.TextBox MANAGER_LOGIN_ID;
    }
}