using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.Morador
{
    public partial class ucModificar : UserControl
    {
        public ucModificar()
        {
            InitializeComponent();
        }
        private void ucModificar_Load(object sender, EventArgs e) 
        {
            btnCadastrar.Enabled = false;
        }
        private void btnConsultarMorador_Click(object sender, EventArgs e) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Morador morador = Db.Morador.FirstOrDefault(t => t.CPF.Contains(mtxCPF.Text)
                                                                        ||   t.RG.Contains(mtxRG.Text)
                                                                        ||   t.DocCivil.Contains(txtConsultarDocCivil.Text));

            lblIdMorador.Text = morador.Id.ToString();
            lblNome.Text = morador.Nome;
            lblSobrenome.Text = morador.Sobrenome;
            lblCPF.Text = morador.CPF;
            lblRG.Text = morador.RG;
            lblDocCivil.Text = morador.DocCivil;
            lblSexo.Text = morador.Sexo;
            lblCEP.Text = morador.CEP;
            lblCodPostal.Text = morador.CodigoPostal;
            lblRua.Text = morador.Rua;
            lblNumero.Text = Convert.ToString(morador.Numero);
            lblCidade.Text = morador.Cidade;
            lblEstado.Text = morador.Estado;
            lblProvincia.Text = morador.Provincia;
            lblPais.Text = morador.Pais;
            lblCelular.Text = morador.Celular;
            lblFixo.Text = morador.Fixo;
            lblIdCondominio.Text = morador.IdCondominio.ToString();
            imgWebCam.Image = Base64ToImage(morador.Foto);

            btnCadastrar.Enabled = true;
        }
        private void btnCadastrar_Click(object sender, EventArgs e) 
        {
            try 
            {
                Domain.Entities.Morador morador = new();
                morador.Id = int.Parse(lblIdMorador.Text);
                morador.Nome = txtNome.Text;
                morador.Sobrenome = txtSobrenome.Text;
                morador.CPF = mtxCPF.Text;
                morador.RG = mtxRG.Text;
                morador.DocCivil = txtDocCivil.Text;
                morador.Sexo = cmbSexo.Text;
                morador.DataNascimento = dtpDataNascimento.Value.Date;
                morador.CEP = mtxCEP.Text;
                morador.CodigoPostal = txtCodPostal.Text;
                morador.Rua = txtRua.Text;
                morador.Numero = Convert.ToInt32(nudNumero.Value);
                morador.Cidade = txtCidade.Text;
                morador.Estado = cmbEstado.Text;
                morador.Provincia = txtProvincia.Text;
                morador.Pais = txtPais.Text;
                morador.EMail = txtEMail.Text;
                morador.Celular = txtCelular.Text;
                morador.Fixo = txtFoneFixo.Text;
                morador.IdCondominio = ConsultarIdCondominio(txtCondominio.Text);

                Infra.Data.Repositories.MoradorRepository repository = new();
                repository.Update(morador);

                MessageBox.Show("Cadastro Atualizado com Sucesso!",
                    "Atualizar Cadastro de Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Atualizar Cadastro de Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private static Image Base64ToImage(string texto)
        {
            byte[] textoByte = Encoding.UTF8.GetBytes(texto);

            string texto64 = Convert.ToBase64String(textoByte);

            byte[] imageBytes = Convert.FromBase64String(texto64);
            MemoryStream ms = new MemoryStream();

            ms.Write(imageBytes, 0, imageBytes.Length);

            Image image = Image.FromStream(ms);
            return image;
        }
        static int ConsultarIdCondominio(string nome)
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Contains(nome));

            return condominio.Id;
        }
    }
}
