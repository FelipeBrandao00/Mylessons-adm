namespace MyLessons
{
    partial class frmRanking
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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbxTurmas = new System.Windows.Forms.ComboBox();
            this.cbxFiltros = new System.Windows.Forms.ComboBox();
            this.tblRanking = new System.Windows.Forms.DataGridView();
            this.clposicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEsmeraldas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edtSearch = new System.Windows.Forms.TextBox();
            this.bntBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(964, 11);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(128, 28);
            this.btnFiltrar.TabIndex = 0;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbxTurmas
            // 
            this.cbxTurmas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTurmas.FormattingEnabled = true;
            this.cbxTurmas.Location = new System.Drawing.Point(12, 10);
            this.cbxTurmas.Name = "cbxTurmas";
            this.cbxTurmas.Size = new System.Drawing.Size(61, 28);
            this.cbxTurmas.TabIndex = 4;
            // 
            // cbxFiltros
            // 
            this.cbxFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFiltros.Items.AddRange(new object[] {
            "Xp",
            "Esmeralda"});
            this.cbxFiltros.Location = new System.Drawing.Point(827, 11);
            this.cbxFiltros.Name = "cbxFiltros";
            this.cbxFiltros.Size = new System.Drawing.Size(119, 28);
            this.cbxFiltros.TabIndex = 5;
            // 
            // tblRanking
            // 
            this.tblRanking.AllowUserToAddRows = false;
            this.tblRanking.AllowUserToDeleteRows = false;
            this.tblRanking.AllowUserToResizeColumns = false;
            this.tblRanking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clposicao,
            this.colTurma,
            this.colNome,
            this.colEsmeraldas,
            this.colXp});
            this.tblRanking.Location = new System.Drawing.Point(12, 44);
            this.tblRanking.Name = "tblRanking";
            this.tblRanking.ReadOnly = true;
            this.tblRanking.RowHeadersVisible = false;
            this.tblRanking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblRanking.Size = new System.Drawing.Size(1080, 480);
            this.tblRanking.TabIndex = 6;
            // 
            // clposicao
            // 
            this.clposicao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clposicao.HeaderText = "Posição";
            this.clposicao.Name = "clposicao";
            this.clposicao.ReadOnly = true;
            this.clposicao.Width = 70;
            // 
            // colTurma
            // 
            this.colTurma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTurma.HeaderText = "Turma";
            this.colTurma.Name = "colTurma";
            this.colTurma.ReadOnly = true;
            this.colTurma.Width = 62;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colEsmeraldas
            // 
            this.colEsmeraldas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEsmeraldas.HeaderText = "Esmeraldas";
            this.colEsmeraldas.Name = "colEsmeraldas";
            this.colEsmeraldas.ReadOnly = true;
            // 
            // colXp
            // 
            this.colXp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colXp.HeaderText = "XP";
            this.colXp.Name = "colXp";
            this.colXp.ReadOnly = true;
            // 
            // edtSearch
            // 
            this.edtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtSearch.ForeColor = System.Drawing.Color.Silver;
            this.edtSearch.Location = new System.Drawing.Point(79, 10);
            this.edtSearch.Name = "edtSearch";
            this.edtSearch.Size = new System.Drawing.Size(722, 26);
            this.edtSearch.TabIndex = 7;
            this.edtSearch.Text = "Search";
            this.edtSearch.Enter += new System.EventHandler(this.edtSearch_Enter);
            this.edtSearch.Leave += new System.EventHandler(this.edtSearch_Leave);
            // 
            // bntBuscar
            // 
            this.bntBuscar.Location = new System.Drawing.Point(737, 13);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(63, 20);
            this.bntBuscar.TabIndex = 8;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // frmRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 536);
            this.Controls.Add(this.bntBuscar);
            this.Controls.Add(this.edtSearch);
            this.Controls.Add(this.tblRanking);
            this.Controls.Add(this.cbxFiltros);
            this.Controls.Add(this.cbxTurmas);
            this.Controls.Add(this.btnFiltrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRanking";
            this.Text = "frmRanking";
            this.Load += new System.EventHandler(this.frmRanking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblRanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cbxTurmas;
        private System.Windows.Forms.ComboBox cbxFiltros;
        private System.Windows.Forms.DataGridView tblRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn clposicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEsmeraldas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXp;
        private System.Windows.Forms.TextBox edtSearch;
        private System.Windows.Forms.Button bntBuscar;
    }
}