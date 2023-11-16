using CIMS.Models;

namespace CIMS.Repo.Interfaces
{
    public interface ICustomerRepo
    {
        void SaveCustomerData(Customer customer);
        Customer GetCustomerById(int id);
        IEnumerable<Customer> GetCustomers();
        void DeleteCustomer(int id);
    }
}
