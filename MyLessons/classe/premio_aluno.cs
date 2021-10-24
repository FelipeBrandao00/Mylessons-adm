using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MyLessons.classe
{
    class premio_aluno:banco
    {
        public int Rm { get; set; }
        public int cdPremio { get; set; }

        public premio_aluno():base()
        {

        }

        public MySqlDataReader buscar()
        {
            MySqlDataReader dados = null;
            string[,] parametros = new string[1, 2];
            parametros[0, 0] = "vRm";
            parametros[0, 1] = Rm.ToString();
            string nomeSP = "buscarPremiosAluno";
            if (consultar(nomeSP, parametros, ref dados))
            {
                return dados;
            }
            return dados;
        }

        public bool atualizar()
        {
            string[,] parametros = new string[2, 2];
            parametros[0, 0] = "vAluno";
            parametros[0, 1] = Rm.ToString();
            parametros[1, 0] = "vPremio";
            parametros[1, 1] = cdPremio.ToString();

            string nomeSP = "EfetivarRetiradaPremioAluno";
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
