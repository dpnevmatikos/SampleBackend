namespace Codehub.Create.Core
{
    /// <summary>
    /// 
    /// </summary>
    public static class ResultCode
    {
        /// <summary>
        /// 
        /// </summary>
        public const int Undefined = 0;

        /// <summary>
        /// 
        /// </summary>
        public const int Success = 200;

        /// <summary>
        /// 
        /// </summary>
        public const int BadRequest = 400;

        /// <summary>
        /// 
        /// </summary>
        public const int Unauthorized = 401;

        /// <summary>
        /// 
        /// </summary>
        public const int Forbidden = 403;

        /// <summary>
        /// 
        /// </summary>
        public const int NotFound = 404;

        /// <summary>
        /// 
        /// </summary>
        public const int MethodNotAllowed = 405;

        /// <summary>
        /// 
        /// </summary>
        public const int Conflict = 409;

        /// <summary>
        /// 
        /// </summary>
        public const int PreconditionFailed = 412;

        /// <summary>
        /// 
        /// </summary>
        public const int UnsupportedMediaType = 415;

        /// <summary>
        /// 
        /// </summary>
        public const int InternalServerError = 500;

        /// <summary>
        /// 
        /// </summary>
        public const int BadGateway = 502;
    }
}