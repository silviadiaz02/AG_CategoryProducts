using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProducts.Data.Models;
using WebApiProducts.Entities.Response;

namespace WebApiProducts.Repository.Interfaces
{
    public interface IProductRepository
    {
        public EntityResponse<Producto> Insert(Producto objectInsert);
        public EntityResponse<Producto> Update(Producto objectUpdate);
        public EntityResponse<Producto> GetList();
        public EntityResponse<Producto> GetById(int idProduct);
        public EntityResponse<Producto> Delete(int idProduct);
    }
}
