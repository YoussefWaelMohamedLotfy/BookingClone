using System;
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.AttractionReviewFeatures.DTOs;

public class AddAttractionReviewDto
{
    public string Comment { get; set; }

    public Attraction Attraction { get; set; }
}

