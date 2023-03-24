﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.country.DTOs;
public class CountryDetailsDto
{
    

    public string Name { get; set; }

    public Continent? Continent { get; set; }

    public List<City>? Cities { get; set; }

  
}
