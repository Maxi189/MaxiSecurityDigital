using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ServicoPortaria.Presentation.Condominio.Forms;
using ServicoPortaria.Infra.Data.Contexto;
using ServicoPortaria.Infra.Data.Repositories;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Presentation.Condominio
{
    public partial class ucListarTodos : UserControl
    {
        public ucListarTodos()
        {
            InitializeComponent();
        }

        private void ucListarTodos_Load(object sender, EventArgs e)
        {
            CondominioRepository repository = new CondominioRepository();

            dgvData.DataSource = repository.ConsultarTodos();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tsmCondominio_Click(object sender, EventArgs e)
        {
            frmInserir form = new();
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
            Sindico.Forms.frmInserir form = new();
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

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
