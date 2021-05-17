using System.Collections.Generic;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface IMoradorRepository : IRepositoryBase<Morador>
    {
        IEnumerable<Morador> BuscarPorNome(string nome);
        IEnumerable<Morador> BuscarPorSobrenome(string sobrenome);
        IEnumerable<Morador> BuscarPorCPF(string cpf);
        IEnumerable<Morador> BuscarPorRG(string rg);
        IEnumerable<Morador> BuscarPorDocCivil(string docCivil);
        IEnumerable<Morador> BuscarPorCEP(string cep);
        IEnumerable<Morador> BuscarPorCodPostal(string codPostal);
        IEnumerable<Morador> BuscarPorRua(string rua);
        IEnumerable<Morador> BuscarPorNumero(int numero);
        IEnumerable<Morador> BuscarPorCelular(string celular);
        IEnumerable<Morador> BuscarPorFoneFixo(string fixo);
        IEnumerable<Morador> BuscarPorEMail(string email);
        IEnumerable<Morador> BuscarPorTodosOsFiltros(string nome, string sobrenome, string cpf, string rg, string docCivil, string cep, string codPostal, string rua, int numero, string celular, string fixo, string email);
    }
}
