using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MyLessons.classe
{
    class ranking:banco
    {
        public string turma { get; set; }
        public int ano { get; set; }

        public ranking() : base() 
        {

        }

        public MySqlDataReader BusarRankingXp()
        {
            MySqlDataReader dados = null;
            string[,] parametros = new string[1, 2];
            parametros[0, 0] = "vTurma";
            parametros[0, 1] = turma;
            string nomeSP = "BusarRankingXp";
            if (consultar(nomeSP, parametros, ref dados))
            {
                return dados;
            }
            return dados;
            desconectar();
        }

        public MySqlDataReader BusarRankingEsmeralda()
        {
            MySqlDataReader dados = null;
            string[,] parametros = new string[1, 2];
            parametros[0, 0] = "vTurma";
            parametros[0, 1] = turma;
            string nomeSP = "BusarRankingEsmeralda";
            if (consultar(nomeSP, parametros, ref dados))
            {
                return dados;
            }
            return dados;
            desconectar();
        }

        public List<string> BuscarTurmas()
        {
            List<string> Turmas = new List<string>();
            string nomeSP = "BuscarTurmas";
            string[,] parametros = new string[1, 2];
            parametros[0, 0] = "vAnoTurma";
            parametros[0, 1] = ano.ToString();
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
    }
}
