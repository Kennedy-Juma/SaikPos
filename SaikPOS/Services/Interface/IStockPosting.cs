namespace SaikPOS.Services.Interface
{
    public interface IStockPosting
    {
        decimal StockCheckForProductSale(decimal decProductId, decimal decBatchId);
    }
}
