using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicoPortaria.Infra.Data.Contexto;

namespace ServicoPortaria.Presentation.Garagem
{
    public partial class ucInserir : UserControl
    {
        public ucInserir()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Domain.Entities.Garagem garagem = new();
            garagem.IdPredio = ConsultarIdPredio(txtPredio.Text);
        }
        static int ConsultarIdPredio(string nome)
        {
            PortariaContext Db = new PortariaContext();

            Domain.Entities.Predio predio = Db.Predio.FirstOrDefault(t => t.Nome.Contains(nome));

            return predio.Id;
        }
    }
}
