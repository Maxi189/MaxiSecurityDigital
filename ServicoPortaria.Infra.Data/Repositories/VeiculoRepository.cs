using System.Linq;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class VeiculoRepository : RepositoryBase<Veiculo>, IVeiculoRepository
    {
        public IEnumerable<Veiculo> ConsultarPorMorador(int id)
        {
            return Db.Veiculo.Where(t => t.IdMorador == id);
        }

        public IEnumerable<Veiculo> ConsultarPorPredio(int id)
        {
            return Db.Veiculo.Where(t => t.PredioId == id);
        }

        public IEnumerable<Veiculo> ConsultarPorMarca(string marca)
        {
            return Db.Veiculo.Where(t => t.Marca.Contains(marca));
        }

        public IEnumerable<Veiculo> ConsultarPorModelo(string modelo)
        {
            return Db.Veiculo.Where(t => t.Modelo.Contains(modelo));
        }

        public IEnumerable <Veiculo> ConsultarPorPlaca(string placa)
        {
            return Db.Veiculo.Where(t => t.Placa.Contains(placa));
        }

        public IEnumerable<Veiculo> ConsultarComTodosOsFiltros(int idMorador, int idPredio, string modelo, string marca, string placa)
        {
            return Db.Veiculo.Where(t => t.IdMorador == idMorador
                                    || t.PredioId == idPredio
                                    || t.Modelo.Contains(modelo)
                                    || t.Marca.Contains(marca)
                                    || t.Placa.Contains(placa));
        }
    }
}
