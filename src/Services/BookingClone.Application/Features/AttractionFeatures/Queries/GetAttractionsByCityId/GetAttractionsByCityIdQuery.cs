﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.DTOs;
using MediatR;

namespace BookingClone.Application.Features.AttractionFeatures.Queries.GetAttractionsByCityID;

public class GetAttractionsByCityIdQuery : IRequest<List<CityDetailsDto>>
{

    public int ID { get; set; }

    public GetAttractionsByCityIdQuery(int iD)
    {
        ID = iD;
    }

}

