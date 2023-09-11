using DrinkShopSolution.ViewModels.Catalog.Products;
using DrinkShopSolution.ViewModels.Catalog.Products.Public;
using DrinkShopSolution.ViewModels.Common;

namespace DrinkShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
