using System;
using System.Windows.Forms;

namespace LivroDeRegistos_v1.gui
{
    public partial class Statistics : Form
    {
        private Registo_Livro registo_Livro;
        public Statistics()
        {
            this.InitializeComponent();
        }

        private void pnlEdit_Paint(object sender, PaintEventArgs e)
        {
        }
        public Panel Get_StatistcsPan()
        {
            return this.pnlStatistics;
        }
        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void bttRefresh_Click(object sender, EventArgs e)
        {
            Registo_Livro registo_Livro = new Registo_Livro();

            int totalExemplares = registo_Livro.GetTotalExemplares();
            int totalAutores = registo_Livro.GetTotalAutores();
            // Other counts for nº de compras, nº de ofertas, etc.

            int disponiveis = registo_Livro.GetTotalEstado("Disponível");
            int indisponiveis = registo_Livro.GetTotalEstado("Indisponível");
            int emExposicao = registo_Livro.GetTotalEstado("Exposição");
            int consultaLocal = registo_Livro.GetTotalEstado("Consulta local");
            int abatidos = registo_Livro.GetTotalEstado("Abatido");
            int perdidos = registo_Livro.GetTotalEstado("Perdido");
            int emDeposito = registo_Livro.GetTotalEstado("Depósito");
            int compras = registo_Livro.GetTotalAqi("Compra");
            int ofertas = registo_Livro.GetTotalAqi("Oferta");
                
            txtNExemplares.Texts = totalExemplares.ToString();
            txtNAutores.Texts = totalAutores.ToString();
            txtNCompras.Texts = compras.ToString();
            txtNOfertas.Texts = ofertas.ToString();
            // Update other text boxes for counts.
            txtDisponiveis.Texts = disponiveis.ToString();
            txtIndisponiveis.Texts = indisponiveis.ToString();
            txtExposicao.Texts = emExposicao.ToString();
            txtConsultaL.Texts = consultaLocal.ToString();
            txtAbatidos.Texts = abatidos.ToString();
            txtPerdidos.Texts = perdidos.ToString();
            txtDeposito.Texts = emDeposito.ToString();
        }
    }
}