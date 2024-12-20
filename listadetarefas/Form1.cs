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
    public partial class Form1 : Form
    {
        private readonly Autenticacao autenticacao;

        public Form1()
        {
            InitializeComponent();
            autenticacao = new Autenticacao();
        }

        public class Usuario : UsuarioBase
        {
            public Usuario(string usuario, string senha) : base(usuario, senha) { }

            public string ObterInformacoes()
            {
                return $"Usuário: {Usuario}"; 
            }
        }
        public class Autenticacao
        {
            private List<UsuarioBase> usuarios;

            public Autenticacao()
            {
                usuarios = new List<UsuarioBase>
                {
                 new Usuario("Evellyn", "12345"),
                 new Usuario("Mateus", "54321"),
                 new Usuario("Beatriz", "12345")
                };
            }

            public bool Validar(string usuario, string senha)
            {
                return usuarios.Any(u => u.Validar(usuario, senha));
            }
        }
        private void btmEntrar_Click(object sender, EventArgs e)
        {
            if (autenticacao.Validar(txtUsuario.Text, txtSenha.Text))
            {
                new tarefas().Show(); 
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear(); 
                txtUsuario.Focus(); 
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var btCadastrar = new cadastro();
            btCadastrar.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Se apertar sim, perderá tudo feito até agora", "Confirmar Cancelamento", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                var Form1 = new Form1();
                Form1.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var btInicio = new inicio(); 
            btInicio.Show();
            this.Hide();
        }
    }
}
