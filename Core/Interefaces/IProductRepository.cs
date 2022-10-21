using Core.Entities;

namespace Core.Interefaces
{
    public interface IProductRepository
    {
        Task<Product>GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>>GetProductsAsync();
        Task<IReadOnlyList<ProductBrand>>GetProductBrandsAsync();
        Task<IReadOnlyList<ProductType>>GetProductTypesAsync();
    }
}