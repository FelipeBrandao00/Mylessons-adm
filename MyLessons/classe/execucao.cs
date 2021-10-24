using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLessons.classe
{
    class execucao
    {
        private static string LinhaCodigo = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=my_lessons";

        public static string GetConexao()
        {
            return LinhaCodigo;
        }
    }
}
