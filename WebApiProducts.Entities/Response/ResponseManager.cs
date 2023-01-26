using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebApiProducts.Entities.Resources;

namespace WebApiProducts.Entities.Response
{
    public class ResponseManager
    {
        /// <summary>
        ///  Logic for ResponseError function
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="message">Error message</param>
        /// <returns></returns>
        public static EntityResponse<T> ResponseError<T>(string message)
        {
            return new EntityResponse<T>
            {
                ResponseCode = HttpStatusCode.BadRequest,
                IdTransactionCode = 0,
                RowsAffected = 0,
                ResponseMessage = message
            };
        }

        public static EntityResponse<T> ResponseErrorNotFound<T>(string message)
        {
            return new EntityResponse<T>
            {
                ResponseCode = HttpStatusCode.NotFound,
                IdTransactionCode = 0,
                RowsAffected = 0,
                ResponseMessage = String.Format(Messages.Warning_NotFoundObject, message)
            };
        }

        /// <summary>
        ///  Logic for ResponseNoContent function
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="message">Validation message</param>
        /// <returns></returns>
        public static EntityResponse<T> ResponseNoContent<T>(string message)
        {
            return new EntityResponse<T>
            {
                ResponseCode = HttpStatusCode.NoContent,
                IdTransactionCode = 0,
                RowsAffected = 0,
                ResponseMessage = message
            };
        }

        /// <summary>
        ///  Logic for ResponseValidation function
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="message">Validation message</param>
        /// <returns></returns>
        public static EntityResponse<T> ResponseValidation<T>(string message)
        {
            return new EntityResponse<T>
            {
                ResponseCode = HttpStatusCode.UnprocessableEntity,
                IdTransactionCode = 0,
                RowsAffected = 0,
                ResponseMessage = message
            };
        }

        /// <summary>
        ///  Logic for ResponseOk function
        /// </summary>
        ///<param name="resultData">Result Data collection</param>
        ///<param name="rowsAffected">Rows affected number</param>
        ///<param name="transactionCode">Id Transaction Code</param>
        /// <returns></returns>
        public static EntityResponse<T> ResponseOk<T>(int rowsAffected, List<T> resultData, long transactionCode)
        {
            return new EntityResponse<T>
            {
                RowsAffected = rowsAffected,
                ResponseCode = HttpStatusCode.OK,
                ResponseMessage = Messages.ResponseMessageOK,
                IdTransactionCode = transactionCode,
                ResultData = resultData
            };
        }

        /// <summary>
        ///  Logic for ResponseOk function
        /// </summary>
        ///<param name="resultData"></param>
        ///<param name="rowsAffected"></param>
        /// <returns></returns>
        public static EntityResponse<T> ResponseOk<T>(int rowsAffected, List<T> resultData)
        {
            return new EntityResponse<T>
            {
                RowsAffected = rowsAffected,
                ResponseCode = HttpStatusCode.OK,
                ResponseMessage = Messages.ResponseMessageOK,
                IdTransactionCode = null,
                ResultData = resultData
            };
        }
    }
}
