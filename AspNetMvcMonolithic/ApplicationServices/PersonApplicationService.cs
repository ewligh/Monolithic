using AspNetMvcMonolithic.ApplicationServices.Dtos.PersonDtos;
using AspNetMvcMonolithic.ApplicationServices.Services.Contracts;
using AspNetMvcMonolithic.Models.Services.Contracts;

namespace AspNetMvcMonolithic.ApplicationServices
{
    public class PersonApplicationService : IPersonApplicationService
    {
        #region [- Ctor -]
        private readonly IPersonRepository _personRepository;
        public PersonApplicationService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        #endregion

        #region [- Post() -]
        public async Task Post(PostPersonDto postPersonDto)
        {
            var person = new Models.DomainModels.PersonAggregates.Person()
            {
                FirstName = postPersonDto.FirstName,
                LastName = postPersonDto.LastName
            };
            await _personRepository.Insert(person);
        }

        #endregion

        #region [- GetAllPerson() -]
        public async Task<List<GetPersonDto>> GetAllPerson()
        {
            var persons = await _personRepository.SelectAll();

            var getPersonDtos = new List<GetPersonDto>();
            foreach (var item in persons)
            {
                var getPersonDto = new GetPersonDto()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                };
                getPersonDtos.Add(getPersonDto);
            }
            return getPersonDtos;
        }
        #endregion

        #region [- Delete() -]
        public async Task Delete(DeletePersonDto deletePersonDto)
        {
            var person = new Models.DomainModels.PersonAggregates.Person()
            {
                Id = deletePersonDto.Id
            };

            await _personRepository.Delete(person);
        }

        #endregion

        #region [- Put() -]
        public async Task Put(PutPersonDto PutPersonDto)
        {
            var person = new Models.DomainModels.PersonAggregates.Person()
            {
                Id = PutPersonDto.Id,
                FirstName = PutPersonDto.FirstName,
                LastName = PutPersonDto.LastName
            };

            await _personRepository.Update(person);
        }
        #endregion

        #region [- GetById() -]
        public async Task<GetPersonDto> GetById(GetPersonDto getPersonDto)
        {
            var person = await _personRepository.SelectById(getPersonDto.Id);

            if (person == null)
            {
                return null;
            }

            var result = new GetPersonDto()
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName
            };

            return result;
        } 
        #endregion
    }
}