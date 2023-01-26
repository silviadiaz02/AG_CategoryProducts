using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProducts.Business.Interfaces;
using WebApiProducts.Data.Models;
using WebApiProducts.Entities.Resources;
using WebApiProducts.Entities.Response;
using WebApiProducts.Repository.Interfaces;

namespace webApiProducts.Business
{
    public class CategoryBusiness : ICategoryBusiness
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryBusiness(
            ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public EntityResponse<Categorium> Delete(int idCategory)
        {
            if (idCategory <= 0)
            {
                return ResponseManager.ResponseValidation<Categorium>(string.Format(CultureInfo.CurrentCulture, Messages.WarningParameterMustBeGreaterThanZero, "Id"));
            }

            try
            {
                var category = _categoryRepository.GetById(idCategory);

                if (category?.ResultData?.FirstOrDefault() == null)
                {
                    return ResponseManager.ResponseNoContent<Categorium>(string.Format(CultureInfo.CurrentCulture,
                        Messages.Warning_NotFoundObject, "Categoria"));
                }

                return _categoryRepository.Delete(idCategory);
            }
            catch (SystemException ex)
            {
                return ResponseManager.ResponseError<Categorium>(Messages.WarningErrorException);
            }
        }

        public EntityResponse<Categorium> GetById(int idCategory)
        {
            if (idCategory <= 0)
            {
                return ResponseManager.ResponseValidation<Categorium>(string.Format(CultureInfo.CurrentCulture, Messages.WarningParameterMustBeGreaterThanZero, "Id"));
            }

            try
            {
                var category = _categoryRepository.GetById(idCategory);

                if (category?.ResultData?.FirstOrDefault() == null)
                {
                    return ResponseManager.ResponseNoContent<Categorium>(string.Format(CultureInfo.CurrentCulture,
                        Messages.Warning_NotFoundObject, "Categoria"));
                }

                return category;
            }
            catch (SystemException ex)
            {
                return ResponseManager.ResponseError<Categorium>(Messages.WarningErrorException);
            }
        }

        public EntityResponse<Categorium> GetList()
        {
            try
            {
                return _categoryRepository.GetList(); ;
            }
            catch (SystemException ex)
            {
                return ResponseManager.ResponseError<Categorium>(Messages.WarningErrorException);
            }
        }

        public EntityResponse<Categorium> Insert(Categorium objectInsert)
        {
            if (objectInsert == null)
            {
                return ResponseManager.ResponseValidation<Categorium>(Messages.WarningCannotAddNullObject);
            }

            try
            {
                return _categoryRepository.Insert(objectInsert);
            }
            catch (SystemException ex)
            {
                return ResponseManager.ResponseError<Categorium>(Messages.WarningErrorException);
            }
        }

        public EntityResponse<Categorium> Update(Categorium objectUpdate)
        {
            if (objectUpdate == null)
            {
                return ResponseManager.ResponseValidation<Categorium>(Messages.WarningCannotAddNullObject);
            }

            try
            {
                var product = _categoryRepository.GetById(objectUpdate.Idcategoria);

                if (product?.ResultData?.FirstOrDefault() == null)
                {
                    return ResponseManager.ResponseNoContent<Categorium>(string.Format(CultureInfo.CurrentCulture,
                        Messages.Warning_NotFoundObject, "Categoria"));
                }

                return _categoryRepository.Update(objectUpdate);
            }
            catch (SystemException ex)
            {
                return ResponseManager.ResponseError<Categorium>(Messages.WarningErrorException);
            }
        }
    }
}
