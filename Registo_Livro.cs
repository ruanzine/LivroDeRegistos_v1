using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LivroDeRegistos_v1
{
    public class Registo_Livro : MainForm
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public void SaveData(string dataEntrega, string titulo,string autor, string cota, string nVolume, string aquisicao, string editora, string observacoes, string estado)
        {

            try
            {
                int autorID;
                int cotaID;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Verificar se o autor já existe na tabela "Autores"
                    using (SqlCommand cmd = new SqlCommand("SELECT ID FROM Autores WHERE Nome = @autor", conn))
                    {
                        cmd.Parameters.AddWithValue("@autor", autor);

                        var result = cmd.ExecuteScalar();
                        if (result != null)  // Autor já existe, recuperar o ID
                        {
                            autorID = (int)result;
                        }
                        else  // Autor não existe, criar uma nova entrada
                        {
                            cmd.CommandText = "INSERT INTO Autores (Nome) VALUES (@autor); SELECT SCOPE_IDENTITY();";

                            autorID = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }

                    // Verificar se a cota já existe na tabela "Cotas"
                    using (SqlCommand cmd = new SqlCommand("SELECT ID FROM Cotas WHERE Cota = @cota", conn))
                    {
                        cmd.Parameters.AddWithValue("@cota", cota);

                        var result = cmd.ExecuteScalar();
                        if (result != null)  // Cota já existe, recuperar o ID
                        {
                            cotaID = (int)result;
                        }
                        else  // Cota não existe, criar uma nova entrada
                        {
                            cmd.CommandText = "INSERT INTO Cotas (Cota) VALUES (@cota); SELECT SCOPE_IDENTITY();";

                            cotaID = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }

                    // Inserir os dados na tabela "Livros"
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Livros (DataDeEntrega, Titulo, AutorID, CotaID, NumVolume, Aquisicao, Editora, Observacoes, Estado) VALUES (@dataEntrega, @titulo, @autorID, @cotaID, @NumVolume, @aquisicao, @editora, @observacoes, @estado)", conn))
                    {
                        cmd.Parameters.AddWithValue("@dataEntrega", dataEntrega);
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@autorID", autorID);
                        cmd.Parameters.AddWithValue("@cotaID", cotaID);
                        cmd.Parameters.AddWithValue("@NumVolume", nVolume);
                        cmd.Parameters.AddWithValue("@aquisicao", aquisicao );
                        cmd.Parameters.AddWithValue("@editora", editora );
                        cmd.Parameters.AddWithValue("@observacoes", observacoes);
                        cmd.Parameters.AddWithValue("@estado", estado);

                        // Executar a query
                        cmd.ExecuteNonQuery();
                    }
                    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public DataTable GetBooks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT L.ID AS [Nº], L.DataDeEntrega AS [Data de Entrega], L.Titulo AS [Título], A.Nome AS Autor, C.Cota AS [Cota da CDU], L.Aquisicao AS [Aquisição], L.Editora AS [Editora] L.NumVolume AS [Nº de Volume], L.Observacoes AS [Observações], L.Estado
                            FROM Livros L
                            INNER JOIN Autores A ON L.AutorID = A.ID
                            INNER JOIN Cotas C ON L.CotaID = C.ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            return dt;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Trate o erro adequadamente ou lance uma exceção personalizada
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }


    }

}
