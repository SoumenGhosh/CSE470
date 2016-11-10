namespace _370_Final_Project
{
    partial class HOME
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
            this.label1 = new System.Windows.Forms.Label();
            this.ADMIN_BUTTON = new System.Windows.Forms.Button();
            this.OTHERS_BUTTON = new System.Windows.Forms.Button();
            this.MANAGER_BUTTON = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.USER_LOGIN_PASSWORD = new System.Windows.Forms.TextBox();
            this.USER_LOGIN_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUMEN TECH";
            // 
            // ADMIN_BUTTON
            // 
            this.ADMIN_BUTTON.Location = new System.Drawing.Point(81, 500);
            this.ADMIN_BUTTON.Name = "ADMIN_BUTTON";
            this.ADMIN_BUTTON.Size = new System.Drawing.Size(253, 162);
            this.ADMIN_BUTTON.TabIndex = 1;
            this.ADMIN_BUTTON.Text = "ADMIN";
            this.ADMIN_BUTTON.UseVisualStyleBackColor = true;
            this.ADMIN_BUTTON.Click += new System.EventHandler(this.ADMIN_BUTTON_Click);
            // 
            // OTHERS_BUTTON
            // 
            this.OTHERS_BUTTON.Location = new System.Drawing.Point(886, 500);
            this.OTHERS_BUTTON.Name = "OTHERS_BUTTON";
            this.OTHERS_BUTTON.Size = new System.Drawing.Size(253, 162);
            this.OTHERS_BUTTON.TabIndex = 3;
            this.OTHERS_BUTTON.Text = "OTHERS";
            this.OTHERS_BUTTON.UseVisualStyleBackColor = true;
            this.OTHERS_BUTTON.Click += new System.EventHandler(this.OTHERS_BUTTON_Click);
            // 
            // MANAGER_BUTTON
            // 
            this.MANAGER_BUTTON.Location = new System.Drawing.Point(469, 500);
            this.MANAGER_BUTTON.Name = "MANAGER_BUTTON";
            this.MANAGER_BUTTON.Size = new System.Drawing.Size(253, 162);
            this.MANAGER_BUTTON.TabIndex = 4;
            this.MANAGER_BUTTON.Text = "MANAGER";
            this.MANAGER_BUTTON.UseVisualStyleBackColor = true;
            this.MANAGER_BUTTON.Click += new System.EventHandler(this.MANAGER_BUTTON_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "LOGIN ID";
            // 
            // USER_LOGIN_PASSWORD
            // 
            this.USER_LOGIN_PASSWORD.Location = new System.Drawing.Point(492, 357);
            this.USER_LOGIN_PASSWORD.Name = "USER_LOGIN_PASSWORD";
            this.USER_LOGIN_PASSWORD.PasswordChar = '*';
            this.USER_LOGIN_PASSWORD.Size = new System.Drawing.Size(205, 22);
            this.USER_LOGIN_PASSWORD.TabIndex = 10;
            // 
            // USER_LOGIN_ID
            // 
            this.USER_LOGIN_ID.Location = new System.Drawing.Point(492, 270);
            this.USER_LOGIN_ID.Name = "USER_LOGIN_ID";
            this.USER_LOGIN_ID.Size = new System.Drawing.Size(205, 22);
            this.USER_LOGIN_ID.TabIndex = 9;
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 712);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.USER_LOGIN_PASSWORD);
            this.Controls.Add(this.USER_LOGIN_ID);
            this.Controls.Add(this.MANAGER_BUTTON);
            this.Controls.Add(this.OTHERS_BUTTON);
            this.Controls.Add(this.ADMIN_BUTTON);
            this.Controls.Add(this.label1);
            this.Name = "HOME";
            this.Text = "HOME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ADMIN_BUTTON;
        private System.Windows.Forms.Button OTHERS_BUTTON;
        private System.Windows.Forms.Button MANAGER_BUTTON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox USER_LOGIN_PASSWORD;
        private System.Windows.Forms.TextBox USER_LOGIN_ID;
    }
}