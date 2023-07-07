using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _1projetoWF
{
    public partial class loginForm1 : Form
    {
        public loginForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //CONECTAR COM O BANCO DE DADOS
            Conexao db = new Conexao();
            db.Conectar();

            UsuarioBanco usuario = new UsuarioBanco();
            usuario.Usuario = textBox1.Text;
            usuario.Senha = textBox2.Text;

            //BUSCAR USUARIO E SENHA NO BANCO DE DADOS

            var retorno = db.BuscarUsuario(usuario.Usuario, usuario.Senha);

            if (!retorno)
            {
                MessageBox.Show("Ops,Usuario ou senha  incorreta !:(", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            else if (retorno)
            {
                MessageBox.Show("Seja bem vindo! :)", "Acesso Permitido", MessageBoxButtons.OK);


                // ENTRAR NA TELA ALUNO
                TelaAluno telaAluno = new TelaAluno();
                telaAluno.ShowDialog();
            }



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastrowk cadastrowk = new Cadastrowk();
            cadastrowk.Show();
        }
    }
}