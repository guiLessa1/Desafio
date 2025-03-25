using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDesktop
{
    internal class Tarefa
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Prioridade { get; set; }
        public string DataVencimento { get; set; }
        public string Status { get; set; }

        public void TarefaConcluida()
        {
            Status = "Concluida";
        }
    }

    internal class TarefaModel
    {
        List<Tarefa> tarefas = new List<Tarefa>();
       
        public void AdicionarTarefa(Tarefa tarefa)
        {
            tarefas.Add(tarefa);
        }

        public void RemoverTarefa(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
        }

        public List<Tarefa> listarTarefas()
        {
            return tarefas;
        }
    }

    internal class TarefaController
    {
        private TarefaModel model = new TarefaModel();

        public string SalvarTarefa(string nome, string Prioridade, string dataVencimento, string status)
        {

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(Prioridade))
                return "É necessário preencher as informações";
             
            
            Tarefa tarefa = new Tarefa
            {
                Nome = nome,
                Prioridade = Prioridade,
                DataVencimento = dataVencimento,
                Status = status
            };

            model.AdicionarTarefa(tarefa);
            return "Tarefa salva com sucesso!. ";
        }

        public List<Tarefa> ListarTarefas()
        {
            return model.listarTarefas();
        }
        public string RemoverTarefa(string nome, string Prioridade, string dataVencimento)
        {

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(Prioridade) || string.IsNullOrEmpty(dataVencimento))
                return "É necessário preencher as informações";

            Tarefa tarefa = new Tarefa
            {
                Nome = nome,
                Prioridade = Prioridade,
                DataVencimento = dataVencimento
            };

            model.RemoverTarefa(tarefa);
            return "Tarefa removida com sucesso!. ";
        }

    }

}
