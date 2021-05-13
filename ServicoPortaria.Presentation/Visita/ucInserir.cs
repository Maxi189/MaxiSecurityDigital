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
    public partial class ucInserir : UserControl
    {
        public ucInserir()
        {
            InitializeComponent();
        }
        private void btnCadastrarVisita_Click(object sender, EventArgs e)
        {
            try
            {
                Domain.Entities.Visita visita = new();
                visita.IdVisitante = ConsultarIdVisitante(mtxCPFVisitante.Text);
                visita.IdMorador = ConsultarIdMorador(mtxCPFMorador.Text);
                visita.DataChegada = dtpDataChegada.Value.Date;
                visita.HoraChegada = dtpHoraChegada.Value.TimeOfDay;
                visita.HoraSaida = dtpHoraSaida.Value.TimeOfDay;
                visita.DataSaida = dtpDataSaida.Value.Date;
                visita.IdCondominio = ConsultarIdCondominio(txtCondominio.Text);
                visita.IdPredio = ConsultarIdPredio(txtPredio.Text);

                Infra.Data.Repositories.VisitaRepository repository = new();
                repository.Inserir(visita);

                MessageBox.Show("Visita Cadastrada Com Sucesso!",
                    "Cadastrar Visita",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Cadastrar Visita",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        static int ConsultarIdMorador(string cpf)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Morador morador = Db.Morador.FirstOrDefault(t => t.CPF.Contains(cpf));

            return morador.Id;
        }
        static int ConsultarIdVisitante(string cpf)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Visitante visitante = Db.Visitante.FirstOrDefault(t => t.CPF.Contains(cpf));

            return visitante.Id;
        }
        static int ConsultarIdPredio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Contains(nome));

            return predio.Id;
        }
        static int ConsultarIdCondominio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;
        }
        static int ConsultarIdApartamento(int numero)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Apartamento apartamento = Db.Apartamento.FirstOrDefault(t => t.Numero == numero);

            return apartamento.Id;
        }

        private void lllConsultarTodos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
