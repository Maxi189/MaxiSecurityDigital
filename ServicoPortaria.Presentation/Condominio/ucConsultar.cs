using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicoPortaria.Infra.Data.Repositories;
using ServicoPortaria.Presentation.Condominio.Forms;

namespace ServicoPortaria.Presentation.Condominio
{
    public partial class ucConsultar : UserControl
    {
        public ucConsultar()
        {
            InitializeComponent();
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            CondominioRepository repository = new CondominioRepository();
            dgvData.DataSource = repository.BuscarPorNome(nome); 
        }

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string cep = mskCEP.Text;

            CondominioRepository repository = new CondominioRepository();
            dgvData.DataSource = repository.BuscarPorCEP(cep);
        }

        private void txtCodPostal_TextChanged(object sender, EventArgs e)
        {
            string codPostal = txtCodPostal.Text;

            CondominioRepository repository = new CondominioRepository();
            dgvData.DataSource = repository.BuscarPorCodPostal(codPostal);
        }

        private void nudNumero_ValueChanged(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(nudNumero.Value);

            CondominioRepository repository = new CondominioRepository();
            dgvData.DataSource = repository.BuscarPorNumero(numero);
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            string cidade = txtCidade.Text;

            CondominioRepository repository = new CondominioRepository();
            dgvData.DataSource = repository.BuscarPorCidade(cidade);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cep = mskCEP.Text;
            string codPostal = txtCodPostal.Text;
            int numero = Convert.ToInt32(nudNumero.Value);
            string cidade = txtCidade.Text;

            CondominioRepository repository = new CondominioRepository();
            dgvData.DataSource = repository.BuscarComTodosOsFiltros(nome, cep, codPostal, numero, cidade);
        }

        private void mnsCondominio_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Application.Exit();
        }
        private void tsmPredio_Click(object sender, EventArgs e)
        {
            Predio.Forms.frmInserir inserir = new Predio.Forms.frmInserir();
            inserir.Show();
        }
        private void tsmMorador_Click(object sender, EventArgs e)
        {
            Morador.Forms.frmInserir form = new Morador.Forms.frmInserir();
            form.Show();
        }

        private void tsmApartamento_Click(object sender, EventArgs e)
        {
            Apartamento.Forms.frmInserir form = new Apartamento.Forms.frmInserir();
            form.Show();
        }

        private void tsmVisitante_Click(object sender, EventArgs e)
        {
            Visitante.Forms.frmInserir form = new Visitante.Forms.frmInserir();
            form.Show();
        }
        private void tsmVeiculo_Click(object sender, EventArgs e)
        {
            Veiculo.Forms.frmInserir form = new Veiculo.Forms.frmInserir();
            form.Show();
        }

        private void tsmPrestadorDeServicos_Click(object sender, EventArgs e)
        {
            PrestadorDeServicos.Forms.frmInserir form = new PrestadorDeServicos.Forms.frmInserir();
            form.Show();
        }

        private void tsmSindico_Click(object sender, EventArgs e)
        {
            Sindico.Forms.frmInserir form = new Sindico.Forms.frmInserir();
            form.Show();
        }

        private void tsmHomePage_Click(object sender, EventArgs e)
        {
            Login.Forms.frmLogin form = new Login.Forms.frmLogin();
            form.Show();
        }

        private void tsmVisita_Click(object sender, EventArgs e)
        {
            Visita.Forms.frmInserir form = new Visita.Forms.frmInserir();
            form.Show();
        }
    }
}
