using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.Visita
{
    public partial class ucConsultar : UserControl
    {
        public ucConsultar()
        {
            InitializeComponent();
        }
        private void mtxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPredio_TextChanged(object sender, EventArgs e)
        {
            int idPredio = BuscarIdPredio(txtPredio.Text);

            Infra.Data.Repositories.VisitaRepository repository = new();
            dgvData.DataSource = repository.BuscarPorPredio(idPredio);
        }
        private void txtCondominio_TextChanged(object sender, EventArgs e)
        {
            int idCondominio = BuscarIdCondominio(txtCondominio.Text);

            Infra.Data.Repositories.VisitaRepository repository = new();
            dgvData.DataSource = repository.BuscarPorApartamento(idCondominio);
        }

        private void dtpDataChegada_ValueChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.VisitaRepository visita = new();
            dgvData.DataSource = visita.BuscarPorDataChegada(dtpDataChegada.Value.Date);
        }

        private void dtpDataSaida_ValueChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.VisitaRepository visita = new();
            dgvData.DataSource = visita.BuscarPorDataSaida(dtpDataSaida.Value.Date);
        }

        private void dtpHoraChegada_ValueChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.VisitaRepository visita = new();
            dgvData.DataSource = visita.BuscarPorHoraEntrada(dtpHoraChegada.Value.TimeOfDay);
        }
        private void dtpHoraSaida_ValueChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.VisitaRepository visita = new();
            dgvData.DataSource = visita.BuscarPorHoraSaida(dtpHoraSaida.Value.TimeOfDay);
        }
        private void mtxCPF_TextChanged(object sender, EventArgs e)
        {
            int idVisitante = BuscarIdVisitante(mtxCPF.Text);

            Infra.Data.Repositories.VisitaRepository repository = new();
            dgvData.DataSource = repository.BuscarPorVisitante(idVisitante);
        }
        private void nudNumero_ValueChanged(object sender, EventArgs e)
        {
            int idApartamento = BuscarIdApartamento(Convert.ToInt32(nudNumero.Value));

            Infra.Data.Repositories.VisitaRepository repository = new();
            dgvData.DataSource = repository.BuscarPorApartamento(idApartamento);
        }
        static int BuscarIdVisitante(string cpf)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Visitante visitante = Db.Visitante.FirstOrDefault(t => t.CPF.Contains(cpf));

            return visitante.Id;
        }
        static int BuscarIdPredio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Contains(nome));

            return predio.Id;
        }
        static int BuscarIdApartamento(int numero)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Apartamento apartamento = Db.Apartamento.FirstOrDefault(t => t.Numero == numero);

            return apartamento.Id;
        }
        static int BuscarIdCondominio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idVisitante = BuscarIdVisitante(mtxCPF.Text);
            int idPredio = BuscarIdPredio(txtPredio.Text);
            int idApartamento = BuscarIdApartamento(Convert.ToInt32(nudNumero.Value));
            int idCondominio = BuscarIdCondominio(txtCondominio.Text);

            Infra.Data.Repositories.VisitaRepository repository = new();
            dgvData.DataSource = repository.BuscarComTodosOsFiltros(idVisitante, idPredio, idApartamento, idCondominio, dtpDataChegada.Value.Date, dtpDataSaida.Value.Date, dtpHoraChegada.Value.TimeOfDay, dtpHoraSaida.Value.TimeOfDay);
        }
    }
}
