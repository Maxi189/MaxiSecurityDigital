using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.Visitante
{
    public partial class ucConsultar : UserControl
    {
        public ucConsultar()
        {
            InitializeComponent();
        }
        private void txtNome_TextChanged(object sender, EventArgs e) 
        {
            Infra.Data.Repositories.VisitanteRepository repository = new();

            dgvData.DataSource = repository.BuscarPorNome(txtNome.Text);
        }
        private void txtSobrenome_TextChanged(object sender, EventArgs e) 
        {
            Infra.Data.Repositories.VisitanteRepository repository = new();

            dgvData.DataSource = repository.BuscarPorSobrenome(txtSobrenome.Text);
        }
        private void mtxCPF_TextChanged(object sender, EventArgs e) 
        {
            Infra.Data.Repositories.VisitanteRepository repository = new();

            dgvData.DataSource = repository.BuscarPorCPF(mtxCPF.Text);
        }
        private void mtxCPF_MaskInputRejected(object sender, EventArgs e) 
        {

        }
        private void mtxRG_TextChanged(object sender, EventArgs e) 
        {
            Infra.Data.Repositories.VisitanteRepository repository = new();

            dgvData.DataSource = repository.BuscarPorSobrenome(mtxRG.Text);
        }
        private void mtxRG_MaskInputRejected(object sender, EventArgs e) 
        {

        }
        private void txtDocCivil_TextChanged(object sender, EventArgs e) 
        {
            Infra.Data.Repositories.VisitanteRepository repository = new();

            dgvData.DataSource = repository.BuscarPorSobrenome(txtDocCivil.Text);
        }
        private void btnConsultar_Click(object sender, EventArgs e) 
        {
            Infra.Data.Repositories.VisitanteRepository repository = new();

            dgvData.DataSource = repository.BuscarComTodosOsFiltros(txtNome.Text, txtSobrenome.Text, mtxCPF.Text, mtxRG.Text, txtDocCivil.Text);
        }
        private void tsmCondominio_Click(object sender, EventArgs e)
        {
            Condominio.Forms.frmInserir form = new Condominio.Forms.frmInserir();
            form.Show();
        }

        private void tsmPredio_Click(object sender, EventArgs e)
        {
            Predio.Forms.frmInserir form = new Predio.Forms.frmInserir();
            form.Show();
        }

        private void tsmMorador_Click(object sender, EventArgs e)
        {
            Morador.Forms.frmInserir form = new();
            form.Show();
        }
        private void tsmApartamento_Click(object sender, EventArgs e)
        {
            Apartamento.Forms.frmInserir form = new();
            form.Show();
        }
        private void tsmVeiculo_Click(object sender, EventArgs e)
        {
            Veiculo.Forms.frmInserir form = new Veiculo.Forms.frmInserir();
            form.Show();
        }
        private void tsmPrestadorServicos_Click(object sender, EventArgs e)
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
