﻿using System;
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.HotelReviewFeatures.DTOs;

public class GetHotelReviewDto
{
    public int ID { get; set; }

    public string? PositiveReview { get; set; }

    public string? NegativeReview { get; set; }

    public decimal ComfortRate { get; set; }

    public decimal StaffRate { get; set; }

    public decimal FacilitiesRate { get; set; }

    public decimal ValueForMoneyRate { get; set; }

    public decimal CleanlinessRate { get; set; }

    public decimal LocationRate { get; set; }

    public Hotel Hotel { get; set; }
}
