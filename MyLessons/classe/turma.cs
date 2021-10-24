using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MyLessons.classe
{
    class turma : banco
    {
        #region Váriaveis
        public string Sigla { get; set; }
        public int Ano { get; set; }

        public turma()
            : base()
        {

        }

        public turma(string sigla, int ano)
            : base()
        {
            this.Sigla = sigla;
            this.Ano = ano;
        }
        #endregion

        #region Adicionar Turma
        public bool Adicionar()
        {
            string[,] parametros = new string[2, 2];
            parametros[0, 0] = "vSigla";
            parametros[0, 1] = Sigla;
            parametros[1, 0] = "vAno";
            parametros[1, 1] = Ano.ToString();

            string nomeSP = "CriarTurma";
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

        #region Buscar Turmas

        public List<string> listar()
        {
            List<string> Turmas = new List<string>();
            string nomeSP = "BuscarTurmas";
            string[,] parametros = new string[1, 2];
            parametros[0, 0] = "vAnoTurma";
            parametros[0, 1] = (DateTime.Now.Year).ToString();
            MySqlDataReader dados = null;
            if (consultar(nomeSP, parametros, ref dados))
            {
                if (dados != null)
                {
                    while (dados.Read())
                    {
                        Turmas.Add(dados[0].ToString());
                    }
                    if (!dados.IsClosed) dados.Close();
                }
            }
            desconectar();
            return Turmas;
        }
        #endregion
    }
}
