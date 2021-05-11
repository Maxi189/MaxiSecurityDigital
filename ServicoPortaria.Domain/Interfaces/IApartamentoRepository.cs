using System.Collections.Generic;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface IApartamentoRepository : IRepositoryBase<Apartamento>
    {
        IEnumerable<Apartamento> BuscarPorCondominio(int id);
        IEnumerable<Apartamento> BuscarPorPredio(int id);
        IEnumerable<Apartamento> BuscarPorBloco(string bloco);
        IEnumerable<Apartamento> BuscarPorRamal(string ramal);
        IEnumerable<Apartamento> BuscarPorNumero(int numero);
        IEnumerable<Apartamento> BuscarComTodosOsFiltros(int idCondominio, int idPredio, string bloco, string ramal, int numero);
    }
}
