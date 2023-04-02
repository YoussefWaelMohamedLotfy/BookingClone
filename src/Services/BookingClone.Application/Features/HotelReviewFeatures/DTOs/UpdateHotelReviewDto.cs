using System;
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.HotelReviewFeatures.DTOs;

public class UpdateHotelReviewDto : AddHotelReviewDto

{
    public int ID { get; set; }
}

