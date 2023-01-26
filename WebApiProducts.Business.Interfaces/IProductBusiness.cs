using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProducts.Data.Models;
using WebApiProducts.Entities.Models;
using WebApiProducts.Entities.Response;

namespace WebApiProducts.Business.Interfaces
{
    public interface IProductBusiness
    {
        public EntityResponse<Producto> Insert(InputProduct objectInsert);
        public EntityResponse<Producto> Update(InputProduct objectUpdate);
        public EntityResponse<Producto> GetList();
        public EntityResponse<Producto> GetById(int idProduct);
        public EntityResponse<Producto> Delete(int idProduct);
    }
}
