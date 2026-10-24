using AspNetMvcMonolithic.Models.DomainModels.ProductAggregates;

namespace AspNetMvcMonolithic.Models.Services.Contracts
{
    public interface IProductRepository
    {
        #region [-SelectAll-]
        Task<List<Product>> SelectAll();

        #endregion

        #region [-SelectById-]
        Task<Product> SelectById(int id);

        #endregion

        #region [-Insert-]
        Task Insert(Product product);

        #endregion

        #region [-Delete-]
        Task<Product> Delete(int id);
        #endregion

        #region [-Update-]
        Task<Product> Update(Product product);
        Task Delete(Product product);

        #endregion

    }
}
