using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.Predio
{
    public partial class ucModificar : UserControl
    {
        public ucModificar()
        {
            InitializeComponent();
        }
        private void btnModificar_Click(object sender, EventArgs e) 
        {
            Domain.Entities.Predio predio = new();
            predio.Id = Convert.ToInt32(lblIdPredio.Text);
        }
        private void btnConsultarPredio_Click(object sender, EventArgs e) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Equals(txtNome.Text)
                                                                     ||   t.Numero == Convert.ToInt32(nudConsultarNumero.Value));
            
            lblIdPredio.Text = Convert.ToString(predio.Id);
            lblNome.Text = predio.Nome;
            lblNumero.Text = Convert.ToString(predio.Numero);
            lblIdCondominio.Text = Convert.ToString(predio.IdCondominio);


        }
        private void ucModificar_Load(object sender, EventArgs e) 
        {
            btnCadastrar.Enabled = false;
        }
    }
}
