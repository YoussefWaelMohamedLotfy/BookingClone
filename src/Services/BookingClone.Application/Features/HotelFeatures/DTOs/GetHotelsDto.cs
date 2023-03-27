using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.HotelFeatures.DTOs;

public class GetHotelsDto
{
    public int Id { get; set; }
    
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal StarRating { get; set; }

    public List<CityHotel> CityHotels { get; set; }

    public List<HotelReview> Reviews { get; set; }

    public List<Room> Rooms { get; set; }
}
