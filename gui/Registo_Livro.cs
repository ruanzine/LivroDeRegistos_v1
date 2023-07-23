﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LivroDeRegistos_v1.gui
{
    public class Registo_Livro : MainForm
    {
        /// <summary>
        /// The connection string used to connect to the database.
        /// </summary>
        public string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        /// <summary>
        /// Saves the data of a new book to the database.
        /// </summary>
        /// <param name="nRegisto">The registration number of the book.</param>
        /// <param name="dataEntrega">The delivery date of the book.</param>
        /// <param name="titulo">The title of the book.</param>
        /// <param name="autor">The author of the book.</param>
        /// <param name="cota">The reference number of the book.</param>
        /// <param name="nVolume">The volume number of the book.</param>
        /// <param name="aquisicao">The acquisition type of the book.</param>
        /// <param name="editora">The publisher of the book.</param>
        /// <param name="observacoes">The observations of the book.</param>
        /// <param name="estado">The status of the book.</param>
        /// <exception cref="SqlException">Thrown when an error occurs while saving the data to the database.</exception>
        public void SaveData(int nRegisto, DateTime dataEntrega, string titulo, string autor, string cota, string nVolume, string aquisicao, string editora, string observacoes, string estado)
        {
            
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

        /// <summary>
        /// Retrieves all books from the database.
        /// </summary>
        /// <returns>A DataTable containing the book data.</returns>
        /// <exception cref="Exception">Thrown when an error occurs while retrieving the books from the database.</exception>
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

        /// <summary>
        /// Retrieves a list of books from the database for editing purposes.
        /// </summary>
        /// <returns>A list of books.</returns>
        /// <exception cref="SqlException">Thrown when an error occurs while retrieving the books from the database.</exception>
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

        /// <summary>
        /// Updates the information of a book in the database.
        /// </summary>
        /// <param name="numeroRegistro">The registration number of the book.</param>
        /// <param name="dataEntrega">The delivery date of the book.</param>
        /// <param name="titulo">The title of the book.</param>
        /// <param name="autor">The author of the book.</param>
        /// <param name="cota">The call number of the book.</param>
        /// <param name="aquisicao">The acquisition type of the book.</param>
        /// <param name="editora">The publisher of the book.</param>
        /// <param name="numeroVolume">The volume number of the book.</param>
        /// <param name="observacoes">The observations of the book.</param>
        /// <param name="estado">The status of the book.</param>
        /// <exception cref="SqlException">Thrown when an error occurs while updating the book in the database.</exception>
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
       
        /// <summary>
        /// Deletes a book from the database based on the registration number.
        /// </summary>
        /// <param name="numeroRegistro">The registration number of the book to delete.</param>
        /// <exception cref="SqlException">Thrown when an error occurs while deleting the book from the database.</exception>
        public void DeleteBook(int numeroRegistro)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Livros WHERE ID = @NumeroRegistro", conn);
                command.Parameters.AddWithValue("@NumeroRegistro", numeroRegistro);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        /// <summary>
        /// Retrieves all registration numbers and corresponding titles from the database.
        /// </summary>
        /// <returns>A DataTable containing the registration numbers and titles of all books.</returns>
        /// <exception cref="SqlException">Thrown when an error occurs while retrieving the registration numbers from the database.</exception>
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

        /// <summary>
        /// Retrieves all authors from the database.
        /// </summary>
        /// <returns>A DataTable containing the names of all authors.</returns>
        /// <exception cref="SqlException">Thrown when an error occurs while retrieving the authors from the database.</exception>
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

        /// <summary>
        /// Retrieves all titles from the database.
        /// </summary>
        /// <returns>A DataTable containing the names of all titles.</returns>
        /// <exception cref="SqlException">Thrown when an error occurs while retrieving the titles from the database.</exception>
        public DataTable GetAllTitles()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT TituloNome AS [Título] FROM Titulos WHERE TituloNome <> '-'";

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

        /// <summary>
        /// Retrieves all cotas from the database.
        /// </summary>
        /// <returns>A DataTable containing the cotas.</returns>
        /// <exception cref="Exception">Thrown when an error occurs while fetching the cotas.</exception>
        public DataTable GetAllCotas()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT Cota FROM Cotas WHERE Cota <> '-'";

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

        /// <summary>
        /// Retrieves all lost books from the database.
        /// </summary>
        /// <returns>A DataTable containing the lost books' information.</returns>
        /// <exception cref="Exception">Thrown when an error occurs while fetching the lost books.</exception>
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

        /// <summary>
        /// Retrieves a book from the database based on its unique registration number.
        /// </summary>
        /// <param name="numeroRegistro">The registration number of the book to retrieve.</param>
        /// <returns>A DataTable containing the book's information.</returns>
        /// <exception cref="Exception">Thrown when an error occurs while fetching the book.</exception>
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

        /// <summary>
        /// Retrieves books from the database based on the specified author name.
        /// </summary>
        /// <param name="autor">The author's name to search for.</param>
        /// <returns>A DataTable containing the books' information.</returns>
        /// <exception cref="Exception">Thrown when an error occurs while fetching the books.</exception>
        public DataTable GetBooksByAutor(string autor)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT L.ID AS [Nº], L.DataDeEntrega AS [Data de Entrada], T.TituloNome AS [Título], A.Nome AS [Autor], C.Cota, L.Aquisicao AS [Aquisição], L.Editora AS [Editora], L.NumVolume AS [Nº de Volume], L.Observacoes AS [Observações], L.Estado
                            FROM Livros L
                            INNER JOIN Autores A ON L.AutorID = A.ID
                            INNER JOIN Cotas C ON L.CotaID = C.ID
                            INNER JOIN Titulos T ON L.TituloID = T.ID
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

        /// <summary>
        /// Retrieves books from the database based on the specified title.
        /// </summary>
        /// <param name="titulo">The title to search for.</param>
        /// <returns>A DataTable containing the books' information.</returns>
        /// <exception cref="Exception">Thrown when an error occurs while fetching the books.</exception>
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

        /// <summary>
        /// Retrieves books from the database based on the specified cota (code).
        /// </summary>
        /// <param name="cota">The cota to search for.</param>
        /// <returns>A DataTable containing the books' information.</returns>
        /// <exception cref="Exception">Thrown when an error occurs while fetching the books.</exception>
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

        /// <summary>
        /// Retrieves books from the database based on the specified status (estado).
        /// </summary>
        /// <param name="estado">The estado to search for.</param>
        /// <returns>A DataTable containing the books' information.</returns>
        /// <exception cref="Exception">Thrown when an error occurs while fetching the books.</exception>
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

        /// <summary>
        /// Retrieves the ID of an author from the database based on the specified author name.
        /// </summary>
        /// <param name="authorName">The name of the author to search for.</param>
        /// <returns>The ID of the author if found; otherwise, returns -1 if the author is not found.</returns>
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

        /// <summary>
        /// Creates a new author in the database with the specified author name.
        /// </summary>
        /// <param name="authorName">The name of the author to create.</param>
        /// <returns>The ID of the newly created author.</returns>
        /// <exception cref="Exception">Thrown when an error occurs while creating the author.</exception>
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

        /// <summary>
        /// Retrieves the ID of a cota from the database based on the specified cota name.
        /// </summary>
        /// <param name="cotaName">The name of the cota to search for.</param>
        /// <returns>The ID of the cota if found; otherwise, returns -1 if the cota is not found.</returns> 
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

        /// <summary>
        /// Creates a new cota in the database with the specified cota name.
        /// </summary>
        /// <param name="cotaName">The name of the cota to create.</param>
        /// <returns>The ID of the newly created cota.</returns>
        /// <exception cref="Exception">Thrown when an error occurs while creating the cota.</exception>
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

        /// <summary>
        /// Retrieves the next available ID for new records in the "Livros" table.
        /// </summary>
        /// <param name="idRegisto">The ID to be assigned to the new record.</param>
        /// <returns>The next available ID for new records.</returns>
        /// <exception cref="Exception">Thrown when an error occurs while retrieving the next ID.</exception>
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

        /// <summary>
        /// Checks if a registration number exists in the "Livros" table.
        /// </summary>
        /// <param name="registrationNumber">The registration number to check for existence.</param>
        /// <returns>True if the registration number exists in the database; otherwise, false.</returns>
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

        /// <summary>
        /// Gets the next available registration number for a book in the "Livros" table.
        /// </summary>
        /// <returns>The next available registration number.</returns>
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

        /// <summary>
        /// Retrieves a list of author names from the "Autores" table.
        /// </summary>
        /// <returns>A list of author names.</returns>
        public List<string> GetAuthors_List()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Nome FROM Autores WHERE Nome <> '-'", conn);
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

        /// <summary>
        /// Retrieves a list of cota names from the "Cotas" table.
        /// </summary>
        /// <returns>A list of cota names.</returns>
        public List<string> GetCotas_List()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Cota  FROM Cotas WHERE Cota <> '-' ", conn);
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

        /// <summary>
        /// Retrieves a list of title names from the "Titulos" table.
        /// </summary>
        /// <returns>A list of title names.</returns>
        public List<string> GetTitles_List()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT TituloNome  FROM Titulos WHERE TituloNome <> '-' ", conn);
                SqlDataReader reader = command.ExecuteReader();
                List<string> titulos = new List<string>();
                while (reader.Read())
                {
                    string titulo = reader.GetString(0);
                    titulos.Add(titulo);
                }
                conn.Close();
                return titulos;
            }
        }

        /// <summary>
        /// Retrieves a list of books by the specified author from the "Livros" table.
        /// </summary>
        /// <param name="autor">The name of the author to filter the books.</param>
        /// <returns>A DataTable containing the books by the specified author.</returns>
        public DataTable GetBooksByAuthor_Listing(string autor)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT L.ID AS [Nº de Registo], T.TituloNome AS [Título], C.Cota, L.Estado " +
                    "FROM Livros L INNER JOIN Titulos T ON T.ID = L.TituloID " +
                    "INNER JOIN Autores A ON A.ID = L.AutorID " +
                    "INNER JOIN Cotas C ON C.ID = L.CotaID  WHERE A.Nome = @Autor AND A.Nome <> '-'", conn);
                command.Parameters.AddWithValue("@Autor", autor);
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                conn.Close();

                return dataTable;
            }
        }

        /// <summary>
        /// Retrieves a list of books by the specified cota from the "Livros" table.
        /// </summary>
        /// <param name="cota">The cota name to filter the books.</param>
        /// <returns>A DataTable containing the books by the specified cota.</returns>
        public DataTable GetBooksByCota_Listing(string cota)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT L.ID AS [Nº de Registo], T.TituloNome AS [Título], C.Cota " +
                                        "FROM Livros L INNER JOIN Titulos T ON T.ID = L.TituloID " +
                                        "INNER JOIN Cotas C ON C.ID = L.CotaID  WHERE C.Cota = @Cota", conn);
                command.Parameters.AddWithValue("@Cota", cota);
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                conn.Close();

                return dataTable;
            }
        }

        /// <summary>
        /// Retrieves a list of books with delivery dates between the specified date range from the "Livros" table.
        /// </summary>
        /// <param name="dataDe">The start date of the date range.</param>
        /// <param name="dataAte">The end date of the date range.</param>
        /// <returns>A DataTable containing the books within the specified date range.</returns>
        public DataTable GetBooksByDate_Listing(DateTime dataDe, DateTime dataAte)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT L.ID AS [Nº de Registo], T.TituloNome AS [Título], C.Cota, L.Estado, " +
                                                    "A.Nome AS [Autor], L.DataDeEntrega AS [Data de Entrada], L.Aquisicao, " +
                                                    "L.Editora, L.NumVolume AS [Nº de Volume], L.Observacoes AS [Observações]" +
                                                    "FROM Livros L " +
                                                    "INNER JOIN Titulos T ON T.ID = L.TituloID " +
                                                    "INNER JOIN Cotas C ON C.ID = L.CotaID " +
                                                    "INNER JOIN Autores A ON A.ID = L.AutorID " +
                                                    "WHERE L.DataDeEntrega BETWEEN @DataDe AND @DataAte", conn);
                command.Parameters.AddWithValue("@DataDe", dataDe);
                command.Parameters.AddWithValue("@DataAte", dataAte);
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                conn.Close();

                return dataTable;
            }
        }

        /// <summary>
        /// Retrieves a list of books by the specified title from the "Livros" table using a LIKE filter on the title.
        /// </summary>
        /// <param name="titulo">The title to filter the books.</param>
        /// <returns>A DataTable containing the books by the specified title.</returns>
        public DataTable GetBooksByTitle_Listing(string titulo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT L.ID AS [Nº de Registo], T.TituloNome AS [Título], C.Cota
                            FROM Livros L
                            INNER JOIN Cotas C ON L.CotaID = C.ID
                            INNER JOIN Titulos T ON L.TituloID = T.ID
                            WHERE T.TituloNome LIKE @titulo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@titulo", titulo);

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

        /// <summary>
        /// Retrieves a list of books with the specified estado (status) from the "Livros" table.
        /// </summary>
        /// <param name="estado">The estado (status) to filter the books.</param>
        /// <returns>A DataTable containing the books with the specified estado.</returns>
        public DataTable GetBooksByEstado_L(string estado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT L.ID AS [Nº], L.DataDeEntrega AS [Data de Entrada], T.TituloNome AS [Título], A.Nome AS [Autor], C.Cota, L.Aquisicao AS [Aquisição], L.Editora AS [Editora], L.NumVolume AS [Nº de Volume], L.Observacoes AS [Observações], L.Estado
                            FROM Livros L
                            INNER JOIN Autores A ON L.AutorID = A.ID
                            INNER JOIN Cotas C ON L.CotaID = C.ID
                            INNER JOIN Titulos T ON L.TituloID = T.ID
                            WHERE L.Estado = @estado";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@estado", estado);

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


        /// <summary>
        /// Retrieves the total number of exemplares (books) present in the "Livros" table.
        /// </summary>
        /// <returns>The total number of exemplares.</returns>
        public int GetTotalExemplares()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Livros";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error while getting total exemplares: " + ex.Message);
            }
        }

        /// <summary>
        /// Retrieves the total number of authors (autores) present in the "Autores" table.
        /// </summary>
        /// <returns>The total number of authors.</returns>
        public int GetTotalAutores()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Autores WHERE Nome <> '-'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error while getting total autores: " + ex.Message);
            }
        }

        /// <summary>
        /// Retrieves the total number of exemplares (books) with the specified estado (status).
        /// </summary>
        /// <param name="estado">The estado (status) to filter the exemplares.</param>
        /// <returns>The total number of exemplares with the specified estado.</returns>
        public int GetTotalEstado(string estado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Livros WHERE Estado = @estado";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@estado", estado);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error while getting exemplares by estado: " + ex.Message);
            }
        }

        /// <summary>
        /// Retrieves the total number of exemplares (books) with the specified aquisicao (acquisition type).
        /// </summary>
        /// <param name="aquisicao">The aquisicao (acquisition type) to filter the exemplares.</param>
        /// <returns>The total number of exemplares with the specified aquisicao.</returns>
        public int GetTotalAqi(string aquisicao)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Livros WHERE Aquisicao = @aquisicao";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@aquisicao", aquisicao);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error while getting exemplares by aquisição: " + ex.Message);
            }
        }


    }
}