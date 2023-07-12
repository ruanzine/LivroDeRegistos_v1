using System;
using System.Data;
using System.Windows.Forms;

namespace LivroDeRegistos_v1
{
    public partial class MainForm : Form
    {
        //private Registo_Livro registo_livro;
        public MainForm()
        {
            InitializeComponent();
        }

        //COLOCAR ADICIONAR DUAS COLUNAS -> Aquisição e Editora

        private void bttAdd_Click_1(object sender, EventArgs e)
        {
            SaveData();
        }
        //private void bttSearch_Click(object sender, EventArgs e)
        //{
        //    registo_livro = new Registo_Livro();
        //    FillDGV();
        //}

        //public void FillDGV()
        //{
        //    try
        //    {

        //        dgvListagem.DataSource = null;
        //        DataTable dt = registo_livro.GetBooks();
        //        dt.Columns["Nº"].SetOrdinal(0); // Define a coluna "Nº de Registo" como a primeira coluna
        //        dgvListagem.DataSource = dt;
        //        ResizeData();



        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ocorreu um erro ao obter os livros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //public void ResizeData()
        //{
        //    dgvListagem.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna
        //    dgvListagem.Columns["Nº"].Width = 40; // Define a largura da coluna
        //    dgvListagem.Columns["Data de Entrega"].Width = 90;
        //    dgvListagem.Columns["Data de Entrega"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvListagem.Columns["Título"].Width = 200;
        //    dgvListagem.Columns["Autor"].Width = 140;
        //    dgvListagem.Columns["Cota da CDU"].Width = 100;
        //    dgvListagem.Columns["Nº de Volume"].Width = 53;
        //    dgvListagem.Columns["Nº de Volume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvListagem.Columns["Observações"].Width = 150;
        //}

        void SaveData()
        {
            string dataEntrega = txtDataEntrega.Texts;
            string titulo = txtTitulo.Texts;
            string autor = txtAutor.Texts;
            string cota = txtCota.Texts;
            string nVolume = txtNVolume.Texts;
            string aquisicao = rjComboBox_Aqi.Texts;
            string editora = txtEditora.Texts;
            string observacoes = txtObservacoes.Texts;
            string estado = rjComboBox_Est.Texts;

            Registo_Livro save = new Registo_Livro();

            save.SaveData(dataEntrega, titulo, autor, cota, nVolume, aquisicao, editora, observacoes, estado);

        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
