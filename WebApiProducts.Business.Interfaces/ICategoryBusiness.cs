using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProducts.Data.Models;
using WebApiProducts.Entities.Response;

namespace WebApiProducts.Business.Interfaces
{
    public interface ICategoryBusiness
    {
        public EntityResponse<Categorium> Insert(Categorium objectInsert);
        public EntityResponse<Categorium> Update(Categorium objectUpdate);
        public EntityResponse<Categorium> GetList();
        public EntityResponse<Categorium> GetById(int idCategory);
        public EntityResponse<Categorium> Delete(int idCategory);
    }
}
