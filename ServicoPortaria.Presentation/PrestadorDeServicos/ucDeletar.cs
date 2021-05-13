using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.PrestadorDeServicos
{
    public partial class ucDeletar : UserControl
    {
        public ucDeletar()
        {
            InitializeComponent();
        }
        private void btnDeletar_Click(object sender, EventArgs e) 
        {
            try 
            {
                Infra.Data.Contexto.PortariaContext Db = new();

                Domain.Entities.PrestadorServicos prestador = Db.PrestadorServico.FirstOrDefault(t => t.CNPJ.Contains(mtxCNPJ.Text)
                                                                                                 ||   t.CPF.Contains(mtxCPF.Text)
                                                                                                 ||   t.DataChegada == dtpDataChegada.Value.Date
                                                                                                 ||   t.DataSaida == dtpDataSaida.Value.Date
                                                                                                 ||   t.HoraChegada == dtpHoraChegada.Value.TimeOfDay
                                                                                                 ||   t.HoraSaida == dtpHoraSaida.Value.TimeOfDay);

                Infra.Data.Repositories.PrestadorServicosRepository repository = new();
                repository.Remove(prestador);

                MessageBox.Show("Prestador de Serviços Removido Com Sucesso!",
                    "Remover Prestador de Serviços",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Remover Prestador de Serviços",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
