using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listadetarefas
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tarefa = new Form1 (); //inicio 
            tarefa.Show();

            this.Hide();
        }
    }
}
