using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiProducts.Business.Interfaces;
using WebApiProducts.Data.Models;
using WebApiProducts.Entities.Response;
using WebApiProducts.Repository.Interfaces;
using WebApiProducts.Entities.Resources;
using WebApiProducts.Entities.Models;
using Microsoft.AspNetCore.Http;

namespace webApiProducts.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductRepository _productRepository;
        public ProductBusiness(
            IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public EntityResponse<Producto> Delete(int idProduct)
        {
            if (idProduct <= 0)
            {
                return ResponseManager.ResponseValidation<Producto>(string.Format(CultureInfo.CurrentCulture, Messages.WarningParameterMustBeGreaterThanZero, "Id"));
            }

            try
            {
                var product = _productRepository.GetById(idProduct);

                if (product?.ResultData?.FirstOrDefault() == null)
                {
                    return ResponseManager.ResponseNoContent<Producto>(string.Format(CultureInfo.CurrentCulture,
                        Messages.Warning_NotFoundObject, "Producto"));
                }

                return _productRepository.Delete(idProduct);
            }
            catch (SystemException ex)
            {
                return ResponseManager.ResponseError<Producto>(Messages.WarningErrorException);
            }
        }

        public EntityResponse<Producto> GetById(int idProduct)
        {
            if (idProduct <= 0)
            {
                return ResponseManager.ResponseValidation<Producto>(string.Format(CultureInfo.CurrentCulture, Messages.WarningParameterMustBeGreaterThanZero, "Id"));
            }

            try
            {
                var product = _productRepository.GetById(idProduct);

                if (product?.ResultData?.FirstOrDefault() == null)
                {
                    return ResponseManager.ResponseNoContent<Producto>(string.Format(CultureInfo.CurrentCulture,
                        Messages.Warning_NotFoundObject, "Producto"));
                }

                return product;
            }
            catch (SystemException ex)
            {
                return ResponseManager.ResponseError<Producto>(Messages.WarningErrorException);
            }
        }

        public EntityResponse<Producto> GetList()
        {
            try
            {
                return _productRepository.GetList(); ;
            }
            catch (SystemException ex)
            {
                return ResponseManager.ResponseError<Producto>(Messages.WarningErrorException);
            }
        }

        public EntityResponse<Producto> Insert(InputProduct objectInsert)
        {
            Producto objectProduct = new Producto();
            if (objectInsert == null)
            {
                return ResponseManager.ResponseValidation<Producto>(Messages.WarningCannotAddNullObject);
            }
            else
            {
                objectProduct.Idproducto = objectInsert.Idproducto;
                objectProduct.Nombre = objectInsert.Nombre;
                objectProduct.Stock = objectInsert.Stock;
                objectProduct.Idcategoria= objectInsert.Idcategoria;
                objectProduct.Codigo= objectInsert.Codigo;
                objectProduct.PrecioVenta= objectInsert.PrecioVenta;
                objectProduct.Descripcion= objectInsert.Descripcion;
                objectProduct.Estado= objectInsert.Estado;
                objectProduct.Imagen = null;
            }

            try
            {
                return _productRepository.Insert(objectProduct);
            }
            catch (SystemException ex)
            {
                return ResponseManager.ResponseError<Producto>(Messages.WarningErrorException);
            }
        }

        public Byte[] GetImageProduct(IFormFile imageProduct)
        {
            
            Byte[] fileBytes;
            using (var stream = new MemoryStream())
            {
                imageProduct.CopyTo(stream);
                fileBytes = stream.ToArray();
            }
            return fileBytes;
        }

        public EntityResponse<Producto> Update(InputProduct objectUpdate)
        {

            Producto objectProduct = new Producto();
            if (objectUpdate == null)
            {
                return ResponseManager.ResponseValidation<Producto>(Messages.WarningCannotAddNullObject);
            }
            else
            {
                objectProduct.Idproducto = objectUpdate.Idproducto;
                objectProduct.Nombre = objectUpdate.Nombre;
                objectProduct.Stock = objectUpdate.Stock;
                objectProduct.Idcategoria = objectUpdate.Idcategoria;
                objectProduct.Codigo = objectUpdate.Codigo;
                objectProduct.PrecioVenta = objectUpdate.PrecioVenta;
                objectProduct.Descripcion = objectUpdate.Descripcion;
                objectProduct.Estado = objectUpdate.Estado;
                objectProduct.Imagen = null;
            }

            try
            {
                var product = _productRepository.GetById(objectProduct.Idproducto);

                if (product?.ResultData?.FirstOrDefault() == null)
                {
                    return ResponseManager.ResponseNoContent<Producto>(string.Format(CultureInfo.CurrentCulture,
                        Messages.Warning_NotFoundObject, "Producto"));
                }

                return _productRepository.Update(objectProduct);
            }
            catch (SystemException ex)
            {
                return ResponseManager.ResponseError<Producto>(Messages.WarningErrorException);
            }
        }
    }
}
