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

namespace ServicoPortaria.Presentation.Veiculo
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
                Domain.Entities.Veiculo veiculo = new();
                veiculo.IdMorador = BuscarIdMorador(mtxCPF.Text);
                veiculo.Marca = txtMarca.Text;
                veiculo.Modelo = txtModelo.Text;
                veiculo.Placa = txtPlaca.Text;
                veiculo.CondominioId = BuscarIdCondominio(txtCondominio.Text);
                veiculo.PredioId = BuscarIdPredio(txtPredio.Text);

                VeiculoRepository repository = new();
                repository.Inserir(veiculo);

                MessageBox.Show("Veículo Cadastrado com Sucesso!",
                    "Cadastrar Veículo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro",
                    "Cadastrar Veículo",
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
        static int BuscarIdMorador(string cpf)
        {
            PortariaContext Db = new PortariaContext();

            Domain.Entities.Morador veiculo = Db.Morador.FirstOrDefault(t => t.CPF.Contains(cpf));

            return veiculo.Id;
        }
        static int BuscarIdPredio(string nome)
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

        private void lllConsultarTodos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.frmListarTodos form = new();
            form.Show();
        }
    }
}
