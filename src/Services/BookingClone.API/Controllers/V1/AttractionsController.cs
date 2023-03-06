using System.Web;

using Azure.Identity;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

using BookingClone.Application.Features.AttractionFeatures.Commands.AddAttraction;
using BookingClone.Application.Features.AttractionFeatures.Commands.DeleteAttraction;
using BookingClone.Application.Features.AttractionFeatures.Commands.UpdateAttraction;
using BookingClone.Application.Features.AttractionFeatures.DTOs;
using BookingClone.Application.Features.AttractionFeatures.Queries.GetAttractionById;
using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Data;

using MediatR;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace BookingClone.API.Controllers.V1;

[Route("api/[controller]")]
[ApiController]
public class AttractionsController : ControllerBase
{
    private readonly IMediator _mediator;
    BookingDbContext _context;

    public AttractionsController(IMediator mediator, BookingDbContext context)
    {
        _mediator = mediator;
        _context = context;
    }

    /// <summary>
    /// Gets a single Attraction by ID
    /// </summary>
    /// <param name="id">The unique Identifier of Attraction</param>
    /// <param name="ct"></param>
    /// <returns>Attraction with specified ID</returns>
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAttractionById(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new GetAttractionByIdQuery { ID = id }, ct);
        return result is null ? NotFound() : Ok(result);
    }

    /// <summary>
    /// Adds a new Attraction
    /// </summary>
    /// <param name="request">The request Body containing new data</param>
    /// <param name="ct"></param>
    /// <returns>The newly added entity with ID generated</returns>
    [HttpPost]
    public async Task<IActionResult> AddNewAttraction(AddAttractionDto request, CancellationToken ct)
    {
        var result = await _mediator.Send(new AddAttractionCommand { Dto = request }, ct);
        return CreatedAtAction(nameof(GetAttractionById), new { id = result.ID }, result);
    }

    [HttpPost("{id}/images")]
    public async Task<IActionResult> AddAttractionImages(int id, [FromForm] List<IFormFile> images, CancellationToken ct)
    {
        if (!images.Any())
            return BadRequest();

        var blobServiceClient = new BlobServiceClient("AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;DefaultEndpointsProtocol=http;BlobEndpoint=http://127.0.0.1:10000/devstoreaccount1;QueueEndpoint=http://127.0.0.1:10001/devstoreaccount1;TableEndpoint=http://127.0.0.1:10002/devstoreaccount1;");
        string containerName = "images-blob";
        BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
        await containerClient.CreateIfNotExistsAsync(cancellationToken: ct);
        await containerClient.SetAccessPolicyAsync(PublicAccessType.BlobContainer, cancellationToken: ct);

        foreach (var item in images)
        {
            //var fileName = ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.ToString();
            //var x = Uri.EscapeDataString(fileName);
            var fileName = Guid.NewGuid().ToString("N");
            await containerClient.UploadBlobAsync(fileName, item.OpenReadStream(), ct);
            _context.AttractionImages.Add(new() { ID = id, ImageUrlPath = $"{containerClient.Uri}/{fileName}" });
        }

        await _context.SaveChangesAsync(ct);
        return Ok();
    }

    /// <summary>
    /// Updates an existing Attraction
    /// </summary>
    /// <param name="request">The request Body containing updated data</param>
    /// <param name="ct"></param>
    /// <returns>The existing entity with updated Data</returns>
    [HttpPut]
    public async Task<IActionResult> UpdateExistingAttraction(UpdateAttractionDto request, CancellationToken ct)
    {
        var result = await _mediator.Send(new UpdateAttractionCommand { Dto = request }, ct);
        return result is not null ? Ok(result) : NotFound();
    }

    /// <summary>
    /// Deletes an existing Attraction
    /// </summary>
    /// <param name="id">The unique Identifier of Attraction</param>
    /// <param name="ct"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAttractionById(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new DeleteAttractionCommand { ID = id }, ct);
        return result <= 0 ? NotFound() : NoContent();
    }
}
