using System.Linq;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;
using System;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class PrestadorServicosRepository : RepositoryBase<PrestadorSevicos>, IPrestadorRepository
    {
        public IEnumerable<PrestadorSevicos> ConsultarPorCNPJ(string cnpj)
        {
            return Db.PrestadorServico.Where(t => t.CNPJ.Contains(cnpj));
        }

        public IEnumerable<PrestadorSevicos> ConsultarPorCondominio(int id)
        {
            return Db.PrestadorServico.Where(t => t.IdCondominio == id);
        }

        public IEnumerable<PrestadorSevicos> ConsultarPorCPF(string cpf)
        {
            return Db.PrestadorServico.Where(t => t.CPF == cpf);
        }

        public IEnumerable<PrestadorSevicos> ConsultarPorNome(string nome)
        {
            return Db.PrestadorServico.Where(t => t.Nome == nome);
        }

        public IEnumerable<PrestadorSevicos> ConsultarPorPredio(int id)
        {
            return Db.PrestadorServico.Where(t => t.IdPredio == id);
        }

        IEnumerable<PrestadorSevicos> IPrestadorRepository.ConsultarPorDataChegada(DateTime data)
        {
            return Db.PrestadorServico.Where(t => t.DataChegada == data);
        }

        IEnumerable<PrestadorSevicos> IPrestadorRepository.ConsultarPorDataSaida(DateTime data)
        {
            return Db.PrestadorServico.Where(t => t.DataSaida == data);
        }

        IEnumerable<PrestadorSevicos> IPrestadorRepository.ConsultarPorHoraChegada(TimeSpan hora)
        {
            return Db.PrestadorServico.Where(t => t.HoraChegada == hora);
        }

        IEnumerable<PrestadorSevicos> IPrestadorRepository.ConsultarPorHoraSaida(TimeSpan hora)
        {
            return Db.PrestadorServico.Where(t => t.HoraSaida == hora);
        }
    }
}
