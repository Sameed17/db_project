namespace AMS_DB_The_Duo
{
    partial class AdminViewFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViewFeedback));
            this.btnNext = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.NumericUpDown();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.tbCustomerInfo = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(874, 390);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(221, 44);
            this.btnNext.TabIndex = 5;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID.AutoSize = true;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbID.Location = new System.Drawing.Point(607, 390);
            this.tbID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(111, 40);
            this.tbID.TabIndex = 7;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrev.BackgroundImage")));
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(195, 390);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(241, 44);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComplete.BackColor = System.Drawing.Color.Transparent;
            this.btnComplete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComplete.BackgroundImage")));
            this.btnComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(195, 467);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(201, 68);
            this.btnComplete.TabIndex = 124;
            this.btnComplete.UseVisualStyleBackColor = false;
            // 
            // tbCustomerInfo
            // 
            this.tbCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCustomerInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tbCustomerInfo.Font = new System.Drawing.Font("LEMON MILK Light", 12F);
            this.tbCustomerInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCustomerInfo.Location = new System.Drawing.Point(195, 193);
            this.tbCustomerInfo.Name = "tbCustomerInfo";
            this.tbCustomerInfo.ReadOnly = true;
            this.tbCustomerInfo.Size = new System.Drawing.Size(900, 191);
            this.tbCustomerInfo.TabIndex = 121;
            this.tbCustomerInfo.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(894, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 68);
            this.button1.TabIndex = 125;
            this.button1.UseVisualStyleBackColor = false;
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
            this.btn_login.Location = new System.Drawing.Point(363, 64);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(585, 123);
            this.btn_login.TabIndex = 126;
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // AdminViewFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AMS_DB_The_Duo.Properties.Resources.Untitled_design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.tbCustomerInfo);
            this.DoubleBuffered = true;
            this.Name = "AdminViewFeedback";
            this.Text = "AdminViewFeedback";
            this.Load += new System.EventHandler(this.AdminViewFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.NumericUpDown tbID;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.RichTextBox tbCustomerInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_login;
    }
}