using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DesafioDesktop
{
    public partial class Form1 : Form
    {
        private TarefaController controller = new TarefaController();
        
        public Form1()
        {
            InitializeComponent();

        }

        public void AtualizarLista()
        {
            List<Tarefa> tarefas = controller.ListarTarefas();

            dtGridTarefas.DataSource = null;
            dtGridTarefas.DataSource = tarefas;
          
        }

        private void btTarefaConcluida_Click(object sender, EventArgs e)
        {
            if (dtGridTarefas.SelectedRows.Count > 0)
            {
                var linhaSelecionada = dtGridTarefas.SelectedRows[0];
                var tarefa = linhaSelecionada.DataBoundItem as Tarefa;
                if (tarefa != null)
                {
                    tarefa.Status = "Concluída";
                    dtGridTarefas.Refresh();
                }
                else
                {
                    MessageBox.Show("Selecione uma tarefa!");
                }          
            }
        }

        private void btAdicionarTarefa_Click(object sender, EventArgs e)
        {
            string nome = txNomeTarefa.Text;
            var valorComboBox = cbPriodade.SelectedIndex.ToString();
            if (valorComboBox == "0")
            {
                valorComboBox = "Alta";
            }
            else if (valorComboBox == "1")
            {
                valorComboBox = "Média";
            }
            else
            {
                valorComboBox = "Baixa";
            }

            var valorComboBoxStatus = cbStatus.SelectedIndex.ToString();
            if (valorComboBoxStatus == "0")
            {
                valorComboBoxStatus = "Pendente";
            }
            else
            {
                valorComboBoxStatus = "Concluida";
            }

            var valorData = dtpTarefaVencida.Value;

            string mensagem = controller.SalvarTarefa(nome, valorComboBox, valorData.ToString(), valorComboBoxStatus);
            MessageBox.Show(mensagem);

            AtualizarLista();
        }

        private void btGrafico_Click(object sender, EventArgs e)
        {
   
            chartTarefas.Series.Clear();
            chartTarefas.Titles.Clear();
            chartTarefas.Titles.Add("Gráfico de Tarefas");
            chartTarefas.ChartAreas[0].AxisX.Title = "Tarefas";
            chartTarefas.ChartAreas[0].AxisY.Title = "Prioridades";
            Series serie = new Series("Valores")
            {
                ChartType = SeriesChartType.Column,
                BorderWidth = 2
            };

            int baixa = 0;
            int media = 0;
            int alta = 0;
            List<Tarefa> tarefas = controller.ListarTarefas();
            for (int i = 0; i < tarefas.Count; i++)
            {
                if (tarefas[i].Prioridade.Equals("Baixa"))
                {
                    baixa+= 1;
                }
                else if(tarefas[i].Prioridade.Equals("Média"))
                {
                    media+= 1;

                }
                else
                {
                    alta+= 1;
                }

            }
            serie.Points.AddXY("Baixa", baixa);
            serie.Points.AddXY("Media", media);
            serie.Points.AddXY("Alta", alta);



            chartTarefas.Series.Add(serie);
        }

    }
}

