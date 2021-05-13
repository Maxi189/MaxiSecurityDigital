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
    public partial class ucModificar : UserControl
    {
        public ucModificar()
        {
            InitializeComponent();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Visita visita = Db.Visita.FirstOrDefault(t => t.DataChegada == dtpConsultarDataChegada.Value.Date
                                                                     ||   t.DataSaida == dtpConsultarDataSaida.Value.Date
                                                                     ||   t.HoraChegada == dtpConsultarHoraChegada.Value.TimeOfDay
                                                                     ||   t.HoraSaida == dtpConsultarHoraSaida.Value.TimeOfDay
                                                                     ||   t.IdMorador == ConsultarIdMorador(mtxConsultarCPF.Text)
                                                                     ||   t.IdVisitante == ConsultarIdVisitante(mtxCPFVisitante.Text));

            lblCodVisita.Text = Convert.ToString(visita.Id);
            lblIdApartamento.Text = Convert.ToString(visita.IdApartamento);
            lblIdPredio.Text = Convert.ToString(visita.IdPredio);            
            lblIdMorador.Text = Convert.ToString(visita.IdMorador);
            lblIdVisitante.Text = Convert.ToString(visita.IdVisitante);
            lblDataChegada.Text = Convert.ToString(visita.DataChegada);
            lblDataSaida.Text = Convert.ToString(visita.DataSaida);
            lblHoraChegada.Text = Convert.ToString(visita.HoraChegada);
            lblHoraSaida.Text = Convert.ToString(visita.HoraSaida);

            btnCadastrarVisita.Enabled = true;
        }

        private void ucModificar_Load(object sender, EventArgs e)
        {
            btnCadastrarVisita.Enabled = false;
        }

        private void btnCadastrarVisita_Click(object sender, EventArgs e)
        {
            try 
            {
                Domain.Entities.Visita visita = new();
                visita.Id = Convert.ToInt32(lblCodVisita.Text);
                visita.DataChegada = dtpDataChegada.Value.Date;
                visita.DataSaida = dtpDataSaida.Value.Date;
                visita.HoraChegada = dtpHoraChegada.Value.TimeOfDay;
                visita.HoraSaida = dtpHoraSaida.Value.TimeOfDay;
                visita.IdCondominio = ConsultarIdCondominio(txtCondominio.Text);
                visita.IdPredio = ConsultarIdPredio(txtPredio.Text);
                visita.IdMorador = ConsultarIdMorador(mtxCPFMorador.Text);
                visita.IdVisitante = ConsultarIdVisitante(mtxCPFVisitante.Text);

                Infra.Data.Repositories.VisitaRepository repository = new();
                repository.Update(visita);

                MessageBox.Show("Cadastro de Visita Atualizado Com Sucesso!",
                    "Modificar Cadastro de Visita",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Modificar Cadastro de Visita",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private static int ConsultarIdMorador(string cpf) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Morador morador = Db.Morador.FirstOrDefault(t => t.CPF.Contains(cpf));

            return morador.Id;
        }
        private static int ConsultarIdVisitante(string cpf) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Visitante visitante = Db.Visitante.FirstOrDefault(t => t.CPF.Contains(cpf));

            return visitante.Id;
        }
        private static int ConsultarIdCondominio(string nome) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;
        }
        private static int ConsultarIdApartamento(int numero) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Apartamento apartamento = Db.Apartamento.FirstOrDefault(t => t.Numero == numero);

            return apartamento.Id;
        }
        private static int ConsultarIdPredio(string nome) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Contains(nome));

            return predio.Id;
        }
    }
}
