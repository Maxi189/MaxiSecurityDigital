using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.Apartamento
{
    public partial class ucConsultar : UserControl
    {
        public ucConsultar()
        {
            InitializeComponent();
        }
        private void txtCondominio_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.ApartamentoRepository repository = new Infra.Data.Repositories.ApartamentoRepository();

            int idCondominio = BuscarIdCondominio(txtCondominio.Text);

            dgvData.DataSource = repository.BuscarPorCondominio(idCondominio).ToList();            
        }        

        private void txtPredio_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.ApartamentoRepository repository = new Infra.Data.Repositories.ApartamentoRepository();

            int idPredio = BuscarIdPredio(txtPredio.Text);

            dgvData.DataSource = repository.BuscarPorCondominio(idPredio).ToList();
        }        

        private void txtBloco_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.ApartamentoRepository repository = new();

            dgvData.DataSource = repository.BuscarPorBloco(txtBloco.Text);
        }
        
        private void txtRamal_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.ApartamentoRepository repository = new();

            dgvData.DataSource = repository.BuscarPorRamal(txtRamal.Text);
        }
        
        private void nudNumero_ValueChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.ApartamentoRepository repository = new();

            dgvData.DataSource = repository.BuscarPorNumero(Convert.ToInt32(nudNumero.Value));
        }
        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idCondominio = BuscarIdCondominio(txtCondominio.Text);
            int idPredio = BuscarIdPredio(txtPredio.Text);

            Infra.Data.Repositories.ApartamentoRepository repository = new();
            dgvData.DataSource = repository.BuscarComTodosOsFiltros(idCondominio, idPredio, txtBloco.Text, txtRamal.Text, Convert.ToInt32(nudNumero.Value));
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
        private static int BuscarIdCondominio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;
        }
        private static int BuscarIdPredio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Contains(nome));

            return predio.Id;
        }
    }
}
