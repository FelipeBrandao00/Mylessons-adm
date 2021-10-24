using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Proffreddy;
using MyLessons.classe;
using MySql.Data.MySqlClient;

namespace MyLessons
{
    public partial class frmTurmas : Form
    {
        List<string> enderecosArquivos;
        public frmTurmas()
        {
            InitializeComponent();
        }

        #region PlaceHolder
        private void textSearchTurmasEnter(object sender, EventArgs e)
        {
            if (pesquisaAlunos.Text == "Search")
            {
                pesquisaAlunos.Text = "";
                pesquisaAlunos.ForeColor = Color.Black;
            }
        }

        private void textSearchTurmasLeave(object sender, EventArgs e)
        {
            if (pesquisaAlunos.Text == "")
            {
                pesquisaAlunos.Text = "Search";
                pesquisaAlunos.ForeColor = Color.Silver;
            }
        }

        private void textSearchAlunosEnter(object sender, EventArgs e)
        {
            if (pesquisaAlunos.Text == "Search")
            {
                pesquisaAlunos.Text = "";
                pesquisaAlunos.ForeColor = Color.Black;
            }
        }

        private void textSearchAlunosLeave(object sender, EventArgs e)
        {

        }
        #endregion

        #region botoes do Atribuir professor 
        private void btnAtribuir_Click(object sender, EventArgs e)
        {
            pnlAtirbuirProfessor.Visible = true;
            CarregarTumas();
            CarregarProfessoresComDisciplina();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            AtribuiraTurma();
            limpar();
            CarregarTumas();
            CarregarProfessoresComDisciplina();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAtirbuirProfessor.Visible = false;
        }

        #region Carregar Turmas
        private void CarregarTumas() 
        {
            turma Turma = new turma();
            List<string> turmas = Turma.listar();
            foreach (var turma in turmas)
            {
                cmbTurmas.Items.Add(turma);
            }
        }
        #endregion

        #region Careegar Professores e disciplina
        private void CarregarProfessoresComDisciplina()
        {
            professor_disciplina professor = new professor_disciplina();
            MySqlDataReader dados = null;
            dados = professor.buscar();
            while (dados.Read())
            {
                string nome = dados[0].ToString();
                string disciplina = dados[1].ToString();
                tblProfessorDisciplina.Rows.Add(false,nome,disciplina);
            }
        }
        #endregion

        #region AtribuirProfessor à turma
        private void AtribuiraTurma() 
        {
            if (cmbTurmas.Text == "")
            {
                MessageBox.Show("Selecione Alguma turma!");
                return;
            }

            turma turma = new turma();
            disciplina disciplina = new disciplina();
            turma.Sigla = cmbTurmas.Text;
            turma.Ano = DateTime.Now.Year;

            for (int i = 0; i < tblProfessorDisciplina.Rows.Count; i++)
            {
                if (tblProfessorDisciplina.Rows[i].Cells[0].Value.ToString() == "True")
                {
                    disciplina.nome = tblProfessorDisciplina.Rows[i].Cells[2].Value.ToString();
                    Professor professor = new Professor(tblProfessorDisciplina.Rows[i].Cells[1].Value.ToString(), disciplina, turma);
                    professor.atribuirTurma();
                }
            }
            MessageBox.Show("Professores Atribuidos com sucesso!");
        }
        #endregion

        #region Limpar
        private void limpar() 
        {
            cmbTurmas.Items.Clear();
            tblProfessorDisciplina.Rows.Clear();
        }
        #endregion

        #endregion

        #region Importar alunos e turmas
        private void btnImportar_Click(object sender, EventArgs e)
        {
            enderecosArquivos = new List<string>();

            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Selecionar planilhas de turmas";
            openfile.Filter = "Exel | *.xls;*.xlsx";
            openfile.Multiselect = true;
            openfile.CheckFileExists = true;
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                listaTurmas.Items.Clear();
                foreach (var arquivo in openfile.FileNames)
                {
                    enderecosArquivos.Add(arquivo);
                    string SomenteNomeArquivo = Path.GetFileNameWithoutExtension(arquivo);
                    listaTurmas.Items.Add(SomenteNomeArquivo);
                }
            }
        }

        private void btnIniciarImportacao_Click(object sender, EventArgs e)
        {
            if (listaTurmas.Items.Count == 0)
            {
                MessageBox.Show("Selecione o(s) Arquivo(s) primeiro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < listaTurmas.Items.Count; i++)
            {
                CarregarAlunos(enderecosArquivos[i]);
                GravarAlunos(listaTurmas.Items[i].ToString());

            }
            tblAaluno.Rows.Clear();
            listaTurmas.Items.Clear();
            enderecosArquivos.Clear();
            MessageBox.Show("Importação concluída com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region carrega os alunos
        void CarregarAlunos(string enderecoArquivo)
        {
            tblAaluno.Rows.Clear();
            clsExcel excel = new clsExcel();
            excel.AbreArquivo(enderecoArquivo);
            excel.EscolhaPlan(1);
            int linha = 5;
            while (excel.Leitura("A" + linha.ToString()) != "")
            {
                string rm = excel.Leitura("A" + linha.ToString());
                string nome = excel.Leitura("B" + linha.ToString());
                string email = excel.Leitura("C" + linha.ToString());
                tblAaluno.Rows.Add(rm, nome, email);

                linha++;
            }
            excel.Fechar();
        }
        #endregion

        #region Grava os alunos no banco
        void GravarAlunos(string sgTurma)
        {
            for (int i = 0; i < tblAaluno.Rows.Count; i++)
            {
                tblAaluno.CurrentCell = tblAaluno.Rows[i].Cells[0];

                string random = (new Random().Next(100000, 999999).ToString());
                int ano = DateTime.Now.Year;
                turma turma = new turma(sgTurma, ano);
                turma.Adicionar();

                aluno aluno = new aluno(int.Parse(tblAaluno.Rows[i].Cells[0].Value.ToString()), tblAaluno.Rows[i].Cells[1].Value.ToString(), tblAaluno.Rows[i].Cells[2].Value.ToString(), random ,turma);
                aluno.Adicionar();
                Application.DoEvents();

                string subject = "MyLessons - Primeira Senha";
                string html = "<body style='font-family: arial;'>";
                html += "<p>Olá querido(a) Aluno(a) " + tblAaluno.Rows[i].Cells[1].Value.ToString() + ", sua senha inicial é:</p><br>";
                html += "<h1 style='text-align: center; color: blue;'>" + random + "</h1>";
                html += "</body>";
                email.personalizado(tblAaluno.Rows[i].Cells[2].Value.ToString(), subject, html);
            }
        }
        #endregion
        #endregion

    }
}
