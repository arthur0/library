using Library.Domain.Entities;
using Library.Domain.Interfaces.Repositories;

namespace Library.Infra.Data.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
    }
}
