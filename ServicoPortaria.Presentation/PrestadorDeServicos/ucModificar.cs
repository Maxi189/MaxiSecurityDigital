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
    public partial class ucModificar : UserControl
    {
        public ucModificar()
        {
            InitializeComponent();
        }
        private void ucModificar_Load(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = false;
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.PrestadorServicos prestador = Db.PrestadorServico.FirstOrDefault(t => t.CPF.Contains(mtxConsultaCPF.Text)
                                                                                             || t.CNPJ.Contains(mtxConsultaCNPJ.Text)
                                                                                             || t.DataChegada == dtpConsultarDataChegada.Value.Date
                                                                                             || t.DataSaida == dtpConsultarDataSaida.Value.Date
                                                                                             || t.HoraChegada == dtpConsultarHoraChegada.Value.TimeOfDay
                                                                                             || t.HoraChegada == dtpConsultarHoraSaida.Value.TimeOfDay);
            
            lblCodPrestador.Text = Convert.ToString(prestador.Id);
            lblNome.Text = prestador.Nome;
            lblCPF.Text = prestador.CPF;
            lblCNPJ.Text = prestador.CNPJ;
            lblDataChegada.Text = prestador.DataChegada.ToString();
            lblDataSaida.Text = prestador.DataSaida.ToString();
            lblHoraChegada.Text = prestador.HoraChegada.ToString();
            lblHoraDaSaida.Text = prestador.HoraSaida.ToString();

            btnCadastrar.Enabled = true;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Domain.Entities.PrestadorServicos prestador = new();
            prestador.Id = Convert.ToInt32(lblCodPrestador.Text);
            prestador.Nome = txtNome.Text;
            prestador.CPF = mtxCPF.Text;
            prestador.CNPJ = mtxCNPJ.Text;
            prestador.DataChegada = dtpDataChegada.Value.Date;
            prestador.DataSaida = dtpDataSaida.Value.Date;
            prestador.HoraChegada = dtpHoraChegada.Value.TimeOfDay;
            prestador.HoraSaida = dtpHoraSaida.Value.TimeOfDay;

            // Infra.Data.Repositories.
        }
        private void lblClose_Click(object sender, EventArgs e)
        {

        }
    }
}
