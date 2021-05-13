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
            
                Domain.Entities.Sindico sindico = Db.Sindico.FirstOrDefault(t => t.CPF.Contains(mtxCPF.Text)
                                                                            ||   t.RG.Contains(mtxRG.Text)
                                                                            ||   t.DocCivil.Contains(txtDocCivil.Text));

                Infra.Data.Repositories.SindicoRepository repository = new();
                repository.Remove(sindico);

                MessageBox.Show("Síndico Excluído Com Sucesso!",
                    "Excluir Síndico",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Excluir Síndico",
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
