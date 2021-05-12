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
    public partial class ucModificar : UserControl
    {
        public ucModificar()
        {
            InitializeComponent();
        }
        private void ucModificar_Load(object sender, EventArgs e) 
        {
            btnInserir.Enabled = false;
        }
        private void btnConsultar_Click(object sender, EventArgs e) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Apartamento apartamento = Db.Apartamento.FirstOrDefault(t => t.Bloco.Contains(txtConsultarBloco.Text)
                                                                                    ||   t.Numero == Convert.ToInt32(nudConsultarNumero.Value)
                                                                                    ||   t.IdMorador == ConsultarIdMorador(mtxConsultarMorador.Text)
                                                                                    ||   t.IdCondominio == ConsultarIdCondominio(txtConsultarCondominio.Text)
                                                                                    ||   t.IdPredio == ConsultarIdPredio(txtPredio.Text));

            lblConsultarCodigoApartamento.Text = Convert.ToString(apartamento.Id);
            lblConsultarNumero.Text = Convert.ToString(apartamento.Numero);
            lblBloco.Text = apartamento.Bloco;
            lblRamal.Text = apartamento.Ramal;
            lblIdMorador.Text = apartamento.IdMorador.ToString();
            lblIdCondominio.Text = apartamento.IdCondominio.ToString();
            lblIdPredio.Text = apartamento.IdPredio.ToString();

            btnInserir.Enabled = true;
        }
        private void btnInserir_Click(object sender, EventArgs e) 
        {
            try 
            {
                Domain.Entities.Apartamento apartamento = new();
                apartamento.Id = int.Parse(lblConsultarCodigoApartamento.Text);
                apartamento.Numero = Convert.ToInt32(nudNumero.Value);
                apartamento.Bloco = txtBloco.Text;
                apartamento.Ramal = txtRamal.Text;
                apartamento.IdMorador = Convert.ToInt32(lblConsultarCodigoMorador.Text);
                apartamento.IdPredio = Convert.ToInt32(lblIdPredio.Text);
                apartamento.IdCondominio = Convert.ToInt32(lblIdCondominio.Text);

                Infra.Data.Repositories.ApartamentoRepository repository = new();
                repository.Update(apartamento);

                MessageBox.Show("Cadastro de Apartamento Atualizado com Sucesso",
                    "Atualizar Cadastro de Apartamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro",
                    "Atualizar Cadastro de Apartamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void lblClose_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }
        static int ConsultarIdMorador(string cpf) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Morador morador = Db.Morador.FirstOrDefault(t => t.CPF.Contains(cpf));

            return morador.Id;
        }
        static int ConsultarIdCondominio(string nome) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;
        }
        static int ConsultarIdPredio(string nome) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Contains(nome));

            return predio.Id;
        }
    }
}
