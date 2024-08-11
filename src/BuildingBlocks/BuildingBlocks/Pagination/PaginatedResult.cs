namespace BuildingBlocks.Pagination;

public class PaginatedResult<TEntity>(int pageIndex, int paseSize, long count, IEnumerable<TEntity> data) where TEntity : class
{
    public int PageIndex { get; } = pageIndex;
    public int PageSize { get; } = paseSize;
    public long Count { get; } = count;
    public IEnumerable<TEntity> Data { get; } = data;
}
