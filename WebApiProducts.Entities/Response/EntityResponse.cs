using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebApiProducts.Entities.Response
{
    public class EntityResponse<T>
    {
        /// <summary>
        /// Gets or Sets from ResponseCode.
        /// </summary>
        public HttpStatusCode ResponseCode { get; set; }

        /// <summary>
        /// Gets or Sets from ResponseMessage.
        /// </summary>
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Gets or Sets from IdTransactionCode.
        /// </summary>
        public long? IdTransactionCode { get; set; }

        /// <summary>
        /// Gets or Sets from RowsAffected.
        /// </summary>
        public int RowsAffected { get; set; }

        /// <summary>
        /// Gets or Sets from ResultData.
        /// </summary>
        public List<T> ResultData { get; set; } = new List<T>();
    }
}
