using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace MyLessons.classe
{
    class banco
    {
        MySqlConnection conexao = null;
        MySqlCommand cSQL = null;
        MySqlDataReader dados = null;
        string linhaConexao = "";

        #region Construtores
        public banco()
        {
            linhaConexao = execucao.GetConexao();
        }
        #endregion

        #region Abertura e Fechamento de Conexão
        private bool conectar()
        {
            conexao = new MySqlConnection(linhaConexao);
            try
            {
                conexao.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool desconectar()
        {
            try
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region consultar e executar

        public bool consultar(string nomeSP, string[,] args, ref MySqlDataReader dados)
        {
            try
            {
                if (conectar())
                {
                    cSQL = new MySqlCommand(nomeSP, conexao);
                    cSQL.CommandType = CommandType.StoredProcedure;
                    cSQL.Parameters.Clear();
                    if (args != null)
                    {
                        for (int i = 0; i < args.Length / 2; i++)
                        {
                            cSQL.Parameters.Add(new MySqlParameter(args[i, 0], args[i, 1]));
                        }
                    }
                    dados = cSQL.ExecuteReader();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool executar(string nomeSP, string[,] args)
        {
            try
            {
                if (conectar())
                {
                    cSQL = new MySqlCommand(nomeSP, conexao);
                    cSQL.CommandType = CommandType.StoredProcedure;
                    cSQL.Parameters.Clear();

                    if (args != null)
                    {
                        for (int i = 0; i < args.Length / 2; i++)
                        {
                            cSQL.Parameters.Add(new MySqlParameter(args[i, 0], args[i, 1]));
                        }
                    }
                    cSQL.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
