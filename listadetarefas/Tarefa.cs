using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listadetarefas
{
    public class Tarefa
    {
            public string Prioridade { get; set; }
            public string Categoria { get; set; }
            public string Titulo { get; set; }
            public string Descricao { get; set; }
            public DateTime Data { get; set; }

            public Tarefa(string prioridade, string categoria, string titulo, string descricao, DateTime data)
            {
                Prioridade = prioridade;
                Categoria = categoria;
                Titulo = titulo;
                Descricao = descricao;
                Data = data;
            }
    }
}
