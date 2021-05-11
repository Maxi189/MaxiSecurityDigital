using System.Linq;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class ApartamentoRepository : RepositoryBase<Apartamento>, IApartamentoRepository
    {
        public IEnumerable<Apartamento> BuscarPorCondominio(int id)
        {
            return Db.Apartamento.Where(p => p.IdCondominio == id);
        }

        public IEnumerable<Apartamento> BuscarPorPredio(int id)
        {
            return Db.Apartamento.Where(p => p.IdMorador == id);
        }

        public IEnumerable<Apartamento> BuscarPorBloco(string bloco)
        {
            return Db.Apartamento.Where(p => p.Bloco.Contains(bloco));
        }

        public IEnumerable<Apartamento> BuscarPorNumero(int numero)
        {
            return Db.Apartamento.Where(p => p.Numero == numero);
        }

        public IEnumerable<Apartamento> BuscarPorRamal(string ramal)
        {
            return Db.Apartamento.Where(p => p.Ramal.Contains(ramal));
        }

        public IEnumerable<Apartamento> BuscarComTodosOsFiltros(int idCondominio, int idPredio, string bloco, string ramal, int numero)
        {
            return Db.Apartamento.Where(p => p.IdCondominio == idCondominio
                                        ||   p.IdPredio == idPredio
                                        ||   p.Bloco.Equals(bloco)
                                        ||   p.Ramal.Equals(ramal)
                                        ||   p.Numero == numero);
        }
    }
}
