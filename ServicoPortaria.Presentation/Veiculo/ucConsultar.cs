using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.Veiculo
{
    public partial class ucConsultar : UserControl
    {
        public ucConsultar()
        {
            InitializeComponent();
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
        private void tsmVisitante_Click(object sender, EventArgs e)
        {
            Visitante.Forms.frmInserir form = new Visitante.Forms.frmInserir();
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

        private void mtxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPredio_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.VeiculoRepository repository = new();

            int idPredio = ConsultarIdPredio(txtPredio.Text);

            dgvData.DataSource = repository.ConsultarPorPredio(idPredio);
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.VeiculoRepository repository = new();

            dgvData.DataSource = repository.ConsultarPorModelo(txtModelo.Text);
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.VeiculoRepository repository = new();

            dgvData.DataSource = repository.ConsultarPorMarca(txtMarca.Text);
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.VeiculoRepository repository = new();

            dgvData.DataSource = repository.ConsultarPorModelo(txtPlaca.Text);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Infra.Data.Repositories.VeiculoRepository repository = new();

            int idMorador = ConsultarIdMorador(mtxCPF.Text);
            int idPredio = ConsultarIdPredio(txtPredio.Text);

            dgvData.DataSource = repository.ConsultarComTodosOsFiltros(idMorador, idPredio, txtModelo.Text, txtMarca.Text, txtPlaca.Text);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mtxCPF_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.VeiculoRepository repository = new();

            int idMorador = ConsultarIdMorador(mtxCPF.Text);

            dgvData.DataSource = repository.ConsultarPorMorador(idMorador);
        }
        static int ConsultarIdMorador(string cpf)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Morador morador = Db.Morador.FirstOrDefault(t => t.CPF.Contains(cpf));

            return morador.Id;
        }
        static int ConsultarIdPredio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Contains(nome));

            return predio.Id;
        }
    }
}
