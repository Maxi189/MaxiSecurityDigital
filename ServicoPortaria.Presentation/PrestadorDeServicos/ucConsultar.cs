using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.PrestadorDeServicos
{
    public partial class ucConsultar : UserControl
    {
        public ucConsultar()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.PrestadorServicosRepository repository = new();

            dgvData.DataSource = repository.ConsultarPorNome(txtNome.Text);
        }
        private void mtxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPredio_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.PrestadorServicosRepository repository = new();

            int idPredio = BuscarIdPredio(txtPredio.Text);

            dgvData.DataSource = repository.ConsultarPorPredio(idPredio);
        }

        private void txtCondominio_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.PrestadorServicosRepository repository = new();

            int idCondominio = BuscarIdPredio(txtCondominio.Text);

            dgvData.DataSource = repository.ConsultarPorPredio(idCondominio);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idPredio = BuscarIdPredio(txtPredio.Text);
            int idCondominio = BuscarIdCondominio(txtCondominio.Text);

            Infra.Data.Repositories.PrestadorServicosRepository repository = new();
            dgvData.DataSource = repository.ConsultarComTodosOsFiltros(txtNome.Text, mtxCPF.Text, mtxCNPJ.Text, dtpDataChegada.Value.Date, dtpDataChegada.Value.Date, dtpHoraChegada.Value.TimeOfDay, dtpHoraSaida.Value.TimeOfDay, idPredio, idCondominio);
        }

        private void mtxCPF_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.PrestadorServicosRepository repository = new();

            dgvData.DataSource = repository.ConsultarPorCPF(mtxCPF.Text);
        }
        private void mtxCNPJ_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.PrestadorServicosRepository repository = new();

            dgvData.DataSource = repository.ConsultarPorCNPJ(mtxCNPJ.Text);
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dtpDataChegada_ValueChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.PrestadorServicosRepository repository = new();

            dgvData.DataSource = repository.ConsultarPorDataChegada(dtpDataChegada.Value.Date);
        }

        private void dtpDataSaida_ValueChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.PrestadorServicosRepository repository = new();

            dgvData.DataSource = repository.ConsultarPorDataSaida(dtpDataSaida.Value.Date);
        }

        private void dtpHoraChegada_ValueChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.PrestadorServicosRepository repository = new();

            dgvData.DataSource = repository.ConsultarPorHoraChegada(dtpHoraChegada.Value.TimeOfDay);
        }

        private void dtpHoraSaida_ValueChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.PrestadorServicosRepository repository = new();

            dgvData.DataSource = repository.ConsultarPorHoraSaida(dtpHoraSaida.Value.TimeOfDay);
        }
        static int BuscarIdPredio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Contains(nome));

            return predio.Id;
        }
        static int BuscarIdCondominio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;
        }
    }
}
