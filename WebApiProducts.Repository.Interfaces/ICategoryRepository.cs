using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProducts.Data.Models;
using WebApiProducts.Entities.Response;

namespace WebApiProducts.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        public EntityResponse<Categorium> Insert(Categorium objectInsert);
        public EntityResponse<Categorium> Update(Categorium objectUpdate);
        public EntityResponse<Categorium> GetList();
        public EntityResponse<Categorium> GetById(int idCategory);
        public EntityResponse<Categorium> Delete(int idCategory);
    }
}
