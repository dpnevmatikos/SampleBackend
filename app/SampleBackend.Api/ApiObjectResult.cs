using System;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using Codehub.Create.Core;

/// <summary>
/// 
/// </summary>
namespace Codehub.Create.AspNetCore
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiObjectResult<T> : ObjectResult
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ApiResult<T> result_;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="result"></param>
        public ApiObjectResult(ApiResult<T> result) : base(result)
        {
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result));
            }

            if (result.Successful)
            {
                Value = result.Data;
                StatusCode = StatusCodes.Status200OK;
            }
            else
            {
                StatusCode = result.Code;

                Value = new
                {
                    status = StatusCode,
                    eventId = result.EventId,
                    message = result.ErrorText
                };
            }

            result_ = result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void OnFormatting(ActionContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            base.OnFormatting(context);

            context.HttpContext.Response.Headers[
                "X-App-EventId"] = $"{result_.EventId}";
        }
    }
}