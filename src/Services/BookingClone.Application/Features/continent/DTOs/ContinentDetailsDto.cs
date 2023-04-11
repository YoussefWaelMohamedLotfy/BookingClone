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
<<<<<<< HEAD
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05

    public int ID { get; set; }
    public string Name { get; set; }


<<<<<<< HEAD
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
=======
}
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
