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
    public partial class frmRanking : Form
    {
        public frmRanking()
        {
            InitializeComponent();
        }

        #region PlaceHolder
        private void edtSearch_Enter(object sender, EventArgs e)
        {
            if (edtSearch.Text == "Search")
            {
                edtSearch.Text = "";
                edtSearch.ForeColor = Color.Black;
            }
        }

        private void edtSearch_Leave(object sender, EventArgs e)
        {
            if (edtSearch.Text == "")
            {
                edtSearch.Text = "Search";
                edtSearch.ForeColor = Color.Silver;
            }
        }
        #endregion

        #region foltrar
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            tblRanking.Rows.Clear();
            ranking rank = new ranking();
            rank.turma = cbxTurmas.Text;
            int posicao = 1;
            MySqlDataReader dados = null;
            if (cbxFiltros.SelectedIndex == 0)
            {
                dados = rank.BusarRankingXp();
                while (dados.Read())
                {
                    string turma = dados[0].ToString();
                    string nome = dados[1].ToString();
                    string esmeralda = dados[2].ToString();
                    string xp = dados[3].ToString();

                    tblRanking.Rows.Add(posicao, turma, nome, esmeralda, xp);
                    posicao++;
                }
            }
            else
            {
                dados = rank.BusarRankingEsmeralda();
                while (dados.Read())
                {
                    string turma = dados[0].ToString();
                    string nome = dados[1].ToString();
                    string esmeralda = dados[2].ToString();
                    string xp = dados[3].ToString();

                    tblRanking.Rows.Add(posicao, turma, nome, esmeralda, xp);
                    posicao++;
                }
            }
        }
        #endregion 

        #region load
        private void frmRanking_Load(object sender, EventArgs e)
        {
            List<string> Turma = new List<string>();
            cbxFiltros.SelectedIndex = 0;
            cbxTurmas.Items.Clear();
            cbxTurmas.Items.Add("");
            ranking rank = new ranking();
            rank.ano = DateTime.Now.Year;
            Turma = rank.BuscarTurmas();
            foreach (var turmas in Turma)
            {
                cbxTurmas.Items.Add(turmas);
            }
        }
        #endregion

        #region buscar
        private void bntBuscar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tblRanking.Rows.Count; i++)
            {
                try
                {
                    if (edtSearch.Text == tblRanking.Rows[i].Cells[2].Value.ToString())
                    {
                        tblRanking.CurrentCell = tblRanking.Rows[i].Cells[0];
                        Application.DoEvents();
                        return;
                    }
                }
                catch
                {
                    return;
                }
            }
        }
        #endregion
    }
}
