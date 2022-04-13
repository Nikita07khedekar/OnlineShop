using DataModelLayer;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace DataLayer.Users
{
    public class ShowProducts
    {
        private readonly PortalEntities _dbContext;
        public ShowProducts()
        {
            _dbContext = new PortalEntities();
        }

        public IEnumerable<Product> GetAllProduct()
        {
            var products = _dbContext.Products;
            return products;
        }
        public AspNetUser GetUser(string id)
        {
            return _dbContext.AspNetUsers.SingleOrDefault(u => u.Id == id); 
        }
        public void AddAddress(DeliveryAddress deliveryAddress)
        {
            _dbContext.DeliveryAddresses.Add(deliveryAddress);
            _dbContext.SaveChanges();
        }
    }
}
