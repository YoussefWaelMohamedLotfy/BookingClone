﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.city.DTOs;
public sealed class CityDetailsDto
{
<<<<<<< HEAD
<<<<<<< HEAD

    public int ID { get; set; }
    public int? CountryID { get; set; }
    public string Name { get; set; }

   
=======
   
=======
>>>>>>> finalcommit

    public int ID { get; set; }
    public string Name { get; set; }

<<<<<<< HEAD
    public City? Country { get; set; }

    public List<Attraction>? Attractions { get; set; }

    public List<CityHotel>? CityHotels { get; set; }
>>>>>>> add city and country and continent
=======
   
>>>>>>> api(country_continent_city)


    

    

    
}