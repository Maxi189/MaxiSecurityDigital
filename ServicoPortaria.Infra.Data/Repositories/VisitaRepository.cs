using System;
using System.Linq;
using System.Collections.Generic;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class VisitaRepository : RepositoryBase<Visita>, IVisitaRepository
    {
        public IEnumerable<Visita> BuscarPorApartamento(int id)
        {
            return Db.Visita.Where(t => t.IdApartamento == id);
        }

        public IEnumerable<Visita> BuscarPorCondominio(int id)
        {
            return Db.Visita.Where(t => t.IdCondominio == id);
        }

        public IEnumerable<Visita> BuscarPorHoraEntrada(TimeSpan time)
        {
            return Db.Visita.Where(t => t.HoraChegada == time);
        }

        public IEnumerable<Visita> BuscarPorPredio(int id)
        {
            return Db.Visita.Where(t => t.IdPredio == id);
        }

        public IEnumerable<Visita> BuscarPorHoraSaida(TimeSpan time)
        {
            return Db.Visita.Where(t => t.HoraSaida == time);
        }

        public IEnumerable<Visita> BuscarPorVisitante(int id)
        {
            return Db.Visita.Where(t => t.IdVisitante == id);
        }

        public IEnumerable<Visita> BuscarPorDataChegada(DateTime date)
        {
            return Db.Visita.Where(t => t.DataChegada == date.Date);
        }

        public IEnumerable<Visita> BuscarPorDataSaida(DateTime date)
        {
            return Db.Visita.Where(t => t.DataSaida == date.Date);
        }

        public IEnumerable<Visita> BuscarComTodosOsFiltros(int idVisitante, int idPredio, int idApartamento, int idCondominio, DateTime dataChegada, DateTime dataSaida, TimeSpan horaChegada, TimeSpan horaSaida)
        {
            return Db.Visita.Where(t => t.IdVisitante == idVisitante
                                   || t.IdPredio == idPredio
                                   || t.IdApartamento == idApartamento
                                   || t.IdCondominio == idCondominio
                                   || t.DataChegada.Date == dataChegada.Date
                                   || t.DataSaida.Date == dataSaida.Date
                                   || t.HoraChegada == horaChegada
                                   || t.HoraSaida == horaSaida);
        }
    }
}
