using Microsoft.EntityFrameworkCore;

namespace RestApiPerson.Model.Context
{
    public class MySqlContext : DbContext
    {
        protected MySqlContext()
        {
        }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

    }
}
