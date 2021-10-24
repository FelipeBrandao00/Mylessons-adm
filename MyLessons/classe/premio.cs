using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MyLessons.classe
{
    class premio:banco
    {
        public int mes { get; set; }
        public int cd { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public int esmeraldas { get; set; }
        public int quantidade { get; set; }
        public string data { get; set; }
        

        public  premio():base()
        {

        }

        public MySqlDataReader buscarPremios()
        {
            MySqlDataReader dados = null;
            string[,] parametros = new string[1, 2];
            parametros[0, 0] = "vMes";
            parametros[0, 1] = mes.ToString();
            string nomeSP = "BuscarPremioEscolarAdm";
            if (consultar(nomeSP, parametros, ref dados))
            {
                return dados;
            }
            return dados;
        }

        public bool adicionar() 
        {
            string[,] parametros = new string[5, 2];
            parametros[0, 0] = "vNome";
            parametros[0, 1] = nome;
            parametros[1, 0] = "vDescricao";
            parametros[1, 1] = descricao;
            parametros[2, 0] = "vValor";
            parametros[2, 1] = esmeraldas.ToString();
            parametros[3, 0] = "vQuantidade";
            parametros[3, 1] = quantidade.ToString();
            parametros[4, 0] = "vData";
            parametros[4, 1] = data;

            string nomeSP = "CriarPremio";
            if (executar(nomeSP, parametros))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool atualizar()
        {
            string[,] parametros = new string[5, 2];
            parametros[0, 0] = "vCd";
            parametros[0, 1] = cd.ToString();
            parametros[1, 0] = "vNome";
            parametros[1, 1] = nome;
            parametros[2, 0] = "vDescricao";
            parametros[2, 1] = descricao;
            parametros[3, 0] = "vValor";
            parametros[3, 1] = esmeraldas.ToString();
            parametros[4, 0] = "vQuantidade";
            parametros[4, 1] = quantidade.ToString();

            string nomeSP = "AtualizarPremio";
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
