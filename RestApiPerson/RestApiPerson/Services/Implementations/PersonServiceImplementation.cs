using RestApiPerson.Model;
using RestApiPerson.Model.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RestApiPerson.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private List<Person> _persons;
        private Person _person;
        private volatile int _count;
        private MySqlContext _mySqlContext;

        public PersonServiceImplementation(MySqlContext mySqlContext)
        {
            _mySqlContext = mySqlContext;
        }

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long Id)
        {
        }

        public List<Person> GetAll() => _mySqlContext.Persons.ToList();

        public Person GetById(long Id)
        {
            return new Person
            {
                Id = 1
                ,
                FirstName = "Assis"
                ,
                LastName = "Zang"
                ,
                Address = "Carazinho - Rio Grande do Sul - Brasil"
                ,
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet()
                            ,
                FirstName = "Person Name " + i
                            ,
                LastName = "Person Last Name " + i
                            ,
                Address = "Person Address " + i
                            ,
                Gender = "Person Gender "
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref _count);
        }
    }
}
