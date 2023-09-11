using DrinkShopSolution.ViewModels.Catalog.Products;
using DrinkShopSolution.ViewModels.Catalog.Products.Manage;
using DrinkShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;

namespace DrinkShop.Application.Catalog.Products
{
    public interface IMageneProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Detele(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);

        Task<int> AddImages(int productId, List<IFormFile> file);

        Task<int> RemoveImages(int imageId);

        Task<int> UpdateImages(int imageId, string caption, bool isDefault);

        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
