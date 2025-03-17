using SignalR.EntityLater.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
   public interface IProductService : IGenericService<Product>
    {
        public List<Product> GetProductsWithCategories();
    }
}
