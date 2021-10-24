using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MyLessons.classe
{
    class disciplina:banco 
    {
        public string nome { get; set; }
        public int Rm { get; set; }


        public disciplina()
            : base()
        {

        }

        public disciplina(string nome) : base() 
        {
            this.nome = nome;
        }

        public disciplina(string nome, int rm)
            : base()
        {
            this.nome = nome;
            this.Rm = rm;
        }

        public MySqlDataReader buscar()
        {
            MySqlDataReader dados = null;
            string[,] parametros = new string[1, 2];
            parametros[0, 0] = "vNome";
            parametros[0, 1] = nome;
            string nomeSP = "BuscarDisciplina";
            if (consultar(nomeSP, parametros, ref dados))
            {
                return dados;
            }
            return dados;
        }

        public bool adicionarProfessor()
        {
            MySqlDataReader dados = null;
            dados = buscar();
            dados.Read();
            string cd_disciplina = dados[0].ToString();
            string[,] parametros = new string[2, 2];
            parametros[0, 0] = "vRm";
            parametros[0, 1] = Rm.ToString();
            parametros[1, 0] = "vDisciplina";
            parametros[1, 1] = cd_disciplina;

            string nomeSP = "ConectarProfessorDisciplina";
            if (executar(nomeSP, parametros))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
