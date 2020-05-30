namespace CREATE_ASSITANT_PROGRAM
{
    partial class LoginMain
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
            this.Memberb = new System.Windows.Forms.Button();
            this.Adminb = new System.Windows.Forms.Button();
            this.LoginB = new System.Windows.Forms.Button();
            this.PASSWORDTEXT = new System.Windows.Forms.TextBox();
            this.USERNAMETEXT = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Memberb
            // 
            this.Memberb.BackColor = System.Drawing.Color.Transparent;
            this.Memberb.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F);
            this.Memberb.ForeColor = System.Drawing.Color.Maroon;
            this.Memberb.Location = new System.Drawing.Point(405, 143);
            this.Memberb.Name = "Memberb";
            this.Memberb.Size = new System.Drawing.Size(183, 90);
            this.Memberb.TabIndex = 14;
            this.Memberb.Text = "Member";
            this.Memberb.UseVisualStyleBackColor = false;
            this.Memberb.Click += new System.EventHandler(this.Memberb_Click);
            // 
            // Adminb
            // 
            this.Adminb.BackColor = System.Drawing.Color.Transparent;
            this.Adminb.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F);
            this.Adminb.ForeColor = System.Drawing.Color.Maroon;
            this.Adminb.Location = new System.Drawing.Point(12, 143);
            this.Adminb.Name = "Adminb";
            this.Adminb.Size = new System.Drawing.Size(185, 90);
            this.Adminb.TabIndex = 13;
            this.Adminb.Text = "ADMIN";
            this.Adminb.UseVisualStyleBackColor = false;
            this.Adminb.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginB
            // 
            this.LoginB.BackColor = System.Drawing.Color.Transparent;
            this.LoginB.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F);
            this.LoginB.ForeColor = System.Drawing.Color.Maroon;
            this.LoginB.Location = new System.Drawing.Point(59, 488);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(468, 76);
            this.LoginB.TabIndex = 12;
            this.LoginB.UseVisualStyleBackColor = false;
            this.LoginB.Click += new System.EventHandler(this.button1_Click);
            // 
            // PASSWORDTEXT
            // 
            this.PASSWORDTEXT.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F);
            this.PASSWORDTEXT.Location = new System.Drawing.Point(149, 369);
            this.PASSWORDTEXT.Name = "PASSWORDTEXT";
            this.PASSWORDTEXT.Size = new System.Drawing.Size(350, 49);
            this.PASSWORDTEXT.TabIndex = 11;
            this.PASSWORDTEXT.UseSystemPasswordChar = true;
            this.PASSWORDTEXT.TextChanged += new System.EventHandler(this.PASSWORDTEXT_TextChanged);
            // 
            // USERNAMETEXT
            // 
            this.USERNAMETEXT.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F);
            this.USERNAMETEXT.Location = new System.Drawing.Point(149, 279);
            this.USERNAMETEXT.Name = "USERNAMETEXT";
            this.USERNAMETEXT.Size = new System.Drawing.Size(350, 49);
            this.USERNAMETEXT.TabIndex = 7;
            this.USERNAMETEXT.TextChanged += new System.EventHandler(this.USERNAMETEXT_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CREATE_ASSITANT_PROGRAM.Properties.Resources.login_form_design_vector_19450333;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 619);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 593);
            this.Controls.Add(this.Memberb);
            this.Controls.Add(this.Adminb);
            this.Controls.Add(this.LoginB);
            this.Controls.Add(this.PASSWORDTEXT);
            this.Controls.Add(this.USERNAMETEXT);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.LoginMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Memberb;
        private System.Windows.Forms.Button Adminb;
        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.TextBox PASSWORDTEXT;
        private System.Windows.Forms.TextBox USERNAMETEXT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

