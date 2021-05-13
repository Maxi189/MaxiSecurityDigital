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
    public partial class ucDeletar : UserControl
    {
        public ucDeletar()
        {
            InitializeComponent();
        }
        private void btnDeletarDados_Click(object sender, EventArgs e) 
        {
            try 
            {
                Infra.Data.Contexto.PortariaContext Db = new();

                Domain.Entities.Visitante visitante = Db.Visitante.FirstOrDefault(t => t.Sexo.Contains(txtSexo.Text)
                                                                                  ||   t.DocCivil.Contains(txtDocCivil.Text)
                                                                                  ||   t.RG.Contains(mtxRG.Text)
                                                                                  ||   t.CPF.Contains(mtxCPF.Text));

                Infra.Data.Repositories.VisitanteRepository repository = new();
                repository.Remove(visitante);

                MessageBox.Show("Visitante Removido com Sucesso!",
                    "Remover Visitante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Remover Visitante",
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
