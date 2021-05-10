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
    public partial class ucInserir : UserControl
    {
        private Capture _camera;
        public ucInserir()
        {
            InitializeComponent();

            const int VIDEODEVICE = 0;
            const int VIDEOWIDTH = 640;
            const int VIDEOHEIGHT = 480;
            const int VIDEOBITSPERPIXEL = 24;

            _camera = new Capture(VIDEODEVICE, VIDEOWIDTH, VIDEOHEIGHT, VIDEOBITSPERPIXEL, imgWebCam);
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
                Domain.Entities.Visitante visitante = new();
                visitante.Nome = txtNome.Text;
                visitante.Sobrenome = txtSobrenome.Text;
                visitante.CPF = mtxCPF.Text;
                visitante.RG = mtxRG.Text;
                visitante.DocCivil = txtDocCivil.Text;
                visitante.Sexo = txtSexo.Text;
                visitante.Celular = txtCelular.Text;
                visitante.Fixo = txtTelefoneFixo.Text;
                visitante.EMail = txtEMail.Text;

                Infra.Data.Repositories.VisitanteRepository repository = new();
                repository.Inserir(visitante);

                MessageBox.Show("Visitante Cadastrado Com Sucesso!",
                    "Cadastrar Visitante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro",
                    "Cadastrar Visitante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
            Morador.Forms.frmInserir form = new();
            form.Show();
        }
        private void tsmApartamento_Click(object sender, EventArgs e)
        {
            Apartamento.Forms.frmInserir form = new();
            form.Show();
        }
        private void tsmVeiculo_Click(object sender, EventArgs e)
        {
            Veiculo.Forms.frmInserir form = new Veiculo.Forms.frmInserir();
            form.Show();
        }
        private void tsmPrestadorDeServicos_Click(object sender, EventArgs e)
        {
            PrestadorDeServicos.Forms.frmInserir form = new PrestadorDeServicos.Forms.frmInserir();
            form.Show();
        }
        private void tsmSindico_Click(object sender, EventArgs e)
        {
            Sindico.Forms.frmInserir form = new Sindico.Forms.frmInserir();
            form.Show();
        }
        private void tsmHomePage_Click(object sender, EventArgs e)
        {
            Login.Forms.frmLogin form = new Login.Forms.frmLogin();
            form.Show();
        }
        private void tsmVisita_Click(object sender, EventArgs e)
        {
            Visita.Forms.frmInserir form = new Visita.Forms.frmInserir();
            form.Show();
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
