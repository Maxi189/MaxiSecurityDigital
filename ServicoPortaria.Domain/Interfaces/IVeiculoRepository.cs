using System.Collections.Generic;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface IVeiculoRepository : IRepositoryBase<Veiculo>
    {
        IEnumerable<Veiculo> ConsultarPorMorador(int id);
        IEnumerable<Veiculo> ConsultarPorPredio(int id);
        IEnumerable<Veiculo> ConsultarPorModelo(string modelo);
        IEnumerable<Veiculo> ConsultarPorMarca(string marca);
        IEnumerable<Veiculo> ConsultarPorPlaca(string placa);
        IEnumerable<Veiculo> ConsultarComTodosOsFiltros(int idMorador, int idPredio, string modelo, string marca, string placa);
    }
}
