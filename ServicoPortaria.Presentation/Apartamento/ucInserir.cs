using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicoPortaria.Infra.Data.Contexto;
using ServicoPortaria.Infra.Data.Repositories;

namespace ServicoPortaria.Presentation.Apartamento
{
    public partial class ucInserir : UserControl
    {
        public ucInserir()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Domain.Entities.Apartamento apartamento = new Domain.Entities.Apartamento();
                apartamento.Numero = Convert.ToInt32(nudNumero.Value);
                apartamento.Bloco = txtBloco.Text;
                apartamento.Ramal = txtRamal.Text;
                apartamento.IdCondominio = CarregarIdCondominio(txtCondominio.Text);
                apartamento.IdPredio = CarregarIdPredio(txtPredio.Text);
                apartamento.IdMorador = CarregarIdMorador(mtxCPF.Text);

                ApartamentoRepository repository = new();
                repository.Inserir(apartamento);

                MessageBox.Show("Apartamento Inserido Com Sucesso!",
                    "Cadastrar Apartamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Cadastrar Apartamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        static int CarregarIdCondominio(string nome)
        {
            PortariaContext Db = new PortariaContext();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;

        }
        static int CarregarIdPredio(string nome)
        {
            PortariaContext Db = new();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Contains(nome));

            return predio.Id;
        }
        static int CarregarIdMorador(string cpf)
        {
            PortariaContext Db = new();

            Domain.Entities.Morador morador = Db.Morador.FirstOrDefault(t => t.CPF.Contains(cpf));

            return morador.Id;
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
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
