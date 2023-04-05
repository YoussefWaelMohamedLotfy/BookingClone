using BookingClone.Application.Features.ReservedAttractionsFeatures.AddReservedAttractions;
using BookingClone.Application.Features.ReservedAttractionsFeatures.DeleteReservedAttractions;
using BookingClone.Application.Features.ReservedAttractionsFeatures.DTOs;
using BookingClone.Application.Features.ReservedAttractionsFeatures.Queries.GetAll;
using BookingClone.Application.Features.ReservedAttractionsFeatures.Queries.GetById;
using BookingClone.Application.Features.ReservedAttractionsFeatures.UpdateReservedAttractions;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace BookingClone.Admin.Controllers;

[Authorize]
public sealed class ReservedAttractionsController : Controller
{
    private readonly IMediator _mediator;

    public ReservedAttractionsController(IMediator mediator)
       => _mediator = mediator;

    public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 10, CancellationToken ct = default)
    {
        var ReservedAttractions = await _mediator.Send(new GetAllReservedAttractionsQuery() { Query = new(pageNumber, pageSize) }, ct);
        return View(ReservedAttractions);
    }

    public async Task<IActionResult> Details(int id, CancellationToken ct)
    {
        var ReservedAttractions = await _mediator.Send(new GetByIdQuery { ID = id }, ct);
        return View(ReservedAttractions);
    }

    public IActionResult Create()
        => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(AddReservedAttractionsDto request, CancellationToken ct)
    {
        if (!ModelState.IsValid)
            return View(request);

        var newReservedAttractions = await _mediator.Send(new AddReservedAttractionsCommand { Dto = request }, ct);
        return RedirectToAction(nameof(Details), new { id = newReservedAttractions.Id });
    }

    public async Task<IActionResult> Edit(int id, CancellationToken ct)
    {
        var ReservedAttractions = await _mediator.Send(new GetByIdQuery { ID = id }, ct);
        return View(ReservedAttractions);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateReservedAttractionsDto request, CancellationToken ct)
    {
        if (!ModelState.IsValid)
            return View(request);

        await _mediator.Send(new UpdateReservedAttractionsCommand { Dto = request }, ct);
        return RedirectToAction(nameof(Details), new { id = request.Id });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id, CancellationToken ct)
    {
        await _mediator.Send(new DeleteReservedAttractionsCommand { Id = id }, ct);
        return RedirectToAction(nameof(Index));
    }
}
