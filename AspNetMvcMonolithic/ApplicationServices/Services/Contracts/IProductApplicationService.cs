using AspNetMvcMonolithic.ApplicationServices.Dtos.ProductDtos;

namespace AspNetMvcMonolithic.ApplicationServices.Services.Contracts
{
    public interface IProductApplicationService
    {
        #region [-GetAll-]
        Task<List<GetProductDto>> GetAllProduct();
        #endregion

        #region[-GetById-]
        Task<GetProductDto> GetById(GetProductDto getProductDto);
        #endregion

        #region [-Post-]
        Task Post(PostProductDto postProductDto);
        #endregion

        #region[-Delete-]
        Task Delete(DeleteProductDto deleteProductDto);
        #endregion

        #region [-Put-]
        Task Put(PutProductDto PutProductDto);
        #endregion
    }
}
