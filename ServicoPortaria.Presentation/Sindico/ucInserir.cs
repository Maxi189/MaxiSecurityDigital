using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.Sindico
{
    public partial class ucInserir : UserControl
    {
        public ucInserir()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Domain.Entities.Sindico sindico = new();
                sindico.Nome = txtNome.Text;
                sindico.Sobrenome = txtSobrenome.Text;
                sindico.CPF = mtxCPF.Text;
                sindico.RG = mtxRG.Text;
                sindico.DocCivil = txtDocCivil.Text;
                sindico.DataNascimento = dtpDataNascimento.Value.Date;
                sindico.Celular = txtCelular.Text;
                sindico.EMail = txtEMail.Text;

                Infra.Data.Repositories.SindicoRepository repository = new();
                repository.Inserir(sindico);

                MessageBox.Show("Síndico Cadastrado Com Sucesso!",
                    "Cadastrar Síndico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Cadastrar Síndico",
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
    }
}
