﻿using BookingClone.Application.Features.HotelReviewFeatures.Commands.AddHotelReview;
using BookingClone.Application.Features.HotelReviewFeatures.Commands.DeleteHotelReview;
using BookingClone.Application.Features.HotelReviewFeatures.Commands.UpdateHotelReview;
using BookingClone.Application.Features.HotelReviewFeatures.DTOs;
using BookingClone.Application.Features.HotelReviewFeatures.Queries.GetHotelReviewById;

using MediatR;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookingClone.API.Controllers.V1;


[Route("api/[controller]")]
[ApiController]
public class HotelReviewsController : Controller
{

    private readonly IMediator _mediator;

    public HotelReviewsController(IMediator mediator)
        => _mediator = mediator;

    [HttpGet("{id}", Name = "Get_[controller]")]
    public async Task<IActionResult> GetHotelReviewById(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new GetHotelReviewByIdQuery { ID = id }, ct);
        return result is null ? NotFound() : Ok(result);
    }


    [HttpPost]
    public async Task<IActionResult> AddNewHotelReview(AddHotelReviewDto request, CancellationToken ct)
    {
        var result = await _mediator.Send(new AddHotelReviewCommand { Dto = request }, ct);
        return CreatedAtRoute("Get_HotelReview", new { id = result.ID }, result);
    }


    [HttpPut]
    public async Task<IActionResult> UpdateExistingHotelReview(UpdateHotelReviewDto request, CancellationToken ct)
    {
        var result = await _mediator.Send(new UpdateHotelReviewCommand { Dto = request }, ct);
        return result is not null ? Ok(result) : NotFound();
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteHotelReviewById(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new DeleteHotelReviewCommand { ID = id }, ct);
        return result <= 0 ? NotFound() : NoContent();
    }

}

