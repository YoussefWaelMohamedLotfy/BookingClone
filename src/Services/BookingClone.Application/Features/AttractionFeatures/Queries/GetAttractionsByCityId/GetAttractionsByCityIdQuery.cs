using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.AttractionFeatures.DTOs;
using MediatR;

namespace BookingClone.Application.Features.AttractionFeatures.Queries.GetAttractionsByCityId;
public class GetAttractionsByCityIdQuery : IRequest<List<AttractionDetailsDto>>
{
    public int ID { get; set; }

    public GetAttractionsByCityIdQuery(int iD)
    {
        ID = iD;
    }
   
}
