using System.Threading.Tasks;

namespace HupunSDK.Core
{
    public interface IBaseClient
    {
        Task<TResponse> ExecuteAsync<TResponse>(IRequest<TResponse> request) where TResponse : BaseResponse, new();

        /// <summary>
        /// 执行请求命令.
        /// </summary>
        /// <typeparam name="TResponse">请求类型对应的 响应类型</typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        TResponse Execute<TResponse>(IRequest<TResponse> request) where TResponse : BaseResponse, new();
    }
}
