using System.Drawing;

namespace AMS_DB_The_Duo
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_pasword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_login.CausesValidation = false;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(417, 114);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(408, 195);
            this.btn_login.TabIndex = 0;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.MouseEnter += new System.EventHandler(this.OnMouseEnterButton1);
            this.btn_login.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton1);
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.Black;
            this.tb_email.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_email.Location = new System.Drawing.Point(417, 348);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(405, 31);
            this.tb_email.TabIndex = 36;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.Black;
            this.tb_password.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_password.Location = new System.Drawing.Point(417, 449);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(405, 31);
            this.tb_password.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(413, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "E-Mail:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(413, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Password:";
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.Transparent;
            this.btn_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signup.FlatAppearance.BorderSize = 0;
            this.btn_signup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_signup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.Color.LightGray;
            this.btn_signup.Location = new System.Drawing.Point(417, 533);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(405, 64);
            this.btn_signup.TabIndex = 40;
            this.btn_signup.Text = "Don\'t have an account? Sign Up.";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_pasword
            // 
            this.btn_pasword.BackColor = System.Drawing.Color.Transparent;
            this.btn_pasword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pasword.FlatAppearance.BorderSize = 0;
            this.btn_pasword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_pasword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_pasword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pasword.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pasword.ForeColor = System.Drawing.Color.LightGray;
            this.btn_pasword.Location = new System.Drawing.Point(417, 594);
            this.btn_pasword.Name = "btn_pasword";
            this.btn_pasword.Size = new System.Drawing.Size(405, 64);
            this.btn_pasword.TabIndex = 41;
            this.btn_pasword.Text = "Forgot Password? Fukc off";
            this.btn_pasword.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_pasword);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.btn_login);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_pasword;
    }
}

