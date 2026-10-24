using AspNetMvcMonolithic.ApplicationServices.Dtos.PersonDtos;

namespace AspNetMvcMonolithic.ApplicationServices.Services.Contracts
{
    public interface IPersonApplicationService
    {
        #region [-GetAll-]
        Task<List<GetPersonDto>> GetAllPerson();
        #endregion

        #region[-GetById-]
        Task<GetPersonDto> GetById(GetPersonDto getPersonDto);
        #endregion

        #region [-Post-]
        Task Post(PostPersonDto postPersonDto);
        #endregion

        #region [-Delete-]
        Task Delete(DeletePersonDto deletePersonDto);
        #endregion

        #region [-Put-]
        Task Put(PutPersonDto PutPersonDto);
        #endregion
    }
}
