using Zadanie7.Interfaces;
using Zadanie7.Models.DTOs;

namespace Zadanie7.Repositories;

public class TripsRepository : ITripRepository
{
    private readonly ApbdZadanie8Context _context; //zobaczyć w slajdach jak zrobic context :-) → wywolac jakas komende w terminalu (podmienic eske?) z włączona baza danych(chyba XD)
    public Task<IEnumerable<TripDTO>> GetTripsAsync()
    {
        throw new NotImplementedException();
    }
}