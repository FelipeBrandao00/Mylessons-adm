namespace MyLessons
{
    partial class frmPremios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPremios));
            this.tblPremios = new System.Windows.Forms.DataGridView();
            this.cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPremio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.edtSearch = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.pnlAdicionarEditar = new System.Windows.Forms.Panel();
            this.pnlRetirada = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProcurarAluno = new System.Windows.Forms.Button();
            this.tbmPremioAluno = new System.Windows.Forms.DataGridView();
            this.clPremio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRetirado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarRetirada = new System.Windows.Forms.Button();
            this.btnConfirmarRetirada = new System.Windows.Forms.Button();
            this.txtRm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtPremio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblPremios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAdicionarEditar.SuspendLayout();
            this.pnlRetirada.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbmPremioAluno)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPremios
            // 
            this.tblPremios.AllowUserToAddRows = false;
            this.tblPremios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPremios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cd,
            this.colPremio,
            this.descricao,
            this.colValor,
            this.colQtd});
            this.tblPremios.Location = new System.Drawing.Point(12, 44);
            this.tblPremios.MultiSelect = false;
            this.tblPremios.Name = "tblPremios";
            this.tblPremios.ReadOnly = true;
            this.tblPremios.RowHeadersVisible = false;
            this.tblPremios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPremios.Size = new System.Drawing.Size(864, 480);
            this.tblPremios.TabIndex = 0;
            // 
            // cd
            // 
            this.cd.HeaderText = "CD";
            this.cd.Name = "cd";
            this.cd.ReadOnly = true;
            this.cd.Visible = false;
            // 
            // colPremio
            // 
            this.colPremio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPremio.HeaderText = "Prêmio";
            this.colPremio.Name = "colPremio";
            this.colPremio.ReadOnly = true;
            this.colPremio.Width = 64;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValor.HeaderText = "Valor (esmeraldas)";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colQtd
            // 
            this.colQtd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colQtd.HeaderText = "QTD";
            this.colQtd.Name = "colQtd";
            this.colQtd.ReadOnly = true;
            this.colQtd.Width = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(882, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 515);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // edtSearch
            // 
            this.edtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtSearch.ForeColor = System.Drawing.Color.Silver;
            this.edtSearch.Location = new System.Drawing.Point(12, 12);
            this.edtSearch.Name = "edtSearch";
            this.edtSearch.Size = new System.Drawing.Size(864, 26);
            this.edtSearch.TabIndex = 10;
            this.edtSearch.Text = "Search";
            this.edtSearch.Enter += new System.EventHandler(this.textSearchEnter);
            this.edtSearch.Leave += new System.EventHandler(this.textSearchLeave);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(906, 239);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 65);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(906, 75);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(157, 65);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(906, 400);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(157, 65);
            this.btnRetirar.TabIndex = 14;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // pnlAdicionarEditar
            // 
            this.pnlAdicionarEditar.Controls.Add(this.pnlRetirada);
            this.pnlAdicionarEditar.Controls.Add(this.panel2);
            this.pnlAdicionarEditar.Location = new System.Drawing.Point(0, 1);
            this.pnlAdicionarEditar.Name = "pnlAdicionarEditar";
            this.pnlAdicionarEditar.Size = new System.Drawing.Size(1104, 536);
            this.pnlAdicionarEditar.TabIndex = 15;
            this.pnlAdicionarEditar.Visible = false;
            // 
            // pnlRetirada
            // 
            this.pnlRetirada.Controls.Add(this.panel3);
            this.pnlRetirada.Location = new System.Drawing.Point(0, 1);
            this.pnlRetirada.Name = "pnlRetirada";
            this.pnlRetirada.Size = new System.Drawing.Size(1104, 536);
            this.pnlRetirada.TabIndex = 17;
            this.pnlRetirada.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnProcurarAluno);
            this.panel3.Controls.Add(this.tbmPremioAluno);
            this.panel3.Controls.Add(this.btnCancelarRetirada);
            this.panel3.Controls.Add(this.btnConfirmarRetirada);
            this.panel3.Controls.Add(this.txtRm);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(366, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 394);
            this.panel3.TabIndex = 0;
            // 
            // btnProcurarAluno
            // 
            this.btnProcurarAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurarAluno.Image")));
            this.btnProcurarAluno.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProcurarAluno.Location = new System.Drawing.Point(335, 33);
            this.btnProcurarAluno.Name = "btnProcurarAluno";
            this.btnProcurarAluno.Size = new System.Drawing.Size(31, 27);
            this.btnProcurarAluno.TabIndex = 11;
            this.btnProcurarAluno.UseVisualStyleBackColor = true;
            this.btnProcurarAluno.Click += new System.EventHandler(this.btnProcurarAluno_Click);
            // 
            // tbmPremioAluno
            // 
            this.tbmPremioAluno.AllowUserToAddRows = false;
            this.tbmPremioAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbmPremioAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clPremio,
            this.clNome,
            this.clRetirado});
            this.tbmPremioAluno.Location = new System.Drawing.Point(7, 79);
            this.tbmPremioAluno.MultiSelect = false;
            this.tbmPremioAluno.Name = "tbmPremioAluno";
            this.tbmPremioAluno.ReadOnly = true;
            this.tbmPremioAluno.RowHeadersVisible = false;
            this.tbmPremioAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbmPremioAluno.Size = new System.Drawing.Size(356, 261);
            this.tbmPremioAluno.TabIndex = 10;
            // 
            // clPremio
            // 
            this.clPremio.HeaderText = "cd";
            this.clPremio.Name = "clPremio";
            this.clPremio.ReadOnly = true;
            this.clPremio.Visible = false;
            // 
            // clNome
            // 
            this.clNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNome.HeaderText = "Nome";
            this.clNome.Name = "clNome";
            this.clNome.ReadOnly = true;
            // 
            // clRetirado
            // 
            this.clRetirado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clRetirado.HeaderText = "Retirado";
            this.clRetirado.MaxInputLength = 4;
            this.clRetirado.Name = "clRetirado";
            this.clRetirado.ReadOnly = true;
            this.clRetirado.Width = 72;
            // 
            // btnCancelarRetirada
            // 
            this.btnCancelarRetirada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRetirada.Location = new System.Drawing.Point(186, 361);
            this.btnCancelarRetirada.Name = "btnCancelarRetirada";
            this.btnCancelarRetirada.Size = new System.Drawing.Size(186, 33);
            this.btnCancelarRetirada.TabIndex = 9;
            this.btnCancelarRetirada.Text = "Cancelar";
            this.btnCancelarRetirada.UseVisualStyleBackColor = true;
            this.btnCancelarRetirada.Click += new System.EventHandler(this.btnCancelarRetirada_Click_1);
            // 
            // btnConfirmarRetirada
            // 
            this.btnConfirmarRetirada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarRetirada.Location = new System.Drawing.Point(0, 361);
            this.btnConfirmarRetirada.Name = "btnConfirmarRetirada";
            this.btnConfirmarRetirada.Size = new System.Drawing.Size(180, 33);
            this.btnConfirmarRetirada.TabIndex = 8;
            this.btnConfirmarRetirada.Text = "Confirmar";
            this.btnConfirmarRetirada.UseVisualStyleBackColor = true;
            this.btnConfirmarRetirada.Click += new System.EventHandler(this.btnConfirmarRetirada_Click);
            // 
            // txtRm
            // 
            this.txtRm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRm.Location = new System.Drawing.Point(7, 33);
            this.txtRm.MaxLength = 5;
            this.txtRm.Name = "txtRm";
            this.txtRm.Size = new System.Drawing.Size(329, 26);
            this.txtRm.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "RM:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtQuantidade);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.txtDescricao);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.txtPremio);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(366, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 394);
            this.panel2.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(7, 172);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(356, 26);
            this.txtQuantidade.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(186, 361);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(186, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(0, 361);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(180, 33);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(7, 246);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(356, 94);
            this.txtDescricao.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(7, 102);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(356, 26);
            this.txtValor.TabIndex = 3;
            // 
            // txtPremio
            // 
            this.txtPremio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPremio.Location = new System.Drawing.Point(7, 33);
            this.txtPremio.Name = "txtPremio";
            this.txtPremio.Size = new System.Drawing.Size(356, 26);
            this.txtPremio.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor (esmeraldas):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prêmio:";
            // 
            // frmPremios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 536);
            this.Controls.Add(this.pnlAdicionarEditar);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.edtSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tblPremios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPremios";
            this.Text = "frmPremios";
            this.Load += new System.EventHandler(this.frmPremios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPremios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAdicionarEditar.ResumeLayout(false);
            this.pnlRetirada.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbmPremioAluno)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox edtSearch;
        private System.Windows.Forms.DataGridView tblPremios;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Panel pnlAdicionarEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtPremio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlRetirada;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProcurarAluno;
        private System.Windows.Forms.DataGridView tbmPremioAluno;
        private System.Windows.Forms.Button btnCancelarRetirada;
        private System.Windows.Forms.Button btnConfirmarRetirada;
        private System.Windows.Forms.TextBox txtRm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPremio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPremio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRetirado;
    }
}