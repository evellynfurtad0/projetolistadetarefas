using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listadetarefas
{
    public class UsuarioBase
    {
        public string Usuario { get; }
        public string Senha { get; }

        public UsuarioBase(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }

        public bool Validar(string usuario, string senha)
        {
            return Usuario == usuario && Senha == senha;
        }
    }
}
