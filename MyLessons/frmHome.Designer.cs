namespace MyLessons
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pnlInicial = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnProfessores = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnPremio = new System.Windows.Forms.Button();
            this.btnTurma = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInicial
            // 
            this.pnlInicial.Controls.Add(this.pictureBox1);
            this.pnlInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInicial.Location = new System.Drawing.Point(0, 66);
            this.pnlInicial.Name = "pnlInicial";
            this.pnlInicial.Size = new System.Drawing.Size(1104, 536);
            this.pnlInicial.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Brown;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.Location = new System.Drawing.Point(1104, 66);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(0, 536);
            this.pnlMenu.TabIndex = 4;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(-1, -1);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(232, 42);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 1;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Firebrick;
            this.pnlTopBar.Controls.Add(this.btnProfessores);
            this.pnlTopBar.Controls.Add(this.btnRanking);
            this.pnlTopBar.Controls.Add(this.btnPremio);
            this.pnlTopBar.Controls.Add(this.btnTurma);
            this.pnlTopBar.Controls.Add(this.picLogo);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1104, 66);
            this.pnlTopBar.TabIndex = 3;
            // 
            // btnProfessores
            // 
            this.btnProfessores.BackColor = System.Drawing.Color.Firebrick;
            this.btnProfessores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfessores.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnProfessores.FlatAppearance.BorderSize = 0;
            this.btnProfessores.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnProfessores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessores.ForeColor = System.Drawing.Color.White;
            this.btnProfessores.Location = new System.Drawing.Point(636, 0);
            this.btnProfessores.Name = "btnProfessores";
            this.btnProfessores.Size = new System.Drawing.Size(116, 66);
            this.btnProfessores.TabIndex = 0;
            this.btnProfessores.Text = "Professores";
            this.btnProfessores.UseVisualStyleBackColor = false;
            this.btnProfessores.Click += new System.EventHandler(this.btnProfessores_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.BackColor = System.Drawing.Color.Firebrick;
            this.btnRanking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRanking.FlatAppearance.BorderSize = 0;
            this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.ForeColor = System.Drawing.Color.White;
            this.btnRanking.Location = new System.Drawing.Point(991, 0);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(101, 66);
            this.btnRanking.TabIndex = 3;
            this.btnRanking.Text = "Ranking";
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btnPremio
            // 
            this.btnPremio.BackColor = System.Drawing.Color.Firebrick;
            this.btnPremio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPremio.FlatAppearance.BorderSize = 0;
            this.btnPremio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPremio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremio.ForeColor = System.Drawing.Color.White;
            this.btnPremio.Location = new System.Drawing.Point(869, 0);
            this.btnPremio.Name = "btnPremio";
            this.btnPremio.Size = new System.Drawing.Size(116, 66);
            this.btnPremio.TabIndex = 2;
            this.btnPremio.Text = "Prêmios";
            this.btnPremio.UseVisualStyleBackColor = false;
            this.btnPremio.Click += new System.EventHandler(this.btnPremio_Click);
            // 
            // btnTurma
            // 
            this.btnTurma.BackColor = System.Drawing.Color.Firebrick;
            this.btnTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTurma.FlatAppearance.BorderSize = 0;
            this.btnTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurma.ForeColor = System.Drawing.Color.White;
            this.btnTurma.Location = new System.Drawing.Point(758, 0);
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(105, 66);
            this.btnTurma.TabIndex = 1;
            this.btnTurma.Text = "Turmas";
            this.btnTurma.UseVisualStyleBackColor = false;
            this.btnTurma.Click += new System.EventHandler(this.btnTurma_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Silver;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 7);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(225, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 602);
            this.Controls.Add(this.pnlInicial);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTopBar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1120, 641);
            this.MinimumSize = new System.Drawing.Size(1120, 641);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyLessons";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing_1);
            this.pnlInicial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInicial;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnProfessores;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btnPremio;
        private System.Windows.Forms.Button btnTurma;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}