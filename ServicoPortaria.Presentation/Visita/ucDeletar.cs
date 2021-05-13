using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicoPortaria.Presentation.Visita
{
    public partial class ucDeletar : UserControl
    {
        public ucDeletar()
        {
            InitializeComponent();
        }
        private void btnDeletarDados_Click(object sender, EventArgs e) 
        {
            try 
            {
                Infra.Data.Contexto.PortariaContext Db = new();

                Domain.Entities.Visita visita = Db.Visita.FirstOrDefault(t => t.IdMorador == ConsultarIdMorador(mtxCPFMorador.Text)
                                                                         ||   t.IdVisitante == ConsultarIdVisitante(mtxCPFVisitante.Text)
                                                                         ||   t.DataChegada == dtpDataChegada.Value.Date
                                                                         ||   t.DataSaida == dtpDataSaida.Value.Date
                                                                         ||   t.HoraChegada == dtpHoraChegada.Value.TimeOfDay
                                                                         ||   t.HoraSaida == dtpHoraSaida.Value.TimeOfDay);

                Infra.Data.Repositories.VisitaRepository repository = new();
                repository.Remove(visita);

                MessageBox.Show("Visita Excluída com Sucesso!",
                    "Excluír Visita",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Ocorreu um Erro!",
                    "Excluír Visita",
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
        private static int ConsultarIdVisitante(string cpf) 
        {
            Infra.Data.Contexto.PortariaContext Db = new();

            Domain.Entities.Visitante visitante = Db.Visitante.FirstOrDefault(t => t.CPF.Contains(cpf));

            return visitante.Id;
        }
    }
}
