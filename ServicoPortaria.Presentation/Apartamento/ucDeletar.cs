using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.Apartamento
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

                Domain.Entities.Apartamento apartamento = Db.Apartamento.FirstOrDefault(t => t.Bloco.Contains(txtBloco.Text)
                                                                                        ||   t.Ramal.Contains(txtRamal.Text)
                                                                                        ||   t.Numero == Convert.ToInt32(nudNumero.Value));

                Infra.Data.Repositories.ApartamentoRepository repository = new();
                repository.Remove(apartamento);

                MessageBox.Show("Apartamento Excluído Com Sucesso!",
                    "Deletar Apartamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Deletar Apartamento",
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
