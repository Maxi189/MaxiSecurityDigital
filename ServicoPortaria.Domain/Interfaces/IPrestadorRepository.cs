using System;
using System.Collections.Generic;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface IPrestadorRepository : IRepositoryBase<PrestadorServicos>
    {
        IEnumerable<PrestadorServicos> ConsultarPorNome(string nome);
        IEnumerable<PrestadorServicos> ConsultarPorCPF(string cpf);
        IEnumerable<PrestadorServicos> ConsultarPorCNPJ(string cnpj);
        IEnumerable<PrestadorServicos> ConsultarPorDataChegada(DateTime data);
        IEnumerable<PrestadorServicos> ConsultarPorDataSaida(DateTime data);
        IEnumerable<PrestadorServicos> ConsultarPorHoraChegada(TimeSpan hora);
        IEnumerable<PrestadorServicos> ConsultarPorHoraSaida(TimeSpan hora);
        IEnumerable<PrestadorServicos> ConsultarPorPredio(int id);
        IEnumerable<PrestadorServicos> ConsultarPorCondominio(int id);
        IEnumerable<PrestadorServicos> ConsultarComTodosOsFiltros(string nome,
                                                                  string cpf,
                                                                  string cnpj,
                                                                  DateTime dataChegada,
                                                                  DateTime dataSaida,
                                                                  TimeSpan horaChegada,
                                                                  TimeSpan horaSaida,
                                                                  int idPredio,
                                                                  int idCondominio);
    }
}
