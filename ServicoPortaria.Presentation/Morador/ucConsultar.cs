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

        }
        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }
        private void mtxCPF_TextChanged(object sender, EventArgs e)
        {

        }        
        private void mtxRG_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtDocCivil_TextChanged(object sender, EventArgs e)
        {

        }
        private void mtxCEP_TextChanged(object sender, EventArgs e)
        {

        }
        private void mtxDocCivil_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtRua_TextChanged(object sender, EventArgs e)
        {

        }
        private void nudNumero_ValueChanged(object sender, EventArgs e)
        {

        }
        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtFoneFixo_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtEMail_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
        private void lblClose_Click(object sender, EventArgs e)
        {

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
