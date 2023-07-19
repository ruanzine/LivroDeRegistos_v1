using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LivroDeRegistos_v1.gui
{
    public class Registo_Livro  : MainForm
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public void SaveData(int nRegisto, DateTime dataEntrega, string titulo, string autor, string cota, string nVolume, string aquisicao, string editora, string observacoes, string estado)
        {
            if (this.IsRegistrationNumberExists(nRegisto)) MessageBox.Show("Houve uma falha ao registar: este Nº de registo já existe", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            try
            {
                int autorID;
                int cotaID;
                int tituloID;

                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    // Verificar se o autor já existe na tabela "Autores"
                    using (SqlCommand cmd = new SqlCommand("SELECT ID FROM Autores WHERE Nome = @autor", conn))
                    {
                        cmd.Parameters.AddWithValue("@autor", autor);

                        object result = cmd.ExecuteScalar();
                        if (result != null) // Autor já existe, recuperar o ID
                        {
                            autorID = (int)result;
                        }
                        else // Autor não existe, criar uma nova entrada
                        {
                            cmd.CommandText = "INSERT INTO Autores (Nome) VALUES (@autor); SELECT SCOPE_IDENTITY();";

                            autorID = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }

                    // Verificar se a cota já existe na tabela "Cotas"
                    using (SqlCommand cmd = new SqlCommand("SELECT ID FROM Cotas WHERE Cota = @cota", conn))
                    {
                        cmd.Parameters.AddWithValue("@cota", cota);

                        object result = cmd.ExecuteScalar();
                        if (result != null) // Cota já existe, recuperar o ID
                        {
                            cotaID = (int)result;
                        }
                        else // Cota não existe, criar uma nova entrada
                        {
                            cmd.CommandText = "INSERT INTO Cotas (Cota) VALUES (@cota); SELECT SCOPE_IDENTITY();";

                            cotaID = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }

                    // Verificar se o autor já existe na tabela "Titulos"
                    using (SqlCommand cmd = new SqlCommand("SELECT ID FROM Titulos WHERE TituloNome = @titulo", conn))
                    {
                        cmd.Parameters.AddWithValue("@titulo", titulo);

                        object result = cmd.ExecuteScalar();
                        if (result != null) // Autor já existe, recuperar o ID
                        {
                            tituloID = (int)result;
                        }
                        else // Autor não existe, criar uma nova entrada
                        {
                            cmd.CommandText = "INSERT INTO Titulos (TituloNome) VALUES (@titulo); SELECT SCOPE_IDENTITY();";

                            tituloID = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }


                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Livros (ID, DataDeEntrega, TituloID, AutorID, CotaID, NumVolume, Aquisicao, Editora, Observacoes, Estado) VALUES (@id, @dataEntrega, @tituloID, @autorID, @cotaID, @NumVolume, @aquisicao, @editora, @observacoes, @estado)", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", nRegisto);
                        cmd.Parameters.AddWithValue("@dataEntrega", dataEntrega);
                        cmd.Parameters.AddWithValue("@tituloID", tituloID);
                        cmd.Parameters.AddWithValue("@autorID", autorID);
                        cmd.Parameters.AddWithValue("@cotaID", cotaID);
                        cmd.Parameters.AddWithValue("@NumVolume", nVolume);
                        cmd.Parameters.AddWithValue("@aquisicao", aquisicao);
                        cmd.Parameters.AddWithValue("@editora", editora);
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
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT L.ID AS [Nº], L.DataDeEntrega AS [Data de Entrada], T.TituloNome AS [Título], A.Nome AS Autor, C.Cota, L.Aquisicao AS [Aquisição], L.Editora AS [Editora], L.NumVolume AS [Nº de Volume], L.Observacoes AS [Observações], L.Estado
                            FROM Livros L
                            INNER JOIN Autores A ON L.AutorID = A.ID
                            INNER JOIN Cotas C ON L.CotaID = C.ID
                            INNER JOIN Titulos T ON L.TituloID = T.ID";


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
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }
        public List<Livro> GetBooks_Edit()
        {
            try
            {
                List<Livro> livros = new List<Livro>();

                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT L.ID AS NumeroRegistro, L.DataDeEntrega, T.TituloNome AS Titulo, A.Nome AS Autor, C.Cota, L.Aquisicao, L.Editora, L.NumVolume AS NumeroVolume, L.Observacoes, L.Estado
                            FROM Livros L
                            INNER JOIN Autores A ON L.AutorID = A.ID
                            INNER JOIN Cotas C ON L.CotaID = C.ID
                            INNER JOIN Titulos T ON L.TituloID = T.ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Livro livro = new Livro
                                {
                                    NumeroRegistro = reader.GetInt32(reader.GetOrdinal("NumeroRegistro")),
                                    DataEntrada = reader.GetDateTime(reader.GetOrdinal("DataDeEntrega")),
                                    Titulo = reader.GetString(reader.GetOrdinal("Titulo")),
                                    Autor = reader.GetString(reader.GetOrdinal("Autor")),
                                    Cota = reader.GetString(reader.GetOrdinal("Cota")),
                                    Aquisicao = reader.GetString(reader.GetOrdinal("Aquisicao")),
                                    Editora = reader.GetString(reader.GetOrdinal("Editora")),
                                    NumeroVolume = reader.GetString(reader.GetOrdinal("NumeroVolume")),
                                    Observacoes = reader.GetString(reader.GetOrdinal("Observacoes")),
                                    Estado = reader.GetString(reader.GetOrdinal("Estado"))
                                };

                                livros.Add(livro);
                            }
                        }
                    }
                }

                return livros;
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }
        public void UpdateBook(int numeroRegistro, DateTime dataEntrega, string titulo, string autor, string cota, string aquisicao, string editora, string numeroVolume, string observacoes, string estado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    // Criar a consulta SQL para atualização do registro
                    string query = @"UPDATE Livros SET
                                DataDeEntrega = @dataEntrega,
                                TituloID = (SELECT ID FROM Titulos WHERE TituloNome = @titulo),
                                AutorID = (SELECT ID FROM Autores WHERE Nome = @autor),
                                CotaID = (SELECT ID FROM Cotas WHERE Cota = @cota),
                                Aquisicao = @aquisicao,
                                Editora = @editora,
                                NumVolume = @numeroVolume,
                                Observacoes = @observacoes,
                                Estado = @estado
                                WHERE ID = @numeroRegistro";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dataEntrega", dataEntrega);
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@autor", autor);
                        cmd.Parameters.AddWithValue("@cota", cota);
                        cmd.Parameters.AddWithValue("@aquisicao", aquisicao);
                        cmd.Parameters.AddWithValue("@editora", editora);
                        cmd.Parameters.AddWithValue("@numeroVolume", numeroVolume);
                        cmd.Parameters.AddWithValue("@observacoes", observacoes);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@numeroRegistro", numeroRegistro);

                        // Executar a consulta SQL
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao atualizar o registro: " + ex.Message);
            }
        }
        public DataTable GetAllNRegs()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT L.ID AS [Nº de Registo], T.TituloNome AS [Título]
                                    FROM Livros L
                                    INNER JOIN Titulos T ON L.TituloID = T.ID";

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
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }
        public DataTable GetAllAuthors()
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT Nome AS [Autor]
                            FROM Autores";
                            
                         

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
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }
        public DataTable GetAllTitles()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT TituloNome AS [Título] FROM Titulos";

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
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }
        public DataTable GetAllCotas()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT Cota FROM Cotas";

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
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }
        public DataTable GetAllLost()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT L.ID AS [Nº de Registo], T.TituloNome AS [Título], L.Estado 
                                    FROM Livros L
                                    INNER JOIN Titulos T ON L.TituloID = T.ID";

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
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }
        public DataTable GetBooksByNumeroRegistro(int numeroRegistro)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT L.ID AS [Nº], L.DataDeEntrega AS [Data de Entrada], 
                            T.TituloNome AS [Título], A.Nome AS Autor, C.Cota, 
                            L.Aquisicao AS [Aquisição], L.Editora AS [Editora], 
                            L.NumVolume AS [Nº de Volume], L.Observacoes AS [Observações], L.Estado
                            FROM Livros L
                            INNER JOIN Autores A ON L.AutorID = A.ID
                            INNER JOIN Cotas C ON L.CotaID = C.ID
                            INNER JOIN Titulos T ON L.TituloID = T.ID
                            WHERE L.ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", numeroRegistro);

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
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }
        public DataTable GetBooksByAutor(string autor)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT L.ID AS [Nº], L.DataDeEntrega AS [Data de Entrada], T.TituloNome AS [Título], A.Nome AS Autor, C.Cota, L.Aquisicao AS [Aquisição], L.Editora AS [Editora], L.NumVolume AS [Nº de Volume], L.Observacoes AS [Observações], L.Estado
                            FROM Livros L
                            INNER JOIN Autores A ON L.AutorID = A.ID
                            INNER JOIN Cotas C ON L.CotaID = C.ID
                            INNER JOIN Titulos T ON T.TituloID = T.ID
                            WHERE A.Nome LIKE @autor";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@autor", autor + "%");

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
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }
        public DataTable GetBooksByTitulo(string titulo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT L.ID AS [Nº], L.DataDeEntrega AS [Data de Entrada], T.TituloNome AS [Título], A.Nome AS Autor, C.Cota, L.Aquisicao AS [Aquisição], L.Editora AS [Editora], L.NumVolume AS [Nº de Volume], L.Observacoes AS [Observações], L.Estado
                            FROM Livros L
                            INNER JOIN Autores A ON L.AutorID = A.ID
                            INNER JOIN Cotas C ON L.CotaID = C.ID
                            INNER JOIN Titulos T ON L.TituloID = T.ID
                            WHERE T.TituloNome LIKE @titulo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@titulo", titulo + "%");

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
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }
        public DataTable GetBooksByCota(string cota)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT L.ID AS [Nº], L.DataDeEntrega AS [Data de Entrada], T.TituloNome AS [Título], A.Nome AS Autor, C.Cota, L.Aquisicao AS [Aquisição], L.Editora AS [Editora], L.NumVolume AS [Nº de Volume], L.Observacoes AS [Observações], L.Estado
                            FROM Livros L
                            INNER JOIN Autores A ON L.AutorID = A.ID
                            INNER JOIN Cotas C ON L.CotaID = C.ID
                            INNER JOIN Titulos T ON L.TituloID = T.ID
                            WHERE C.Cota LIKE @cota";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cota", "%" + cota + "%");

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
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }
        public DataTable GetBooksByEstado(string estado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT L.ID AS [Nº], L.DataDeEntrega AS [Data de Entrada], T.TituloNome AS [Título], A.Nome AS Autor, C.Cota, L.Aquisicao AS [Aquisição], L.Editora AS [Editora], L.NumVolume AS [Nº de Volume], L.Observacoes AS [Observações], L.Estado
                            FROM Livros L
                            INNER JOIN Autores A ON L.AutorID = A.ID
                            INNER JOIN Cotas C ON L.CotaID = C.ID
                            INNER JOIN Titulos T ON L.TituloID = T.ID
                            WHERE L.Estado LIKE @estado";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@estado", estado + "%");

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
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }
        public int GetAuthorID(string authorName)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();

                string query = "SELECT ID FROM Autores WHERE Nome = @Nome";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", authorName);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return (int)result;
                    else
                        return -1; // Autor não encontrado
                }
            }
        }
        public int CreateAuthor(string authorName)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Autores (Nome) VALUES (@Nome); SELECT SCOPE_IDENTITY()";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", authorName);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return Convert.ToInt32(result);
                    else
                        throw new Exception("Erro ao criar autor."); // Erro ao criar autor
                }
            }
        }
        public int GetCotaID(string cotaName)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();

                string query = "SELECT ID FROM Cotas WHERE Cota = @Cota";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cota", cotaName);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return (int)result;
                    else
                        return -1; // Cota não encontrada
                }
            }
        }
        public int CreateCota(string cotaName)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Cotas (Cota) VALUES (@Cota); SELECT SCOPE_IDENTITY()";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cota", cotaName);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return Convert.ToInt32(result);
                    else
                        throw new Exception("Erro ao criar cota."); // Erro ao criar cota
                }
            }
        }
        public string GetId(string idRegisto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT MAX(ID) + 1
                            FROM Livros";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        idRegisto = cmd.ExecuteScalar().ToString();
                        return idRegisto;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }
        public bool IsRegistrationNumberExists(int registrationNumber)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Livros WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", registrationNumber);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }
        public int GetNextRegistrationNumber()
        {
            int nextRegistrationNumber = 1;

            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();

                string query = "SELECT ID FROM Livros ORDER BY ID ASC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int currentRegistrationNumber = reader.GetInt32(reader.GetOrdinal("ID"));

                            if (currentRegistrationNumber == nextRegistrationNumber)
                                nextRegistrationNumber++;
                            else
                                // Found an available registration number
                                break;
                        }
                    }
                }
            }

            return nextRegistrationNumber;
        }
        public int GetLastRN()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT MAX(ID) FROM Livros";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();


                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao obter o próximo número de registro: " + ex.Message);
            }
        }
        public List<int> GetAvailableRegistrationNumbers(int startNumber, int endNumber)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT ID FROM Livros WHERE ID >= @startNumber AND ID <= @endNumber";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@startNumber", startNumber);
                        cmd.Parameters.AddWithValue("@endNumber", endNumber);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<int> usedNumbers = new List<int>();
                            while (reader.Read())
                            {
                                int registrationNumber = reader.GetInt32(reader.GetOrdinal("ID"));
                                usedNumbers.Add(registrationNumber);
                            }

                            List<int> availableNumbers = new List<int>();
                            for (int i = startNumber; i <= endNumber; i++)
                                if (!usedNumbers.Contains(i))
                                    availableNumbers.Add(i);

                            return availableNumbers;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao obter os números de registro disponíveis: " + ex.Message);
            }
        }
        public List<string> GetAuthors_List()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Nome FROM Autores", conn);
                SqlDataReader reader = command.ExecuteReader();
                List<string> autores = new List<string>();
                while (reader.Read())
                {
                    string autor = reader.GetString(0);
                    autores.Add(autor);
                }
                conn.Close();
                return autores;
            }
        }
        public List<string> GetCotas_List()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Cota  FROM Cotas ", conn);
                SqlDataReader reader = command.ExecuteReader();
                List<string> cotas = new List<string>();
                while (reader.Read())
                {
                    string cota = reader.GetString(0);
                    cotas.Add(cota);
                }
                conn.Close();
                return cotas;
            }
        }
        public DataTable GetBooksByAuthor_Listing(string autor)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT L.ID AS [Nº de Registo], T.TituloNome AS [Título], C.Cota, L.Estado " +
                    "FROM Livros L INNER JOIN Titulos T ON T.ID = L.TituloID " +
                    "INNER JOIN Autores A ON A.ID = L.AutorID " +
                    "INNER JOIN Cotas C ON C.ID = L.CotaID  WHERE A.Nome = @Autor", conn);
                command.Parameters.AddWithValue("@Autor", autor);
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                conn.Close();

                return dataTable;
            }
        }


    }
}