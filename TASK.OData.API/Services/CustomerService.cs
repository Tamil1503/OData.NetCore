using System.Collections.Generic;
using TASK.OData.API.Models;
using System.Linq;

namespace TASK.OData.API.Services
{
    public class CustomerService
    {
        public List<CustomerModel> CreateData()
        {
            List<CustomerModel> customerModels = new();
            customerModels.Add(new CustomerModel { Id = 1, Name = "Joe", City = "Coimbatore", Pincode = 641659 });
            customerModels.Add(new CustomerModel { Id = 2, Name = "Vick ", City = "Madurai", Pincode = 641658 });
            customerModels.Add(new CustomerModel { Id = 3, Name = "Lovin", City = "Vellor", Pincode = 641657 });
            customerModels.Add(new CustomerModel { Id = 4, Name = "Henry", City = "Karur", Pincode = 641656 });
            customerModels.Add(new CustomerModel { Id = 5, Name = "Patrick", City = "Namakkal", Pincode = 641655 });
            customerModels.Add(new CustomerModel { Id = 6, Name = "Yaser", City = "Selam", Pincode = 641654 });
            customerModels.Add(new CustomerModel { Id = 7, Name = "Mohammed", City = "Tirchy", Pincode = 641653 });
            customerModels.Add(new CustomerModel { Id = 8, Name = "Rashid", City = "Pollachi", Pincode = 641652 });
            customerModels.Add(new CustomerModel { Id = 9, Name = "John", City = "Dinidgal", Pincode = 641651 });
            customerModels.Add(new CustomerModel { Id = 10, Name = "Macvin", City = "Sattur", Pincode = 641650 });
            customerModels.Add(new CustomerModel { Id = 11, Name = "Udir", City = "Sivakasi", Pincode = 641649 });
            return customerModels;
        }

        public List<CustomerModel> GetCustomer() => CreateData().ToList();
    }
}
