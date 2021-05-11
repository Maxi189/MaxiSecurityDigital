using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.Condominio
{
    public partial class ucModificar : UserControl
    {
        public ucModificar()
        {
            InitializeComponent();
        } 
        private void btnConsultarDados_Click(object sender, EventArgs e)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(txtConsultarNome.Text)
                                                                                 ||   t.CEP.Contains(mtxConsultarCEP.Text)
                                                                                 ||   t.Cidade.Contains(txtCidade.Text)
                                                                                 ||   t.Pais.Contains(txtPais.Text));

            lblIdCondominio.Text = Convert.ToString(condominio.Id);
            lblNome.Text = condominio.Nome;
            lblCEP.Text = condominio.CEP;
            lblCodPostal.Text = condominio.CodPostal;
            lblRua.Text = condominio.Rua;
            lblNumero.Text = Convert.ToString(condominio.Numero);
            lblCidade.Text = condominio.Cidade;
            lblEstado.Text = condominio.Estado;
            lblProvincia.Text = condominio.Provincia;
            lblPais.Text = condominio.Pais;

            btnUpdate.Enabled = true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try 
            {
                Domain.Entities.Condominio condominio = new Domain.Entities.Condominio();              
                condominio.Id = int.Parse(lblIdCondominio.Text);      
                condominio.Nome = txtNome.Text;
                condominio.CEP = mtxCEP.Text;
                condominio.CodPostal = txtCodPostal.Text;
                condominio.Rua = txtRua.Text;
                condominio.Numero = Convert.ToInt32(nudNumero.Value);
                condominio.Cidade = txtCidade.Text;
                condominio.Estado = cmbEstado.Text;
                condominio.Provincia = txtProvincia.Text;
                condominio.Pais = txtPais.Text;

                Infra.Data.Repositories.CondominioRepository repository = new();
                repository.Update(condominio);

                MessageBox.Show("Cadastro Atualizado com Sucesso!",
                "Cadastro de Condomínio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro!",
                "Cadastro de Condomínio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void ucModificar_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
        }
    }
}
