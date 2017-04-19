using Library.Domain.Entities;
using Library.Domain.Interfaces.Repositories;
using Library.Domain.Interfaces.Services;

namespace Library.Domain.Services
{
    public class CustomerService : BaseService<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _repository;


        public CustomerService(ICustomerRepository repository) : base(repository)
        {
            _repository = repository;
        }

    }
}
