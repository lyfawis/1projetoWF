using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace _1projetoWF
{
    public class Conexao
    {
        public SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Jovem Programador;Data Source=aline\\SQLEXPRESS");


        public void Conectar()
        {
            conn.Open();
        }
        public void Desconectar()
        {
            conn.Close();
        }
    



       public bool BuscarUsuario(string usuario, string senha)
       {
        string sql = $"select * from Usuario where Usuario = '{usuario}' and Senha = '{senha}' ";
        SqlCommand comando = new SqlCommand(sql, conn);



          var retorno = comando.ExecuteReader();



          if (retorno.Read())
            return true;



          return false;



       }


        public List<Aluno> BuscarAluno()
        {
            string sql = "select Nome, Idade, Telefone, Email from Aluno";
            SqlCommand comando = new SqlCommand(sql, conn);



            List<Aluno> aluno = new List<Aluno>();



            using (var reader = comando.ExecuteReader())
            { //cria um leitor do ADO.Net
                while (reader.Read())
                { //vai lendo cada item do resultado do select
                  //retorna sob demanda cada item encontrado
                    var NomeDb = reader.GetString(reader.GetOrdinal("Nome"));
                    var IdadeDb = reader.GetString(reader.GetOrdinal("Idade"));
                    var TelefoneDb = reader.GetString(reader.GetOrdinal("Telefone"));
                    var EmailDb = reader.GetString(reader.GetOrdinal("Email"));




                    aluno.Add(new Aluno()
                    {
                        Nome = NomeDb,
                        Idade = IdadeDb,
                        Email = EmailDb,
                        Telefone = TelefoneDb




                    });



                }
                return aluno;
            }


        }
    }
}
