using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.Morador
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

                Domain.Entities.Morador morador = Db.Morador.FirstOrDefault(t => t.Sexo.Contains(cmbSexo.Text)
                                                                        ||   t.DocCivil.Contains(txtDocCivil.Text)
                                                                        ||   t.RG.Contains(mtxRG.Text)
                                                                        ||   t.CPF.Contains(mtxCPF.Text));

                Infra.Data.Repositories.MoradorRepository repository = new();
                repository.Remove(morador);

                MessageBox.Show("Morador Removido Com Sucesso",
                    "Excluir Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Excluir Morador",
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
