using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listadetarefas
{
    public class GerenciadorDeTarefas
    {
        private List<Tarefa> tarefas = new List<Tarefa>();

        public void AdicionarTarefa(Tarefa tarefa)
        {
            tarefas.Add(tarefa);
        }

        public void RemoverTarefa(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
        }

        public List<Tarefa> ObterTarefas()
        {
            return tarefas;
        }
    }
}
