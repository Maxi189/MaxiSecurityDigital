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
    public partial class ucModificar : UserControl
    {
        public ucModificar()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Sindico sindico = Db.Sindico.FirstOrDefault(t => t.CPF.Contains(mtxConsultarCPF.Text)
                                                                        ||   t.RG.Contains(mtxConsultarRG.Text));

            lblIdPredio.Text = Convert.ToString(sindico.IdPredio);
            lblCodCondominio.Text = Convert.ToString(sindico.IdCondominio);
            lblNome.Text = sindico.Nome;
            lblSobrenome.Text = sindico.Sobrenome;
            lblCPF.Text = sindico.CPF;
            lblRG.Text = sindico.RG;
            lblDocCivil.Text = sindico.DocCivil;
            lblCelular.Text = sindico.Celular;
            lblEMail.Text = sindico.EMail;

            btnInsert.Enabled = true;
        }
        private void ucModificar_Load(object sender, EventArgs e)
        {
            btnInsert.Enabled = false;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Domain.Entities.Sindico sindico = new();
                sindico.Id = Convert.ToInt32(lblIdPredio.Text);
                sindico.IdPredio = ConsultarIdPredio(txtPredio.Text);
                sindico.IdCondominio = ConsultarIdCondominio(txtNome.Text);
                sindico.Nome = txtNome.Text;
                sindico.Sobrenome = txtSobrenome.Text;
                sindico.CPF = mtxCPF.Text;
                sindico.RG = mtxRG.Text;
                sindico.DocCivil = txtDocCivil.Text;
                sindico.Celular = txtCelular.Text;
                sindico.EMail = txtEMail.Text;

                Infra.Data.Repositories.SindicoRepository repository = new();
                repository.Update(sindico);

                MessageBox.Show("Cadastro de Síndico Atualizado com Sucesso!",
                    "Atualizar Cadastro de Síndico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Atualizar Cadastro de Síndico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private static int ConsultarIdCondominio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;
        }
        private static int ConsultarIdPredio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Contains(nome));

            return predio.Id;
        }
    }
}
