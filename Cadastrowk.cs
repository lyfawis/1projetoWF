using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1projetoWF
{
    public partial class Cadastrowk : Form
    {
        public Cadastrowk()
        {
            InitializeComponent();


        }
        public SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Jovem Programador;Data Source=aline\\SQLEXPRESS");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrowk_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deja sair sem salvar os dados?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private SqlCommand GetCmd()
        {
            return cmd;
        }

        private void button1_Click(object sender, EventArgs e, SqlCommand cmd)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text==""&& textBox3.Text=="")
            {
                MessageBox.Show("Campos em branco", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (textBox2.Text ==textBox3.Text)
            {
                conn.Open();
                string Cadastrowk = "insert into user_tb values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5 + "','" + textBox6.Text + "')";
                cmd= new SqlCommand(Cadastrowk, conn);

                conn.Close();
                textBox1.Text = ""; textBox2.Text= ""; textBox3.Text= ""; textBox4.Text= ""; textBox5.Text=""; textBox6.Text="";
                MessageBox.Show("usuario cadastrado com sucesso", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" Senhas diferentes", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                textBox3.Text = "";
                textBox2.Focus();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ENTRAR NA TELA login
            loginForm1 loginForm1 = new loginForm1();
            loginForm1.ShowDialog();
        }
    }
}