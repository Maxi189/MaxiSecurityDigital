using ServicoPortaria.Infra.Data.Contexto;
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
    public partial class ucInserir : UserControl
    {
        public ucInserir()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Domain.Entities.PrestadorSevicos prestador = new();
                prestador.Nome = txtNome.Text;
                prestador.CNPJ = mtxCNPJ.Text;
                prestador.CPF = mtxCPF.Text;
                prestador.DataChegada = dtpDataChegada.Value.Date;
                prestador.DataSaida = dtpDataSaida.Value.Date;
                prestador.HoraChegada = dtpDataSaida.Value.TimeOfDay;
                prestador.HoraSaida = dtpHoraSaida.Value.TimeOfDay;
                prestador.IdPredio = BuscarIdPredio(txtNomePredio.Text);
                prestador.IdCondominio = BuscarIdCondominio(txtCondominio.Text);

                Infra.Data.Repositories.PrestadorServicosRepository repository = new();
                repository.Inserir(prestador);

                MessageBox.Show("Prestador Cadastrado com Sucesso!",
                    "Cadastrar Prestador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Cadastrar Prestador",
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
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        static int BuscarIdPredio (string nome)
        {
            PortariaContext Db = new();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Contains(nome));

            return predio.Id;
        }
        static int BuscarIdCondominio(string nome)
        {
            PortariaContext Db = new();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;
        }

        private void ucInserir_Load(object sender, EventArgs e)
        {

        }
    }
}
