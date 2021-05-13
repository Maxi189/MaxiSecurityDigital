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
    public partial class ucDeletar : UserControl
    {
        public ucDeletar()
        {
            InitializeComponent();
        }
        private void btnDeletar_Click(object sender, EventArgs e) 
        {
            try 
            {
                Infra.Data.Contexto.PortariaContext Db = new();

                Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Estado.Contains(cmbEstado.Text)
                                                                                    ||   t.Cidade.Contains(txtCidade.Text)
                                                                                    ||   t.Rua.Contains(txtRua.Text)
                                                                                    ||   t.CEP.Contains(mtxCEP.Text)
                                                                                    ||   t.Nome.Contains(txtNome.Text));

                Infra.Data.Repositories.CondominioRepository repository = new();
                repository.Remove(condominio);

                MessageBox.Show("Cadastro Removido Com Sucesso",
                    "Remover Condomínio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Remover Condomínio",
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
