using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MyLessons.classe
{
    class professor_disciplina:banco
    {
        public professor_disciplina() : base() 
        {

        }

        public MySqlDataReader buscar()
        {
            MySqlDataReader dados = null;
            string[,] parametros = null;
            string nomeSP = "BuscarProfessorDisciplina";
            if (consultar(nomeSP, parametros, ref dados))
            {
                return dados;
            }
            return dados;
        }
    }
}
