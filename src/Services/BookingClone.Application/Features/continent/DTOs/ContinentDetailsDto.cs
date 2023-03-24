using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.continent.DTOs;
public class ContinentDetailsDto
{
   

    public string Name { get; set; }

    public List<City>? Countries { get; set; }
}
