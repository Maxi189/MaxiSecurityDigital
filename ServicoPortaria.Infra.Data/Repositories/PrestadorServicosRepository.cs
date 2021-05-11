using System.Linq;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;
using System;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class PrestadorServicosRepository : RepositoryBase<PrestadorServicos>, IPrestadorRepository
    {
        public IEnumerable<PrestadorServicos> ConsultarPorCNPJ(string cnpj)
        {
            return Db.PrestadorServico.Where(t => t.CNPJ.Contains(cnpj));
        }

        public IEnumerable<PrestadorServicos> ConsultarPorCondominio(int id)
        {
            return Db.PrestadorServico.Where(t => t.IdCondominio == id);
        }

        public IEnumerable<PrestadorServicos> ConsultarPorCPF(string cpf)
        {
            return Db.PrestadorServico.Where(t => t.CPF == cpf);
        }

        public IEnumerable<PrestadorServicos> ConsultarPorNome(string nome)
        {
            return Db.PrestadorServico.Where(t => t.Nome == nome);
        }

        public IEnumerable<PrestadorServicos> ConsultarPorPredio(int id)
        {
            return Db.PrestadorServico.Where(t => t.IdPredio == id);
        }

        public IEnumerable<PrestadorServicos> ConsultarPorDataChegada(DateTime data)
        {
            return Db.PrestadorServico.Where(t => t.DataChegada == data);
        }

        public IEnumerable<PrestadorServicos> ConsultarPorDataSaida(DateTime data)
        {
            return Db.PrestadorServico.Where(t => t.DataSaida == data);
        }

        public IEnumerable<PrestadorServicos> ConsultarPorHoraChegada(TimeSpan hora)
        {
            return Db.PrestadorServico.Where(t => t.HoraChegada == hora);
        }

        public IEnumerable<PrestadorServicos> ConsultarPorHoraSaida(TimeSpan hora)
        {
            return Db.PrestadorServico.Where(t => t.HoraSaida == hora);
        }

        public IEnumerable<PrestadorServicos> ConsultarComTodosOsFiltros(string nome, string cpf, string cnpj, DateTime dataChegada, DateTime dataSaida, TimeSpan horaChegada, TimeSpan horaSaida, int idPredio, int idCondominio)
        {
            return Db.PrestadorServico.Where(t => t.Nome.Contains(nome)
                                             || t.CPF.Contains(cpf)
                                             || t.CNPJ.Contains(cnpj)
                                             || t.DataChegada.Date == dataChegada.Date
                                             || t.DataSaida.Date == dataSaida.Date
                                             || t.HoraChegada == horaSaida
                                             || t.HoraSaida == horaSaida
                                             || t.IdPredio == idPredio
                                             || t.IdCondominio == idCondominio);
        }
    }
}
