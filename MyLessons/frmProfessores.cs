using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MyLessons.classe;

namespace MyLessons
{
    public partial class frmProfessores : Form
    {
    
        public frmProfessores()
        {
            InitializeComponent();
        }
        #region variaveis globais
        public int cd_professdor = 0;
        public string nm_professdor = "";
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

        #region form load
        private void frmProfessores_Load(object sender, EventArgs e)
        {
            CarregarProfessores();
        }
        #endregion

        #region botoes do forms
        private void btnInserir_Click(object sender, EventArgs e)
        {
            pnlAdicionar.Visible = true;
            CarregarDisciplinas();
        }
       
        private void btnDesativar_Click(object sender, EventArgs e)
        {
            DesativarProfessor();
        }

        private void btnAtribuir_Click_1(object sender, EventArgs e)
        {
             #region Linha Selecionada
            string index = "";

            try
            {
                index = tblProfessores.SelectedRows[0].ToString();
            }
            catch
            {
                CarregarProfessores();
                MessageBox.Show("Selecione Alguma Linha para Edição");
                return;
            }

            index = index.Replace("DataGridViewRow { Index=", "");
            index = index.Replace(" }", "");
            #endregion

            #region Validação
            if (tblProfessores.Rows[int.Parse(index)].Cells[3].Value.ToString() == "Ativo")
            {

                try
                {
                    cd_professdor = int.Parse(tblProfessores.Rows[int.Parse(index)].Cells[0].Value.ToString());
                    nm_professdor = tblProfessores.Rows[int.Parse(index)].Cells[1].Value.ToString();
                    txtProfessorAtribuir.Text = nm_professdor;
                }
                catch
                {
                    MessageBox.Show("Verifique se a linha está Selecionada!");
                    return;
                }

                pnlDisciplina.Visible = true;
                CarregarDisciplinas();
            }
            else
            {
                MessageBox.Show("Esse Professor está Desativado, Não é possível atribuir uma disciplina!");
                return;
            }
            #endregion
        }
        #endregion

        #region botoes Criar Professor
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            CriarProfessor();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CarregarProfessores();
            pnlAdicionar.Visible = false;
        }
        #endregion

        #region Atribuir disciplina 
        private void btnCancelarDisciplina_Click(object sender, EventArgs e)
        {
            limpar();
            pnlDisciplina.Visible = false;
        }

        private void btnConfirmarDisciplina_Click(object sender, EventArgs e)
        {          
                disciplina disciplina = new disciplina(cbxAtribuirDisciplina.Text, cd_professdor);
                if (disciplina.adicionarProfessor())
                {
                    MessageBox.Show("Disciplina atribuída com sucesso!");
                    btnCancelarDisciplina_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Não foi possivel atribuir a disciplina!");
                    btnCancelarDisciplina_Click(sender, e);
                }          
        }
        #endregion 

        #region metodos

        #region Carregar Professores
        private void CarregarProfessores()
        {
            Professor professor = new Professor();
            tblProfessores.Rows.Clear();
            MySqlDataReader dados = null;
            dados = professor.buscar();
            while (dados.Read())
            {
                string estado_professor = "";
                int cd = int.Parse(dados[0].ToString());
                string nome = dados[1].ToString();
                string email = dados[2].ToString();
                if (dados[3].ToString() == "")
                {
                    estado_professor = "Inativo";
                }
                else
                {
                    estado_professor = "Ativo";
                }

                tblProfessores.Rows.Add(cd, nome, email, estado_professor);
            }
        }
        #endregion

        #region Desativar Professor
        private void DesativarProfessor()
        {
            Professor professor = new Professor();
            #region Linha Selecionada
            string index = "";

            try
            {
                index = tblProfessores.SelectedRows[0].ToString();
            }
            catch
            {
                CarregarProfessores();
                MessageBox.Show("Selecione Alguma Linha para Edição");
                return;
            }

            index = index.Replace("DataGridViewRow { Index=", "");
            index = index.Replace(" }", "");
            #endregion

            try
            {
                #region Validação
                if (tblProfessores.Rows[int.Parse(index)].Cells[3].Value.ToString() == "Ativo")
                {

                    try
                    {
                        professor.cd = int.Parse(tblProfessores.Rows[int.Parse(index)].Cells[0].Value.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Verifique se a linha está Selecionada!");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Esse Professor Já está Desativado!");
                    return;
                }
                #endregion
            }
            catch
            {
                MessageBox.Show("Verifique se a linha está Selecionada!");
                return;
            }

            #region Desativar Professor
            if (professor.Desativar())
            {
                CarregarProfessores();
                MessageBox.Show("Professor Desativado com Sucesso!");
                return;
            }
            else
            {
                MessageBox.Show("Algo deu Errado!");
                return;
            }
            #endregion

        }
        #endregion

        #region carregar disciplinas
        private void CarregarDisciplinas()
        {
            disciplina disciplina = new disciplina("");
            cbxDisciplina.Items.Clear();
            cbxAtribuirDisciplina.Items.Clear();
            MySqlDataReader dados = null;

            dados = disciplina.buscar();
            while (dados.Read())
            {
                string NomeDisciplina = dados[1].ToString();
                cbxDisciplina.Items.Add(NomeDisciplina);
                cbxAtribuirDisciplina.Items.Add(NomeDisciplina);
            }
        }
        #endregion

        #region Criar Professor
        private void CriarProfessor()
        {
            #region validação

            if (txtCdProf.Text == "" || txtNomeProf.Text == "" || txtEmail.Text == "" || cbxDisciplina.Text == "")
            {
                MessageBox.Show("Preenha todos os Campos!");
                return;
            }

            #endregion

            #region variaveis
            Professor professor = new Professor();
            string random = (new Random().Next(100000, 999999).ToString());
            try
            {
                professor.cd = int.Parse(txtCdProf.Text);
                professor.nome = txtNomeProf.Text;
                professor.Email = txtEmail.Text;
                professor.Senha = random;
                professor.Disciplina = cbxDisciplina.Text;
            }
            catch
            {
                limpar();
                MessageBox.Show("Algo deu errado, Preencha os campos Novamente!");
                txtCdProf.Focus();
                return;
            }
            #endregion

            if (professor.adicionar())
            {
                MessageBox.Show("Professor Adcionado com Sucesso, uma senha foi enviada para o professor!");
                string subject = "MyLessons - Primeira Senha";
                string html = "<body style='font-family: arial;'>";
                html += "<p>Olá Senhor(a) Professor(a) " + txtNomeProf.Text + ", sua senha inicial é:</p><br>";
	            html += "<h1 style='text-align: center; color: blue;'>" + random + "</h1>";
                html += "</body>";
                email.personalizado(txtEmail.Text,subject,html);
            }
            else
            {
                MessageBox.Show("Algo deu Errado!");
            }
            limpar();
        }
        #endregion

        #region Limpar
        private void limpar()
        {
            txtCdProf.Clear();
            txtProfessorAtribuir.Clear();
            txtEmail.Clear();
            txtNomeProf.Clear();
            txtProfessorAtribuir.Clear();
            cbxAtribuirDisciplina.Items.Clear();
        }
        #endregion

        private void cbxAtribuirDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConfirmarDisciplina.Enabled = true;
        }
        #endregion
    }
}
