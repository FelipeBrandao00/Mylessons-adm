namespace MyLessons
{
    partial class frmTurmas
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
            this.Alunos = new System.Windows.Forms.Label();
            this.pesquisaAlunos = new System.Windows.Forms.TextBox();
            this.tblAaluno = new System.Windows.Forms.DataGridView();
            this.colRm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnAtribuir = new System.Windows.Forms.Button();
            this.pnlAtirbuirProfessor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTurmas = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.tblProfessorDisciplina = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIniciarImportacao = new System.Windows.Forms.Button();
            this.listaTurmas = new System.Windows.Forms.ListBox();
            this.clAtribuir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNomeTurmas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblAaluno)).BeginInit();
            this.pnlAtirbuirProfessor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProfessorDisciplina)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Alunos
            // 
            this.Alunos.AutoSize = true;
            this.Alunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alunos.Location = new System.Drawing.Point(18, 11);
            this.Alunos.Name = "Alunos";
            this.Alunos.Size = new System.Drawing.Size(69, 24);
            this.Alunos.TabIndex = 0;
            this.Alunos.Text = "Alunos";
            // 
            // pesquisaAlunos
            // 
            this.pesquisaAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaAlunos.ForeColor = System.Drawing.Color.Silver;
            this.pesquisaAlunos.Location = new System.Drawing.Point(93, 9);
            this.pesquisaAlunos.Name = "pesquisaAlunos";
            this.pesquisaAlunos.Size = new System.Drawing.Size(773, 26);
            this.pesquisaAlunos.TabIndex = 2;
            this.pesquisaAlunos.Text = "Search";
            this.pesquisaAlunos.Enter += new System.EventHandler(this.textSearchTurmasEnter);
            this.pesquisaAlunos.Leave += new System.EventHandler(this.textSearchTurmasLeave);
            // 
            // tblAaluno
            // 
            this.tblAaluno.AllowUserToAddRows = false;
            this.tblAaluno.AllowUserToDeleteRows = false;
            this.tblAaluno.AllowUserToResizeColumns = false;
            this.tblAaluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAaluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRm,
            this.colNome,
            this.clEmail});
            this.tblAaluno.Location = new System.Drawing.Point(8, 41);
            this.tblAaluno.MultiSelect = false;
            this.tblAaluno.Name = "tblAaluno";
            this.tblAaluno.ReadOnly = true;
            this.tblAaluno.RowHeadersVisible = false;
            this.tblAaluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblAaluno.Size = new System.Drawing.Size(858, 483);
            this.tblAaluno.TabIndex = 5;
            this.tblAaluno.TabStop = false;
            // 
            // colRm
            // 
            this.colRm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRm.HeaderText = "RM";
            this.colRm.Name = "colRm";
            this.colRm.ReadOnly = true;
            this.colRm.Width = 49;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 60;
            // 
            // clEmail
            // 
            this.clEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clEmail.HeaderText = "Email";
            this.clEmail.Name = "clEmail";
            this.clEmail.ReadOnly = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Location = new System.Drawing.Point(41, 114);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(157, 65);
            this.btnImportar.TabIndex = 8;
            this.btnImportar.Text = "Selecionar Planilhas";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnAtribuir
            // 
            this.btnAtribuir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtribuir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtribuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtribuir.Location = new System.Drawing.Point(41, 43);
            this.btnAtribuir.Name = "btnAtribuir";
            this.btnAtribuir.Size = new System.Drawing.Size(157, 65);
            this.btnAtribuir.TabIndex = 9;
            this.btnAtribuir.Text = "Atribuir Professores";
            this.btnAtribuir.UseVisualStyleBackColor = true;
            this.btnAtribuir.Click += new System.EventHandler(this.btnAtribuir_Click);
            // 
            // pnlAtirbuirProfessor
            // 
            this.pnlAtirbuirProfessor.Controls.Add(this.label2);
            this.pnlAtirbuirProfessor.Controls.Add(this.panel1);
            this.pnlAtirbuirProfessor.Location = new System.Drawing.Point(0, 0);
            this.pnlAtirbuirProfessor.Name = "pnlAtirbuirProfessor";
            this.pnlAtirbuirProfessor.Size = new System.Drawing.Size(1104, 536);
            this.pnlAtirbuirProfessor.TabIndex = 14;
            this.pnlAtirbuirProfessor.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione uma turma para atribuir um professor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbTurmas);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.tblProfessorDisciplina);
            this.panel1.Location = new System.Drawing.Point(247, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 323);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turmas";
            // 
            // cmbTurmas
            // 
            this.cmbTurmas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurmas.FormattingEnabled = true;
            this.cmbTurmas.Location = new System.Drawing.Point(3, 29);
            this.cmbTurmas.Name = "cmbTurmas";
            this.cmbTurmas.Size = new System.Drawing.Size(69, 21);
            this.cmbTurmas.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(320, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(309, 33);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(0, 290);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(305, 33);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // tblProfessorDisciplina
            // 
            this.tblProfessorDisciplina.AllowUserToAddRows = false;
            this.tblProfessorDisciplina.AllowUserToDeleteRows = false;
            this.tblProfessorDisciplina.AllowUserToResizeColumns = false;
            this.tblProfessorDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProfessorDisciplina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clAtribuir,
            this.colNomeTurmas,
            this.colMateria});
            this.tblProfessorDisciplina.Location = new System.Drawing.Point(78, 4);
            this.tblProfessorDisciplina.MultiSelect = false;
            this.tblProfessorDisciplina.Name = "tblProfessorDisciplina";
            this.tblProfessorDisciplina.RowHeadersVisible = false;
            this.tblProfessorDisciplina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProfessorDisciplina.Size = new System.Drawing.Size(548, 280);
            this.tblProfessorDisciplina.TabIndex = 0;
            this.tblProfessorDisciplina.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAtribuir);
            this.groupBox1.Controls.Add(this.btnIniciarImportacao);
            this.groupBox1.Controls.Add(this.listaTurmas);
            this.groupBox1.Controls.Add(this.btnImportar);
            this.groupBox1.Location = new System.Drawing.Point(872, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 526);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // btnIniciarImportacao
            // 
            this.btnIniciarImportacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarImportacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarImportacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarImportacao.Location = new System.Drawing.Point(41, 403);
            this.btnIniciarImportacao.Name = "btnIniciarImportacao";
            this.btnIniciarImportacao.Size = new System.Drawing.Size(157, 65);
            this.btnIniciarImportacao.TabIndex = 10;
            this.btnIniciarImportacao.Text = "Iniciar Importação";
            this.btnIniciarImportacao.UseVisualStyleBackColor = true;
            this.btnIniciarImportacao.Click += new System.EventHandler(this.btnIniciarImportacao_Click);
            // 
            // listaTurmas
            // 
            this.listaTurmas.FormattingEnabled = true;
            this.listaTurmas.Location = new System.Drawing.Point(41, 185);
            this.listaTurmas.Name = "listaTurmas";
            this.listaTurmas.Size = new System.Drawing.Size(157, 212);
            this.listaTurmas.TabIndex = 9;
            // 
            // clAtribuir
            // 
            this.clAtribuir.HeaderText = "atribuir";
            this.clAtribuir.Name = "clAtribuir";
            this.clAtribuir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clAtribuir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colNomeTurmas
            // 
            this.colNomeTurmas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeTurmas.HeaderText = "Nome";
            this.colNomeTurmas.Name = "colNomeTurmas";
            // 
            // colMateria
            // 
            this.colMateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMateria.HeaderText = "Matéria";
            this.colMateria.Name = "colMateria";
            // 
            // frmTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 536);
            this.Controls.Add(this.pnlAtirbuirProfessor);
            this.Controls.Add(this.tblAaluno);
            this.Controls.Add(this.pesquisaAlunos);
            this.Controls.Add(this.Alunos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTurmas";
            this.Text = "frmTurmas";
            ((System.ComponentModel.ISupportInitialize)(this.tblAaluno)).EndInit();
            this.pnlAtirbuirProfessor.ResumeLayout(false);
            this.pnlAtirbuirProfessor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProfessorDisciplina)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Alunos;
        private System.Windows.Forms.TextBox pesquisaAlunos;
        private System.Windows.Forms.DataGridView tblAaluno;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnAtribuir;
        private System.Windows.Forms.Panel pnlAtirbuirProfessor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tblProfessorDisciplina;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listaTurmas;
        private System.Windows.Forms.Button btnIniciarImportacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTurmas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clAtribuir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeTurmas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMateria;
    }
}