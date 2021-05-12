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

            Domain.Entities.Veiculo veiculo = Db.Veiculo.FirstOrDefault(t => t.IdMorador == ConsultarIdMorador(mtxConsultarMorador.Text)
                                                                        ||   t.Marca.Contains(txtMarca.Text)
                                                                        ||   t.Modelo.Contains(txtModelo.Text)
                                                                        ||   t.Placa.Contains(txtPlaca.Text)); 

            lblIdVeiculo.Text = veiculo.Id.ToString();
            lblIdMorador.Text = veiculo.IdMorador.ToString();
            lblMarca.Text = veiculo.Marca;
            lblPlaca.Text = veiculo.Placa;
            lblModelo.Text = veiculo.Modelo;
            lblIdPredio.Text = Convert.ToString(veiculo.PredioId);
            lblIdCondominio.Text = Convert.ToString(veiculo.CondominioId);
        }
        private void btnModificar_Click(object sender, EventArgs e) 
        {
            try 
            {
                Domain.Entities.Veiculo veiculo = new();
                veiculo.Id = Convert.ToInt32(lblIdVeiculo.Text);
                veiculo.IdMorador = ConsultarIdMorador(mtxCPF.Text);
                veiculo.Marca = txtMarca.Text;
                veiculo.Placa = txtPlaca.Text;
                veiculo.Modelo = txtModelo.Text;
                veiculo.PredioId = ConsultarIdPredio(txtPredio.Text);
                veiculo.CondominioId = ConsultarIdCondominio(txtCondominio.Text);

                Infra.Data.Repositories.VeiculoRepository repository = new();
                repository.Update(veiculo);

                MessageBox.Show("Cadastro Atualizado com Sucesso",
                    "Atualizar Cadastro de Veículo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Atualizar Cadastro de Veículo",
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
        private static int ConsultarIdPredio(string nome) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Contains(nome));

            return predio.Id;
        }
        private static int ConsultarIdCondominio(string nome) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;
        }
    }
}
