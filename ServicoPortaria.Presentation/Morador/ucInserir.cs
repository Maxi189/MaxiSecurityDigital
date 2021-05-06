using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ServicoPortaria.Infra.Data.Contexto;

namespace ServicoPortaria.Presentation.Morador
{
    public partial class ucInserir : UserControl
    {
        private ServicoPortaria.Presentation.Capture _camera;
        public ucInserir()
        {
            InitializeComponent();

            const int VIDEODEVICE = 0;
            const int VIDEOWIDTH = 640;
            const int VIDEOHEIGHT = 480;
            const int VIDEOBITSPERPIXEL = 24;

            _camera = new Capture(VIDEODEVICE, VIDEOWIDTH, VIDEOHEIGHT, VIDEOBITSPERPIXEL, imgWebCam);
        }
        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(imgWebCam.Width, imgWebCam.Height);

            using (var graphics = Graphics.FromImage(bitmap))
            {
                var webCamPoint = imgWebCam.PointToScreen(new Point(0, 0));
                graphics.CopyFromScreen(webCamPoint.X, webCamPoint.Y, 0, 0, bitmap.Size);
            }
            bitmap.Save("snapshot.png", System.Drawing.Imaging.ImageFormat.Png);

            try
            {
                Domain.Entities.Morador morador = new Domain.Entities.Morador();
                morador.Nome = txtNome.Text;
                morador.Sobrenome = txtSobrenome.Text;
                morador.CPF = mtxCPF.Text;
                morador.RG = mtxRG.Text;
                morador.DocCivil = txtDocCivil.Text;
                morador.Sexo = cmbSexo.Text;
                morador.CEP = mtxCEP.Text;
                morador.CodigoPostal = txtCodPostal.Text;
                morador.Rua = txtRua.Text;
                morador.Numero = Convert.ToInt32(nudNumero.Value);
                morador.Cidade = txtCidade.Text;
                morador.Estado = cmbEstado.Text;
                morador.Provincia = txtProvincia.Text;
                morador.Pais = txtPais.Text;
                morador.Celular = txtCidade.Text;
                morador.Fixo = txtFixo.Text;
                morador.EMail = txtEMail.Text;
                morador.IdCondominio = ConsultarId(txtCondominio.Text);
                morador.Foto = imgWebCam.Image.ToString();

                Infra.Data.Repositories.MoradorRepository repository = new Infra.Data.Repositories.MoradorRepository();
                repository.Inserir(morador);

                MessageBox.Show("Cadastro Feito com Sucesso!",
                    "Cadastrar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            } 
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Cadastrar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        static int ConsultarId (string nome)
        {
            PortariaContext Db = new PortariaContext();

            Domain.Entities.Condominio condominio = Db.Condominio.FirstOrDefault(t => t.Nome.Equals(nome));

            return condominio.Id;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmCondominio_Click(object sender, EventArgs e)
        {
            Condominio.Forms.frmInserir form = new Condominio.Forms.frmInserir();
            form.Show();
        }

        private void tsmPredio_Click(object sender, EventArgs e)
        {
            Predio.Forms.frmInserir form = new Predio.Forms.frmInserir();
            form.Show();
        }

        private void tsmMorador_Click(object sender, EventArgs e)
        {
            Morador.Forms.frmInserir form = new Forms.frmInserir();
            form.Show();
        }

        private void tsmApartamento_Click(object sender, EventArgs e)
        {
            Apartamento.Forms.frmInserir form = new Apartamento.Forms.frmInserir();
            form.Show();
        }
    }
}
