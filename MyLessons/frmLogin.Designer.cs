namespace MyLessons
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.edtSenhaLogin = new System.Windows.Forms.TextBox();
            this.edtNomeLogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblErroLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // edtSenhaLogin
            // 
            this.edtSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtSenhaLogin.ForeColor = System.Drawing.Color.Silver;
            this.edtSenhaLogin.Location = new System.Drawing.Point(169, 331);
            this.edtSenhaLogin.Name = "edtSenhaLogin";
            this.edtSenhaLogin.Size = new System.Drawing.Size(423, 26);
            this.edtSenhaLogin.TabIndex = 31;
            this.edtSenhaLogin.Text = "Senha";
            this.edtSenhaLogin.Enter += new System.EventHandler(this.textSenhaEnter);
            this.edtSenhaLogin.Leave += new System.EventHandler(this.textSenhaLeave);
            // 
            // edtNomeLogin
            // 
            this.edtNomeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtNomeLogin.ForeColor = System.Drawing.Color.Silver;
            this.edtNomeLogin.Location = new System.Drawing.Point(169, 235);
            this.edtNomeLogin.Name = "edtNomeLogin";
            this.edtNomeLogin.Size = new System.Drawing.Size(423, 26);
            this.edtNomeLogin.TabIndex = 30;
            this.edtNomeLogin.Text = "Nome";
            this.edtNomeLogin.Enter += new System.EventHandler(this.textNameEnter);
            this.edtNomeLogin.Leave += new System.EventHandler(this.textNameLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(721, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // lblErroLogin
            // 
            this.lblErroLogin.AutoSize = true;
            this.lblErroLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroLogin.ForeColor = System.Drawing.Color.Red;
            this.lblErroLogin.Location = new System.Drawing.Point(166, 360);
            this.lblErroLogin.Name = "lblErroLogin";
            this.lblErroLogin.Size = new System.Drawing.Size(149, 13);
            this.lblErroLogin.TabIndex = 28;
            this.lblErroLogin.Text = "( ! ) Nome ou senha incorretos";
            this.lblErroLogin.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 39);
            this.label2.TabIndex = 27;
            this.label2.Text = "Login";
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.Color.White;
            this.btnLogar.Location = new System.Drawing.Point(272, 416);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(227, 47);
            this.btnLogar.TabIndex = 26;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 602);
            this.Controls.Add(this.edtSenhaLogin);
            this.Controls.Add(this.edtNomeLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblErroLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1120, 641);
            this.MinimumSize = new System.Drawing.Size(1120, 641);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyLessons";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtSenhaLogin;
        private System.Windows.Forms.TextBox edtNomeLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblErroLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogar;




    }
}

