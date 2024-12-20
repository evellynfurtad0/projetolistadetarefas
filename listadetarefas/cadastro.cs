using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static listadetarefas.Form1;
using static listadetarefas.tarefas;

namespace listadetarefas
{   
        
       public partial class cadastro : Form
       {
        private readonly Autenticacao autenticacao;

        public cadastro()
        {
            InitializeComponent();
            this.autenticacao = new Autenticacao();
        }

        public class Autenticacao
        {
            private List<Usuario> usuarios;

            public Autenticacao()
            {
                usuarios = new List<Usuario>();
            }

            public void CadastrarUsuario(string nomeUsuario, string senha)
            {
                var usuario = new Usuario(nomeUsuario, senha);
                usuarios.Add(usuario);
            }

            public bool Validar(string usuario, string senha)
            {
                return usuarios.Any(u => u.NomeUsuario == usuario && u.Senha == senha);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //criado sem querer
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //criado sem querer
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Se apertar sim, perderá tudo feito até agora", "Confirmar Cancelamento", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                var cadastro = new cadastro();
                cadastro.Show();
                this.Hide();
            }
        }

        private void btFacaLogin_Click(object sender, EventArgs e)
        {
            var cadastro = new Form1();
            cadastro.Show();

            this.Hide();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(nomeUsuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            autenticacao.CadastrarUsuario(nomeUsuario, senha);
            MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            txtUsuario.Clear();
            txtSenha.Clear();

            
            var cadastro = new tarefas (); 
            cadastro.Show(); 

            this.Hide(); 

        }

        private void cadastro_Load(object sender, EventArgs e)
        {
            //criado sem querer
        }
    }
}
