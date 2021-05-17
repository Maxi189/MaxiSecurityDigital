using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Presentation.Predio
{
    public partial class ucConsultar : UserControl
    {
        public ucConsultar()
        {
            InitializeComponent();
        }
        private void txtNome_TextChanged(object sender, EventArgs e) 
        {
            try
            {
                Infra.Data.Repositories.PredioRepository repository = new();

                dgvData.DataSource = repository.BuscarPorNome(txtNome.Text).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro",
                    "Consultar Prédio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void txtCondominio_TextChanged(object sender, EventArgs e) 
        {
            try
            {
                int idCondominio = BuscarIdCondominio(txtCondominio.Text);

                Infra.Data.Repositories.PredioRepository repository = new();

                dgvData.DataSource = repository.BuscarPorCondominio(idCondominio).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro",
                    "Consultar Prédio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void nudNumero_ValueChanged(object sender, EventArgs e) 
        {
            try
            {
                Infra.Data.Repositories.PredioRepository repository = new();

                dgvData.DataSource = repository.BuscarPorNumero(Convert.ToInt32(nudNumero.Value));
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro",
                    "Consultar Prédio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                Infra.Data.Contexto.PortariaContext Db = new();
                int idCondominio = BuscarIdCondominio(txtCondominio.Text);

                dgvData.DataSource = Db.Predio.Where(t => t.Nome.Contains(txtNome.Text)
                                                     || t.IdCondominio == idCondominio
                                                     || t.Numero == nudNumero.Value).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro",
                    "Consultar Prédio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmCondominio_Click(object sender, EventArgs e)
        {
            Condominio.Forms.frmInserir form = new Condominio.Forms.frmInserir();
            form.Show();
        }
        private void tsmMorador_Click(object sender, EventArgs e)
        {
            Morador.Forms.frmInserir form = new Morador.Forms.frmInserir();
            form.Show();
        }

        private void tsmApartamento_Click(object sender, EventArgs e)
        {
            Apartamento.Forms.frmInserir form = new Apartamento.Forms.frmInserir();
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

        private void tsmPrestadorServicos_Click(object sender, EventArgs e)
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
        static int BuscarIdCondominio(string nome) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;
        }

        private void lllInserir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.frmInserir form = new();
            form.Show();
        }

        private void lllConsultar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.frmConsultar form = new();
            form.Show();
        }
    }
}
