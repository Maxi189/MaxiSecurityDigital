using System;
using System.Collections.Generic;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface IPrestadorRepository : IRepositoryBase<PrestadorSevicos>
    {
        IEnumerable<PrestadorSevicos> ConsultarPorNome(string nome);
        IEnumerable<PrestadorSevicos> ConsultarPorCPF(string cpf);
        IEnumerable<PrestadorSevicos> ConsultarPorCNPJ(string cnpj);
        IEnumerable<PrestadorSevicos> ConsultarPorDataChegada(DateTime data);
        IEnumerable<PrestadorSevicos> ConsultarPorDataSaida(DateTime data);
        IEnumerable<PrestadorSevicos> ConsultarPorHoraChegada(TimeSpan hora);
        IEnumerable<PrestadorSevicos> ConsultarPorHoraSaida(TimeSpan hora);
        IEnumerable<PrestadorSevicos> ConsultarPorPredio(int id);
        IEnumerable<PrestadorSevicos> ConsultarPorCondominio(int id);
    }
}
