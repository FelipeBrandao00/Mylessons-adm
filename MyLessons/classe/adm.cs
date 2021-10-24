using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace MyLessons.classe
{
    class adm:banco
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public adm():base()
        {

        }

        public adm(string login, string senha): base()
        {
            this.Login = login;
            this.Senha = senha;
        }

        public bool VerificarLogin()
        {
            MySqlDataReader dados = null;
            string[,] parametros = new string[2, 2];
            parametros[0, 0] = "vLogin";
            parametros[0, 1] = Login;
            parametros[1, 0] = "vSenha";
            parametros[1, 1] = Senha;
            string nomeSP = "verificarAdm";
            if (consultar(nomeSP, parametros, ref dados))
            {
                while (dados.Read())
                {
                    if (dados[0].ToString() != null || dados[0].ToString() != "")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    } 
                }
            }
            
            return false;
            desconectar();
        }
    }
}
