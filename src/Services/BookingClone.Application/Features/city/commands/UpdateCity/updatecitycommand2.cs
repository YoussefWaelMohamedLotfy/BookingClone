﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.AttractionReservationFeatures.DTOs;
using BookingClone.Application.Features.city.DTOs;

using MediatR;

namespace BookingClone.Application.Features.city.commands.UpdateCity;
<<<<<<< HEAD
public class updatecitycommand2 : IRequest<CityDetailsDto?>
{
    public required CityDetailsDto Dto { get; set; }
=======
public class updatecitycommand2 : IRequest<updatecityDto2?>
{
    public required updatecityDto2 Dto { get; set; }
>>>>>>> salmateest
   
}