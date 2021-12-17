using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Pagina // Página de interação como banco de dados
    {
        private string sqlConn()
        {
            return ConfigurationManager.AppSettings["sqlConn"];
        }

        public DataTable Lista()
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))
            {
                string queryString = "select * from paginas";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public void Salvar(int id, string nome, string conteudo, DateTime data)
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))

            {

              //  string queryString = "insert into paginas(nome, data, conteudo) values('" + nome + "','" + data.ToString("yyyy-MMMM-dd HH:mm:sss") + "','" + conteudo +"')";
                string queryString = "insert into paginas(nome, data, conteudo) values (@nome, @data, @conteudo)";
                if(id != 0)
                {
                    //queryString = "update paginas set nome=@nome, data='" + data.ToString("yyyy-MMMM-dd HH:mm:sss") + "', conteudo='" + conteudo + "' where id=" + id;
                    queryString = "update paginas set nome=@nome, data=@data, conteudo=@conteudo, where id=@id";
                }
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@data", data);
                command.Parameters.AddWithValue("@conteudo", conteudo);
                command.Parameters.AddWithValue("@id", id);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Excluir(int id)
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))
            {
                string queryString = "delete from paginas where id=" + id;
              
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable BuscarId(int id)
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))
            {
                string queryString = "select * from paginas where id=" + id;
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;

            }
        }
    }
}
