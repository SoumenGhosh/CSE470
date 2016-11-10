namespace _370_Final_Project
{
    partial class ADMIN_REGISTER
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.USER_REGISTRATION_PASSWORD = new System.Windows.Forms.TextBox();
            this.USER_REGISTRATION_ID = new System.Windows.Forms.TextBox();
            this.USER_REGISTRATION_BUTTON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.USER_REGISTRATION_TYPE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "USER ID";
            // 
            // USER_REGISTRATION_PASSWORD
            // 
            this.USER_REGISTRATION_PASSWORD.Location = new System.Drawing.Point(266, 306);
            this.USER_REGISTRATION_PASSWORD.Name = "USER_REGISTRATION_PASSWORD";
            this.USER_REGISTRATION_PASSWORD.Size = new System.Drawing.Size(205, 22);
            this.USER_REGISTRATION_PASSWORD.TabIndex = 14;
            // 
            // USER_REGISTRATION_ID
            // 
            this.USER_REGISTRATION_ID.Location = new System.Drawing.Point(266, 219);
            this.USER_REGISTRATION_ID.Name = "USER_REGISTRATION_ID";
            this.USER_REGISTRATION_ID.Size = new System.Drawing.Size(205, 22);
            this.USER_REGISTRATION_ID.TabIndex = 13;
            this.USER_REGISTRATION_ID.TextChanged += new System.EventHandler(this.USER_REGISTRATION_ID_TextChanged);
            // 
            // USER_REGISTRATION_BUTTON
            // 
            this.USER_REGISTRATION_BUTTON.Location = new System.Drawing.Point(300, 477);
            this.USER_REGISTRATION_BUTTON.Name = "USER_REGISTRATION_BUTTON";
            this.USER_REGISTRATION_BUTTON.Size = new System.Drawing.Size(132, 48);
            this.USER_REGISTRATION_BUTTON.TabIndex = 17;
            this.USER_REGISTRATION_BUTTON.Text = "SIGN UP";
            this.USER_REGISTRATION_BUTTON.UseVisualStyleBackColor = true;
            this.USER_REGISTRATION_BUTTON.Click += new System.EventHandler(this.USER_REGISTRATION_BUTTON_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "TYPE";
            // 
            // USER_REGISTRATION_TYPE
            // 
            this.USER_REGISTRATION_TYPE.Location = new System.Drawing.Point(266, 400);
            this.USER_REGISTRATION_TYPE.Name = "USER_REGISTRATION_TYPE";
            this.USER_REGISTRATION_TYPE.Size = new System.Drawing.Size(205, 22);
            this.USER_REGISTRATION_TYPE.TabIndex = 18;
            // 
            // ADMIN_REGISTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 664);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USER_REGISTRATION_TYPE);
            this.Controls.Add(this.USER_REGISTRATION_BUTTON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.USER_REGISTRATION_PASSWORD);
            this.Controls.Add(this.USER_REGISTRATION_ID);
            this.Name = "ADMIN_REGISTER";
            this.Text = "ADMIN_REGISTER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox USER_REGISTRATION_PASSWORD;
        private System.Windows.Forms.TextBox USER_REGISTRATION_ID;
        private System.Windows.Forms.Button USER_REGISTRATION_BUTTON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox USER_REGISTRATION_TYPE;
    }
}