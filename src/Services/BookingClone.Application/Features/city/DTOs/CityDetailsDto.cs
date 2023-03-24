using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.city.DTOs;
public sealed class CityDetailsDto
{
   

    public string Name { get; set; }

    public City? Country { get; set; }

    public List<Attraction>? Attractions { get; set; }

    public List<CityHotel>? CityHotels { get; set; }


    

    

    
}
