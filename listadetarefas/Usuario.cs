using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listadetarefas
{
    public class Usuario
    {
        public string NomeUsuario { get; }
        public string Senha { get; }

        public Usuario(string nomeUsuario, string senha)
        {
            NomeUsuario = nomeUsuario;
            Senha = senha;
        }
    }
}
