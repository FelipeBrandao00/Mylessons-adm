namespace MyLessons
{
    partial class frmProfessores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessores));
            this.tblProfessores = new System.Windows.Forms.DataGridView();
            this.colRm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edtSearch = new System.Windows.Forms.TextBox();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxDisciplina = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeProf = new System.Windows.Forms.TextBox();
            this.txtCdProf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlAdicionar = new System.Windows.Forms.Panel();
            this.pnlDisciplina = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxAtribuirDisciplina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaDisciplina = new System.Windows.Forms.Button();
            this.btnCancelarDisciplina = new System.Windows.Forms.Button();
            this.btnConfirmarDisciplina = new System.Windows.Forms.Button();
            this.txtProfessorAtribuir = new System.Windows.Forms.TextBox();
            this.btnAtribuir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblProfessores)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlAdicionar.SuspendLayout();
            this.pnlDisciplina.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblProfessores
            // 
            this.tblProfessores.AllowUserToAddRows = false;
            this.tblProfessores.AllowUserToDeleteRows = false;
            this.tblProfessores.AllowUserToResizeColumns = false;
            this.tblProfessores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProfessores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRm,
            this.colNome,
            this.colEmail,
            this.colSituacao});
            this.tblProfessores.Location = new System.Drawing.Point(12, 83);
            this.tblProfessores.MultiSelect = false;
            this.tblProfessores.Name = "tblProfessores";
            this.tblProfessores.ReadOnly = true;
            this.tblProfessores.RowHeadersVisible = false;
            this.tblProfessores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProfessores.Size = new System.Drawing.Size(1080, 441);
            this.tblProfessores.TabIndex = 0;
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
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colSituacao
            // 
            this.colSituacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSituacao.HeaderText = "Situação";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            this.colSituacao.Width = 74;
            // 
            // edtSearch
            // 
            this.edtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtSearch.ForeColor = System.Drawing.Color.Silver;
            this.edtSearch.Location = new System.Drawing.Point(12, 26);
            this.edtSearch.Name = "edtSearch";
            this.edtSearch.Size = new System.Drawing.Size(755, 26);
            this.edtSearch.TabIndex = 1;
            this.edtSearch.Text = "Search";
            this.edtSearch.Enter += new System.EventHandler(this.textSearchEnter);
            this.edtSearch.Leave += new System.EventHandler(this.textSearchLeave);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesativar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesativar.Location = new System.Drawing.Point(896, 12);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(95, 55);
            this.btnDesativar.TabIndex = 2;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.UseVisualStyleBackColor = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(795, 12);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(95, 55);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbxDisciplina);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtNomeProf);
            this.panel2.Controls.Add(this.txtCdProf);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(364, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 342);
            this.panel2.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(186, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(186, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(0, 310);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(180, 33);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(7, 246);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(356, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email::";
            // 
            // cbxDisciplina
            // 
            this.cbxDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDisciplina.FormattingEnabled = true;
            this.cbxDisciplina.Location = new System.Drawing.Point(7, 172);
            this.cbxDisciplina.Name = "cbxDisciplina";
            this.cbxDisciplina.Size = new System.Drawing.Size(356, 28);
            this.cbxDisciplina.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Disciplina:";
            // 
            // txtNomeProf
            // 
            this.txtNomeProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProf.Location = new System.Drawing.Point(7, 102);
            this.txtNomeProf.Name = "txtNomeProf";
            this.txtNomeProf.Size = new System.Drawing.Size(356, 26);
            this.txtNomeProf.TabIndex = 3;
            // 
            // txtCdProf
            // 
            this.txtCdProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCdProf.Location = new System.Drawing.Point(7, 33);
            this.txtCdProf.Name = "txtCdProf";
            this.txtCdProf.Size = new System.Drawing.Size(356, 26);
            this.txtCdProf.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "RM:";
            // 
            // pnlAdicionar
            // 
            this.pnlAdicionar.Controls.Add(this.panel2);
            this.pnlAdicionar.Location = new System.Drawing.Point(0, 0);
            this.pnlAdicionar.Name = "pnlAdicionar";
            this.pnlAdicionar.Size = new System.Drawing.Size(1104, 536);
            this.pnlAdicionar.TabIndex = 14;
            this.pnlAdicionar.Visible = false;
            // 
            // pnlDisciplina
            // 
            this.pnlDisciplina.Controls.Add(this.panel3);
            this.pnlDisciplina.Location = new System.Drawing.Point(0, 0);
            this.pnlDisciplina.Name = "pnlDisciplina";
            this.pnlDisciplina.Size = new System.Drawing.Size(1104, 536);
            this.pnlDisciplina.TabIndex = 15;
            this.pnlDisciplina.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbxAtribuirDisciplina);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnBuscaDisciplina);
            this.panel3.Controls.Add(this.btnCancelarDisciplina);
            this.panel3.Controls.Add(this.btnConfirmarDisciplina);
            this.panel3.Controls.Add(this.txtProfessorAtribuir);
            this.panel3.Location = new System.Drawing.Point(364, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 196);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Disciplina:";
            // 
            // cbxAtribuirDisciplina
            // 
            this.cbxAtribuirDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAtribuirDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAtribuirDisciplina.FormattingEnabled = true;
            this.cbxAtribuirDisciplina.Location = new System.Drawing.Point(7, 106);
            this.cbxAtribuirDisciplina.Name = "cbxAtribuirDisciplina";
            this.cbxAtribuirDisciplina.Size = new System.Drawing.Size(356, 28);
            this.cbxAtribuirDisciplina.TabIndex = 13;
            this.cbxAtribuirDisciplina.SelectedIndexChanged += new System.EventHandler(this.cbxAtribuirDisciplina_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome:";
            // 
            // btnBuscaDisciplina
            // 
            this.btnBuscaDisciplina.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaDisciplina.Image")));
            this.btnBuscaDisciplina.Location = new System.Drawing.Point(332, 33);
            this.btnBuscaDisciplina.Name = "btnBuscaDisciplina";
            this.btnBuscaDisciplina.Size = new System.Drawing.Size(31, 26);
            this.btnBuscaDisciplina.TabIndex = 11;
            this.btnBuscaDisciplina.UseVisualStyleBackColor = true;
            // 
            // btnCancelarDisciplina
            // 
            this.btnCancelarDisciplina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDisciplina.Location = new System.Drawing.Point(186, 163);
            this.btnCancelarDisciplina.Name = "btnCancelarDisciplina";
            this.btnCancelarDisciplina.Size = new System.Drawing.Size(186, 33);
            this.btnCancelarDisciplina.TabIndex = 9;
            this.btnCancelarDisciplina.Text = "Cancelar";
            this.btnCancelarDisciplina.UseVisualStyleBackColor = true;
            this.btnCancelarDisciplina.Click += new System.EventHandler(this.btnCancelarDisciplina_Click);
            // 
            // btnConfirmarDisciplina
            // 
            this.btnConfirmarDisciplina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarDisciplina.Enabled = false;
            this.btnConfirmarDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarDisciplina.Location = new System.Drawing.Point(0, 163);
            this.btnConfirmarDisciplina.Name = "btnConfirmarDisciplina";
            this.btnConfirmarDisciplina.Size = new System.Drawing.Size(180, 33);
            this.btnConfirmarDisciplina.TabIndex = 8;
            this.btnConfirmarDisciplina.Text = "Confirmar";
            this.btnConfirmarDisciplina.UseVisualStyleBackColor = true;
            this.btnConfirmarDisciplina.Click += new System.EventHandler(this.btnConfirmarDisciplina_Click);
            // 
            // txtProfessorAtribuir
            // 
            this.txtProfessorAtribuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfessorAtribuir.Location = new System.Drawing.Point(7, 33);
            this.txtProfessorAtribuir.Name = "txtProfessorAtribuir";
            this.txtProfessorAtribuir.ReadOnly = true;
            this.txtProfessorAtribuir.Size = new System.Drawing.Size(329, 26);
            this.txtProfessorAtribuir.TabIndex = 2;
            // 
            // btnAtribuir
            // 
            this.btnAtribuir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtribuir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtribuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtribuir.Location = new System.Drawing.Point(997, 12);
            this.btnAtribuir.Name = "btnAtribuir";
            this.btnAtribuir.Size = new System.Drawing.Size(95, 55);
            this.btnAtribuir.TabIndex = 16;
            this.btnAtribuir.Text = "Atribuir\r\nDisciplina\r\n";
            this.btnAtribuir.UseVisualStyleBackColor = true;
            this.btnAtribuir.Click += new System.EventHandler(this.btnAtribuir_Click_1);
            // 
            // frmProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 536);
            this.Controls.Add(this.pnlDisciplina);
            this.Controls.Add(this.pnlAdicionar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.edtSearch);
            this.Controls.Add(this.tblProfessores);
            this.Controls.Add(this.btnAtribuir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfessores";
            this.Text = "frmProfessores";
            this.Load += new System.EventHandler(this.frmProfessores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProfessores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlAdicionar.ResumeLayout(false);
            this.pnlDisciplina.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblProfessores;
        private System.Windows.Forms.TextBox edtSearch;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxDisciplina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeProf;
        private System.Windows.Forms.TextBox txtCdProf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlAdicionar;
        private System.Windows.Forms.Panel pnlDisciplina;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBuscaDisciplina;
        private System.Windows.Forms.Button btnCancelarDisciplina;
        private System.Windows.Forms.Button btnConfirmarDisciplina;
        private System.Windows.Forms.Button btnAtribuir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxAtribuirDisciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfessorAtribuir;
    }
}