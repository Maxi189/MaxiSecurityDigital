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
    public partial class ucConsultar : UserControl
    {
        public ucConsultar()
        {
            InitializeComponent();
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Infra.Data.Repositories.MoradorRepository repository = new();
                dgvData.DataSource = repository.BuscarPorNome(txtNome.Text).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Infra.Data.Repositories.MoradorRepository repository = new();
                dgvData.DataSource = repository.BuscarPorSobrenome(txtNome.Text).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void mtxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            try
            {
                MessageBox.Show("Formato de CPF Inválido!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void mtxCPF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Infra.Data.Repositories.MoradorRepository repository = new();
                dgvData.DataSource = repository.BuscarPorCPF(mtxCPF.Text).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }        
        private void mtxRG_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Infra.Data.Repositories.MoradorRepository repository = new();
                dgvData.DataSource = repository.BuscarPorRG(mtxRG.Text).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void mtxRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            try
            {
                MessageBox.Show("RG Inválido!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void txtDocCivil_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Infra.Data.Repositories.MoradorRepository repository = new();
                dgvData.DataSource = repository.BuscarPorDocCivil(txtDocCivil.Text).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void mtxCEP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Infra.Data.Repositories.MoradorRepository repository = new();
                dgvData.DataSource = repository.BuscarPorCPF(mtxCEP.Text).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void mtxCEP_MaskInputRejected(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void txtCodPostal_TextChanged(object sender, EventArgs e) 
        {
            try
            {
                Infra.Data.Repositories.MoradorRepository repository = new();
                dgvData.DataSource = repository.BuscarPorCodPostal(txtCodPostal.Text).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void txtRua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Infra.Data.Repositories.MoradorRepository repository = new();
                dgvData.DataSource = repository.BuscarPorRua(txtRua.Text).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void nudNumero_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Infra.Data.Repositories.MoradorRepository repository = new();
                dgvData.DataSource = repository.BuscarPorNumero(Convert.ToInt32(nudNumero.Value)).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Infra.Data.Repositories.MoradorRepository repository = new();
                dgvData.DataSource = repository.BuscarPorCelular(txtCelular.Text).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void txtFoneFixo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Infra.Data.Repositories.MoradorRepository repository = new();
                dgvData.DataSource = repository.BuscarPorFoneFixo(txtFoneFixo.Text).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void txtEMail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Infra.Data.Repositories.MoradorRepository repository = new();
                dgvData.DataSource = repository.BuscarPorEMail(txtEMail.Text).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Infra.Data.Repositories.MoradorRepository repository = new();
                dgvData.DataSource = repository.BuscarPorTodosOsFiltros(txtNome.Text, txtSobrenome.Text, mtxCPF.Text, mtxRG.Text, txtDocCivil.Text, mtxCEP.Text, txtDocCivil.Text, txtRua.Text, Convert.ToInt32(nudNumero.Value), txtCelular.Text, txtFoneFixo.Text, txtEMail.Text).ToList();
            }
            catch
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Consultar Morador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

        private void tsmVisitante_Click(object sender, EventArgs e)
        {
            Visitante.Forms.frmInserir form = new Visitante.Forms.frmInserir();
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
    }
}
