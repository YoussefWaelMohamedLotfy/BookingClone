using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.continent.DTOs;
public class ContinentDetailsDto
{
<<<<<<< HEAD
<<<<<<< HEAD

    public int ID { get; set; }
    public string Name { get; set; }


}
=======
   

    public string Name { get; set; }

    public List<City>? Countries { get; set; }
}
>>>>>>> add city and country and continent
=======

    public int ID { get; set; }
    public string Name { get; set; }


}
>>>>>>> api(country_continent_city)
