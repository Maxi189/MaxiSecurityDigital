using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.Predio
{
    public partial class ucModificar : UserControl
    {
        public ucModificar()
        {
            InitializeComponent();
        }
        private void btnModificar_Click(object sender, EventArgs e) 
        {
            try 
            {
                Domain.Entities.Predio predio = new();
                predio.Id = Convert.ToInt32(lblIdPredio.Text);
                predio.Nome = txtNome.Text;
                predio.Numero = Convert.ToInt32(nudNumero.Value);
                predio.IdCondominio = ConsultarIdCondominio(txtCondominio.Text);

                Infra.Data.Repositories.PredioRepository repository = new();
                repository.Update(predio);

                MessageBox.Show("Cadastro de Prédio atualizado com Sucesso!",
                    "Modificar Cadastro de Prédio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro",
                    "Modificar Cadastro de Prédio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnConsultarPredio_Click(object sender, EventArgs e) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Equals(txtNome.Text)
                                                                     ||   t.Numero == Convert.ToInt32(nudConsultarNumero.Value));
            
            lblIdPredio.Text = Convert.ToString(predio.Id);
            lblNome.Text = predio.Nome;
            lblNumero.Text = Convert.ToString(predio.Numero);
            lblIdCondominio.Text = Convert.ToString(predio.IdCondominio);

            btnCadastrar.Enabled = true;
        }
        private void ucModificar_Load(object sender, EventArgs e) 
        {
            btnCadastrar.Enabled = false;
        }
        static int ConsultarIdCondominio(string nome) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Contains(nome));

            return predio.Id;
        }
    }
}
