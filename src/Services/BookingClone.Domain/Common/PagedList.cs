using System.Collections;

namespace BookingClone.Domain.Common;

public sealed class PagedList<T> : IReadOnlyList<T>
{
    private readonly IList<T> _subset;

    public PagedList(IEnumerable<T> items, int count, int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        _subset = items as IList<T> ?? new List<T>(items);
    }

    public int PageNumber { get; }

    public int TotalPages { get; }

    public bool IsFirstPage => PageNumber == 1;

    public bool IsLastPage => PageNumber == TotalPages;

    public int Count => _subset.Count;

    public T this[int index] => _subset[index];

    public IEnumerator<T> GetEnumerator() => _subset.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _subset.GetEnumerator();
}