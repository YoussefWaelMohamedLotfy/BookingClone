﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Domain.Entities;

using MediatR;

namespace BookingClone.Application.Features.city.commands.UpdateCity;
public class UpdateCityCommand : IRequest<CityDetailsDto>
{
    public int ID { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public int? CountryID { get; set; }
=======
>>>>>>> add city and country and continent
=======
    public int? CountryID { get; set; }
>>>>>>> select
=======
    public int? CountryID { get; set; }
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
    public string? Name { get; set; }


}
