using RestApiPerson.Model;
using System.Collections.Generic;

namespace RestApiPerson.Services
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person Update(Person person);

        void Delete(long Id);

        Person GetById(long Id);

        List<Person> GetAll();
    }
}
