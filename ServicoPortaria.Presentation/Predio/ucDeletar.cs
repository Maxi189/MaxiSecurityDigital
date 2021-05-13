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
    public partial class ucDeletar : UserControl
    {
        public ucDeletar()
        {
            InitializeComponent();
        }
        public void btnDeletar_Click(object sender, EventArgs e) 
        {
            try 
            {
                Infra.Data.Contexto.PortariaContext Db = new();

                Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.IdCondominio == ConsultarIdCondominio(txtNome.Text)
                                                                         ||   t.Nome.Contains(txtNome.Text)
                                                                         ||   t.Numero == Convert.ToInt32(nudNumero.Value));

                Infra.Data.Repositories.PredioRepository repository = new();
                repository.Remove(predio);

                MessageBox.Show("Prédio Removido Com Sucesso!",
                    "Excluir Prédios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Excluir Prédios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public void lblClose_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }
        private static int ConsultarIdCondominio(string nome) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;
        }
    }
}
