using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyLessons.classe;
using MySql.Data.MySqlClient;



namespace MyLessons
{
    public partial class frmPremios : Form
    {
        public frmPremios()
        {
            InitializeComponent();
        }
        #region Variaveis e instancias globais 
        premio premio = new premio();
        int teste = 0;
        int cdPremio = 0;
        #endregion

        #region PlaceHolder
        private void textSearchEnter(object sender, EventArgs e)
        {
            if (edtSearch.Text == "Search")
            {
                edtSearch.Text = "";
                edtSearch.ForeColor = Color.Black;
            }
        }

        private void textSearchLeave(object sender, EventArgs e)
        {
            if (edtSearch.Text == "")
            {
                edtSearch.Text = "Search";
                edtSearch.ForeColor = Color.Silver;
            }
        }
        #endregion

        #region add e edit
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            pnlAdicionarEditar.Visible = true;
            teste = 0;
            txtPremio.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            #region Linha Selecionada
            pnlAdicionarEditar.Visible = true;
            teste = 1;
            txtPremio.Text = "";
            string index = "";
            
            try
            {
                 index = tblPremios.SelectedRows[0].ToString();
            }
            catch 
            {
                carregarPremios();
                pnlAdicionarEditar.Visible = false;
                MessageBox.Show("Selecione Alguma Linha para Edição");
                return;
            }

            index = index.Replace("DataGridViewRow { Index=","");
            index = index.Replace(" }", "");
            #endregion

            cdPremio = int.Parse(tblPremios.Rows[int.Parse(index)].Cells[0].Value.ToString());            
            txtPremio.Text = tblPremios.Rows[int.Parse(index)].Cells[1].Value.ToString();
            txtDescricao.Text = tblPremios.Rows[int.Parse(index)].Cells[2].Value.ToString();
            txtValor.Text = tblPremios.Rows[int.Parse(index)].Cells[3].Value.ToString();
            txtQuantidade.Text = tblPremios.Rows[int.Parse(index)].Cells[4].Value.ToString();
            
        }
        #endregion

        #region confirm e cancel
        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            #region Validação
            if (txtPremio.Text == "" || txtValor.Text == "" || txtDescricao.Text == "" || txtQuantidade.Text == "")
            {
                MessageBox.Show("Preencha todas as caixas de informação");
                return;
            }

            try
            {
                int.Parse(txtValor.Text);
                int.Parse(txtQuantidade.Text);
            }
            catch 
            {
                MessageBox.Show("Digite Apenas Números nos campos: Valor e Quantidade");
                txtValor.Clear();
                txtQuantidade.Clear();
                txtValor.Focus();
                return;
            }

            #endregion

            #region Add Premio
            if (teste == 0)
            {
                string data = (DateTime.Now.Year).ToString() + "-" + (DateTime.Now.Month).ToString() + "-" + DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                premio premio = new premio() 
                { 
                    nome = txtPremio.Text,
                    descricao = txtDescricao.Text,
                    esmeraldas = int.Parse(txtValor.Text),
                    data = data,
                    quantidade = int.Parse(txtQuantidade.Text)
                    
                };

                if (premio.adicionar())
                {
                    MessageBox.Show("Prêmio Adcionado com sucesso");  
                }
                else
                {
                    MessageBox.Show("erro");
                }
                limparPremio();
            }
            #endregion

            #region Atualizar Premio
            else
            {
                premio.cd = cdPremio;
                premio.nome = txtPremio.Text;
                premio.descricao = txtDescricao.Text;
                premio.esmeraldas = int.Parse(txtValor.Text);
                premio.quantidade = int.Parse(txtQuantidade.Text);

                if (premio.atualizar())
                {
                    MessageBox.Show("Atualizado com Sucesso");
                    limparPremio();
                    pnlAdicionarEditar.Visible = false;
                    carregarPremios();
                }
                else
                {
                    MessageBox.Show("Algo deu errado");
                }
            }
            #endregion

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            carregarPremios();
            pnlAdicionarEditar.Visible = false;
        }
        #endregion

        #region Premios do Aluno
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            limparPremioAluno();
            pnlAdicionarEditar.Visible = true;
            pnlRetirada.Visible = true;
        }
     
        private void btnCancelarRetirada_Click_1(object sender, EventArgs e)
        {
            pnlAdicionarEditar.Visible = false;
            pnlRetirada.Visible = false;
        }
        private void btnConfirmarRetirada_Click(object sender, EventArgs e)
        {
            #region Linha Selecionada
            string index = "";

            try
            {
                index = tbmPremioAluno.SelectedRows[0].ToString();
            }
            catch
            {
                carregarPremios();
                MessageBox.Show("Selecione Alguma Linha para Edição");
                return;
            }

            index = index.Replace("DataGridViewRow { Index=", "");
            index = index.Replace(" }", "");
            #endregion

            premio_aluno premio_aluno = new premio_aluno();
            try
            {
                #region Validação
            if (tbmPremioAluno.Rows[int.Parse(index)].Cells[2].Value.ToString() == "não")
            {
                 
            try
            {
                premio_aluno.cdPremio = int.Parse(tbmPremioAluno.Rows[int.Parse(index)].Cells[0].Value.ToString());
                premio_aluno.Rm = int.Parse(txtRm.Text);
            }
            catch 
            {
                MessageBox.Show("Verifique se o Rm foi Digitado e se a linha está Selecionada!");
                return;
            }
            
            }
            else
            {
                MessageBox.Show("Esse Prêmio ja foi retirado");
                return;  
            }
            #endregion
            }
            catch 
            {
                MessageBox.Show("Verifique se o Rm foi Digitado e se a linha está Selecionada!");
                return;
            }

            #region Atualizar Premio
            if (premio_aluno.atualizar()) 
            {
                CarregarPremiosAluno();
                MessageBox.Show("Prêmio Atualizado com Sucesso!");
                return;
            }
            else
            {
                MessageBox.Show("Algo deu Errado!");
                return;
            }
            #endregion
        }

        private void btnProcurarAluno_Click(object sender, EventArgs e)
        {
            CarregarPremiosAluno();
        }
        #endregion

        #region Limpeza
        public void limparPremio() 
        {
            txtPremio.Clear();
            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
            txtPremio.Focus();
        }

        public void limparPremioAluno()
        {
            txtRm.Clear();
            tbmPremioAluno.Rows.Clear();
            txtRm.Focus();
        }

        #endregion

        #region Load 
        private void frmPremios_Load(object sender, EventArgs e)
        {
            carregarPremios();
        }

        #region Carregar Premios
        public void carregarPremios()
        {
            premio premio = new premio();
            tblPremios.Rows.Clear();
            int mes = DateTime.Now.Month;
            premio.mes = mes;
            MySqlDataReader dados = null;
            dados = premio.buscarPremios();
            while (dados.Read())
            {
                int cd = int.Parse(dados[0].ToString());
                string nome = dados[1].ToString();
                string descricao = dados[3].ToString();
                int valor = int.Parse(dados[2].ToString());
                int quantidade = int.Parse(dados[4].ToString());

                tblPremios.Rows.Add(cd, nome, descricao, valor, quantidade);
            }

            if (dados.IsClosed)
            {
                dados.Close();
            }
        }
        #endregion

        #region Carregar Premios do Aluno
        void CarregarPremiosAluno()
        {
            #region Validação
            premio_aluno premio_aluno = new premio_aluno();
            if (txtRm.Text.Length == 5)
            {
                try
                {
                    premio_aluno.Rm = int.Parse(txtRm.Text);   
                }
                catch 
                {
                    MessageBox.Show("Digite um Rm Válido");
                    return;
                }   
            }
            else
            {
                MessageBox.Show("Digite um Rm Válido");
                return;
            }
            #endregion


            tbmPremioAluno.Rows.Clear();
            MySqlDataReader dados = null;
            dados = premio_aluno.buscar();
            while (dados.Read())
            {
                string Retirado = "";
                int cd = int.Parse(dados[0].ToString());
                string nome = dados[4].ToString();
                if (dados[1].ToString() == "False")
                {
                     Retirado = "não";
                }
                else
                {
                     Retirado = "sim";
                }

                tbmPremioAluno.Rows.Add(cd, nome, Retirado);
            }

            if (dados.IsClosed)
            {
                dados.Close();
            }
        }
        #endregion
        #endregion

    }
}
