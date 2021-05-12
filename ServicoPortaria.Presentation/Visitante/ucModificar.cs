using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.Visitante
{
    public partial class ucModificar : UserControl
    {
        public ucModificar()
        {
            InitializeComponent();
        }
        private void ucModificar_Load(object sender, EventArgs e) 
        {
            btnModificar.Enabled = false;
        }
        private void btnConsultar_Click(object sender, EventArgs e) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Visitante visitante = Db.Visitante.FirstOrDefault(t => t.CPF.Contains(mtxConsultarCPF.Text)
                                                                              ||   t.RG.Contains(mtxConsultarRG.Text)
                                                                              ||   t.DocCivil.Contains(txtDocCivil.Text));

            lblCodigoVisitante.Text = Convert.ToString(visitante.Id);
            lblNome.Text = visitante.Nome;
            lblSobrenome.Text = visitante.Sobrenome;
            lblCPF.Text = visitante.CPF;
            lblRG.Text = visitante.RG;
            lblDocCivil.Text = visitante.DocCivil;
            lblSexo.Text = visitante.Sexo;
            lblCelular.Text = visitante.Celular;
            lblFixo.Text = visitante.Fixo;
            lblEMail.Text = visitante.EMail;

            btnModificar.Enabled = true;
        }
        private void btnModificar_Click(object sender, EventArgs e) 
        {
            try {
                Domain.Entities.Visitante visitante = new();
                visitante.Id = Convert.ToInt32(lblCodigoVisitante.Text);
                visitante.Nome = txtNome.Text;
                visitante.Sobrenome = txtSobrenome.Text;
                visitante.CPF = mtxCPF.Text;
                visitante.RG = mtxRG.Text;
                visitante.DocCivil = txtDocCivil.Text;
                visitante.Sexo = txtSexo.Text;
                visitante.Celular = txtCelular.Text;
                visitante.Fixo = txtTelefoneFixo.Text;
                visitante.EMail = txtEMail.Text;

                Infra.Data.Repositories.VisitanteRepository repository = new();
                repository.Update(visitante);

                MessageBox.Show("Cadastro de Visitante Atualizado com Sucesso!",
                    "Modificar Cadastro de Visitante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro",
                    "Modificar Cadastro de Visitante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void lblClose_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }
    }
}
