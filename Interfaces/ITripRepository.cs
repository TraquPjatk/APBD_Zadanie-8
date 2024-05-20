using Zadanie7.Models.DTOs;

namespace Zadanie7.Interfaces;

public interface ITripRepository
{
    Task<IEnumerable<TripDTO>> GetTripsAsync();
}