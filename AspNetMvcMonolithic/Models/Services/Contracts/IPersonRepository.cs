using AspNetMvcMonolithic.Models.DomainModels.PersonAggregates;

namespace AspNetMvcMonolithic.Models.Services.Contracts
{
    public interface IPersonRepository
    {
        #region [-SelectAll-]
        Task<List<Person>> SelectAll();
        #endregion

        #region [-SelectById-]
        Task<Person> SelectById(int id);

        #endregion

        #region [-Insert-]
        Task Insert(Person person);

        #endregion

        #region [-Delete-]
        Task Delete(Person person);

        #endregion

        #region [-Update-]
        Task Update(Person person);

        #endregion

    }
}
