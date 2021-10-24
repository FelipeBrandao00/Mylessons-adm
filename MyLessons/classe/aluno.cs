using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MyLessons.classe
{
    class aluno : banco
    {
        #region Váriaveis:
        public int RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public turma Turma { get; set; }

        public aluno()
            : base()
        {

        }

        public aluno(int rm, string nome,string email, string senha, turma turma)
            : base()
        {
            this.RM = rm;
            this.Nome = nome;
            this.Turma = turma;
            this.Email = email;
            this.Senha = senha;
        }

        public aluno(turma turma)
            : base()
        {
            this.Turma = turma;
        }
        #endregion

        #region Adicionar Aluno
        public bool Adicionar()
        {
            string[,] parametros = new string[6, 2];
            parametros[0, 0] = "vRm";
            parametros[0, 1] = RM.ToString();
            parametros[1, 0] = "vNome";
            parametros[1, 1] = Nome;
            parametros[2, 0] = "vEmail";
            parametros[2, 1] = Email;
            parametros[3, 0] = "vSenha";
            parametros[3, 1] = Senha;
            parametros[4, 0] = "vSigla";
            parametros[4, 1] = Turma.Sigla;
            parametros[5, 0] = "vAno";
            parametros[5, 1] = (Turma.Ano).ToString();


            string nomeSP = "CriarAluno";
            if (executar(nomeSP, parametros))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Carregar Alunos

        public int BuscarQuantidadeAlunos()
        {
            int QuantidadeAlunos = 0;
            string nomeSP = "ContarAlunosTurma";
            string[,] parametros = new string[1, 2];
            parametros[0, 0] = "vTurma";
            parametros[0, 1] = Turma.Sigla;
            MySqlDataReader dados = null;

            if (consultar(nomeSP, parametros, ref dados))
            {
                if (dados != null)
                {
                    while (dados.Read())
                    {
                        QuantidadeAlunos = int.Parse(dados[0].ToString());
                    }
                    return QuantidadeAlunos;
                    if (!dados.IsClosed) dados.Close();
                }
                return QuantidadeAlunos;
            }
            return QuantidadeAlunos;
            desconectar();
        }

        public string[,] listar()
        {
            int index = 0;
            index = BuscarQuantidadeAlunos();
            string[,] retorno = new string[index, 4];

            List<string> Turmas = new List<string>();
            string nomeSP = "CarregarAlunos";
            string[,] parametros = new string[1, 2];
            parametros[0, 0] = "vTurma";
            parametros[0, 1] = Turma.Sigla;
            MySqlDataReader dados = null;
            if (consultar(nomeSP, parametros, ref dados))
            {
                if (dados != null)
                {
                    for (int i = 0; i < index; i++)
                    {
                        dados.Read();
                        retorno[i, 0] = dados[0].ToString();
                        retorno[i, 1] = dados[1].ToString();
                        retorno[i, 2] = dados[2].ToString();
                        retorno[i, 3] = dados[3].ToString();
                    }

                    return retorno;
                    if (!dados.IsClosed) dados.Close();
                }
                return retorno;
            }
            return retorno;
            desconectar();

        }

        #endregion
    }
}
