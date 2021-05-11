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
    public partial class ucConsultar : UserControl
    {
        public ucConsultar()
        {
            InitializeComponent();
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.SindicoRepository repository = new();

            dgvData.DataSource = repository.ConsultarNome(txtNome.Text);
        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.SindicoRepository repository = new();

            dgvData.DataSource = repository.ConsultarSobrenome(txtSobrenome.Text);
        }
        private void mtxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void mtxRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtDocCivil_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.SindicoRepository repository = new();
            dgvData.DataSource = repository.ConsultarNome(txtDocCivil.Text);
        }

        private void txtCondominio_TextChanged(object sender, EventArgs e)
        {
            int idCondominio = BuscarIdCondominio(txtCondominio.Text);

            Infra.Data.Repositories.SindicoRepository repository = new();
            dgvData.DataSource = repository.ConsultarCondominio(idCondominio);
        }

        private void txtPredio_TextChanged(object sender, EventArgs e)
        {
            int idPredio = BuscarIdPredio(txtPredio.Text);

            Infra.Data.Repositories.SindicoRepository repository = new();
            dgvData.DataSource = repository.ConsultarPredio(idPredio);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idCondominio = BuscarIdCondominio(txtCondominio.Text);
            int idPredio = BuscarIdPredio(txtPredio.Text);

            Infra.Data.Repositories.SindicoRepository sindico = new();
            dgvData.DataSource = sindico.ConsultarComFiltros(txtNome.Text, txtSobrenome.Text, mtxCPF.Text, mtxRG.Text, txtDocCivil.Text, idPredio, idPredio);
        }
        private void mtxCPF_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.SindicoRepository repository = new();

            dgvData.DataSource = repository.ConsultarCPF(mtxCPF.Text);
        }
        private void mtxRG_TextChanged(object sender, EventArgs e)
        {
            Infra.Data.Repositories.SindicoRepository repository = new();

            dgvData.DataSource = repository.ConsultarRG(mtxRG.Text);
        }
        static int BuscarIdCondominio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;
        }
        static int BuscarIdPredio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Contains(nome));

            return predio.Id;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
