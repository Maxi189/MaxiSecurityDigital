using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.Veiculo
{
    public partial class ucDeletar : UserControl
    {
        public ucDeletar()
        {
            InitializeComponent();
        }

        private void ucDeletar_Load(object sender, EventArgs e)
        {

        }
        private void btnDeletar_Click(object sender, EventArgs e) 
        {
            try 
            {
                Infra.Data.Contexto.PortariaContext Db = new();

                Domain.Entities.Veiculo veiculo = Db.Veiculo.FirstOrDefault(t => t.IdMorador == ConsultarIdMorador(mtxCPF.Text)
                                                                            ||   t.Marca.Contains(txtMarca.Text)
                                                                            ||   t.Placa.Contains(txtPlaca.Text));

                Infra.Data.Repositories.VeiculoRepository repository = new();
                repository.Remove(veiculo);

                MessageBox.Show("Veículo Removido Com Sucesso",
                    "Excluir Veículo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro",
                    "Excluir Veículo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void lblClose_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }
        private static int ConsultarIdMorador(string cpf) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Morador morador = Db.Morador.FirstOrDefault(t => t.CPF.Contains(cpf));

            return morador.Id;
        }
    }
}
