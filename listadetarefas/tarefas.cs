using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace listadetarefas
{
    public partial class tarefas : Form
    {
        static string[] prioridades = { "Alta", "Média", "Baixa", "Nenhuma" };
        private GerenciadorDeTarefas gerenciadorDeTarefas = new GerenciadorDeTarefas();
        public tarefas()
        {
            InitializeComponent();
        }
        
        private void tarefas_Load(object sender, EventArgs e)
        {
           LimparCampos();
           PreencherPrioridade();
           PreencherComboBoxFiltrar();
        }
       
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            
            Tarefa novaTarefa = new Tarefa(cmbPrioridade1.Text, txtCategoria.Text, txtTitulo.Text, txtDescricao.Text, DateTime.Parse(dData.Text));
            gerenciadorDeTarefas.AdicionarTarefa(novaTarefa);

            
            ListViewItem item = new ListViewItem(novaTarefa.Prioridade);
            item.SubItems.Add(novaTarefa.Categoria);
            item.SubItems.Add(novaTarefa.Titulo);
            item.SubItems.Add(novaTarefa.Descricao);
            item.SubItems.Add(novaTarefa.Data.ToString("d"));
            lvInformacoes.Items.Add(item);

            LimparCampos();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         //criado sem querer
        }

        private void cmbPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {
          //criado sem querer
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtCategoria.Clear();
            txtTitulo.Clear();
            cmbPrioridade1.SelectedIndex = -1; 
            txtTitulo.Focus(); 
        }

        private void PreencherPrioridade()
        {
            cmbPrioridade1.Items.Clear(); 
            foreach (var p in prioridades)
            {
                cmbPrioridade1.Items.Add(p);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
          LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lvInformacoes.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    
                    var item = lvInformacoes.SelectedItems[0];
                    Tarefa tarefaParaRemover = new Tarefa(item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, DateTime.Parse(item.SubItems[4].Text));
                    gerenciadorDeTarefas.RemoverTarefa(tarefaParaRemover);
                    lvInformacoes.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Selecione um item para excluir.");
            }
        }
    

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (lvInformacoes.SelectedItems.Count > 0)
            {
                ListViewItem item = lvInformacoes.SelectedItems[0];
                txtCategoria.Text = item.SubItems[1].Text; 
                txtTitulo.Text = item.SubItems[2].Text; 
                txtDescricao.Text = item.SubItems[3].Text; 
                cmbPrioridade1.SelectedItem = item.Text; 

                
                Tarefa tarefaParaRemover = new Tarefa(item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, DateTime.Parse(item.SubItems[4].Text));
                gerenciadorDeTarefas.RemoverTarefa(tarefaParaRemover);
                lvInformacoes.Items.Remove(item);
            }
            else
            {
                MessageBox.Show("Selecione um item para editar.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //criado sem querer
        }

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Se apertar sim, perderá tudo feito até agora", "Confirmar Cancelamento", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimparCampos();
            }
        }

        private void dateTimePickerFiltro_ValueChanged(object sender, EventArgs e)
        {
            //criado sem querer
        }

        private void cmbFiltrarPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {
            //criado sem querer
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
          FiltrarTarefas();
        }
        private void PreencherComboBoxFiltrar()
        {
            cmbFiltrarPrioridade.Items.Clear();
            foreach (var p in prioridades)
            {
                cmbFiltrarPrioridade.Items.Add(p);
            }
        }
        private void FiltrarTarefas()
        {
            string prioridadeSelecionada = cmbFiltrarPrioridade.SelectedItem?.ToString();
            DateTime dataSelecionada = dateTimePickerFiltro.Value.Date;

            lvInformacoes.Items.Clear(); 

            foreach (var tarefa in gerenciadorDeTarefas.ObterTarefas())
            {
               
                if ((prioridadeSelecionada == null || tarefa.Prioridade == prioridadeSelecionada) &&
                    tarefa.Data.Date == dataSelecionada)
                {
                    ListViewItem item = new ListViewItem(tarefa.Prioridade);
                    item.SubItems.Add(tarefa.Categoria);
                    item.SubItems.Add(tarefa.Titulo);
                    item.SubItems.Add(tarefa.Descricao);
                    item.SubItems.Add(tarefa.Data.ToString("d"));
                    lvInformacoes.Items.Add(item);
                }
            }
        }
    }
}
