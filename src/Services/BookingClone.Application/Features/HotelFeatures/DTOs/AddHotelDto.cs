using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingClone.Application.Features.HotelFeatures.DTOs;
public class AddHotelsDto
{
    public string Name { get; set; }

    public string? Description { get; set; }

    public decimal? StarRating { get; set; }

  
}
