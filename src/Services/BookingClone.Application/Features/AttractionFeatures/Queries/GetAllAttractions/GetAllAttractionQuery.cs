using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.AttractionFeatures.DTOs;
using BookingClone.Application.Features.city.DTOs;
using MediatR;

namespace BookingClone.Application.Features.AttractionFeatures.Queries.GetAllAttractions;
internal class GetAllAttractionQuery : IRequest<IEnumerable<AttractionDetailsDto>>

{
    public int ID { get; set; }

    public int? CityID { get; set; }


    public string Name { get; set; }

    public string Description { get; set; }

    public int AvailableTickets { get; set; }

    public decimal TicketPrice { get; set; }

    public string Duration { get; set; }
}
