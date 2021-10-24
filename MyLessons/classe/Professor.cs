using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MyLessons.classe
{
    class Professor:banco
    {
        public int cd { get; set; }
        public string nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Disciplina { get; set; }
        public turma Turma { get; set; }
        public disciplina Disciplinaa { get; set; }

        public Professor() : base() 
        {

        }
        
        public Professor(turma turma)
            : base()
        {
            this.Turma = turma;
        }

        public Professor(disciplina disciplina)
            : base()
        {
            this.Disciplinaa = disciplina;
        }
         public Professor(string nome,disciplina disciplina, turma turma)
            : base()
        {
            this.nome = nome;
            this.Disciplinaa = disciplina;
            this.Turma = turma;
        }

        public MySqlDataReader buscar()
        {
            MySqlDataReader dados = null;
            string[,] parametros = null;
            string nomeSP = "BuscarTudoProfessor";
            if (consultar(nomeSP, parametros, ref dados))
            {
                return dados;
            }
            return dados;
        }

        public bool Desativar()
        {
            string[,] parametros = new string[1, 2];
            parametros[0, 0] = "vRm";
            parametros[0, 1] = cd.ToString();


            string nomeSP = "DesativarProfessor";
            if (executar(nomeSP, parametros))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool adicionar()
        {
            disciplina disciplina = new disciplina(Disciplina);
            MySqlDataReader dados = null;
            dados = disciplina.buscar();
            dados.Read();
            int cdDisciplina = int.Parse(dados[0].ToString());

            string[,] parametros = new string[5, 2];
            parametros[0, 0] = "vRm";
            parametros[0, 1] = cd.ToString();
            parametros[1, 0] = "vNome";
            parametros[1, 1] = nome;
            parametros[2, 0] = "vEmail";
            parametros[2, 1] = Email;
            parametros[3, 0] = "vSenha";
            parametros[3, 1] = Senha;
            parametros[4, 0] = "vDisciplina";
            parametros[4, 1] = cdDisciplina.ToString();

            string nomeSP = "CriarProfessor";
            if (executar(nomeSP, parametros))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool atribuirTurma()
        {
            string[,] parametros = new string[4, 2];
            parametros[0, 0] = "vNome";
            parametros[0, 1] = nome;
            parametros[1, 0] = "vDisciplina";
            parametros[1, 1] = Disciplinaa.nome;
            parametros[2, 0] = "vTurma";
            parametros[2, 1] = Turma.Sigla;
            parametros[3, 0] = "vAno";
            parametros[3, 1] = (Turma.Ano).ToString();

            string nomeSP = "ConectarProfessorTurma";
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
